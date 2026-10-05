using Impinj.OctaneSdk;

namespace RFIDapp
{
    public partial class Form1 : Form
    {
        ImpinjReader reader;
        public Form1()
        {
            InitializeComponent();
            if (reader == null)
            {
                buzzerToolStripMenuItem.Enabled = false;
                ePCTableToolStripMenuItem.Enabled = false;
            }
        }

        public Form1(ImpinjReader read)
        {
            InitializeComponent();
            reader = read;
            if (reader.IsConnected)
            {
                buzzerToolStripMenuItem.Enabled = true;
                ePCTableToolStripMenuItem.Enabled = true;
            }
            else
            {
                buzzerToolStripMenuItem.Enabled = false;
                ePCTableToolStripMenuItem.Enabled = false;
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
