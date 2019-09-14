namespace ajoutxt
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomAdministrateur = new System.Windows.Forms.Label();
            this.mdp = new System.Windows.Forms.Label();
            this.textBoxAdministrateur = new System.Windows.Forms.TextBox();
            this.textBoxmdp = new System.Windows.Forms.TextBox();
            this.btnSeconnecter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.checkBoxmdp = new System.Windows.Forms.CheckBox();
            this.picturemdp = new System.Windows.Forms.PictureBox();
            this.pictureuser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturemdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureuser)).BeginInit();
            this.SuspendLayout();
            // 
            // nomAdministrateur
            // 
            this.nomAdministrateur.AutoSize = true;
            this.nomAdministrateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAdministrateur.Location = new System.Drawing.Point(208, 48);
            this.nomAdministrateur.Name = "nomAdministrateur";
            this.nomAdministrateur.Size = new System.Drawing.Size(86, 20);
            this.nomAdministrateur.TabIndex = 0;
            this.nomAdministrateur.Text = "اسم المستخدم";
            // 
            // mdp
            // 
            this.mdp.AutoSize = true;
            this.mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp.Location = new System.Drawing.Point(227, 106);
            this.mdp.Name = "mdp";
            this.mdp.Size = new System.Drawing.Size(67, 20);
            this.mdp.TabIndex = 1;
            this.mdp.Text = "كلمة السر";
            // 
            // textBoxAdministrateur
            // 
            this.textBoxAdministrateur.Location = new System.Drawing.Point(35, 48);
            this.textBoxAdministrateur.Name = "textBoxAdministrateur";
            this.textBoxAdministrateur.Size = new System.Drawing.Size(164, 20);
            this.textBoxAdministrateur.TabIndex = 2;
            // 
            // textBoxmdp
            // 
            this.textBoxmdp.Location = new System.Drawing.Point(35, 106);
            this.textBoxmdp.Name = "textBoxmdp";
            this.textBoxmdp.Size = new System.Drawing.Size(164, 20);
            this.textBoxmdp.TabIndex = 3;
            // 
            // btnSeconnecter
            // 
            this.btnSeconnecter.BackColor = System.Drawing.Color.Silver;
            this.btnSeconnecter.Location = new System.Drawing.Point(186, 195);
            this.btnSeconnecter.Name = "btnSeconnecter";
            this.btnSeconnecter.Size = new System.Drawing.Size(75, 34);
            this.btnSeconnecter.TabIndex = 4;
            this.btnSeconnecter.Text = "اتصال";
            this.btnSeconnecter.UseVisualStyleBackColor = false;
            this.btnSeconnecter.Click += new System.EventHandler(this.BtnSeconnecter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.Silver;
            this.btnQuitter.Location = new System.Drawing.Point(93, 195);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 34);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "الخروج";
            this.btnQuitter.UseVisualStyleBackColor = false;
            // 
            // checkBoxmdp
            // 
            this.checkBoxmdp.AutoSize = true;
            this.checkBoxmdp.Location = new System.Drawing.Point(66, 132);
            this.checkBoxmdp.Name = "checkBoxmdp";
            this.checkBoxmdp.Size = new System.Drawing.Size(102, 17);
            this.checkBoxmdp.TabIndex = 6;
            this.checkBoxmdp.Text = "عرض كلمة المرور";
            this.checkBoxmdp.UseVisualStyleBackColor = true;
            this.checkBoxmdp.CheckedChanged += new System.EventHandler(this.CheckBoxmdp_CheckedChanged);
            // 
            // picturemdp
            // 
            this.picturemdp.ErrorImage = global::ajoutxt.Properties.Resources.user;
            this.picturemdp.Image = global::ajoutxt.Properties.Resources.mdp;
            this.picturemdp.InitialImage = global::ajoutxt.Properties.Resources.user;
            this.picturemdp.Location = new System.Drawing.Point(319, 106);
            this.picturemdp.Name = "picturemdp";
            this.picturemdp.Size = new System.Drawing.Size(32, 35);
            this.picturemdp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturemdp.TabIndex = 9;
            this.picturemdp.TabStop = false;
            // 
            // pictureuser
            // 
            this.pictureuser.ErrorImage = global::ajoutxt.Properties.Resources.user;
            this.pictureuser.Image = global::ajoutxt.Properties.Resources.user;
            this.pictureuser.InitialImage = global::ajoutxt.Properties.Resources.user;
            this.pictureuser.Location = new System.Drawing.Point(319, 33);
            this.pictureuser.Name = "pictureuser";
            this.pictureuser.Size = new System.Drawing.Size(32, 35);
            this.pictureuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureuser.TabIndex = 7;
            this.pictureuser.TabStop = false;
            this.pictureuser.Click += new System.EventHandler(this.Pictureuser_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 265);
            this.Controls.Add(this.picturemdp);
            this.Controls.Add(this.pictureuser);
            this.Controls.Add(this.checkBoxmdp);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSeconnecter);
            this.Controls.Add(this.textBoxmdp);
            this.Controls.Add(this.textBoxAdministrateur);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.nomAdministrateur);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Jjj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picturemdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomAdministrateur;
        private System.Windows.Forms.Label mdp;
        private System.Windows.Forms.TextBox textBoxAdministrateur;
        private System.Windows.Forms.TextBox textBoxmdp;
        private System.Windows.Forms.Button btnSeconnecter;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.CheckBox checkBoxmdp;
        private System.Windows.Forms.PictureBox pictureuser;
        private System.Windows.Forms.PictureBox picturemdp;
    }
}