using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Impinj.OctaneSdk;

namespace RFIDapp
{
    public partial class Buzzer : Form
    {
        ImpinjReader reader;
        public Buzzer()
        {

            if (reader == null)
            {
                MessageBox.Show("Reader is not connected. Please connect to the reader first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            InitializeComponent();
        }
        public Buzzer(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                reader.SetGpo(5, true);
                label2.Text = "ON";
                Thread.Sleep(3000);
                reader.SetGpo(5, false);
                label2.Text = "OFF";
            }
            catch (OctaneSdkException ex)
            {
                reader.SetGpo(5, false);
                label2.Text = "OFF";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
