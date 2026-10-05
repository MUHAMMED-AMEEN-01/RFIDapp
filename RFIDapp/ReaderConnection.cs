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
                button2.Enabled = true;
                button1.Enabled = false;
                label5.Text = "Connected";
                label5.ForeColor = Color.Green;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label5.Text = "Disconnected";
                label5.ForeColor = Color.Red;
            }
        }

        public void timerfunc()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10000;
            timer.Tick += sts;
            timer.Start();
        }
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public ReaderConnection()
        {
            InitializeComponent();
           
                button1.Enabled = true;
                button2.Enabled = false;
                label5.Text = "Disconnected";
                label5.ForeColor = Color.Red;
        }

        public ReaderConnection(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
            if (reader.IsConnected)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label5.Text = "Connected";
                label5.ForeColor = Color.Green;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label5.Text = "Disconnected";
                label5.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Connecting...";
            label5.ForeColor = Color.Orange;
            ipPortValid IpPortValid = new ipPortValid();
            try
            {
                int port = Convert.ToInt32(textBox2.Text);
                
                if (ipPortValid.IsValidIP(textBox1.Text, port))
                {

                    try
                    {
                        reader.Connect(textBox1.Text, port);
                    }
                    catch (OctaneSdkException ex)
                    {
                        label5.Text = "Connection Error";
                        label5.ForeColor = Color.DarkRed;
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
