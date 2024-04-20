namespace NetworkSpeed
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.lblInterface = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentDownload = new System.Windows.Forms.Label();
            this.lblCurrentUpload = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.lblPublicIP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboxAlywaysOnTop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxDownload = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalDownload = new System.Windows.Forms.Label();
            this.lblTotalUpload = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMaxUpload = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTipLabel = new System.Windows.Forms.ToolTip(this.components);
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cmbInterface
            // 
            this.cmbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(69, 10);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(267, 21);
            this.cmbInterface.TabIndex = 0;
            this.cmbInterface.SelectedIndexChanged += new System.EventHandler(this.cmbInterface_SelectedIndexChanged);
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(6, 13);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(49, 13);
            this.lblInterface.TabIndex = 1;
            this.lblInterface.Text = "Interface";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Download";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Upload";
            // 
            // lblCurrentDownload
            // 
            this.lblCurrentDownload.AutoSize = true;
            this.lblCurrentDownload.Location = new System.Drawing.Point(66, 38);
            this.lblCurrentDownload.Name = "lblCurrentDownload";
            this.lblCurrentDownload.Size = new System.Drawing.Size(64, 13);
            this.lblCurrentDownload.TabIndex = 14;
            this.lblCurrentDownload.Text = "999.9 MBps";
            // 
            // lblCurrentUpload
            // 
            this.lblCurrentUpload.AutoSize = true;
            this.lblCurrentUpload.Location = new System.Drawing.Point(66, 60);
            this.lblCurrentUpload.Name = "lblCurrentUpload";
            this.lblCurrentUpload.Size = new System.Drawing.Size(64, 13);
            this.lblCurrentUpload.TabIndex = 15;
            this.lblCurrentUpload.Text = "999.9 MBps";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(6, 81);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(61, 13);
            this.labelIP.TabIndex = 16;
            this.labelIP.Text = "IP Address:";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(66, 81);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(88, 13);
            this.labelIPAddress.TabIndex = 17;
            this.labelIPAddress.Text = "255.255.255.255";
            // 
            // lblPublicIP
            // 
            this.lblPublicIP.AutoSize = true;
            this.lblPublicIP.Location = new System.Drawing.Point(161, 81);
            this.lblPublicIP.Name = "lblPublicIP";
            this.lblPublicIP.Size = new System.Drawing.Size(88, 13);
            this.lblPublicIP.TabIndex = 18;
            this.lblPublicIP.Text = "255.255.255.255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "/";
            // 
            // cboxAlywaysOnTop
            // 
            this.cboxAlywaysOnTop.AutoSize = true;
            this.cboxAlywaysOnTop.Location = new System.Drawing.Point(291, 81);
            this.cboxAlywaysOnTop.Name = "cboxAlywaysOnTop";
            this.cboxAlywaysOnTop.Size = new System.Drawing.Size(45, 17);
            this.cboxAlywaysOnTop.TabIndex = 20;
            this.cboxAlywaysOnTop.Text = "Top";
            this.cboxAlywaysOnTop.UseVisualStyleBackColor = true;
            this.cboxAlywaysOnTop.CheckedChanged += new System.EventHandler(this.cboxAlywaysOnTop_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "|";
            // 
            // lblMaxDownload
            // 
            this.lblMaxDownload.AutoSize = true;
            this.lblMaxDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDownload.Location = new System.Drawing.Point(141, 38);
            this.lblMaxDownload.Name = "lblMaxDownload";
            this.lblMaxDownload.Size = new System.Drawing.Size(64, 13);
            this.lblMaxDownload.TabIndex = 22;
            this.lblMaxDownload.Text = "999.9 MBps";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "|";
            // 
            // lblTotalDownload
            // 
            this.lblTotalDownload.AutoSize = true;
            this.lblTotalDownload.Location = new System.Drawing.Point(217, 38);
            this.lblTotalDownload.Name = "lblTotalDownload";
            this.lblTotalDownload.Size = new System.Drawing.Size(64, 13);
            this.lblTotalDownload.TabIndex = 24;
            this.lblTotalDownload.Text = "999.9 MBps";
            // 
            // lblTotalUpload
            // 
            this.lblTotalUpload.AutoSize = true;
            this.lblTotalUpload.Location = new System.Drawing.Point(217, 60);
            this.lblTotalUpload.Name = "lblTotalUpload";
            this.lblTotalUpload.Size = new System.Drawing.Size(64, 13);
            this.lblTotalUpload.TabIndex = 27;
            this.lblTotalUpload.Text = "999.9 MBps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(206, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(9, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "|";
            // 
            // lblMaxUpload
            // 
            this.lblMaxUpload.AutoSize = true;
            this.lblMaxUpload.Location = new System.Drawing.Point(141, 60);
            this.lblMaxUpload.Name = "lblMaxUpload";
            this.lblMaxUpload.Size = new System.Drawing.Size(64, 13);
            this.lblMaxUpload.TabIndex = 25;
            this.lblMaxUpload.Text = "999.9 MBps";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(9, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "|";
            // 
            // linkLabel1
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Location = new System.Drawing.Point(306, 38);
            this.linkGithub.Name = "linkLabel1";
            this.linkGithub.Size = new System.Drawing.Size(32, 13);
            this.linkGithub.TabIndex = 29;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "@me";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 103);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotalUpload);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMaxUpload);
            this.Controls.Add(this.lblTotalDownload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaxDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxAlywaysOnTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPublicIP);
            this.Controls.Add(this.cmbInterface);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentDownload);
            this.Controls.Add(this.lblCurrentUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Network Speed V1.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentDownload;
        private System.Windows.Forms.Label lblCurrentUpload;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label lblPublicIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cboxAlywaysOnTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaxDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalDownload;
        private System.Windows.Forms.Label lblTotalUpload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMaxUpload;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTipLabel;
        private System.Windows.Forms.LinkLabel linkGithub;
    }
}

