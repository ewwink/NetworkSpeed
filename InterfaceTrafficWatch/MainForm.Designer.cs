namespace InterfaceTrafficWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cmbInterface = new System.Windows.Forms.ComboBox();
            this.lblInterface = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblBytesSent = new System.Windows.Forms.Label();
            this.lblBytesReceived = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInterfaceType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDownload = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbInterface
            // 
            this.cmbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterface.FormattingEnabled = true;
            this.cmbInterface.Location = new System.Drawing.Point(67, 6);
            this.cmbInterface.Name = "cmbInterface";
            this.cmbInterface.Size = new System.Drawing.Size(205, 21);
            this.cmbInterface.TabIndex = 0;
            // 
            // lblInterface
            // 
            this.lblInterface.AutoSize = true;
            this.lblInterface.Location = new System.Drawing.Point(12, 9);
            this.lblInterface.Name = "lblInterface";
            this.lblInterface.Size = new System.Drawing.Size(49, 13);
            this.lblInterface.TabIndex = 1;
            this.lblInterface.Text = "Interface";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bytes Sent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bytes Received:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(106, 63);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(13, 13);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "0";
            // 
            // lblBytesSent
            // 
            this.lblBytesSent.AutoSize = true;
            this.lblBytesSent.Location = new System.Drawing.Point(106, 89);
            this.lblBytesSent.Name = "lblBytesSent";
            this.lblBytesSent.Size = new System.Drawing.Size(13, 13);
            this.lblBytesSent.TabIndex = 8;
            this.lblBytesSent.Text = "0";
            // 
            // lblBytesReceived
            // 
            this.lblBytesReceived.AutoSize = true;
            this.lblBytesReceived.Location = new System.Drawing.Point(106, 115);
            this.lblBytesReceived.Name = "lblBytesReceived";
            this.lblBytesReceived.Size = new System.Drawing.Size(13, 13);
            this.lblBytesReceived.TabIndex = 9;
            this.lblBytesReceived.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Interface Type:";
            // 
            // lblInterfaceType
            // 
            this.lblInterfaceType.AutoSize = true;
            this.lblInterfaceType.Location = new System.Drawing.Point(106, 37);
            this.lblInterfaceType.Name = "lblInterfaceType";
            this.lblInterfaceType.Size = new System.Drawing.Size(13, 13);
            this.lblInterfaceType.TabIndex = 11;
            this.lblInterfaceType.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Download:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Upload";
            // 
            // lblDownload
            // 
            this.lblDownload.AutoSize = true;
            this.lblDownload.Location = new System.Drawing.Point(106, 141);
            this.lblDownload.Name = "lblDownload";
            this.lblDownload.Size = new System.Drawing.Size(13, 13);
            this.lblDownload.TabIndex = 14;
            this.lblDownload.Text = "0";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Location = new System.Drawing.Point(106, 167);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(13, 13);
            this.lblUpload.TabIndex = 15;
            this.lblUpload.Text = "0";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(15, 195);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(61, 13);
            this.labelIP.TabIndex = 16;
            this.labelIP.Text = "IP Address:";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(109, 194);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(40, 13);
            this.labelIPAddress.TabIndex = 17;
            this.labelIPAddress.Text = "0.0.0.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.labelIPAddress);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.lblUpload);
            this.Controls.Add(this.lblDownload);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInterfaceType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBytesReceived);
            this.Controls.Add(this.lblBytesSent);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInterface);
            this.Controls.Add(this.cmbInterface);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Bandwidth Meter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterface;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblBytesSent;
        private System.Windows.Forms.Label lblBytesReceived;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInterfaceType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDownload;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.ComboBox cmbInterface;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelIPAddress;
    }
}

