﻿using System;
using System.IO;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace WorkMonit.Modules
{
    public class MailDetails
    {
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
                        return "";
                    case "Default":
                        return readRTFSignature();
                }
                return "";
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
            rtf.LoadFile(path);
            return rtf.Rtf;
        }

    }
}