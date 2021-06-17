
namespace Library
{
    partial class AddPersonel
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
            this.txtPersonelEmail = new System.Windows.Forms.TextBox();
            this.ptxAddPersonel = new System.Windows.Forms.PictureBox();
            this.dtpAddPersonel = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPersonel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPersonelWoman = new System.Windows.Forms.RadioButton();
            this.rbPersonelMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersonelNationality = new System.Windows.Forms.ComboBox();
            this.txtPersonelSurname = new System.Windows.Forms.TextBox();
            this.txtPersonelName = new System.Windows.Forms.TextBox();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.label7);
            this.grbYazar.Controls.Add(this.txtPersonelEmail);
            this.grbYazar.Controls.Add(this.ptxAddPersonel);
            this.grbYazar.Controls.Add(this.dtpAddPersonel);
            this.grbYazar.Controls.Add(this.cmbPosition);
            this.grbYazar.Controls.Add(this.label6);
            this.grbYazar.Controls.Add(this.btnAddPersonel);
            this.grbYazar.Controls.Add(this.label5);
            this.grbYazar.Controls.Add(this.rbPersonelWoman);
            this.grbYazar.Controls.Add(this.rbPersonelMan);
            this.grbYazar.Controls.Add(this.label4);
            this.grbYazar.Controls.Add(this.label3);
            this.grbYazar.Controls.Add(this.label2);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.cmbPersonelNationality);
            this.grbYazar.Controls.Add(this.txtPersonelSurname);
            this.grbYazar.Controls.Add(this.txtPersonelName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(191, 153);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(455, 438);
            this.grbYazar.TabIndex = 3;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "ADD PERSONEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "EMAIL";
            // 
            // txtPersonelEmail
            // 
            this.txtPersonelEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtPersonelEmail.Location = new System.Drawing.Point(184, 142);
            this.txtPersonelEmail.Name = "txtPersonelEmail";
            this.txtPersonelEmail.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelEmail.TabIndex = 18;
            // 
            // ptxAddPersonel
            // 
            this.ptxAddPersonel.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxAddPersonel.Location = new System.Drawing.Point(335, 33);
            this.ptxAddPersonel.Name = "ptxAddPersonel";
            this.ptxAddPersonel.Size = new System.Drawing.Size(100, 94);
            this.ptxAddPersonel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxAddPersonel.TabIndex = 17;
            this.ptxAddPersonel.TabStop = false;
            this.ptxAddPersonel.Click += new System.EventHandler(this.ptxAddPersonel_Click);
            // 
            // dtpAddPersonel
            // 
            this.dtpAddPersonel.Location = new System.Drawing.Point(186, 181);
            this.dtpAddPersonel.Name = "dtpAddPersonel";
            this.dtpAddPersonel.Size = new System.Drawing.Size(119, 26);
            this.dtpAddPersonel.TabIndex = 16;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Items.AddRange(new object[] {
            "ADMIN",
            "MANAGER",
            "AUTHORIZED",
            "WORKER"});
            this.cmbPosition.Location = new System.Drawing.Point(186, 310);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 27);
            this.cmbPosition.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "POSITION";
            // 
            // btnAddPersonel
            // 
            this.btnAddPersonel.Location = new System.Drawing.Point(162, 370);
            this.btnAddPersonel.Name = "btnAddPersonel";
            this.btnAddPersonel.Size = new System.Drawing.Size(132, 46);
            this.btnAddPersonel.TabIndex = 3;
            this.btnAddPersonel.Text = "Add Personel";
            this.btnAddPersonel.UseVisualStyleBackColor = true;
            this.btnAddPersonel.Click += new System.EventHandler(this.btnAddPersonel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "YEAR_OF_BIRTH";
            // 
            // rbPersonelWoman
            // 
            this.rbPersonelWoman.AutoSize = true;
            this.rbPersonelWoman.Location = new System.Drawing.Point(253, 269);
            this.rbPersonelWoman.Name = "rbPersonelWoman";
            this.rbPersonelWoman.Size = new System.Drawing.Size(87, 23);
            this.rbPersonelWoman.TabIndex = 10;
            this.rbPersonelWoman.TabStop = true;
            this.rbPersonelWoman.Text = "Woman";
            this.rbPersonelWoman.UseVisualStyleBackColor = true;
            // 
            // rbPersonelMan
            // 
            this.rbPersonelMan.AutoSize = true;
            this.rbPersonelMan.Location = new System.Drawing.Point(184, 269);
            this.rbPersonelMan.Name = "rbPersonelMan";
            this.rbPersonelMan.Size = new System.Drawing.Size(63, 23);
            this.rbPersonelMan.TabIndex = 9;
            this.rbPersonelMan.TabStop = true;
            this.rbPersonelMan.Text = "Man";
            this.rbPersonelMan.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 228);
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
            // cmbPersonelNationality
            // 
            this.cmbPersonelNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPersonelNationality.FormattingEnabled = true;
            this.cmbPersonelNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbPersonelNationality.Location = new System.Drawing.Point(186, 229);
            this.cmbPersonelNationality.Name = "cmbPersonelNationality";
            this.cmbPersonelNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbPersonelNationality.TabIndex = 2;
            // 
            // txtPersonelSurname
            // 
            this.txtPersonelSurname.Location = new System.Drawing.Point(184, 100);
            this.txtPersonelSurname.Name = "txtPersonelSurname";
            this.txtPersonelSurname.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelSurname.TabIndex = 1;
            // 
            // txtPersonelName
            // 
            this.txtPersonelName.Location = new System.Drawing.Point(184, 57);
            this.txtPersonelName.Name = "txtPersonelName";
            this.txtPersonelName.Size = new System.Drawing.Size(121, 26);
            this.txtPersonelName.TabIndex = 0;
            // 
            // AddPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.grbYazar);
            this.Name = "AddPersonel";
            this.Text = "Add Personel";
            this.Load += new System.EventHandler(this.AddPersonel_Load);
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddPersonel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPersonelWoman;
        private System.Windows.Forms.RadioButton rbPersonelMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersonelNationality;
        private System.Windows.Forms.TextBox txtPersonelSurname;
        private System.Windows.Forms.TextBox txtPersonelName;
        private System.Windows.Forms.DateTimePicker dtpAddPersonel;
        private System.Windows.Forms.PictureBox ptxAddPersonel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPersonelEmail;
    }
}
