using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMonit.Modules
{
    class PrepareMail
    {
        public static MailDetails PrepareHOMail(int type)
        {
            var mail = new MailDetails();
            switch(type)
            {
                case 1:
                    mail.Subject = Properties.Settings.Default.HomeWorkStartHeader;
                    mail.Content = Properties.Settings.Default.HomeWorkStartBody;
                    return mail;
                case 2:
                    mail.Subject = Properties.Settings.Default.HomeWorkStopHeader;
                    mail.Content = Properties.Settings.Default.HomeWorkStopBody;
                    return mail;
            }
            return null;
        }

        public static MailDetails PrepareWorkMail(int type)
        {
            var mail = new MailDetails();
            switch (type)
            {
                case 1:
                    mail.Subject = Properties.Settings.Default.WrokStartHeader;
                    mail.Content = Properties.Settings.Default.WorkStartBody;
                    return mail;
                case 2:
                    mail.Subject = Properties.Settings.Default.WorkStopHeader;
                    mail.Content = Properties.Settings.Default.WorkStopBody;
                    return mail;
            }
            return null;
        }
    }
}
