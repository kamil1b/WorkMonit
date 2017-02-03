namespace WorkMonit
{
    partial class SettingsForm
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
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.signatureComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.workGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.hoGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.homeOfficeDaysCheckedList = new System.Windows.Forms.CheckedListBox();
            this.homeOfficeDays = new System.Windows.Forms.GroupBox();
            this.urlRules = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.configurationGroupBox.SuspendLayout();
            this.workGroupBox.SuspendLayout();
            this.hoGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.homeOfficeDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.checkBox3);
            this.configurationGroupBox.Controls.Add(this.checkBox1);
            this.configurationGroupBox.Controls.Add(this.checkBox2);
            this.configurationGroupBox.Controls.Add(this.checkBox4);
            this.configurationGroupBox.Controls.Add(this.signatureComboBox);
            this.configurationGroupBox.Controls.Add(this.label7);
            this.configurationGroupBox.Controls.Add(this.label6);
            this.configurationGroupBox.Controls.Add(this.textBox1);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(292, 168);
            this.configurationGroupBox.TabIndex = 2;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Basic configuration";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = global::WorkMonit.Properties.Settings.Default.SilentMode;
            this.checkBox4.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WorkMonit.Properties.Settings.Default, "SilentMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox4.Location = new System.Drawing.Point(6, 15);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(142, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Disable dialog on startup";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // signatureComboBox
            // 
            this.signatureComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "Signature", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signatureComboBox.FormattingEnabled = true;
            this.signatureComboBox.Items.AddRange(new object[] {
            "None",
            "Default"});
            this.signatureComboBox.Location = new System.Drawing.Point(107, 136);
            this.signatureComboBox.Name = "signatureComboBox";
            this.signatureComboBox.Size = new System.Drawing.Size(179, 21);
            this.signatureComboBox.TabIndex = 7;
            this.signatureComboBox.Text = global::WorkMonit.Properties.Settings.Default.Signature;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Signature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email to supervisor";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(107, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = global::WorkMonit.Properties.Settings.Default.Email;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Define method to detect HO";
            // 
            // workGroupBox
            // 
            this.workGroupBox.Controls.Add(this.label2);
            this.workGroupBox.Controls.Add(this.dateTimePicker2);
            this.workGroupBox.Controls.Add(this.label1);
            this.workGroupBox.Controls.Add(this.dateTimePicker1);
            this.workGroupBox.Location = new System.Drawing.Point(12, 186);
            this.workGroupBox.Name = "workGroupBox";
            this.workGroupBox.Size = new System.Drawing.Size(292, 72);
            this.workGroupBox.TabIndex = 3;
            this.workGroupBox.TabStop = false;
            this.workGroupBox.Text = "Office";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inform about work end after";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WorkMonit.Properties.Settings.Default, "TimeWorkEnd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(176, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = global::WorkMonit.Properties.Settings.Default.TimeWorkEnd;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inform about work begin before";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WorkMonit.Properties.Settings.Default, "TimeWorkBegin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = global::WorkMonit.Properties.Settings.Default.TimeWorkBegin;
            // 
            // hoGroupBox
            // 
            this.hoGroupBox.Controls.Add(this.label3);
            this.hoGroupBox.Controls.Add(this.dateTimePicker3);
            this.hoGroupBox.Controls.Add(this.label4);
            this.hoGroupBox.Controls.Add(this.dateTimePicker4);
            this.hoGroupBox.Location = new System.Drawing.Point(12, 264);
            this.hoGroupBox.Name = "hoGroupBox";
            this.hoGroupBox.Size = new System.Drawing.Size(292, 66);
            this.hoGroupBox.TabIndex = 4;
            this.hoGroupBox.TabStop = false;
            this.hoGroupBox.Text = "Home Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inform about work end after";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WorkMonit.Properties.Settings.Default, "HOWorkEnd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(176, 36);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = global::WorkMonit.Properties.Settings.Default.HOWorkEnd;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inform about work begin before";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::WorkMonit.Properties.Settings.Default, "HOWorkBegin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(176, 10);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker4.TabIndex = 5;
            this.dateTimePicker4.Value = global::WorkMonit.Properties.Settings.Default.HOWorkBegin;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(310, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Home office";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "DetectHomeOffice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Define home office days"});
            this.comboBox1.Location = new System.Drawing.Point(6, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = global::WorkMonit.Properties.Settings.Default.DetectHomeOffice;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // homeOfficeDaysCheckedList
            // 
            this.homeOfficeDaysCheckedList.CheckOnClick = true;
            this.homeOfficeDaysCheckedList.FormattingEnabled = true;
            this.homeOfficeDaysCheckedList.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.homeOfficeDaysCheckedList.Location = new System.Drawing.Point(6, 26);
            this.homeOfficeDaysCheckedList.Name = "homeOfficeDaysCheckedList";
            this.homeOfficeDaysCheckedList.Size = new System.Drawing.Size(280, 109);
            this.homeOfficeDaysCheckedList.TabIndex = 3;
            this.homeOfficeDaysCheckedList.SelectedIndexChanged += new System.EventHandler(this.homeOfficeDays_SelectedIndexChanged);
            // 
            // homeOfficeDays
            // 
            this.homeOfficeDays.Controls.Add(this.homeOfficeDaysCheckedList);
            this.homeOfficeDays.Location = new System.Drawing.Point(310, 79);
            this.homeOfficeDays.Name = "homeOfficeDays";
            this.homeOfficeDays.Size = new System.Drawing.Size(292, 141);
            this.homeOfficeDays.TabIndex = 11;
            this.homeOfficeDays.TabStop = false;
            this.homeOfficeDays.Text = "Home office days";
            // 
            // urlRules
            // 
            this.urlRules.Location = new System.Drawing.Point(310, 227);
            this.urlRules.Name = "urlRules";
            this.urlRules.Size = new System.Drawing.Size(292, 103);
            this.urlRules.TabIndex = 12;
            this.urlRules.TabStop = false;
            this.urlRules.Text = "Url and process rules";
            this.urlRules.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::WorkMonit.Properties.Settings.Default.AutoHomeWork;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WorkMonit.Properties.Settings.Default, "AutoHomeWork", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(6, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(213, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Auto mail send if home work is detected";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(6, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(236, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Auto mail send if work from office is detected";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::WorkMonit.Properties.Settings.Default.MailPrompt;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WorkMonit.Properties.Settings.Default, "MailPrompt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(7, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Promt before mail send";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 344);
            this.Controls.Add(this.urlRules);
            this.Controls.Add(this.homeOfficeDays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hoGroupBox);
            this.Controls.Add(this.workGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            this.workGroupBox.ResumeLayout(false);
            this.workGroupBox.PerformLayout();
            this.hoGroupBox.ResumeLayout(false);
            this.hoGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.homeOfficeDays.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox workGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox hoGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox signatureComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox homeOfficeDaysCheckedList;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox homeOfficeDays;
        private System.Windows.Forms.GroupBox urlRules;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}