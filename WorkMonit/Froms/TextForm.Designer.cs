﻿namespace WorkMonit.Froms
{
    partial class TextForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Office";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "WorkStopBody", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(105, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = global::WorkMonit.Properties.Settings.Default.WorkStopBody;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Work stop body";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "WorkStopHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox4.Location = new System.Drawing.Point(105, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(309, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = global::WorkMonit.Properties.Settings.Default.WorkStopHeader;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work stop subject";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "WorkStartBody", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(105, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = global::WorkMonit.Properties.Settings.Default.WorkStartBody;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Works start body";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "WrokStartHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(105, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = global::WorkMonit.Properties.Settings.Default.WrokStartHeader;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Work start subject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(14, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Home Office";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "HomeWorkStopBody", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox5.Location = new System.Drawing.Point(105, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(309, 20);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = global::WorkMonit.Properties.Settings.Default.HomeWorkStopBody;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Work stop body";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "HomeWorkStopHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox6.Location = new System.Drawing.Point(105, 73);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(309, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = global::WorkMonit.Properties.Settings.Default.HomeWorkStopHeader;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Work stop subject";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "HomeWorkStartBody", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox7.Location = new System.Drawing.Point(105, 47);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(309, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = global::WorkMonit.Properties.Settings.Default.HomeWorkStartBody;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Works start body";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "HomeWorkStartHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox8.Location = new System.Drawing.Point(105, 21);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(309, 20);
            this.textBox8.TabIndex = 9;
            this.textBox8.Text = global::WorkMonit.Properties.Settings.Default.HomeWorkStartHeader;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Work start subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mail header";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WorkMonit.Properties.Settings.Default, "MailHeader", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox9.Location = new System.Drawing.Point(119, 301);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(309, 20);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = global::WorkMonit.Properties.Settings.Default.MailHeader;
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 326);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TextForm";
            this.Text = "Custom text";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox9;
    }
}