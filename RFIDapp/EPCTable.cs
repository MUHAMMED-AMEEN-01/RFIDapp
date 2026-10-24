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

    public partial class EPCTable : Form
    {
        ImpinjReader reader;

        public EPCTable()
        {
            InitializeComponent();

        }
        public EPCTable(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
            if (!reader.IsConnected)
            {
                MessageBox.Show("Reader is not connected. Please connect to the reader first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //reader.ClearSettings();
                Settings settings = reader.QueryDefaultSettings();
                settings.Report.IncludeAntennaPortNumber = true;
                settings.Report.IncludeLastSeenTime = true;
                settings.Report.IncludeSeenCount = true;
                settings.Report.IncludePeakRssi = true;
                settings.Report.Mode = ReportMode.Individual;
                reader.ApplySettings(settings);
                reader.TagsReported += TagsReport;
                reader.Start();
            }
            catch (OctaneSdkException ex)
            {
                reader.Stop();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TagsReport(ImpinjReader reader, TagReport report)
        {

            foreach (Tag tag in report)
            {
                foreach (DataGridViewRow rv in tableEpc.Rows)
                {
                    if (rv.Cells[0].Value == tag.Epc.ToString() && rv.Cells[1].Value == tag.AntennaPortNumber.ToString())
                    {
                        rv.Cells[3].Value = tag.TagSeenCount.ToString();
                        rv.Cells[4].Value = tag.PeakRssiInDbm.ToString();
                        rv.Cells[5].Value = tag.FirstSeenTime.ToString();
                        continue;
                    }
                }
                tableEpc.Rows.Add(tag.Epc.ToString(), tag.AntennaPortNumber.ToString(), tag.LastSeenTime.ToString(), tag.TagSeenCount.ToString(), tag.PeakRssiInDbm.ToString(), tag.FirstSeenTime.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableEpc.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader.Stop();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
