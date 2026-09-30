using Impinj.OctaneSdk;

namespace RFIDapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ImpinjReader reader = new ImpinjReader();
            reader.Connect("192.168.1.100");
            reader.ClearSettings();
            Settings settings= reader.QueryFactorySettings();
            settings.Report.IncludeAntennaPortNumber = true;
            settings.Report.Mode = ReportMode.WaitForQuery;
            reader.ApplySettings(settings);


        }
    }
}
