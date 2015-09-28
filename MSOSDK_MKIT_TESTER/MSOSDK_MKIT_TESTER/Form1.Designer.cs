namespace MSOSDK_MKIT_TESTER
{
    partial class Form1
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
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radMkit = new System.Windows.Forms.RadioButton();
            this.radMsoSdk = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDevices
            // 
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(13, 33);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(490, 21);
            this.cmbDevices.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devices";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(490, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enroll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radMkit
            // 
            this.radMkit.AutoSize = true;
            this.radMkit.Location = new System.Drawing.Point(28, 61);
            this.radMkit.Name = "radMkit";
            this.radMkit.Size = new System.Drawing.Size(73, 17);
            this.radMkit.TabIndex = 3;
            this.radMkit.Text = "MorphoKit";
            this.radMkit.UseVisualStyleBackColor = true;
            this.radMkit.CheckedChanged += new System.EventHandler(this.radMkit_CheckedChanged);
            // 
            // radMsoSdk
            // 
            this.radMsoSdk.AutoSize = true;
            this.radMsoSdk.Checked = true;
            this.radMsoSdk.Location = new System.Drawing.Point(28, 84);
            this.radMsoSdk.Name = "radMsoSdk";
            this.radMsoSdk.Size = new System.Drawing.Size(74, 17);
            this.radMsoSdk.TabIndex = 4;
            this.radMsoSdk.TabStop = true;
            this.radMsoSdk.Text = "MSO SDK";
            this.radMsoSdk.UseVisualStyleBackColor = true;
            this.radMsoSdk.CheckedChanged += new System.EventHandler(this.radMsoSdk_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(490, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Restart App";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 172);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radMsoSdk);
            this.Controls.Add(this.radMkit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDevices);
            this.Name = "Form1";
            this.Text = "Enrolment Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radMkit;
        private System.Windows.Forms.RadioButton radMsoSdk;
        private System.Windows.Forms.Button button2;
    }
}

