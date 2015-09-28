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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnTmpDbLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTmpDbLoc = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.rchStatus = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblNotification = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            this.btnStartIntegrity.Location = new System.Drawing.Point(23, 163);
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
            // tabPage2
            // 
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
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(11, 60);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(363, 23);
            this.btnTestConnection.TabIndex = 3;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnTmpDbLoc
            // 
            this.btnTmpDbLoc.Location = new System.Drawing.Point(344, 34);
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
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Manager Database Location";
            // 
            // txtTmpDbLoc
            // 
            this.txtTmpDbLoc.Location = new System.Drawing.Point(11, 34);
            this.txtTmpDbLoc.Name = "txtTmpDbLoc";
            this.txtTmpDbLoc.Size = new System.Drawing.Size(327, 20);
            this.txtTmpDbLoc.TabIndex = 0;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Timer Interval (seconds):";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(14, 107);
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
            // lblNotification
            // 
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(138, 22);
            this.lblNotification.Text = "Time till next processing:";
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
            this.Text = "Time Manager Platinum - Payroll Exporter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
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
    }
}

