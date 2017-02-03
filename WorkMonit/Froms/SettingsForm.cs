using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace WorkMonit
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            homeOfficeEnableElements();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            homeOfficeEnableElements();
        }

        private void homeOfficeEnableElements()
        {
            homeOfficeDays.Enabled = false;
            urlRules.Enabled = false;
            if (comboBox1.SelectedItem.ToString() == "Reach url and process run")
            {
                urlRules.Enabled = true;
            }
            if (comboBox1.SelectedItem.ToString() == "Define home office days")
            {
                homeOfficeDays.Enabled = true;
            }
        }

        private void homeOfficeDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringCollection dayList = new StringCollection();
            foreach (var item in homeOfficeDaysCheckedList.CheckedItems)
                dayList.Add(item.ToString());
            Properties.Settings.Default.HomeOfficeDays = dayList;
        }
    }
}
