using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using WorkMonit.Froms;
using WorkMonit.Modules;
using Office = Microsoft.Office.Core;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new MyRibbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace WorkMonit
{
    [ComVisible(true)]
    public class MyRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public MyRibbon(ThisAddIn mainObj)
        {
            MainObj = mainObj;
        }

        public void OnSettingsButton(Office.IRibbonControl control)
        {
            new SettingsForm().Show();
        }

        public void onTextButton(Office.IRibbonControl control)
        {
            new TextForm().Show();
        }

        public void OnBeginWork(Office.IRibbonControl control)
        {
            var mail = PrepareMail.PrepareWorkMail(1);
            MainObj.SendeMailItem(mail, true);
        }

        public void OnEndWork(Office.IRibbonControl control)
        {
            var mail = PrepareMail.PrepareWorkMail(2);
            MainObj.SendeMailItem(mail, false);
        }

        public void OnBeginHO(Office.IRibbonControl control)
        {
            var mail = PrepareMail.PrepareHOMail(1);
            MainObj.SendeMailItem(mail, true);
        }

        public void OnEndHO(Office.IRibbonControl control)
        {
            var mail = PrepareMail.PrepareHOMail(2);
            MainObj.SendeMailItem(mail, false);
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("WorkMonit.MyRibbon.xml");
        }

        ThisAddIn MainObj
        {
            get;set;
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit http://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
