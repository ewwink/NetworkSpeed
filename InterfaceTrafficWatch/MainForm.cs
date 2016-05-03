using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Collections.Generic;

namespace InterfaceTrafficWatch
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
            
        }
        /// <summary>
        /// Initialize all network interfaces on this computer
        /// </summary>
        private void InitializeNetworkInterface()
        {
            nicArr = NetworkInterface.GetAllNetworkInterfaces();
            List<NetworkInterface> goodAdapters = new List<NetworkInterface>();

            foreach (NetworkInterface nicnac in nicArr)
            {
                var ipv4Stat = nicnac.GetIPv4Statistics();
                var status = nicnac.OperationalStatus;

                if ( nicnac.SupportsMulticast && ipv4Stat.UnicastPacketsReceived >= 1 && nicnac.OperationalStatus == OperationalStatus.Up)
                {
                    goodAdapters.Add(nicnac);
                    //cmbInterface.Items.Add(nicnac.Name);
                }
            }
            if (goodAdapters.Count != cmbInterface.Items.Count && goodAdapters.Count != 0)
            {
                cmbInterface.Items.Clear();
                cmbInterface.DisplayMember = "Name";
                foreach (var gadpt in goodAdapters)
                {
                    cmbInterface.Items.Add(gadpt);
                }
                 cmbInterface.SelectedIndex = 0;
            }
            if (goodAdapters.Count == 0) cmbInterface.Items.Clear();
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
        private void UpdateNetworkInterface()
        {
            //MessageBox.Show(cmbInterface.Items.Count.ToString());

            // Grab NetworkInterface object that describes the current interface
            var nic = cmbInterface.SelectedItem as NetworkInterface;
            if (nic != null)
            {   
                // Grab the stats for that interface
                IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();
                
                int bytesSentSpeed = (int)(interfaceStats.BytesSent - double.Parse(lblBytesSent.Text)) / 1024;
                int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - double.Parse(lblBytesReceived.Text)) / 1024;

                // Update the labels
                lblSpeed.Text = nic.Speed.ToString();
                lblInterfaceType.Text = nic.NetworkInterfaceType.ToString();
                lblSpeed.Text = (nic.Speed).ToString("N0");
                lblBytesReceived.Text = interfaceStats.BytesReceived.ToString("N0");
                lblBytesSent.Text = interfaceStats.BytesSent.ToString("N0");
                lblUpload.Text = bytesSentSpeed.ToString() + " KB/s";
                lblDownload.Text = bytesReceivedSpeed.ToString() + " KB/s";

                UnicastIPAddressInformationCollection ipInfo = nic.GetIPProperties().UnicastAddresses;

                foreach (UnicastIPAddressInformation item in ipInfo)
                {
                    if (item.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        labelIPAddress.Text = item.Address.ToString();
                        //uniCastIPInfo = item;
                        break;
                    }
                }
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            InitializeNetworkInterface();
            UpdateNetworkInterface();
            
        }
    }
}
