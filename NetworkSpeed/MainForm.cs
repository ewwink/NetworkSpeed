using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSpeed
{
    /// <summary>
    /// Network Interface Traffic Watch
    /// by Mohamed Mansour
    /// 
    /// Free to use under GPL open source license!
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Timer Update (every 1 sec)
        /// </summary>
        private const double timerUpdate = 1000;

        /// <summary>
        /// Interface Storage
        /// </summary>
        private NetworkInterface[] nicArr;

        /// <summary>
        /// Main Timer Object 
        /// (we could use something more efficient such 
        /// as interop calls to HighPerformanceTimers)
        /// </summary>
        private Timer timer;
        private long TotalBytesReceived = 0;
        private long TotalBytesSent = 0;
        private long MaxSpeedDownload = 0;
        private long MaxSpeedUpload = 0;

        private NetworkInterface SelectedNetworkInterface = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitializeTimer();
            SetToolTip(lblCurrentDownload, "Current Download Speed");
            SetToolTip(lblMaxDownload, "Maximum Download Speed");
            SetToolTip(lblTotalDownload, "Total Downloaded Bytes");
            SetToolTip(lblCurrentUpload, "Current Upload Speed");
            SetToolTip(lblMaxUpload, "Maximum Download Speed");
            SetToolTip(lblTotalUpload, "Total Upload Bytes");
            SetToolTip(cboxAlywaysOnTop, "Make App Always on Top");
            SetToolTip(linkGithub, "Find me on Github");
        }

        private void SetToolTip(Control ctrl, string text)
        {
            toolTipLabel.SetToolTip(ctrl, text);
        }
        private String ConvertByteSpeed(long bytes, string suffix, int unit = 1000)
        {
            if (bytes < unit) { return $"{bytes} B"; }
            var exp = (int)(Math.Log(bytes) / Math.Log(unit));
            return $"{bytes / Math.Pow(unit, exp):F1} {("KMGTP")[exp - 1]}{suffix}";
        }

        /// <summary>
        /// Initialize all network interfaces on this computer
        /// </summary>
        private async Task InitializeNetworkInterface()
        {
            await Task.Run(() =>
            {
                nicArr = NetworkInterface.GetAllNetworkInterfaces();
                List<string> goodAdapters = new List<string>();

                foreach (NetworkInterface nicnac in nicArr)
                {
                    if (nicnac.SupportsMulticast && nicnac.GetIPv4Statistics().UnicastPacketsReceived >= 1 && nicnac.OperationalStatus.ToString() == "Up")
                    {
                        string nicName = nicnac.Name + " @ " + ConvertByteSpeed(nicnac.Speed, "bps");
                        goodAdapters.Add(nicName);
                    }
                }

                if (goodAdapters.Count != cmbInterface.Items.Count && goodAdapters.Count != 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        cmbInterface.Items.Clear();
                        foreach (string gadpt in goodAdapters)
                        {
                            cmbInterface.Items.Add(gadpt);
                        }
                        cmbInterface.SelectedIndex = 0;
                    }));

                }

                if (goodAdapters.Count == 0)
                {
                    this.Invoke(new Action(() =>
                    {
                        cmbInterface.Items.Clear();
                    }));
                }

            });
        }

        /// <summary>
        /// Initialize the Timer
        /// </summary>
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }

        /// <summary>
        /// Update GUI components for the network interfaces
        /// </summary>
        private async Task UpdateNetworkInterface()
        {
            if (cmbInterface.Items.Count >= 1)
            {
                await Task.Run(() =>
                {
                    // Grab the stats for that interface
                    IPv4InterfaceStatistics interfaceStats = SelectedNetworkInterface.GetIPv4Statistics();

                    long speedDownload = interfaceStats.BytesReceived - TotalBytesReceived;
                    TotalBytesReceived = interfaceStats.BytesReceived;
                    if (speedDownload > MaxSpeedDownload) MaxSpeedDownload = speedDownload;

                    long speedUpload = interfaceStats.BytesSent - TotalBytesSent;
                    TotalBytesSent = interfaceStats.BytesSent;
                    if (speedUpload > MaxSpeedUpload) MaxSpeedUpload = speedUpload;

                    string localIP = "127.0.0.1";
                    UnicastIPAddressInformationCollection ipInfo = SelectedNetworkInterface.GetIPProperties().UnicastAddresses;

                    foreach (UnicastIPAddressInformation item in ipInfo)
                    {
                        if (item.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                        {
                            localIP = item.Address.ToString();
                            break;
                        }
                    }
                    this.Invoke(new Action(() =>
                    {
                        // Update the labels
                        lblCurrentDownload.Text = ConvertByteSpeed(speedDownload, "Bps", 1024);
                        lblMaxDownload.Text = ConvertByteSpeed(MaxSpeedDownload, "Bps", 1024);
                        lblTotalDownload.Text = ConvertByteSpeed(interfaceStats.BytesReceived, "Bps", 1024);

                        lblCurrentUpload.Text = ConvertByteSpeed(speedUpload, "Bps", 1024);
                        lblMaxUpload.Text = ConvertByteSpeed(MaxSpeedUpload, "Bps", 1024);
                        lblTotalUpload.Text = ConvertByteSpeed(interfaceStats.BytesSent, "Bps", 1024);
                        labelIPAddress.Text = localIP;
                    }));

                });
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            _ = InitializeNetworkInterface();
            _ = UpdateNetworkInterface();

        }
        private async Task getPublicIP()
        {
            var publicIP = "0.0.0.0";
            try
            {
                var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(10);
                publicIP = await client.GetStringAsync("https://ipecho.net/plain");
            }
            catch { }
            lblPublicIP.Text = publicIP;

        }
        private void cmbInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NetworkInterface n in nicArr)
            {
                string adapterName = cmbInterface.SelectedItem.ToString().Split('@')[0].Trim();
                if (n.Name == adapterName)
                {
                    SelectedNetworkInterface = n;
                    break;
                }
            }
            IPv4InterfaceStatistics interfaceStats = SelectedNetworkInterface.GetIPv4Statistics();
            TotalBytesReceived = interfaceStats.BytesReceived;
            TotalBytesSent = interfaceStats.BytesSent;
            _ = getPublicIP();
        }

        private void cboxAlywaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = cboxAlywaysOnTop.Checked ? true : false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ewwink/NetworkSpeed");
        }
    }
}
