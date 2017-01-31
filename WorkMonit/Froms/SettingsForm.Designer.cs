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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.signatureComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.configurationGroupBox.SuspendLayout();
            this.workGroupBox.SuspendLayout();
            this.hoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.label5);
            this.configurationGroupBox.Controls.Add(this.comboBox1);
            this.configurationGroupBox.Controls.Add(this.checkBox1);
            this.configurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(260, 86);
            this.configurationGroupBox.TabIndex = 2;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Silent mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Define method to detect HO";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "DetectHomeOffice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "UrlMethod",
            "UraDetect"});
            this.comboBox1.Location = new System.Drawing.Point(6, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = global::WorkMonit.Properties.Settings.Default.DetectHomeOffice;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::WorkMonit.Properties.Settings.Default.SilentMode;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::WorkMonit.Properties.Settings.Default, "SilentMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Silent mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // workGroupBox
            // 
            this.workGroupBox.Controls.Add(this.label2);
            this.workGroupBox.Controls.Add(this.dateTimePicker2);
            this.workGroupBox.Controls.Add(this.label1);
            this.workGroupBox.Controls.Add(this.dateTimePicker1);
            this.workGroupBox.Location = new System.Drawing.Point(13, 104);
            this.workGroupBox.Name = "workGroupBox";
            this.workGroupBox.Size = new System.Drawing.Size(259, 72);
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
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 36);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(166, 10);
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
            this.hoGroupBox.Location = new System.Drawing.Point(13, 182);
            this.hoGroupBox.Name = "hoGroupBox";
            this.hoGroupBox.Size = new System.Drawing.Size(259, 66);
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
            this.dateTimePicker3.Location = new System.Drawing.Point(166, 36);
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
            this.dateTimePicker4.Location = new System.Drawing.Point(166, 10);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker4.TabIndex = 5;
            this.dateTimePicker4.Value = global::WorkMonit.Properties.Settings.Default.HOWorkBegin;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email to supervisor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Signature";
            // 
            // signatureComboBox
            // 
            this.signatureComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "Signature", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.signatureComboBox.FormattingEnabled = true;
            this.signatureComboBox.Items.AddRange(new object[] {
            "None",
            "Default"});
            this.signatureComboBox.Location = new System.Drawing.Point(114, 281);
            this.signatureComboBox.Name = "signatureComboBox";
            this.signatureComboBox.Size = new System.Drawing.Size(158, 21);
            this.signatureComboBox.TabIndex = 7;
            this.signatureComboBox.Text = global::WorkMonit.Properties.Settings.Default.Signature;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(114, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = global::WorkMonit.Properties.Settings.Default.Email;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 315);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.signatureComboBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
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
    }
}