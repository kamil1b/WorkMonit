using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using WorkMonit.Modules;
using System.Text;
using System.Windows.Forms;

namespace WorkMonit
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            if (!Properties.Settings.Default.SilentMode)
                new MainForm(this).Show();
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new MyRibbon(this);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see http://go.microsoft.com/fwlink/?LinkId=506785
        }

        public void SendeMailItem(MailDetails mail)
        {
            if(Properties.Settings.Default.Email == "")
            {
                MessageBox.Show("Please add supervisior mail");
                return;
            }

            Outlook.MailItem mailItem = (Outlook.MailItem)
                this.Application.CreateItem(Outlook.OlItemType.olMailItem);
            mailItem.Subject = mail.Subject;
            mailItem.To = Properties.Settings.Default.Email;
            //mail.SignatureRTF = System.Text.Encoding.Default.GetString(mailItem.RTFBody);
            mailItem.RTFBody = mail.Body;
            mailItem.Importance = Outlook.OlImportance.olImportanceLow;
            mailItem.Display(false);

            mailItem.Send();
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

        #endregion
    }
}
