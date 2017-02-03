using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WorkMonit.Modules
{
    public class MailDetails
    {
        public MailDetails()
        {
            sendDate = null;
        }

        public string Subject
        {
            set;get;
        }

        public string Content { set; get; }

        public string Header
        {
            get { return Properties.Settings.Default.MailHeader + "\n\r"; }
        }

        private static string FormatAsRTF(string DirtyText)
        {
            System.Windows.Forms.RichTextBox rtf = new System.Windows.Forms.RichTextBox();
            rtf.Text = DirtyText;
            return rtf.Rtf;
        }

        private static string addRTFString(string text1, string text2)
        {
            System.Windows.Forms.RichTextBox rtf = new System.Windows.Forms.RichTextBox();
            rtf.Rtf = text1;
            rtf.Select(rtf.TextLength, 0);
            rtf.SelectedRtf = text2;
            return rtf.Rtf;
        }

        public byte[] Body{
            get
            {
                return Encoding.ASCII.GetBytes(addRTFString(FormatAsRTF(Header + Content + "\n\r"), SignatureRTF));
            }
        }

        public string SignatureRTF
        {
            get
            {                
                switch (Properties.Settings.Default.Signature)
                {
                    case "None":
                    case "":
                        return "";
                    case "Default":
                        return readRTFSignature();
                }
                return Properties.Settings.Default.Signature;
            }
        }

        static private string readRTFSignature(string signatureName = null)
        {
            if (signatureName == null)
            {
                Word.Application oWord = new Word.Application();
                Word.EmailOptions oOptions = oWord.EmailOptions;
                signatureName = oOptions.EmailSignature.NewMessageSignature;
            }

            System.Windows.Forms.RichTextBox rtf = new System.Windows.Forms.RichTextBox();
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
                "Microsoft\\Signatures\\" + signatureName + ".rtf");
            try {
                rtf.LoadFile(path);
            }
            catch
            {
                MessageBox.Show("Can't read signature.");
            }
            
            return rtf.Rtf;
        }

        public DateTime? SendDate { get { return sendDate; } set { sendDate = value; } }

        private DateTime? sendDate;

    }
}
