namespace TMP_TAExporter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpIntegrityFilters = new System.Windows.Forms.GroupBox();
            this.btnRefreshDepartments = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbccTo = new System.Windows.Forms.ComboBox();
            this.cmbccFrom = new System.Windows.Forms.ComboBox();
            this.chkEnableFilters = new System.Windows.Forms.CheckBox();
            this.chkApplyTarget = new System.Windows.Forms.CheckBox();
            this.btnStartIntegrity = new System.Windows.Forms.Button();
            this.btnBrowseIntegrity = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntegrityExport = new System.Windows.Forms.TextBox();
            this.dtIntegrityEnd = new System.Windows.Forms.DateTimePicker();
            this.dtIntegrityStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSamsungLocBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSamsungLocation = new System.Windows.Forms.TextBox();
            this.btnStartSamsungExport = new System.Windows.Forms.Button();
            this.chkSamsungEnabled = new System.Windows.Forms.CheckBox();
            this.dtSamsungEnd = new System.Windows.Forms.DateTimePicker();
            this.dtSamsungStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBrowsePPShifts = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPPShiftsLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBrowsePP = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPPLocation = new System.Windows.Forms.TextBox();
            this.dtPPEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPPStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNetworkLocation = new System.Windows.Forms.TextBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnTmpDbLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTmpDbLoc = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblNotification = new System.Windows.Forms.ToolStripLabel();
            this.rchStatus = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCompanyTo = new System.Windows.Forms.ComboBox();
            this.cmbCompanyFrom = new System.Windows.Forms.ComboBox();
            this.chkEnablePeoplePayrollFilters = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpIntegrityFilters.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpIntegrityFilters);
            this.tabPage1.Controls.Add(this.chkApplyTarget);
            this.tabPage1.Controls.Add(this.btnStartIntegrity);
            this.tabPage1.Controls.Add(this.btnBrowseIntegrity);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtIntegrityExport);
            this.tabPage1.Controls.Add(this.dtIntegrityEnd);
            this.tabPage1.Controls.Add(this.dtIntegrityStart);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Integrity Export";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpIntegrityFilters
            // 
            this.grpIntegrityFilters.Controls.Add(this.btnRefreshDepartments);
            this.grpIntegrityFilters.Controls.Add(this.label14);
            this.grpIntegrityFilters.Controls.Add(this.label13);
            this.grpIntegrityFilters.Controls.Add(this.cmbccTo);
            this.grpIntegrityFilters.Controls.Add(this.cmbccFrom);
            this.grpIntegrityFilters.Controls.Add(this.chkEnableFilters);
            this.grpIntegrityFilters.Location = new System.Drawing.Point(23, 162);
            this.grpIntegrityFilters.Name = "grpIntegrityFilters";
            this.grpIntegrityFilters.Size = new System.Drawing.Size(354, 138);
            this.grpIntegrityFilters.TabIndex = 10;
            this.grpIntegrityFilters.TabStop = false;
            this.grpIntegrityFilters.Text = "Filters";
            // 
            // btnRefreshDepartments
            // 
            this.btnRefreshDepartments.Location = new System.Drawing.Point(273, 15);
            this.btnRefreshDepartments.Name = "btnRefreshDepartments";
            this.btnRefreshDepartments.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshDepartments.TabIndex = 5;
            this.btnRefreshDepartments.Text = "Refresh";
            this.btnRefreshDepartments.UseVisualStyleBackColor = true;
            this.btnRefreshDepartments.Click += new System.EventHandler(this.btnRefreshDepartments_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Branch To:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Branch From:";
            // 
            // cmbccTo
            // 
            this.cmbccTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbccTo.FormattingEnabled = true;
            this.cmbccTo.Location = new System.Drawing.Point(6, 102);
            this.cmbccTo.Name = "cmbccTo";
            this.cmbccTo.Size = new System.Drawing.Size(342, 21);
            this.cmbccTo.TabIndex = 2;
            // 
            // cmbccFrom
            // 
            this.cmbccFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbccFrom.FormattingEnabled = true;
            this.cmbccFrom.Location = new System.Drawing.Point(6, 63);
            this.cmbccFrom.Name = "cmbccFrom";
            this.cmbccFrom.Size = new System.Drawing.Size(342, 21);
            this.cmbccFrom.TabIndex = 1;
            // 
            // chkEnableFilters
            // 
            this.chkEnableFilters.AutoSize = true;
            this.chkEnableFilters.Location = new System.Drawing.Point(6, 19);
            this.chkEnableFilters.Name = "chkEnableFilters";
            this.chkEnableFilters.Size = new System.Drawing.Size(89, 17);
            this.chkEnableFilters.TabIndex = 0;
            this.chkEnableFilters.Text = "Enable Filters";
            this.chkEnableFilters.UseVisualStyleBackColor = true;
            this.chkEnableFilters.CheckedChanged += new System.EventHandler(this.chkEnableFilters_CheckedChanged);
            // 
            // chkApplyTarget
            // 
            this.chkApplyTarget.AutoSize = true;
            this.chkApplyTarget.Checked = true;
            this.chkApplyTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkApplyTarget.Location = new System.Drawing.Point(23, 20);
            this.chkApplyTarget.Name = "chkApplyTarget";
            this.chkApplyTarget.Size = new System.Drawing.Size(96, 17);
            this.chkApplyTarget.TabIndex = 9;
            this.chkApplyTarget.Text = "Balance Hours";
            this.chkApplyTarget.UseVisualStyleBackColor = true;
            // 
            // btnStartIntegrity
            // 
            this.btnStartIntegrity.Location = new System.Drawing.Point(23, 306);
            this.btnStartIntegrity.Name = "btnStartIntegrity";
            this.btnStartIntegrity.Size = new System.Drawing.Size(354, 23);
            this.btnStartIntegrity.TabIndex = 8;
            this.btnStartIntegrity.Text = "Start Export";
            this.btnStartIntegrity.UseVisualStyleBackColor = true;
            this.btnStartIntegrity.Click += new System.EventHandler(this.btnStartIntegrity_Click);
            // 
            // btnBrowseIntegrity
            // 
            this.btnBrowseIntegrity.Location = new System.Drawing.Point(347, 70);
            this.btnBrowseIntegrity.Name = "btnBrowseIntegrity";
            this.btnBrowseIntegrity.Size = new System.Drawing.Size(30, 20);
            this.btnBrowseIntegrity.TabIndex = 6;
            this.btnBrowseIntegrity.Text = "...";
            this.btnBrowseIntegrity.UseVisualStyleBackColor = true;
            this.btnBrowseIntegrity.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Export Location:";
            // 
            // txtIntegrityExport
            // 
            this.txtIntegrityExport.Location = new System.Drawing.Point(23, 70);
            this.txtIntegrityExport.Name = "txtIntegrityExport";
            this.txtIntegrityExport.Size = new System.Drawing.Size(318, 20);
            this.txtIntegrityExport.TabIndex = 4;
            // 
            // dtIntegrityEnd
            // 
            this.dtIntegrityEnd.Location = new System.Drawing.Point(85, 124);
            this.dtIntegrityEnd.Name = "dtIntegrityEnd";
            this.dtIntegrityEnd.Size = new System.Drawing.Size(292, 20);
            this.dtIntegrityEnd.TabIndex = 3;
            // 
            // dtIntegrityStart
            // 
            this.dtIntegrityStart.Location = new System.Drawing.Point(85, 98);
            this.dtIntegrityStart.Name = "dtIntegrityStart";
            this.dtIntegrityStart.Size = new System.Drawing.Size(292, 20);
            this.dtIntegrityStart.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "To Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "From Date:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSamsungLocBrowse);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtSamsungLocation);
            this.tabPage3.Controls.Add(this.btnStartSamsungExport);
            this.tabPage3.Controls.Add(this.chkSamsungEnabled);
            this.tabPage3.Controls.Add(this.dtSamsungEnd);
            this.tabPage3.Controls.Add(this.dtSamsungStart);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 521);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Samsung Export";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSamsungLocBrowse
            // 
            this.btnSamsungLocBrowse.Location = new System.Drawing.Point(341, 63);
            this.btnSamsungLocBrowse.Name = "btnSamsungLocBrowse";
            this.btnSamsungLocBrowse.Size = new System.Drawing.Size(30, 20);
            this.btnSamsungLocBrowse.TabIndex = 20;
            this.btnSamsungLocBrowse.Text = "...";
            this.btnSamsungLocBrowse.UseVisualStyleBackColor = true;
            this.btnSamsungLocBrowse.Click += new System.EventHandler(this.btnSamsungLocBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Export Location:";
            // 
            // txtSamsungLocation
            // 
            this.txtSamsungLocation.Location = new System.Drawing.Point(11, 63);
            this.txtSamsungLocation.Name = "txtSamsungLocation";
            this.txtSamsungLocation.Size = new System.Drawing.Size(324, 20);
            this.txtSamsungLocation.TabIndex = 18;
            // 
            // btnStartSamsungExport
            // 
            this.btnStartSamsungExport.Location = new System.Drawing.Point(11, 151);
            this.btnStartSamsungExport.Name = "btnStartSamsungExport";
            this.btnStartSamsungExport.Size = new System.Drawing.Size(360, 23);
            this.btnStartSamsungExport.TabIndex = 17;
            this.btnStartSamsungExport.Text = "Start Export";
            this.btnStartSamsungExport.UseVisualStyleBackColor = true;
            this.btnStartSamsungExport.Click += new System.EventHandler(this.btnStartSamsungExport_Click);
            // 
            // chkSamsungEnabled
            // 
            this.chkSamsungEnabled.AutoSize = true;
            this.chkSamsungEnabled.Location = new System.Drawing.Point(17, 17);
            this.chkSamsungEnabled.Name = "chkSamsungEnabled";
            this.chkSamsungEnabled.Size = new System.Drawing.Size(88, 17);
            this.chkSamsungEnabled.TabIndex = 16;
            this.chkSamsungEnabled.Text = "Enable Timer";
            this.chkSamsungEnabled.UseVisualStyleBackColor = true;
            this.chkSamsungEnabled.CheckedChanged += new System.EventHandler(this.chkSamsungEnabled_CheckedChanged);
            // 
            // dtSamsungEnd
            // 
            this.dtSamsungEnd.Location = new System.Drawing.Point(73, 115);
            this.dtSamsungEnd.Name = "dtSamsungEnd";
            this.dtSamsungEnd.Size = new System.Drawing.Size(298, 20);
            this.dtSamsungEnd.TabIndex = 12;
            // 
            // dtSamsungStart
            // 
            this.dtSamsungStart.Location = new System.Drawing.Point(73, 89);
            this.dtSamsungStart.Name = "dtSamsungStart";
            this.dtSamsungStart.Size = new System.Drawing.Size(298, 20);
            this.dtSamsungStart.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "To Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "From Date:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.btnBrowsePPShifts);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtPPShiftsLocation);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btnBrowsePP);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtPPLocation);
            this.tabPage4.Controls.Add(this.dtPPEnd);
            this.tabPage4.Controls.Add(this.dtPPStart);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(385, 521);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Peoples Payroll Export";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // btnBrowsePPShifts
            // 
            this.btnBrowsePPShifts.Location = new System.Drawing.Point(335, 71);
            this.btnBrowsePPShifts.Name = "btnBrowsePPShifts";
            this.btnBrowsePPShifts.Size = new System.Drawing.Size(30, 20);
            this.btnBrowsePPShifts.TabIndex = 19;
            this.btnBrowsePPShifts.Text = "...";
            this.btnBrowsePPShifts.UseVisualStyleBackColor = true;
            this.btnBrowsePPShifts.Click += new System.EventHandler(this.btnBrowsePPShifts_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Export Location (Shifts):";
            // 
            // txtPPShiftsLocation
            // 
            this.txtPPShiftsLocation.Location = new System.Drawing.Point(11, 71);
            this.txtPPShiftsLocation.Name = "txtPPShiftsLocation";
            this.txtPPShiftsLocation.Size = new System.Drawing.Size(318, 20);
            this.txtPPShiftsLocation.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(354, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Start Export";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnBrowsePP
            // 
            this.btnBrowsePP.Location = new System.Drawing.Point(335, 32);
            this.btnBrowsePP.Name = "btnBrowsePP";
            this.btnBrowsePP.Size = new System.Drawing.Size(30, 20);
            this.btnBrowsePP.TabIndex = 15;
            this.btnBrowsePP.Text = "...";
            this.btnBrowsePP.UseVisualStyleBackColor = true;
            this.btnBrowsePP.Click += new System.EventHandler(this.btnBrowsePP_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Export Location (Hours):";
            // 
            // txtPPLocation
            // 
            this.txtPPLocation.Location = new System.Drawing.Point(11, 32);
            this.txtPPLocation.Name = "txtPPLocation";
            this.txtPPLocation.Size = new System.Drawing.Size(318, 20);
            this.txtPPLocation.TabIndex = 13;
            // 
            // dtPPEnd
            // 
            this.dtPPEnd.Location = new System.Drawing.Point(70, 131);
            this.dtPPEnd.Name = "dtPPEnd";
            this.dtPPEnd.Size = new System.Drawing.Size(292, 20);
            this.dtPPEnd.TabIndex = 12;
            // 
            // dtPPStart
            // 
            this.dtPPStart.Location = new System.Drawing.Point(70, 105);
            this.dtPPStart.Name = "dtPPStart";
            this.dtPPStart.Size = new System.Drawing.Size(292, 20);
            this.dtPPStart.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "To Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "From Date:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtNetworkLocation);
            this.tabPage2.Controls.Add(this.numInterval);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnTestConnection);
            this.tabPage2.Controls.Add(this.btnTmpDbLoc);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtTmpDbLoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Network location";
            // 
            // txtNetworkLocation
            // 
            this.txtNetworkLocation.Location = new System.Drawing.Point(14, 30);
            this.txtNetworkLocation.Name = "txtNetworkLocation";
            this.txtNetworkLocation.Size = new System.Drawing.Size(327, 20);
            this.txtNetworkLocation.TabIndex = 6;
            this.txtNetworkLocation.TextChanged += new System.EventHandler(this.txtNetworkLocation_TextChanged);
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(14, 146);
            this.numInterval.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(360, 20);
            this.numInterval.TabIndex = 5;
            this.numInterval.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Timer Interval (seconds):";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(11, 99);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(363, 23);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnTmpDbLoc
            // 
            this.btnTmpDbLoc.Location = new System.Drawing.Point(344, 73);
            this.btnTmpDbLoc.Name = "btnTmpDbLoc";
            this.btnTmpDbLoc.Size = new System.Drawing.Size(30, 20);
            this.btnTmpDbLoc.TabIndex = 2;
            this.btnTmpDbLoc.Text = "...";
            this.btnTmpDbLoc.UseVisualStyleBackColor = true;
            this.btnTmpDbLoc.Click += new System.EventHandler(this.btnTmpDbLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Manager Database Location";
            // 
            // txtTmpDbLoc
            // 
            this.txtTmpDbLoc.Location = new System.Drawing.Point(11, 73);
            this.txtTmpDbLoc.Name = "txtTmpDbLoc";
            this.txtTmpDbLoc.Size = new System.Drawing.Size(327, 20);
            this.txtTmpDbLoc.TabIndex = 0;
            this.txtTmpDbLoc.TextChanged += new System.EventHandler(this.txtTmpDbLoc_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolProgressBar,
            this.lblNotification});
            this.toolStrip1.Location = new System.Drawing.Point(0, 522);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(393, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolProgressBar
            // 
            this.toolProgressBar.Name = "toolProgressBar";
            this.toolProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // lblNotification
            // 
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(138, 22);
            this.lblNotification.Text = "Time till next processing:";
            // 
            // rchStatus
            // 
            this.rchStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rchStatus.Location = new System.Drawing.Point(0, 357);
            this.rchStatus.Name = "rchStatus";
            this.rchStatus.ReadOnly = true;
            this.rchStatus.Size = new System.Drawing.Size(393, 165);
            this.rchStatus.TabIndex = 18;
            this.rchStatus.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbCompanyTo);
            this.groupBox1.Controls.Add(this.cmbCompanyFrom);
            this.groupBox1.Controls.Add(this.chkEnablePeoplePayrollFilters);
            this.groupBox1.Location = new System.Drawing.Point(11, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 138);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Company To:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "Company From:";
            // 
            // cmbCompanyTo
            // 
            this.cmbCompanyTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyTo.FormattingEnabled = true;
            this.cmbCompanyTo.Location = new System.Drawing.Point(6, 102);
            this.cmbCompanyTo.Name = "cmbCompanyTo";
            this.cmbCompanyTo.Size = new System.Drawing.Size(342, 21);
            this.cmbCompanyTo.TabIndex = 2;
            // 
            // cmbCompanyFrom
            // 
            this.cmbCompanyFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompanyFrom.FormattingEnabled = true;
            this.cmbCompanyFrom.Location = new System.Drawing.Point(6, 63);
            this.cmbCompanyFrom.Name = "cmbCompanyFrom";
            this.cmbCompanyFrom.Size = new System.Drawing.Size(342, 21);
            this.cmbCompanyFrom.TabIndex = 1;
            // 
            // chkEnablePeoplePayrollFilters
            // 
            this.chkEnablePeoplePayrollFilters.AutoSize = true;
            this.chkEnablePeoplePayrollFilters.Location = new System.Drawing.Point(6, 19);
            this.chkEnablePeoplePayrollFilters.Name = "chkEnablePeoplePayrollFilters";
            this.chkEnablePeoplePayrollFilters.Size = new System.Drawing.Size(89, 17);
            this.chkEnablePeoplePayrollFilters.TabIndex = 0;
            this.chkEnablePeoplePayrollFilters.Text = "Enable Filters";
            this.chkEnablePeoplePayrollFilters.UseVisualStyleBackColor = true;
            this.chkEnablePeoplePayrollFilters.CheckedChanged += new System.EventHandler(this.chkEnablePeoplePayrollFilters_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 547);
            this.Controls.Add(this.rchStatus);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpIntegrityFilters.ResumeLayout(false);
            this.grpIntegrityFilters.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnTmpDbLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTmpDbLoc;
        private System.Windows.Forms.DateTimePicker dtIntegrityEnd;
        private System.Windows.Forms.DateTimePicker dtIntegrityStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnStartIntegrity;
        private System.Windows.Forms.Button btnStartSamsungExport;
        private System.Windows.Forms.CheckBox chkSamsungEnabled;
        private System.Windows.Forms.DateTimePicker dtSamsungEnd;
        private System.Windows.Forms.DateTimePicker dtSamsungStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolProgressBar;
        private System.Windows.Forms.RichTextBox rchStatus;
        private System.Windows.Forms.Button btnBrowseIntegrity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntegrityExport;
        private System.Windows.Forms.Button btnSamsungLocBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSamsungLocation;
        private System.Windows.Forms.CheckBox chkApplyTarget;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel lblNotification;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBrowsePP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPPLocation;
        private System.Windows.Forms.DateTimePicker dtPPEnd;
        private System.Windows.Forms.DateTimePicker dtPPStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrowsePPShifts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPPShiftsLocation;
        private System.Windows.Forms.GroupBox grpIntegrityFilters;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbccTo;
        private System.Windows.Forms.ComboBox cmbccFrom;
        private System.Windows.Forms.CheckBox chkEnableFilters;
        private System.Windows.Forms.Button btnRefreshDepartments;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNetworkLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbCompanyTo;
        private System.Windows.Forms.ComboBox cmbCompanyFrom;
        private System.Windows.Forms.CheckBox chkEnablePeoplePayrollFilters;
    }
}

