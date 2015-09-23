using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using TMP_TAExporter.Properties;

namespace TMP_TAExporter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTmpDbLoc_Click(object sender, EventArgs e)
        {
            var openDlg = new OpenFileDialog
            {
                FileName = "TIMEMANAGERPLATINUM.gdb",
                Filter = @"gdb Files (*.gdb)|*.gdb|fdb Files (*.fdb)|*.fdb|All files (*.*)|*.*",
                AddExtension = true
            };
            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            txtTmpDbLoc.Text = openDlg.FileName;
            Settings.Default.TmpDbLocation = openDlg.FileName;
            Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtTmpDbLoc.Text = Settings.Default.TmpDbLocation;
            txtIntegrityExport.Text = Settings.Default.IntegrityExportLocation;
            txtSamsungLocation.Text = Settings.Default.SamsungExportLocation;

            SamsungExport.OnProgressHandler += SamsungExport_OnProgressHandler;
            IntegrityExport.OnProgressHandler += IntegrityExport_OnProgressHandler;
        }

        private void IntegrityExport_OnProgressHandler(object sender, EventArgs e)
        {
            toolProgressBar.Value = ((IntegrityExport.ProgressEventArgs) e).Progress;
        }

        private void SamsungExport_OnProgressHandler(object sender, EventArgs e)
        {
            toolProgressBar.Value = ((SamsungExport.ProgressEventArgs) e).Progress;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the ServerType to 1 for connect to the embedded server
                var connectionString =
                    "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + @txtTmpDbLoc.Text + ";" +
                    "DataSource=localhost;" +
                    "Port=3050;" +
                    "Dialect=3;" +
                    "Charset=NONE;" +
                    "Role=;" +
                    "Connection lifetime=15;" +
                    "Pooling=true;" +
                    "Packet Size=8192;" +
                    "ServerType=0";

                var myConnection = new FbConnection(connectionString);
                myConnection.Open();

                MessageBox.Show(@"Connection Successful");

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openDlg = new SaveFileDialog
            {
                FileName = "Payroll.txt",
                Filter = @"txt Files (*.txt)|*.txt|All files (*.*)|*.*",
                AddExtension = true
            };
            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            txtIntegrityExport.Text = openDlg.FileName;
            Settings.Default.IntegrityExportLocation = openDlg.FileName;
            Settings.Default.Save();
        }

        private void btnStartSamsungExport_Click(object sender, EventArgs e)
        {
            AddMessage("Starting Samsung Export");
            var error = SamsungExport.ExportSamsung(dtSamsungStart.Value, dtSamsungEnd.Value);
            AddMessage(error);
        }

        private void AddMessage(string message)
        {
            rchStatus.Text += $"{message} \n";
        }

        private void btnSamsungLocBrowse_Click(object sender, EventArgs e)
        {
            var openDlg = new FolderBrowserDialog();
            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            txtSamsungLocation.Text = openDlg.SelectedPath;
            Settings.Default.SamsungExportLocation = openDlg.SelectedPath;
            Settings.Default.Save();
        }

        private void btnStartIntegrity_Click(object sender, EventArgs e)
        {
            AddMessage("Starting Integrity Export");
            var err = IntegrityExport.ExportIntegrity(dtIntegrityStart.Value, dtIntegrityEnd.Value);
            AddMessage(err);
        }
    }
}