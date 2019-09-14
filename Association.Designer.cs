namespace ajoutxt
{
    partial class Association
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
            this.label1 = new System.Windows.Forms.Label();
            this.textasso1 = new System.Windows.Forms.TextBox();
            this.textasso2 = new System.Windows.Forms.TextBox();
            this.textasso3 = new System.Windows.Forms.TextBox();
            this.textasso4 = new System.Windows.Forms.TextBox();
            this.Association1 = new System.Windows.Forms.Label();
            this.Association2 = new System.Windows.Forms.Label();
            this.Association3 = new System.Windows.Forms.Label();
            this.Association4 = new System.Windows.Forms.Label();
            this.حفظ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(85, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ادخلوا أسماء الجمعيات المشتركة";
            // 
            // textasso1
            // 
            this.textasso1.Location = new System.Drawing.Point(52, 139);
            this.textasso1.Name = "textasso1";
            this.textasso1.Size = new System.Drawing.Size(181, 20);
            this.textasso1.TabIndex = 1;
            // 
            // textasso2
            // 
            this.textasso2.Location = new System.Drawing.Point(52, 190);
            this.textasso2.Name = "textasso2";
            this.textasso2.Size = new System.Drawing.Size(181, 20);
            this.textasso2.TabIndex = 2;
            // 
            // textasso3
            // 
            this.textasso3.Location = new System.Drawing.Point(52, 247);
            this.textasso3.Name = "textasso3";
            this.textasso3.Size = new System.Drawing.Size(181, 20);
            this.textasso3.TabIndex = 3;
            // 
            // textasso4
            // 
            this.textasso4.Location = new System.Drawing.Point(52, 307);
            this.textasso4.Name = "textasso4";
            this.textasso4.Size = new System.Drawing.Size(181, 20);
            this.textasso4.TabIndex = 4;
            // 
            // Association1
            // 
            this.Association1.AutoSize = true;
            this.Association1.Location = new System.Drawing.Point(284, 142);
            this.Association1.Name = "Association1";
            this.Association1.Size = new System.Drawing.Size(115, 13);
            this.Association1.TabIndex = 5;
            this.Association1.Text = "الجمعية المشاركة الأولى";
            // 
            // Association2
            // 
            this.Association2.AutoSize = true;
            this.Association2.Location = new System.Drawing.Point(285, 190);
            this.Association2.Name = "Association2";
            this.Association2.Size = new System.Drawing.Size(114, 13);
            this.Association2.TabIndex = 6;
            this.Association2.Text = "الجمعية المشاركة الثانية";
            // 
            // Association3
            // 
            this.Association3.AutoSize = true;
            this.Association3.Location = new System.Drawing.Point(286, 250);
            this.Association3.Name = "Association3";
            this.Association3.Size = new System.Drawing.Size(113, 13);
            this.Association3.TabIndex = 7;
            this.Association3.Text = "الجمعية المشاركة الثالثة";
            // 
            // Association4
            // 
            this.Association4.AutoSize = true;
            this.Association4.Location = new System.Drawing.Point(283, 310);
            this.Association4.Name = "Association4";
            this.Association4.Size = new System.Drawing.Size(116, 13);
            this.Association4.TabIndex = 8;
            this.Association4.Text = "الجمعية المشاركة الرابعة";
            // 
            // حفظ
            // 
            this.حفظ.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.حفظ.Location = new System.Drawing.Point(157, 368);
            this.حفظ.Name = "حفظ";
            this.حفظ.Size = new System.Drawing.Size(90, 32);
            this.حفظ.TabIndex = 9;
            this.حفظ.Text = "حفظ";
            this.حفظ.UseVisualStyleBackColor = false;
            this.حفظ.Click += new System.EventHandler(this.حفظ_Click);
            // 
            // Association
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 436);
            this.Controls.Add(this.حفظ);
            this.Controls.Add(this.Association4);
            this.Controls.Add(this.Association3);
            this.Controls.Add(this.Association2);
            this.Controls.Add(this.Association1);
            this.Controls.Add(this.textasso4);
            this.Controls.Add(this.textasso3);
            this.Controls.Add(this.textasso2);
            this.Controls.Add(this.textasso1);
            this.Controls.Add(this.label1);
            this.Name = "Association";
            this.ShowIcon = false;
            this.Text = "Association";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textasso1;
        private System.Windows.Forms.TextBox textasso2;
        private System.Windows.Forms.TextBox textasso3;
        private System.Windows.Forms.TextBox textasso4;
        private System.Windows.Forms.Label Association1;
        private System.Windows.Forms.Label Association2;
        private System.Windows.Forms.Label Association3;
        private System.Windows.Forms.Label Association4;
        private System.Windows.Forms.Button حفظ;
    }
}