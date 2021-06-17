
namespace Library
{
    partial class UpdatePersonel
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
            this.dgwUpdatePersonel = new System.Windows.Forms.DataGridView();
            this.grbYazar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePersonelEmail = new System.Windows.Forms.TextBox();
            this.dtpUpdatePersonel = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUpdatePosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ptxUpdatePersonel = new System.Windows.Forms.PictureBox();
            this.rbUpdatePersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbUpdatePersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUpdatePersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtUpdatePersonelSurname = new System.Windows.Forms.TextBox();
            this.txtUpdatePersonelName = new System.Windows.Forms.TextBox();
            this.btnUpdatePersonel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePersonel)).BeginInit();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxUpdatePersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUpdatePersonel
            // 
            this.dgwUpdatePersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdatePersonel.Location = new System.Drawing.Point(165, 69);
            this.dgwUpdatePersonel.Name = "dgwUpdatePersonel";
            this.dgwUpdatePersonel.Size = new System.Drawing.Size(513, 150);
            this.dgwUpdatePersonel.TabIndex = 26;
            this.dgwUpdatePersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdatePersonel_CellClick);
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.label7);
            this.grbYazar.Controls.Add(this.txtUpdatePersonelEmail);
            this.grbYazar.Controls.Add(this.dtpUpdatePersonel);
            this.grbYazar.Controls.Add(this.label5);
            this.grbYazar.Controls.Add(this.cmbUpdatePosition);
            this.grbYazar.Controls.Add(this.label6);
            this.grbYazar.Controls.Add(this.ptxUpdatePersonel);
            this.grbYazar.Controls.Add(this.rbUpdatePersonelWoman);
            this.grbYazar.Controls.Add(this.rbUpdatePersonelMan);
            this.grbYazar.Controls.Add(this.label4);
            this.grbYazar.Controls.Add(this.label3);
            this.grbYazar.Controls.Add(this.label2);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.cmbUpdatePersonelNationality);
            this.grbYazar.Controls.Add(this.txtUpdatePersonelSurname);
            this.grbYazar.Controls.Add(this.txtUpdatePersonelName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(206, 239);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(431, 372);
            this.grbYazar.TabIndex = 25;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "SEARCH PERSONEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "EMAIL";
            // 
            // txtUpdatePersonelEmail
            // 
            this.txtUpdatePersonelEmail.Location = new System.Drawing.Point(180, 143);
            this.txtUpdatePersonelEmail.Name = "txtUpdatePersonelEmail";
            this.txtUpdatePersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelEmail.TabIndex = 22;
            this.txtUpdatePersonelEmail.TextChanged += new System.EventHandler(this.txtUpdatePersonelEmail_TextChanged);
            // 
            // dtpUpdatePersonel
            // 
            this.dtpUpdatePersonel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdatePersonel.Location = new System.Drawing.Point(178, 188);
            this.dtpUpdatePersonel.Name = "dtpUpdatePersonel";
            this.dtpUpdatePersonel.Size = new System.Drawing.Size(119, 26);
            this.dtpUpdatePersonel.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "YEAR_OF_BIRTH";
            // 
            // cmbUpdatePosition
            // 
            this.cmbUpdatePosition.FormattingEnabled = true;
            this.cmbUpdatePosition.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "AUTHORIZED",
            "WORKER"});
            this.cmbUpdatePosition.Location = new System.Drawing.Point(178, 311);
            this.cmbUpdatePosition.Name = "cmbUpdatePosition";
            this.cmbUpdatePosition.Size = new System.Drawing.Size(121, 27);
            this.cmbUpdatePosition.TabIndex = 15;
            this.cmbUpdatePosition.SelectedIndexChanged += new System.EventHandler(this.cmbUpdatePosition_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "POSITION";
            // 
            // ptxUpdatePersonel
            // 
            this.ptxUpdatePersonel.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxUpdatePersonel.Location = new System.Drawing.Point(325, 25);
            this.ptxUpdatePersonel.Name = "ptxUpdatePersonel";
            this.ptxUpdatePersonel.Size = new System.Drawing.Size(100, 105);
            this.ptxUpdatePersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxUpdatePersonel.TabIndex = 11;
            this.ptxUpdatePersonel.TabStop = false;
            this.ptxUpdatePersonel.Click += new System.EventHandler(this.ptxUpdatePersonel_Click);
            // 
            // rbUpdatePersonelWoman
            // 
            this.rbUpdatePersonelWoman.AutoSize = true;
            this.rbUpdatePersonelWoman.Location = new System.Drawing.Point(247, 275);
            this.rbUpdatePersonelWoman.Name = "rbUpdatePersonelWoman";
            this.rbUpdatePersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbUpdatePersonelWoman.TabIndex = 10;
            this.rbUpdatePersonelWoman.TabStop = true;
            this.rbUpdatePersonelWoman.Text = "Woman";
            this.rbUpdatePersonelWoman.UseVisualStyleBackColor = true;
            this.rbUpdatePersonelWoman.CheckedChanged += new System.EventHandler(this.rbUpdatePersonelWoman_CheckedChanged);
            // 
            // rbUpdatePersonelMan
            // 
            this.rbUpdatePersonelMan.AutoSize = true;
            this.rbUpdatePersonelMan.Location = new System.Drawing.Point(178, 275);
            this.rbUpdatePersonelMan.Name = "rbUpdatePersonelMan";
            this.rbUpdatePersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbUpdatePersonelMan.TabIndex = 9;
            this.rbUpdatePersonelMan.TabStop = true;
            this.rbUpdatePersonelMan.Text = "Man";
            this.rbUpdatePersonelMan.UseVisualStyleBackColor = true;
            this.rbUpdatePersonelMan.CheckedChanged += new System.EventHandler(this.rbUpdatePersonelMan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
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
            // cmbUpdatePersonelNationality
            // 
            this.cmbUpdatePersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdatePersonelNationality.FormattingEnabled = true;
            this.cmbUpdatePersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbUpdatePersonelNationality.Location = new System.Drawing.Point(178, 230);
            this.cmbUpdatePersonelNationality.Name = "cmbUpdatePersonelNationality";
            this.cmbUpdatePersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbUpdatePersonelNationality.TabIndex = 2;
            this.cmbUpdatePersonelNationality.SelectedIndexChanged += new System.EventHandler(this.cmbUpdatePersonelNationality_SelectedIndexChanged);
            // 
            // txtUpdatePersonelSurname
            // 
            this.txtUpdatePersonelSurname.Location = new System.Drawing.Point(180, 100);
            this.txtUpdatePersonelSurname.Name = "txtUpdatePersonelSurname";
            this.txtUpdatePersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelSurname.TabIndex = 1;
            this.txtUpdatePersonelSurname.TextChanged += new System.EventHandler(this.txtUpdatePersonelSurname_TextChanged);
            // 
            // txtUpdatePersonelName
            // 
            this.txtUpdatePersonelName.Location = new System.Drawing.Point(180, 57);
            this.txtUpdatePersonelName.Name = "txtUpdatePersonelName";
            this.txtUpdatePersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePersonelName.TabIndex = 0;
            this.txtUpdatePersonelName.TextChanged += new System.EventHandler(this.txtUpdatePersonelName_TextChanged);
            // 
            // btnUpdatePersonel
            // 
            this.btnUpdatePersonel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePersonel.Location = new System.Drawing.Point(338, 636);
            this.btnUpdatePersonel.Name = "btnUpdatePersonel";
            this.btnUpdatePersonel.Size = new System.Drawing.Size(166, 46);
            this.btnUpdatePersonel.TabIndex = 3;
            this.btnUpdatePersonel.Text = "Update Personel";
            this.btnUpdatePersonel.UseVisualStyleBackColor = true;
            this.btnUpdatePersonel.Click += new System.EventHandler(this.btnUpdatePersonel_Click);
            // 
            // UpdatePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwUpdatePersonel);
            this.Controls.Add(this.grbYazar);
            this.Controls.Add(this.btnUpdatePersonel);
            this.Name = "UpdatePersonel";
            this.Text = "Update Personel";
            this.Load += new System.EventHandler(this.UpdatePersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePersonel)).EndInit();
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxUpdatePersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUpdatePersonel;
        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.ComboBox cmbUpdatePosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdatePersonel;
        private System.Windows.Forms.PictureBox ptxUpdatePersonel;
        private System.Windows.Forms.RadioButton rbUpdatePersonelWoman;
        private System.Windows.Forms.RadioButton rbUpdatePersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUpdatePersonelNationality;
        private System.Windows.Forms.TextBox txtUpdatePersonelSurname;
        private System.Windows.Forms.TextBox txtUpdatePersonelName;
        private System.Windows.Forms.DateTimePicker dtpUpdatePersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdatePersonelEmail;
    }
}
