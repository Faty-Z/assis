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
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using MySql.Data.MySqlClient;

namespace ajoutxt
{
    public partial class Association : Form
    {
        public Association()
        {
            InitializeComponent();
        }

        private void حفظ_Click(object sender, EventArgs e)
        {
            ConratInfosForm a = new ConratInfosForm();

            string asso1 = textasso1.Text;
            string asso2 = textasso2.Text;
            string asso3 = textasso3.Text;
            string asso4 = textasso4.Text;


            a.FindAndReplace("$$assoc1$$" , asso1);
            a.FindAndReplace("$$assoc2$$", asso2);
            a.FindAndReplace("$$assoc3$$", asso3);
            a.FindAndReplace("$$assoc4$$", asso4);

            this.Hide();
           new ConratInfosForm().Show();
        }
    }
}
