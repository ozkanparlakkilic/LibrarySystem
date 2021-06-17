
namespace Library.Forms
{
    partial class UpdateAuthor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptxUpdateAuthor = new System.Windows.Forms.PictureBox();
            this.dtpUpdateAuthorYearOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rbUpdateAuthorWoman = new System.Windows.Forms.RadioButton();
            this.rbUpdateAuthorMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUpdateNationality = new System.Windows.Forms.ComboBox();
            this.txtUpdateAuthorSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpdateAuthorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgwUpdateAuthor = new System.Windows.Forms.DataGridView();
            this.btmUpdateAuthor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxUpdateAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdateAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptxUpdateAuthor);
            this.groupBox1.Controls.Add(this.dtpUpdateAuthorYearOfBirth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbUpdateAuthorWoman);
            this.groupBox1.Controls.Add(this.rbUpdateAuthorMan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbUpdateNationality);
            this.groupBox1.Controls.Add(this.txtUpdateAuthorSurname);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtUpdateAuthorName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH AUTHOR";
            // 
            // ptxUpdateAuthor
            // 
            this.ptxUpdateAuthor.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxUpdateAuthor.Location = new System.Drawing.Point(488, 18);
            this.ptxUpdateAuthor.Name = "ptxUpdateAuthor";
            this.ptxUpdateAuthor.Size = new System.Drawing.Size(100, 94);
            this.ptxUpdateAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxUpdateAuthor.TabIndex = 23;
            this.ptxUpdateAuthor.TabStop = false;
            this.ptxUpdateAuthor.Click += new System.EventHandler(this.ptxUpdateAuthor_Click);
            // 
            // dtpUpdateAuthorYearOfBirth
            // 
            this.dtpUpdateAuthorYearOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUpdateAuthorYearOfBirth.Location = new System.Drawing.Point(338, 216);
            this.dtpUpdateAuthorYearOfBirth.Name = "dtpUpdateAuthorYearOfBirth";
            this.dtpUpdateAuthorYearOfBirth.Size = new System.Drawing.Size(121, 26);
            this.dtpUpdateAuthorYearOfBirth.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "DATE OF BIRTH :";
            // 
            // rbUpdateAuthorWoman
            // 
            this.rbUpdateAuthorWoman.AutoSize = true;
            this.rbUpdateAuthorWoman.Location = new System.Drawing.Point(407, 179);
            this.rbUpdateAuthorWoman.Name = "rbUpdateAuthorWoman";
            this.rbUpdateAuthorWoman.Size = new System.Drawing.Size(87, 23);
            this.rbUpdateAuthorWoman.TabIndex = 20;
            this.rbUpdateAuthorWoman.TabStop = true;
            this.rbUpdateAuthorWoman.Text = "Woman";
            this.rbUpdateAuthorWoman.UseVisualStyleBackColor = true;
            this.rbUpdateAuthorWoman.CheckedChanged += new System.EventHandler(this.rbUpdateAuthorWoman_CheckedChanged);
            // 
            // rbUpdateAuthorMan
            // 
            this.rbUpdateAuthorMan.AutoSize = true;
            this.rbUpdateAuthorMan.Location = new System.Drawing.Point(338, 179);
            this.rbUpdateAuthorMan.Name = "rbUpdateAuthorMan";
            this.rbUpdateAuthorMan.Size = new System.Drawing.Size(63, 23);
            this.rbUpdateAuthorMan.TabIndex = 19;
            this.rbUpdateAuthorMan.TabStop = true;
            this.rbUpdateAuthorMan.Text = "Man";
            this.rbUpdateAuthorMan.UseVisualStyleBackColor = true;
            this.rbUpdateAuthorMan.CheckedChanged += new System.EventHandler(this.rbUpdateAuthorMan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "GENDER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "NATIONALITY :";
            // 
            // cmbUpdateNationality
            // 
            this.cmbUpdateNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUpdateNationality.FormattingEnabled = true;
            this.cmbUpdateNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbUpdateNationality.Location = new System.Drawing.Point(338, 132);
            this.cmbUpdateNationality.Name = "cmbUpdateNationality";
            this.cmbUpdateNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbUpdateNationality.TabIndex = 14;
            this.cmbUpdateNationality.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateNationality_SelectedIndexChanged);
            // 
            // txtUpdateAuthorSurname
            // 
            this.txtUpdateAuthorSurname.Location = new System.Drawing.Point(338, 86);
            this.txtUpdateAuthorSurname.Name = "txtUpdateAuthorSurname";
            this.txtUpdateAuthorSurname.Size = new System.Drawing.Size(100, 26);
            this.txtUpdateAuthorSurname.TabIndex = 13;
            this.txtUpdateAuthorSurname.TextChanged += new System.EventHandler(this.txtUpdateAuthorSurname_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(45, 89);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = " AUTHOR SURNAME :";
            // 
            // txtUpdateAuthorName
            // 
            this.txtUpdateAuthorName.Location = new System.Drawing.Point(338, 43);
            this.txtUpdateAuthorName.Name = "txtUpdateAuthorName";
            this.txtUpdateAuthorName.Size = new System.Drawing.Size(100, 26);
            this.txtUpdateAuthorName.TabIndex = 9;
            this.txtUpdateAuthorName.TextChanged += new System.EventHandler(this.txtUpdateAuthorName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "AUTHOR NAME :";
            // 
            // dgwUpdateAuthor
            // 
            this.dgwUpdateAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdateAuthor.Location = new System.Drawing.Point(111, 83);
            this.dgwUpdateAuthor.Name = "dgwUpdateAuthor";
            this.dgwUpdateAuthor.Size = new System.Drawing.Size(588, 150);
            this.dgwUpdateAuthor.TabIndex = 6;
            this.dgwUpdateAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdateAuthor_CellClick);
            // 
            // btmUpdateAuthor
            // 
            this.btmUpdateAuthor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmUpdateAuthor.Location = new System.Drawing.Point(325, 628);
            this.btmUpdateAuthor.Name = "btmUpdateAuthor";
            this.btmUpdateAuthor.Size = new System.Drawing.Size(160, 47);
            this.btmUpdateAuthor.TabIndex = 8;
            this.btmUpdateAuthor.Text = "UPDATE";
            this.btmUpdateAuthor.UseVisualStyleBackColor = true;
            this.btmUpdateAuthor.Click += new System.EventHandler(this.btmUpdateAuthor_Click);
            // 
            // UpdateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.btmUpdateAuthor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwUpdateAuthor);
            this.Name = "UpdateAuthor";
            this.Text = "Update Author";
            this.Load += new System.EventHandler(this.UpdateAuthor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxUpdateAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdateAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUpdateAuthorWoman;
        private System.Windows.Forms.RadioButton rbUpdateAuthorMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUpdateNationality;
        private System.Windows.Forms.TextBox txtUpdateAuthorSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUpdateAuthorName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgwUpdateAuthor;
        private System.Windows.Forms.Button btmUpdateAuthor;
        private System.Windows.Forms.DateTimePicker dtpUpdateAuthorYearOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ptxUpdateAuthor;
    }
}
