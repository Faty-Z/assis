using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Globalization;
using System.Drawing.Drawing2D; // si on veut ajouter une photo"logo"
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using Dapper;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace ajoutxt
{
    public partial class ConratInfosForm : Form
    {
        
        public ConratInfosForm()
        {
            InitializeComponent();

            // Pour ajouter du texte
            var ci = new CultureInfo("ar-AR");

            Thread.CurrentThread.CurrentCulture = ci;

            List<string> partenaires = new List<string>()
            {
                "عمالة مكناس", "عمالة ويسلان"
            };

            chkLstPartners.Items.Add("عمالة مكناس");
            chkLstPartners.Items.Add("عمالة ويسلان");
            chkLstPartners.Items.Add("جماعة المشور الستينية");
            chkLstPartners.Items.Add("جماعة بوفكران");
            chkLstPartners.Items.Add("جماعة تولال ");
            chkLstPartners.Items.Add("جماعة مولاي ادريس زرهون");
            chkLstPartners.Items.Add("جماعة ويسلان");
            chkLstPartners.Items.Add("جماعة عين جمعة");
            chkLstPartners.Items.Add("جماعة عين كرمة-واد الرمان");
            chkLstPartners.Items.Add("جماعة عين عرمة");
            chkLstPartners.Items.Add("جماعة أيت ولال");
            chkLstPartners.Items.Add("جماعة دار أم السلطان");
            chkLstPartners.Items.Add("جماعة الدخيسة");
            chkLstPartners.Items.Add("جماعة مجاط");
            chkLstPartners.Items.Add("جماعة واد الجديدة");
            chkLstPartners.Items.Add("جماعة سيدي سليمان مول الكيفان");
            chkLstPartners.Items.Add("جماعة شرقاوة");
            chkLstPartners.Items.Add("جماعة مغاصيين");
            chkLstPartners.Items.Add("جماعة نزالة بني عمار");
            chkLstPartners.Items.Add("جماعة وليلي");
            chkLstPartners.Items.Add("جماعة  سيدي عبد الله الخياط");
            chkLstPartners.Items.Add("وزارة التربية والتعليم");
            chkLstPartners.Items.Add("وزارة الصحة");
            chkLstPartners.Items.Add("وزارة الخارجية");
            chkLstPartners.Items.Add("وزارة المالية");
            chkLstPartners.Items.Add("وزارة التعليم العالي");
            chkLstPartners.Items.Add("وزارة الداخلية");
            chkLstPartners.Items.Add("وزارة الكهرباء والماء");
            chkLstPartners.Items.Add("وزارة الاشغال العامه");
            chkLstPartners.Items.Add("وزارة الصحة العامة");
            chkLstPartners.Items.Add("وزارة الشئون الاجتماعية");
            chkLstPartners.Items.Add("وزارة الطاقة");
            chkLstPartners.Items.Add("وزارة التجارة العامة");
            chkLstPartners.Items.Add("وزارة الصناعة");
            chkLstPartners.Items.Add("وزارة الدعم والتموين");
            chkLstPartners.Items.Add("وزارة الدعم والتموين");
            chkLstPartners.Items.Add("وزارة الثقافة والآداب");
            chkLstPartners.Items.Add("وزارة الاعلام");
            chkLstPartners.Items.Add("وزارة شئون مجلس الوزراء");
            chkLstPartners.Items.Add("وزارة شئون مجلس النواب والشوري");
            chkLstPartners.Items.Add("وزارة العدل");
            chkLstPartners.Items.Add("وزارة الاوقاف وشئون الحج");
            chkLstPartners.Items.Add("وزارة النفط والغاز");
            chkLstPartners.Items.Add("وزارة الانتخابات والشئون الحزبية");
            chkLstPartners.Items.Add("وزارة البلدية والشئون القروية");

        }

        public void FindAndReplace( object pattern, object replacementText)
        {
            object missing = Missing.Value;
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            int intFound = 0;

            var wdApp = Globals.ThisAddIn.Application;

            var rng = wdApp.ActiveDocument.Content;
            rng.Find.ClearFormatting();
            rng.Find.Forward = true;
            rng.Find.Text = (string)pattern;


           /* rng.Replace(pattern, replacementText, true, true);
            Section sec = rng.Sections[0];
            TextSelection[] finds = rng.FindAllString(pattern, true, true);
            finds[1].GetAsOneRange().Text = replacementText;*/

            rng.Find.Execute(
                pattern, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, replacementText
                );

            while (rng.Find.Found)
            {
                intFound++;
                rng.Find.Execute(
                    pattern, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, replacementText
                   );
            }

            if (intFound == 0)
                Debug.Print("Searched Text \"{0}\" not found !", pattern);
            

           /* wdApp.Selection.Find.ClearFormatting();

            bool isFound = wdApp.Selection.Find.Execute(pattern, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, replacementText);

            

            while (isFound)
            {
                intFound++;
                isFound = wdApp.Selection.Find.Execute(
                          pattern, ref missing, ref missing, ref missing, ref missing,
                          ref missing, ref missing, ref missing, ref missing, replacementText);
            }*/

        }
   
        protected void Txt_premiers_partenaires_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox1 = new ComboBox();
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            MessageBox.Show("Selected Item Text: " + selectedItem.ToString() + "\n" +
                            "Index: " + selectedIndex.ToString());
        }
    

        protected void Txt_intitule_projet_TextChanged(object sender, EventArgs e)
        {
        }

        protected void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        protected void Textobjectif_TextChanged(object sender, EventArgs e)
        {
            string[] lines = textobjectif.Lines;

            for (int i = 0; i < lines.GetUpperBound(0); i++)
            {
                MessageBox.Show(lines[i]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void ConratInfosForm_Load(object sender, EventArgs e)
        {
        }

        protected void Premiers_partenaires_Click(object sender, EventArgs e)
        {

        }

         void LoadData( DBHelper infos)
        {
           
        }

        //ConratInfosForm GetFormData();

        protected void BnApplyData_Click(object sender, EventArgs e)
        {
            string parterns = chkLstPartners.Text;
            string intituleprojet = txt_intitule_projet.Text;
            decimal montantGlobal = num_montant.Value;
            string  obj= textobjectif.Text;

            string selectedItem = (string)chkLstPartners?.Text;

            Debug.Print(selectedItem);

           


            selectedItem = selectedItem.Replace("," , System.Environment.NewLine);

            this.FindAndReplace("$$premiers_partenaires$$", selectedItem);
            this.FindAndReplace("$$intitule_projet$$", intituleprojet);
            this.FindAndReplace("$$montant$$", montantGlobal.ToString());
            this.FindAndReplace("$$objectifs$$", obj);

            // make guid
            string convID = Guid.NewGuid().ToString();


            DBHelper ci = new DBHelper()
            {
                Conv_ID = convID,
                Partners = chkLstPartners.Text,
                //Associations = Associations.textasso1.Text,
                intitule_projet = txt_intitule_projet.Text,
                Montant = num_montant.Value,
                objectifs= textobjectif.Text,
            };


            int result = DBHelper.Insert(ci);

            if (result != 1)
            {
                MessageBox.Show("Enregistrement non réussi !");
                return;
            }

            var wdApp = Globals.ThisAddIn.Application;
            DocumentProperties properties = wdApp.ActiveDocument.BuiltInDocumentProperties;

            properties.Add("code_conv", false, MsoDocProperties.msoPropertyTypeString, convID);
            Properties.Settings.Default.Save();

        }

        protected void Button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "*";
            dlg.DefaultExt = "pdf";
            dlg.ValidateNames = true;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

               Globals.ThisAddIn.Application.ActiveDocument.ExportAsFixedFormat(dlg.FileName, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            }
        }

        protected void CheckedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (Ex_Conv.SelectedText == "الماء والكهرباء")
            {

            }
            else if (Ex_Conv.SelectedText == "التربية و التعليم")
            {

            }
            else if (Ex_Conv.SelectedText == "الصحة")
            {

            }
            else if(Ex_Conv.SelectedText == "الصحة")
            {

            }
            else 
            {
                Globals.ThisAddIn.Open_existingdoc();
                object readOnly = false; //default
                object isVisible = false;
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;
                this.Hide();
                ConratInfosForm aff = new ConratInfosForm();
                aff.Show();
            }
            System.Guid g = System.Guid.NewGuid();


        }

        private void نعم_CheckedChanged(object sender, EventArgs e)
        {
            new Association().Show();
            this.Hide();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Generate_GUID_Click(object sender, EventArgs e)
        {
            string NewGUID = System.Guid.NewGuid().ToString();
            MessageBox.Show(NewGUID);
        }
    }
}
