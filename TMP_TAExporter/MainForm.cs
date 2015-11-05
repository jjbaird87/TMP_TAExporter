using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using TMP_TAExporter.Classes;
using TMP_TAExporter.Properties;

namespace TMP_TAExporter
{
    public partial class MainForm : Form
    {
        private int _timeRemaining;

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
            _timeRemaining = Settings.Default.TimerInterval;
            txtTmpDbLoc.Text = Settings.Default.TmpDbLocation;
            txtIntegrityExport.Text = Settings.Default.IntegrityExportLocation;
            txtPPLocation.Text = Settings.Default.PeopleExportLocation;
            txtPPShiftsLocation.Text = Settings.Default.PeopleShiftsExportLocation;
            txtSamsungLocation.Text = Settings.Default.SamsungExportLocation;
            numInterval.Value = Settings.Default.TimerInterval;
            chkSamsungEnabled.Checked = Settings.Default.TimerEnabled;
            chkEnableFilters.Checked = Settings.Default.EnableIntegrityFilters;

            SamsungExport.OnProgressHandler += SamsungExport_OnProgressHandler;
            IntegrityExport.OnProgressHandler += IntegrityExport_OnProgressHandler;
            PeoplePayroll.OnProgressHandler += PeoplePayroll_OnProgressHandler;

            LoadCostCentres();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }



        private void PeoplePayroll_OnProgressHandler(object sender, EventArgs e)
        {
            toolProgressBar.Value = ((PeoplePayroll.ProgressEventArgs)e).Progress;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_timeRemaining == 0)
            {
                if (!chkSamsungEnabled.Checked) return;
                AddMessage("Starting Automated Samsung Export");
                var error = SamsungExport.ExportSamsung(new DateTime(), new DateTime(), true);
                AddMessage(error);

                _timeRemaining = Settings.Default.TimerInterval;
            }
            else
            {
                _timeRemaining -= 1;
                if (chkSamsungEnabled.Enabled)
                    lblNotification.Text = $"Seconds before processing starts: {_timeRemaining}";
            }
            timer1.Start();
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
            rchStatus.Text = $"{message} \n" + rchStatus.Text;
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
            var ccFrom = ((ComboBoxItemCostCentre) cmbccFrom.SelectedItem).ItemObject.Code;
            var ccTo = ((ComboBoxItemCostCentre)cmbccTo.SelectedItem).ItemObject.Code;
            var err = IntegrityExport.ExportIntegrity(dtIntegrityStart.Value, dtIntegrityEnd.Value,
                chkApplyTarget.Checked, chkEnableFilters.Checked, ccFrom, ccTo);
            AddMessage(err);
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.TimerInterval = (int) numInterval.Value;
            Settings.Default.Save();
            _timeRemaining = (int) numInterval.Value;
        }

        private void chkSamsungEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.TimerEnabled = chkSamsungEnabled.Checked;
            Settings.Default.Save();
        }

        private void btnBrowsePP_Click(object sender, EventArgs e)
        {
            var openDlg = new SaveFileDialog
            {
                FileName = "Hours.xlsx",
                Filter = @"xlsx Files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                AddExtension = true
            };
            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            txtPPLocation.Text = openDlg.FileName;
            Settings.Default.PeopleExportLocation = openDlg.FileName;
            Settings.Default.Save();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddMessage("Starting People's Payroll Export");
            var err = PeoplePayroll.Export(dtPPStart.Value, dtPPEnd.Value);
            AddMessage(err);
        }

        private void btnBrowsePPShifts_Click(object sender, EventArgs e)
        {
            var openDlg = new SaveFileDialog
            {
                FileName = "Shifts.xlsx",
                Filter = @"xlsx Files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                AddExtension = true
            };
            if (openDlg.ShowDialog() != DialogResult.OK)
                return;

            txtPPShiftsLocation.Text = openDlg.FileName;
            Settings.Default.PeopleShiftsExportLocation = openDlg.FileName;
            Settings.Default.Save();
        }

        private void chkEnableFilters_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableIntegrityFilters = chkEnableFilters.Checked;
            Settings.Default.Save();
        }

        private void btnRefreshDepartments_Click(object sender, EventArgs e)
        {
            LoadCostCentres();
        }

        private void LoadCostCentres()
        {
            if (Settings.Default.TmpDbLocation =="")
                return;

            var da = new DataAccess(Settings.Default.TmpDbLocation);
            var cc =  da.GetCostCentres();
            foreach (var costCentre in cc)
            {
                cmbccFrom.Items.Add(new ComboBoxItemCostCentre
                {
                    ItemObject = costCentre
                });
                cmbccTo.Items.Add(new ComboBoxItemCostCentre
                {
                    ItemObject = costCentre
                });
            }

            if (cmbccFrom.Items.Count > 0)
                cmbccFrom.SelectedIndex = 0;

            if (cmbccTo.Items.Count > 0)
                cmbccTo.SelectedIndex = cmbccTo.Items.Count-1;
        }

    }
}