using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ajoutxt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Jjj_Load(object sender, EventArgs e)
        {

        }

        private void CheckBoxmdp_CheckedChanged(object sender, EventArgs e)
        {
             if (checkBoxmdp.Checked)
            {
                textBoxmdp.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxmdp.UseSystemPasswordChar = false;
            }
        }

        private void BtnSeconnecter_Click(object sender, EventArgs e)
        {
            String user, pass;
          user = textBoxAdministrateur.Text;
          pass = textBoxmdp.Text;
          if (user=="FZE" && pass=="F2000")
          {
              MessageBox.Show("مرحبا بكم");
                this.Hide();
                new ConratInfosForm().Show();
            }
          else
          {
              MessageBox.Show(" !المرجو تصحيح معلوماتكم الشخصية ");
          }   
        }

        private void Pictureuser_Click(object sender, EventArgs e)
        {

        }
    }
}
