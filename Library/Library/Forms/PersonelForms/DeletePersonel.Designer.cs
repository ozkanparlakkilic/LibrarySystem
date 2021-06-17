
namespace Library
{
    partial class DeletePersonel
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
            this.txtRemovePersonelEmail = new System.Windows.Forms.TextBox();
            this.dtpDeletePersonel = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRemovePosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptxDeletePersonel = new System.Windows.Forms.PictureBox();
            this.rbRemovePersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbRemovePersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRemovePersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtRemovePersonelSurname = new System.Windows.Forms.TextBox();
            this.txtRemovePersonelName = new System.Windows.Forms.TextBox();
            this.btnRemovePersonel = new System.Windows.Forms.Button();
            this.dgwRemovePersonel = new System.Windows.Forms.DataGridView();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDeletePersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemovePersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.label7);
            this.grbYazar.Controls.Add(this.txtRemovePersonelEmail);
            this.grbYazar.Controls.Add(this.dtpDeletePersonel);
            this.grbYazar.Controls.Add(this.label5);
            this.grbYazar.Controls.Add(this.cmbRemovePosition);
            this.grbYazar.Controls.Add(this.label6);
            this.grbYazar.Controls.Add(this.ptxDeletePersonel);
            this.grbYazar.Controls.Add(this.rbRemovePersonelWoman);
            this.grbYazar.Controls.Add(this.rbRemovePersonelMan);
            this.grbYazar.Controls.Add(this.label4);
            this.grbYazar.Controls.Add(this.label3);
            this.grbYazar.Controls.Add(this.label2);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.cmbRemovePersonelNationality);
            this.grbYazar.Controls.Add(this.txtRemovePersonelSurname);
            this.grbYazar.Controls.Add(this.txtRemovePersonelName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(205, 262);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(431, 373);
            this.grbYazar.TabIndex = 25;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "SEARCH PERSONEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "EMAIL";
            // 
            // txtRemovePersonelEmail
            // 
            this.txtRemovePersonelEmail.Location = new System.Drawing.Point(171, 143);
            this.txtRemovePersonelEmail.Name = "txtRemovePersonelEmail";
            this.txtRemovePersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePersonelEmail.TabIndex = 20;
            this.txtRemovePersonelEmail.TextChanged += new System.EventHandler(this.txtRemovePersonelEmail_TextChanged);
            // 
            // dtpDeletePersonel
            // 
            this.dtpDeletePersonel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeletePersonel.Location = new System.Drawing.Point(172, 181);
            this.dtpDeletePersonel.Name = "dtpDeletePersonel";
            this.dtpDeletePersonel.Size = new System.Drawing.Size(121, 26);
            this.dtpDeletePersonel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "YEAR_OF_BIRTH";
            // 
            // cmbRemovePosition
            // 
            this.cmbRemovePosition.FormattingEnabled = true;
            this.cmbRemovePosition.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "AUTHORIZED",
            "WORKER"});
            this.cmbRemovePosition.Location = new System.Drawing.Point(171, 307);
            this.cmbRemovePosition.Name = "cmbRemovePosition";
            this.cmbRemovePosition.Size = new System.Drawing.Size(121, 27);
            this.cmbRemovePosition.TabIndex = 15;
            this.cmbRemovePosition.SelectedIndexChanged += new System.EventHandler(this.cmbRemovePosition_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "POSITION";
            // 
            // ptxDeletePersonel
            // 
            this.ptxDeletePersonel.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxDeletePersonel.Location = new System.Drawing.Point(316, 25);
            this.ptxDeletePersonel.Name = "ptxDeletePersonel";
            this.ptxDeletePersonel.Size = new System.Drawing.Size(100, 105);
            this.ptxDeletePersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxDeletePersonel.TabIndex = 11;
            this.ptxDeletePersonel.TabStop = false;
            this.ptxDeletePersonel.Click += new System.EventHandler(this.ptxDeletePersonel_Click);
            // 
            // rbRemovePersonelWoman
            // 
            this.rbRemovePersonelWoman.AutoSize = true;
            this.rbRemovePersonelWoman.Location = new System.Drawing.Point(241, 266);
            this.rbRemovePersonelWoman.Name = "rbRemovePersonelWoman";
            this.rbRemovePersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbRemovePersonelWoman.TabIndex = 10;
            this.rbRemovePersonelWoman.TabStop = true;
            this.rbRemovePersonelWoman.Text = "Woman";
            this.rbRemovePersonelWoman.UseVisualStyleBackColor = true;
            this.rbRemovePersonelWoman.CheckedChanged += new System.EventHandler(this.rbRemovePersonelWoman_CheckedChanged);
            // 
            // rbRemovePersonelMan
            // 
            this.rbRemovePersonelMan.AutoSize = true;
            this.rbRemovePersonelMan.Location = new System.Drawing.Point(172, 266);
            this.rbRemovePersonelMan.Name = "rbRemovePersonelMan";
            this.rbRemovePersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbRemovePersonelMan.TabIndex = 9;
            this.rbRemovePersonelMan.TabStop = true;
            this.rbRemovePersonelMan.Text = "Man";
            this.rbRemovePersonelMan.UseVisualStyleBackColor = true;
            this.rbRemovePersonelMan.CheckedChanged += new System.EventHandler(this.rbRemovePersonelMan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "SURNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME";
            // 
            // cmbRemovePersonelNationality
            // 
            this.cmbRemovePersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRemovePersonelNationality.FormattingEnabled = true;
            this.cmbRemovePersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbRemovePersonelNationality.Location = new System.Drawing.Point(172, 228);
            this.cmbRemovePersonelNationality.Name = "cmbRemovePersonelNationality";
            this.cmbRemovePersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbRemovePersonelNationality.TabIndex = 2;
            this.cmbRemovePersonelNationality.SelectedIndexChanged += new System.EventHandler(this.cmbRemovePersonelNationality_SelectedIndexChanged);
            // 
            // txtRemovePersonelSurname
            // 
            this.txtRemovePersonelSurname.Location = new System.Drawing.Point(171, 102);
            this.txtRemovePersonelSurname.Name = "txtRemovePersonelSurname";
            this.txtRemovePersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePersonelSurname.TabIndex = 1;
            this.txtRemovePersonelSurname.TextChanged += new System.EventHandler(this.txtRemovePersonelSurname_TextChanged);
            // 
            // txtRemovePersonelName
            // 
            this.txtRemovePersonelName.Location = new System.Drawing.Point(171, 61);
            this.txtRemovePersonelName.Name = "txtRemovePersonelName";
            this.txtRemovePersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePersonelName.TabIndex = 0;
            this.txtRemovePersonelName.TextChanged += new System.EventHandler(this.txtRemovePersonelName_TextChanged);
            // 
            // btnRemovePersonel
            // 
            this.btnRemovePersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePersonel.Location = new System.Drawing.Point(337, 665);
            this.btnRemovePersonel.Name = "btnRemovePersonel";
            this.btnRemovePersonel.Size = new System.Drawing.Size(166, 46);
            this.btnRemovePersonel.TabIndex = 3;
            this.btnRemovePersonel.Text = "Remove Personel";
            this.btnRemovePersonel.UseVisualStyleBackColor = true;
            this.btnRemovePersonel.Click += new System.EventHandler(this.btnRemovePersonel_Click);
            // 
            // dgwRemovePersonel
            // 
            this.dgwRemovePersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRemovePersonel.Location = new System.Drawing.Point(174, 57);
            this.dgwRemovePersonel.Name = "dgwRemovePersonel";
            this.dgwRemovePersonel.RowTemplate.Height = 30;
            this.dgwRemovePersonel.Size = new System.Drawing.Size(492, 150);
            this.dgwRemovePersonel.TabIndex = 27;
            // 
            // DeletePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwRemovePersonel);
            this.Controls.Add(this.grbYazar);
            this.Controls.Add(this.btnRemovePersonel);
            this.Name = "DeletePersonel";
            this.Text = "Delete Personel";
            this.Load += new System.EventHandler(this.DeletePersonel_Load);
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDeletePersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemovePersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.ComboBox cmbRemovePosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemovePersonel;
        private System.Windows.Forms.PictureBox ptxDeletePersonel;
        private System.Windows.Forms.RadioButton rbRemovePersonelWoman;
        private System.Windows.Forms.RadioButton rbRemovePersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRemovePersonelNationality;
        private System.Windows.Forms.TextBox txtRemovePersonelSurname;
        private System.Windows.Forms.TextBox txtRemovePersonelName;
        private System.Windows.Forms.DateTimePicker dtpDeletePersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemovePersonelEmail;
        private System.Windows.Forms.DataGridView dgwRemovePersonel;
    }
}
