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
        TagData tag = new TagData();
        ImpinjReader reader;
        public AppSession appSession;
        public EPCTable()
        {
            InitializeComponent();

        }
        public EPCTable(AppSession session, ImpinjReader read)
        {
            InitializeComponent();
            appSession = session;
            reader = read;
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
                foreach(DataRow rv in dataGridView1.Rows)
                {
                    if (rv[0].ToString() == tag.Epc.ToString())
                    {
                        rv[3] = tag.TagSeenCount.ToString();
                        rv[4] = tag.PeakRssiInDbm.ToString();
                        rv[5] = tag.FirstSeenTime.ToString();
                        return;
                    }
                }
                dataGridView1.Rows.Add(tag.Epc.ToString(), tag.AntennaPortNumber.ToString(), tag.LastSeenTime.ToString(), tag.TagSeenCount.ToString(), tag.PeakRssiInDbm.ToString(),tag.FirstSeenTime);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reader.Stop(); 
        }
    }
}
