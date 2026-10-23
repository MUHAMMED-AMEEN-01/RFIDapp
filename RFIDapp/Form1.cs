using Impinj.OctaneSdk;

namespace RFIDapp
{
    public partial class Index : Form
    {
        ImpinjReader reader;
        public Index()
        {
            InitializeComponent();
            if (reader == null)
            {
                buzzer.Enabled = false;
                epcTable.Enabled = false;
            }
        }

        public Index(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
            if (reader.IsConnected)
            {
                buzzer.Enabled = true;
                epcTable.Enabled = true;
            }
            else
            {
                buzzer.Enabled = false;
                epcTable.Enabled = false;
            }
        }
        private void buzzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buzzer buzzer = new Buzzer(reader);
            buzzer.Show();

        }

        private void ePCTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPCTable ePCTable = new EPCTable(reader);
            ePCTable.Show();
        }

        private void readerConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader != null && reader.IsConnected)
            {
                ReaderConnection readerConnection = new ReaderConnection(reader);
                readerConnection.Show();
                
            }
            else
            {
                ReaderConnection readerConnection = new ReaderConnection();
                readerConnection.Show();
                
            }
       
        }
    }
}
