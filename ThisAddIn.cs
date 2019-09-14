using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Windows.Forms;
//using System.IO.File.WriteAllText;
//using Word=Microsoft.Office.Core.DocumentProperties;



using System.IO;
using System.Diagnostics;
using Microsoft.Office.Core;

namespace ajoutxt
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            this.Application.DocumentOpen += Application_DocumentOpen;
            ((Word.ApplicationEvents4_Event)this.Application).NewDocument += ThisAddIn_NewDocument;

            //Prevent Word from doing the default action associated with a double click or right clik
            this.Application.WindowBeforeDoubleClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(App_WindowBeforeDoubleClick);
            // this.Application.OneClick += new Word.ApplicationEvents4_WindowBeforeDoubleClickEventHandler(App_WindowOneClick);
        }
    

        void App_WindowBeforeDoubleClick(Word.Selection selection , ref bool cancel)
            {
              if(selection.Type == Word.WdSelectionType.wdSelectionNormal)
        {
                selection.Range.Case = Word.WdCharacterCase.wdTitleWord;
                cancel = true;
        }
        }

        public void Open_existingdoc()
        {
            string path = "C:\\Users\\PC\\Desktop\\test\\modele_terrain.docx";

            if (File.Exists(path))
            {
                this.Application.Documents.Open(path);
                Word.Document aDoc = this.Application.Documents.Open(path);
                aDoc.Activate();
            }
            else
            {
                MessageBox.Show("File does not exist");
                Debug.Print("File not found @ {0}", path);
            }
        }
        private void ThisAddIn_NewDocument(Word.Document Doc)
        {
          //  MessageBox.Show(String.Format("NewDocument event on {0}", Doc.Name));
          //  Word.Range range = Doc.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
           // range.Text = String.Format("created on {0} by {1}", System.DateTime.Now, Application.UserName);
        }
        private void Application_DocumentOpen(Word.Document Doc)
        {

            //  MessageBox.Show(String.Format("DocumentOpen event on {0}", Doc.Name));
            //  Word.Range range = Doc.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            // range.Text = String.Format("Lasted on {0} by {1}", System.DateTime.Now, Application.UserName);

        }

        public void WorkWithDocument(Word.Document doc)
        {
            //Globals.ThisAddIn.Application.Language = Office.MsoLanguageID.msoLanguageIDArabic;


            // Using InsertBefore method inserts text   
            doc.Content.InsertBefore("Text @ the          Start - ");
            // Using InsertAfter method inserts text   
            doc.Content.InsertAfter(" - Text @          the End");
        }


        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

          public static void Guidcode()
          {
            // make guid
            System.Guid g = System.Guid.NewGuid();

            // convert to byte array
            byte[] gBytes = g.ToByteArray();

            // convert to int
            int gInt = BitConverter.ToInt32(gBytes, 0);

           /* Guid g;
              // Create and display the value of two GUIDs.
              g = Guid.NewGuid();
              Console.WriteLine(g);
              Console.WriteLine(Guid.NewGuid()); */
          }
        /*
         This code example produces the following results:
          0f8fad5b-d9cb-469f-a165-70867728950e
          7c9e6679-7425-40de-944b-e07fc1f90ae7
        */

        public object BuiltInDocumentProperties { get;  }
        public string ReadDocumentProperty(string propertyCode)
        {
            DocumentProperties properties = Application.ActiveDocument.BuiltInDocumentProperties as DocumentProperties;
            DocumentProperty prop = properties["code_conv"];

            return prop.Value;

        }

         public static void WrietDocumentProperty()
        {
            
        }
    }
}
