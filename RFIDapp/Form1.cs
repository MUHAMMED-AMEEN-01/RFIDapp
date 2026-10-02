using Impinj.OctaneSdk;

namespace RFIDapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buzzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buzzer buzzer = new Buzzer();
            buzzer.Show();

        }

        private void ePCTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EPCTable ePCTable = new EPCTable();
            ePCTable.Show();
        }

        private void readerConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReaderConnection readerConnection = new ReaderConnection();
            readerConnection.Show();

        }
    }
}
