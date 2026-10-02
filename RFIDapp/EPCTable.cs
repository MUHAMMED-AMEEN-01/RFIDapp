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
        public EPCTable(AppSession session , ImpinjReader read)
        {
            InitializeComponent();
            appSession = session;
            reader = read;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= null;
        }
    }
}
