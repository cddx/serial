namespace test
{
    partial class FrmSerialCommuctionTest
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
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCOM = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.radAscii = new System.Windows.Forms.RadioButton();
            this.radHex = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.txtOutBytes = new System.Windows.Forms.TextBox();
            this.txtInBytes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(518, 71);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(16, 167);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(617, 342);
            this.txtLog.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "LOG:";
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Location = new System.Drawing.Point(16, 22);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(71, 12);
            this.lblCOM.TabIndex = 3;
            this.lblCOM.Text = "SerialPort:";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(92, 18);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(71, 20);
            this.cboComPort.TabIndex = 4;
            this.cboComPort.SelectedIndexChanged += new System.EventHandler(this.cboComPort1_SelectedIndexChanged);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(18, 70);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(425, 21);
            this.txtSend.TabIndex = 5;
            this.txtSend.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "BaudRate:";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(239, 18);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(71, 20);
            this.cboBaudRate.TabIndex = 10;
            this.cboBaudRate.SelectedIndexChanged += new System.EventHandler(this.cboBaudRate1_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(335, 17);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(84, 23);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // radAscii
            // 
            this.radAscii.AutoSize = true;
            this.radAscii.Location = new System.Drawing.Point(18, 111);
            this.radAscii.Name = "radAscii";
            this.radAscii.Size = new System.Drawing.Size(53, 16);
            this.radAscii.TabIndex = 19;
            this.radAscii.TabStop = true;
            this.radAscii.Text = "ASCII";
            this.radAscii.UseVisualStyleBackColor = true;
            // 
            // radHex
            // 
            this.radHex.AutoSize = true;
            this.radHex.Location = new System.Drawing.Point(18, 133);
            this.radHex.Name = "radHex";
            this.radHex.Size = new System.Drawing.Size(41, 16);
            this.radHex.TabIndex = 20;
            this.radHex.TabStop = true;
            this.radHex.Text = "HEX";
            this.radHex.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(518, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(456, 75);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(48, 16);
            this.chkAuto.TabIndex = 22;
            this.chkAuto.Text = "Auto";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // txtOutBytes
            // 
            this.txtOutBytes.Location = new System.Drawing.Point(155, 102);
            this.txtOutBytes.Name = "txtOutBytes";
            this.txtOutBytes.Size = new System.Drawing.Size(100, 21);
            this.txtOutBytes.TabIndex = 24;
            // 
            // txtInBytes
            // 
            this.txtInBytes.Location = new System.Drawing.Point(155, 133);
            this.txtInBytes.Name = "txtInBytes";
            this.txtInBytes.Size = new System.Drawing.Size(100, 21);
            this.txtInBytes.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Send:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "Receviced:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 30;
            this.label6.Text = "ms";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(456, 106);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(43, 21);
            this.txtInterval.TabIndex = 23;
            this.txtInterval.TextChanged += new System.EventHandler(this.txtInterval_TextChanged);
            // 
            // FrmSerialCommuctionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 532);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInBytes);
            this.Controls.Add(this.txtOutBytes);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.radHex);
            this.Controls.Add(this.radAscii);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.lblCOM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmSerialCommuctionTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSerialCommuctionTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.RadioButton radAscii;
        private System.Windows.Forms.RadioButton radHex;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.TextBox txtOutBytes;
        private System.Windows.Forms.TextBox txtInBytes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
              private System.Windows.Forms.Label label6;
       
    }
}

