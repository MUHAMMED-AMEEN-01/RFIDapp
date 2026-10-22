using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Impinj.OctaneSdk;
using System.Windows.Forms;
using Renci.SshNet;


namespace RFIDapp
{
    public partial class ReaderConnection : Form
    {
        public System.Windows.Forms.Timer timer;
        public ImpinjReader reader = new ImpinjReader();

        public void sts(object sender, EventArgs e)
        {
            if (reader.IsConnected)
            {
                btnDisconnect.Enabled = true;
                btnConnect.Enabled = false;
                dispStatus.Text = "Connected";
                dispStatus.ForeColor = Color.Green;
            }
            else
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                dispStatus.Text = "Disconnected";
                dispStatus.ForeColor = Color.Red;
            }
        }

        public void timerfunc()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000;
            timer.Tick += sts;
            timer.Start();
            epcTable.Enabled = false;
            buzzer.Enabled = false;
        }
        public void clear()
        {
            inputIp.Clear();
            inputPort.Clear();
        }
        public ReaderConnection()
        {
            InitializeComponent();
           
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
            epcTable.Enabled = false;
            buzzer.Enabled=false;
        }

        public ReaderConnection(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
            if (reader.IsConnected)
            {
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                dispStatus.Text = "Connected";
                dispStatus.ForeColor = Color.Green;
                epcTable.Enabled = true;
                buzzer.Enabled = true;
            }
            else
            {
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                dispStatus.Text = "Disconnected";
                dispStatus.ForeColor = Color.Red;
                epcTable.Enabled = false;
                buzzer.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port;
            dispStatus.Text = "Connecting...";
            dispStatus.ForeColor = Color.Orange;
            ipPortValid IpPortValid = new ipPortValid();
            try
            {
                 port = Convert.ToInt32(inputPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "It take default port '5084'","null or invalid port", MessageBoxButtons.OK, MessageBoxIcon.Error);
                port = 5084;
            }

            if (ipPortValid.IsValidIP(inputIp.Text, port))
                {

                    try
                    {
                        reader.Connect(inputIp.Text, port);

                        btnConnect.Enabled = false;
                        btnDisconnect.Enabled = true;
                        dispStatus.Text = "Connected";
                        dispStatus.ForeColor = Color.Green;
                        epcTable.Enabled = false;
                        buzzer.Enabled = false;

                    }
                    catch (OctaneSdkException ex)
                    {
                        dispStatus.Text = "Connection Error";
                        dispStatus.ForeColor = Color.DarkRed;
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                dispStatus.Text = "Connection Error";
                dispStatus.ForeColor = Color.DarkRed;
                clear();
                }
           
            timerfunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reader.Disconnect();
            clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ePCTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPCTable EPC = new EPCTable( reader);
            EPC.Show();
        }

        private void buzzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buzzer buzzer = new Buzzer(reader);
            buzzer.Show();
        }
    }
}
