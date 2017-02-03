using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using WorkMonit.Modules;
using System.Windows.Forms;
using System;

namespace WorkMonit
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OnWorkBeginTime == DateTime.Today)
            {
                setTimer();
                return;
            }             

            if (Properties.Settings.Default.AutoHomeWork)
                if (DetectEnviroment.isHomeWork())
                {
                    var type = TimeCheck.CheckHomeOfficeTime();
                    var mail = PrepareMail.PrepareHOMail(type);
                    if (mail == null)
                        return;
                    if (SendeMailItem(mail, true) && type == 1)
                    {
                        Properties.Settings.Default.OnTimeSend = DateTime.Now.AddHours(8);
                        Properties.Settings.Default.OnTimeSendType = 1;
                        Properties.Settings.Default.OnWorkBeginTime = DateTime.Today;
                        Properties.Settings.Default.Save();
                        setTimer();
                    }
                    return;
                }

            if (!Properties.Settings.Default.SilentMode)
                new MainForm(this).Show();
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new MyRibbon(this);
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        public bool SendeMailItem(MailDetails mail , bool workBegin)
        {
            if(Properties.Settings.Default.Email == "")
            {
                MessageBox.Show("Please add supervisior mail");
                return false;
            }

            if (Properties.Settings.Default.MailPrompt)
            {

                DialogResult result = MessageBox.Show("Could I send mail with subject " + mail.Subject, "Work Monit", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return false;
            }

            Outlook.MailItem mailItem = (Outlook.MailItem)
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = mail.Subject;
            mailItem.To = Properties.Settings.Default.Email;
            mailItem.RTFBody = mail.Body;
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;

            mailItem.Send();

            if(workBegin)
                Properties.Settings.Default.OnWorkBeginTime = DateTime.Today;

            return true;

        }

        public void setTimer()
        {
            if (Properties.Settings.Default.OnTimeSend < DateTime.Now)
                return;
            timer = new Timer();
            timer.Interval = (int)(Properties.Settings.Default.OnTimeSend - DateTime.Now).TotalMilliseconds;
            timer.Tick += new EventHandler(sendDelayMail);
            timer.Start();
        }

        public void sendDelayMail(object sender, EventArgs args)
        {
            switch(Properties.Settings.Default.OnTimeSendType)
            {
                case 1:
                    SendeMailItem(PrepareMail.PrepareHOMail(2), true);
                    break;
                case 2:
                    SendeMailItem(PrepareMail.PrepareWorkMail(2), true);
                    break;
            }
            timer = null;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        private Timer timer;

        #endregion
    }
}
