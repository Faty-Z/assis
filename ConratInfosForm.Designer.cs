namespace ajoutxt
{
    partial class ConratInfosForm
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
            this.premiers_partenaires = new System.Windows.Forms.Label();
            this.intitule_projet = new System.Windows.Forms.Label();
            this.montant = new System.Windows.Forms.Label();
            this.objectifs = new System.Windows.Forms.Label();
            this.num_montant = new System.Windows.Forms.NumericUpDown();
            this.txt_intitule_projet = new System.Windows.Forms.TextBox();
            this.bnApplyData = new System.Windows.Forms.Button();
            this.textobjectif = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chkLstPartners = new CheckComboBoxTest.CheckedComboBox();
            this.Ex_Conv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.نعم = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_montant)).BeginInit();
            this.SuspendLayout();
            // 
            // premiers_partenaires
            // 
            this.premiers_partenaires.AutoSize = true;
            this.premiers_partenaires.Location = new System.Drawing.Point(386, 149);
            this.premiers_partenaires.Name = "premiers_partenaires";
            this.premiers_partenaires.Size = new System.Drawing.Size(84, 13);
            this.premiers_partenaires.TabIndex = 0;
            this.premiers_partenaires.Text = "الأطراف المشاركة";
            this.premiers_partenaires.Click += new System.EventHandler(this.Premiers_partenaires_Click);
            // 
            // intitule_projet
            // 
            this.intitule_projet.AutoSize = true;
            this.intitule_projet.Location = new System.Drawing.Point(405, 261);
            this.intitule_projet.Name = "intitule_projet";
            this.intitule_projet.Size = new System.Drawing.Size(65, 13);
            this.intitule_projet.TabIndex = 2;
            this.intitule_projet.Text = "اسم المشروع";
            // 
            // montant
            // 
            this.montant.AutoSize = true;
            this.montant.Location = new System.Drawing.Point(405, 306);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(63, 13);
            this.montant.TabIndex = 3;
            this.montant.Text = "المبلغ المالي";
            // 
            // objectifs
            // 
            this.objectifs.AutoSize = true;
            this.objectifs.Location = new System.Drawing.Point(425, 347);
            this.objectifs.Name = "objectifs";
            this.objectifs.Size = new System.Drawing.Size(43, 13);
            this.objectifs.TabIndex = 4;
            this.objectifs.Text = "الأهداف ";
            // 
            // num_montant
            // 
            this.num_montant.Location = new System.Drawing.Point(75, 304);
            this.num_montant.Name = "num_montant";
            this.num_montant.Size = new System.Drawing.Size(219, 20);
            this.num_montant.TabIndex = 10;
            this.num_montant.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // txt_intitule_projet
            // 
            this.txt_intitule_projet.Location = new System.Drawing.Point(75, 254);
            this.txt_intitule_projet.Multiline = true;
            this.txt_intitule_projet.Name = "txt_intitule_projet";
            this.txt_intitule_projet.Size = new System.Drawing.Size(219, 20);
            this.txt_intitule_projet.TabIndex = 7;
            this.txt_intitule_projet.TextChanged += new System.EventHandler(this.Txt_intitule_projet_TextChanged);
            // 
            // bnApplyData
            // 
            this.bnApplyData.Location = new System.Drawing.Point(389, 451);
            this.bnApplyData.Name = "bnApplyData";
            this.bnApplyData.Size = new System.Drawing.Size(69, 34);
            this.bnApplyData.TabIndex = 16;
            this.bnApplyData.Text = "حفظ ";
            this.bnApplyData.UseVisualStyleBackColor = true;
            this.bnApplyData.Click += new System.EventHandler(this.BnApplyData_Click);
            // 
            // textobjectif
            // 
            this.textobjectif.Location = new System.Drawing.Point(75, 347);
            this.textobjectif.Multiline = true;
            this.textobjectif.Name = "textobjectif";
            this.textobjectif.Size = new System.Drawing.Size(219, 60);
            this.textobjectif.TabIndex = 17;
            this.textobjectif.TextChanged += new System.EventHandler(this.Textobjectif_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = " تطبيق";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // chkLstPartners
            // 
            this.chkLstPartners.CheckOnClick = true;
            this.chkLstPartners.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.chkLstPartners.DropDownHeight = 1;
            this.chkLstPartners.FormattingEnabled = true;
            this.chkLstPartners.IntegralHeight = false;
            this.chkLstPartners.Location = new System.Drawing.Point(75, 146);
            this.chkLstPartners.Name = "chkLstPartners";
            this.chkLstPartners.Size = new System.Drawing.Size(219, 21);
            this.chkLstPartners.TabIndex = 22;
            this.chkLstPartners.ValueSeparator = ", ";
            this.chkLstPartners.SelectedIndexChanged += new System.EventHandler(this.CheckedComboBox1_SelectedIndexChanged);
            // 
            // Ex_Conv
            // 
            this.Ex_Conv.FormattingEnabled = true;
            this.Ex_Conv.Items.AddRange(new object[] {
            "الماء والكهرباء",
            "التربية و التعليم",
            "الصحة",
            "الطرقات",
            "الشباب و الرياضة"});
            this.Ex_Conv.Location = new System.Drawing.Point(75, 81);
            this.Ex_Conv.Name = "Ex_Conv";
            this.Ex_Conv.Size = new System.Drawing.Size(357, 21);
            this.Ex_Conv.TabIndex = 23;
            this.Ex_Conv.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "اختر نماذج اتفاقيات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "هل توجد جمعيات مشاركة ؟";
            // 
            // نعم
            // 
            this.نعم.AutoSize = true;
            this.نعم.Location = new System.Drawing.Point(222, 202);
            this.نعم.Name = "نعم";
            this.نعم.Size = new System.Drawing.Size(40, 17);
            this.نعم.TabIndex = 26;
            this.نعم.TabStop = true;
            this.نعم.Text = "نعم";
            this.نعم.UseVisualStyleBackColor = true;
            this.نعم.CheckedChanged += new System.EventHandler(this.نعم_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(109, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "لا";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 34);
            this.button2.TabIndex = 28;
            this.button2.Text = "مسح";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 451);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 34);
            this.button3.TabIndex = 29;
            this.button3.Text = "تحديث";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // ConratInfosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(534, 559);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.نعم);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ex_Conv);
            this.Controls.Add(this.chkLstPartners);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textobjectif);
            this.Controls.Add(this.bnApplyData);
            this.Controls.Add(this.num_montant);
            this.Controls.Add(this.txt_intitule_projet);
            this.Controls.Add(this.objectifs);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.intitule_projet);
            this.Controls.Add(this.premiers_partenaires);
            this.Name = "ConratInfosForm";
            this.ShowIcon = false;
            this.Text = "المعلومات المتعلقة بالإتفاقية";
            this.Load += new System.EventHandler(this.ConratInfosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_montant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label premiers_partenaires;
        private System.Windows.Forms.Label intitule_projet;
        private System.Windows.Forms.Label montant;
        private System.Windows.Forms.Label objectifs;
        private System.Windows.Forms.NumericUpDown num_montant;
        private System.Windows.Forms.TextBox txt_intitule_projet;
        private System.Windows.Forms.Button bnApplyData;
        private System.Windows.Forms.TextBox textobjectif;
        private System.Windows.Forms.Button button1;
        private CheckComboBoxTest.CheckedComboBox chkLstPartners;
        private System.Windows.Forms.ComboBox Ex_Conv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton نعم;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}