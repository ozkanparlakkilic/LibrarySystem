
namespace Library
{
    partial class SearchPersonel
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
            this.grbYazar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchPersonelEmail = new System.Windows.Forms.TextBox();
            this.cmbSearchPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSearchPersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbSearchPersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSearchPersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtSearchPersonelSurname = new System.Windows.Forms.TextBox();
            this.txtSearchPersonelName = new System.Windows.Forms.TextBox();
            this.dgwSearchPersonel = new System.Windows.Forms.DataGridView();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.label7);
            this.grbYazar.Controls.Add(this.txtSearchPersonelEmail);
            this.grbYazar.Controls.Add(this.cmbSearchPosition);
            this.grbYazar.Controls.Add(this.label6);
            this.grbYazar.Controls.Add(this.rbSearchPersonelWoman);
            this.grbYazar.Controls.Add(this.rbSearchPersonelMan);
            this.grbYazar.Controls.Add(this.label4);
            this.grbYazar.Controls.Add(this.label3);
            this.grbYazar.Controls.Add(this.label2);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.cmbSearchPersonelNationality);
            this.grbYazar.Controls.Add(this.txtSearchPersonelSurname);
            this.grbYazar.Controls.Add(this.txtSearchPersonelName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(244, 308);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(332, 312);
            this.grbYazar.TabIndex = 24;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "SEARCH PERSONEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "EMAIL";
            // 
            // txtSearchPersonelEmail
            // 
            this.txtSearchPersonelEmail.Location = new System.Drawing.Point(171, 137);
            this.txtSearchPersonelEmail.Name = "txtSearchPersonelEmail";
            this.txtSearchPersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelEmail.TabIndex = 22;
            this.txtSearchPersonelEmail.TextChanged += new System.EventHandler(this.txtSearchPersonelEmail_TextChanged);
            // 
            // cmbSearchPosition
            // 
            this.cmbSearchPosition.FormattingEnabled = true;
            this.cmbSearchPosition.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "AUTHORIZED",
            "WORKER"});
            this.cmbSearchPosition.Location = new System.Drawing.Point(171, 257);
            this.cmbSearchPosition.Name = "cmbSearchPosition";
            this.cmbSearchPosition.Size = new System.Drawing.Size(121, 27);
            this.cmbSearchPosition.TabIndex = 15;
            this.cmbSearchPosition.SelectedIndexChanged += new System.EventHandler(this.cmbSearchPosition_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "POSITION";
            // 
            // rbSearchPersonelWoman
            // 
            this.rbSearchPersonelWoman.AutoSize = true;
            this.rbSearchPersonelWoman.Location = new System.Drawing.Point(239, 218);
            this.rbSearchPersonelWoman.Name = "rbSearchPersonelWoman";
            this.rbSearchPersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbSearchPersonelWoman.TabIndex = 10;
            this.rbSearchPersonelWoman.TabStop = true;
            this.rbSearchPersonelWoman.Text = "Woman";
            this.rbSearchPersonelWoman.UseVisualStyleBackColor = true;
            this.rbSearchPersonelWoman.CheckedChanged += new System.EventHandler(this.rbSearchPersonelWoman_CheckedChanged);
            // 
            // rbSearchPersonelMan
            // 
            this.rbSearchPersonelMan.AutoSize = true;
            this.rbSearchPersonelMan.Location = new System.Drawing.Point(171, 218);
            this.rbSearchPersonelMan.Name = "rbSearchPersonelMan";
            this.rbSearchPersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbSearchPersonelMan.TabIndex = 9;
            this.rbSearchPersonelMan.TabStop = true;
            this.rbSearchPersonelMan.Text = "Man";
            this.rbSearchPersonelMan.UseVisualStyleBackColor = true;
            this.rbSearchPersonelMan.CheckedChanged += new System.EventHandler(this.rbSearchPersonelMan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // cmbSearchPersonelNationality
            // 
            this.cmbSearchPersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchPersonelNationality.FormattingEnabled = true;
            this.cmbSearchPersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbSearchPersonelNationality.Location = new System.Drawing.Point(171, 178);
            this.cmbSearchPersonelNationality.Name = "cmbSearchPersonelNationality";
            this.cmbSearchPersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbSearchPersonelNationality.TabIndex = 2;
            this.cmbSearchPersonelNationality.SelectedIndexChanged += new System.EventHandler(this.cmbSearchPersonelNationality_SelectedIndexChanged);
            // 
            // txtSearchPersonelSurname
            // 
            this.txtSearchPersonelSurname.Location = new System.Drawing.Point(171, 97);
            this.txtSearchPersonelSurname.Name = "txtSearchPersonelSurname";
            this.txtSearchPersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelSurname.TabIndex = 1;
            this.txtSearchPersonelSurname.TextChanged += new System.EventHandler(this.txtSearchPersonelSurname_TextChanged);
            // 
            // txtSearchPersonelName
            // 
            this.txtSearchPersonelName.Location = new System.Drawing.Point(171, 57);
            this.txtSearchPersonelName.Name = "txtSearchPersonelName";
            this.txtSearchPersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPersonelName.TabIndex = 0;
            this.txtSearchPersonelName.TextChanged += new System.EventHandler(this.txtSearchPersonelName_TextChanged);
            // 
            // dgwSearchPersonel
            // 
            this.dgwSearchPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearchPersonel.Location = new System.Drawing.Point(154, 115);
            this.dgwSearchPersonel.Name = "dgwSearchPersonel";
            this.dgwSearchPersonel.Size = new System.Drawing.Size(513, 150);
            this.dgwSearchPersonel.TabIndex = 23;
            // 
            // SearchPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.grbYazar);
            this.Controls.Add(this.dgwSearchPersonel);
            this.Name = "SearchPersonel";
            this.Text = "Search Personel";
            this.Load += new System.EventHandler(this.SearchPersonel_Load);
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.ComboBox cmbSearchPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSearchPersonelWoman;
        private System.Windows.Forms.RadioButton rbSearchPersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchPersonelNationality;
        private System.Windows.Forms.TextBox txtSearchPersonelSurname;
        private System.Windows.Forms.DataGridView dgwSearchPersonel;
        private System.Windows.Forms.TextBox txtSearchPersonelName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchPersonelEmail;
    }
}
