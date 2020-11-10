using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace test
{
    public partial class FrmSerialCommuctionTest : Form
    {
        private readonly StringBuilder _sb = new StringBuilder();
        private readonly SerialPort _sp = new SerialPort();
        public long Displaybytes { get; private set; }
        private long _inbytes;
        private long _outbytes;

        public FrmSerialCommuctionTest()
        {
            InitializeComponent();
        }

        public long Bytesintxtbox { get; private set; }

        private void FrmSerialCommuctionTest_Load(object sender, EventArgs e)
        {
            var filePath = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;

            if (File.Exists(filePath))
            {
                cboComPort.SelectedIndex = cboComPort.Items.IndexOf(Properties.Settings.Default.com_1);
                cboBaudRate.SelectedIndex = cboBaudRate.Items.IndexOf(Properties.Settings.Default.baud_1);
                txtInterval.Text = Properties.Settings.Default.interval_1;
            }
            else
            {
                cboComPort.SelectedIndex = cboComPort.Items.IndexOf(Properties.Settings.Default.com1);
                cboBaudRate.SelectedIndex = cboBaudRate.Items.IndexOf(Properties.Settings.Default.baud1);
                txtInterval.Text = Properties.Settings.Default.interval;
            }

            txtInBytes.Text = "0";
            txtOutBytes.Text = "0";

            _sp.NewLine = Environment.NewLine;

            btnSend.Enabled = false;
            btnClear.Enabled = false;

            chkAuto.Enabled = false;

            txtSend.Enabled = false;
            txtInBytes.Enabled = false;
            txtOutBytes.Enabled = false;
            txtInterval.Enabled = false;

            timer1.Enabled = false;
            radHex.Checked = false;
            radAscii.Checked = true;

            cboBaudRate.Enabled = true;
            cboComPort.Enabled = true;

            txtSend.Text = Properties.Settings.Default.greeting;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = string.Empty;
            _outbytes = 0;
            _inbytes = 0;
            txtInBytes.Text = @"0";
            txtOutBytes.Text = @"0";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_sp.IsOpen)
            {
                timer1.Enabled = false;
                chkAuto.Checked = false;
                chkAuto.Enabled = false;
                _sp.DataReceived -= sp_DataReceived;
                _sp.Close();
                _inbytes = 0;
                _outbytes = 0;
                Displaybytes = 0;
            }
            else
            {
                try
                {
                    _sp.PortName = cboComPort.Text;
                    _sp.BaudRate = int.Parse(cboBaudRate.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    _sp.Open();
                    _sp.DataReceived += sp_DataReceived;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                chkAuto.Enabled = true;
            }
            btnOpen.Text = _sp.IsOpen ? "Close" : "Open";
            btnSend.Enabled = _sp.IsOpen;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int n;
            if (_sp.IsOpen)
            {
                if (radHex.Checked)
                {
                    var mc = Regex.Matches(txtSend.Text, @"(?i)[\da-f]{2}");
                    var buf = new List<byte>();
                    foreach (Match m in mc)
                    {
                        buf.Add(byte.Parse(m.Value, NumberStyles.HexNumber));
                    }
                    _sp.Write(buf.ToArray(), 0, buf.Count);
                    n = buf.Count;
                }
                else
                {
                    _sp.WriteLine(txtSend.Text);
                    n = txtSend.Text.Length;
                }
                _outbytes += n;
            }
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = chkAuto.Checked;
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var n = _sp.BytesToRead;

            var buf = new byte[n];
            _inbytes += n;
            Bytesintxtbox += n;

            _sp.Read(buf, 0, n);
            _sb.Clear();
            Displaybytes += n;

            if (radHex.Checked)
            {
                foreach (var b in buf)
                {
                    _sb.Append(b.ToString("X2") + " ");
                }
            }
            else
            {
                _sb.Append(Encoding.ASCII.GetString(buf));
                _inbytes -= 2;
            }
            Invoke(new Action(() =>
            {
                txtOutBytes.Text = _outbytes.ToString();
                txtInBytes.Text = _inbytes.ToString();
                txtLog.AppendText(_sb.ToString());
            }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnSend_Click(sender, e);
            if (radHex.Checked)
            {
                txtLog.AppendText("\r\n" + DateTime.Now + "\r\n");
            }
            else
            {
                txtLog.AppendText(DateTime.Now + "\r\n");
            }
        }

        private void txtInterval_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.interval_1 = txtInterval.Text;
            Properties.Settings.Default.Save();

            if (int.TryParse(txtInterval.Text, out var time))
            {
                timer1.Interval = time;
            }
            else
            {
                MessageBox.Show("数据非法");
            }
        }

        #region 串口和波特率设置

        /// <summary>
        /// </summary>
        private void cboBaudRate1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.baud_1 = cboBaudRate.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void cboComPort1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.com_1 = cboComPort.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        #endregion 串口和波特率设置
    }
}