using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkMonit.Modules;

namespace WorkMonit
{
    public partial class MainForm : Form
    {
        public MainForm(ThisAddIn mainObj)
        {
            MainObj = mainObj;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainObj.SendeMailItem(PrepareMail.PrepareHOMail(TimeCheck.CheckHomeOfficeTime()), false);
        }

        private ThisAddIn MainObj;

        private void button2_Click(object sender, EventArgs e)
        {
            MainObj.SendeMailItem(PrepareMail.PrepareHOMail(TimeCheck.CheckOfficeTime()), false);
        }
    }
}
