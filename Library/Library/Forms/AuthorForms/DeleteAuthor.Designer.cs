
namespace Library.Forms
{
    partial class DeleteAuthor
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
            this.ptxDeleteAuthor = new System.Windows.Forms.PictureBox();
            this.rbDeleteAuthorWoman = new System.Windows.Forms.RadioButton();
            this.rbDeleteAuthorMan = new System.Windows.Forms.RadioButton();
            this.dtpDeleteAuthorYearOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDeleteNationality = new System.Windows.Forms.ComboBox();
            this.txtDeleteAuthorSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDeleteAuthorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btmDeleteAuthor = new System.Windows.Forms.Button();
            this.dgwDeleteAuthor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDeleteAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeleteAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ptxDeleteAuthor);
            this.groupBox1.Controls.Add(this.rbDeleteAuthorWoman);
            this.groupBox1.Controls.Add(this.rbDeleteAuthorMan);
            this.groupBox1.Controls.Add(this.dtpDeleteAuthorYearOfBirth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDeleteNationality);
            this.groupBox1.Controls.Add(this.txtDeleteAuthorSurname);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDeleteAuthorName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 306);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH AUTHOR";
            // 
            // ptxDeleteAuthor
            // 
            this.ptxDeleteAuthor.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxDeleteAuthor.Location = new System.Drawing.Point(477, 25);
            this.ptxDeleteAuthor.Name = "ptxDeleteAuthor";
            this.ptxDeleteAuthor.Size = new System.Drawing.Size(100, 94);
            this.ptxDeleteAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxDeleteAuthor.TabIndex = 24;
            this.ptxDeleteAuthor.TabStop = false;
            this.ptxDeleteAuthor.Click += new System.EventHandler(this.ptxDeleteAuthor_Click);
            // 
            // rbDeleteAuthorWoman
            // 
            this.rbDeleteAuthorWoman.AutoSize = true;
            this.rbDeleteAuthorWoman.Location = new System.Drawing.Point(396, 191);
            this.rbDeleteAuthorWoman.Name = "rbDeleteAuthorWoman";
            this.rbDeleteAuthorWoman.Size = new System.Drawing.Size(87, 23);
            this.rbDeleteAuthorWoman.TabIndex = 20;
            this.rbDeleteAuthorWoman.TabStop = true;
            this.rbDeleteAuthorWoman.Text = "Woman";
            this.rbDeleteAuthorWoman.UseVisualStyleBackColor = true;
            this.rbDeleteAuthorWoman.CheckedChanged += new System.EventHandler(this.rbDeleteAuthorWoman_CheckedChanged);
            // 
            // rbDeleteAuthorMan
            // 
            this.rbDeleteAuthorMan.AutoSize = true;
            this.rbDeleteAuthorMan.Location = new System.Drawing.Point(327, 191);
            this.rbDeleteAuthorMan.Name = "rbDeleteAuthorMan";
            this.rbDeleteAuthorMan.Size = new System.Drawing.Size(63, 23);
            this.rbDeleteAuthorMan.TabIndex = 19;
            this.rbDeleteAuthorMan.TabStop = true;
            this.rbDeleteAuthorMan.Text = "Man";
            this.rbDeleteAuthorMan.UseVisualStyleBackColor = true;
            this.rbDeleteAuthorMan.CheckedChanged += new System.EventHandler(this.rbDeleteAuthorMan_CheckedChanged);
            // 
            // dtpDeleteAuthorYearOfBirth
            // 
            this.dtpDeleteAuthorYearOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeleteAuthorYearOfBirth.Location = new System.Drawing.Point(327, 224);
            this.dtpDeleteAuthorYearOfBirth.Name = "dtpDeleteAuthorYearOfBirth";
            this.dtpDeleteAuthorYearOfBirth.Size = new System.Drawing.Size(121, 26);
            this.dtpDeleteAuthorYearOfBirth.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "DATE OF BIRTH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "GENDER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "NATIONALITY :";
            // 
            // cmbDeleteNationality
            // 
            this.cmbDeleteNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeleteNationality.FormattingEnabled = true;
            this.cmbDeleteNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbDeleteNationality.Location = new System.Drawing.Point(327, 144);
            this.cmbDeleteNationality.Name = "cmbDeleteNationality";
            this.cmbDeleteNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbDeleteNationality.TabIndex = 14;
            this.cmbDeleteNationality.SelectedIndexChanged += new System.EventHandler(this.cmbDeleteNationality_SelectedIndexChanged);
            // 
            // txtDeleteAuthorSurname
            // 
            this.txtDeleteAuthorSurname.Location = new System.Drawing.Point(327, 98);
            this.txtDeleteAuthorSurname.Name = "txtDeleteAuthorSurname";
            this.txtDeleteAuthorSurname.Size = new System.Drawing.Size(100, 26);
            this.txtDeleteAuthorSurname.TabIndex = 13;
            this.txtDeleteAuthorSurname.TextChanged += new System.EventHandler(this.txtDeleteAuthorSurname_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = " AUTHOR SURNAME :";
            // 
            // txtDeleteAuthorName
            // 
            this.txtDeleteAuthorName.Location = new System.Drawing.Point(327, 55);
            this.txtDeleteAuthorName.Name = "txtDeleteAuthorName";
            this.txtDeleteAuthorName.Size = new System.Drawing.Size(100, 26);
            this.txtDeleteAuthorName.TabIndex = 9;
            this.txtDeleteAuthorName.TextChanged += new System.EventHandler(this.txtDeleteAuthorName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "AUTHOR NAME :";
            // 
            // btmDeleteAuthor
            // 
            this.btmDeleteAuthor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDeleteAuthor.Location = new System.Drawing.Point(328, 623);
            this.btmDeleteAuthor.Name = "btmDeleteAuthor";
            this.btmDeleteAuthor.Size = new System.Drawing.Size(160, 47);
            this.btmDeleteAuthor.TabIndex = 9;
            this.btmDeleteAuthor.Text = "REMOVE";
            this.btmDeleteAuthor.UseVisualStyleBackColor = true;
            this.btmDeleteAuthor.Click += new System.EventHandler(this.btmDeleteAuthor_Click);
            // 
            // dgwDeleteAuthor
            // 
            this.dgwDeleteAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeleteAuthor.Location = new System.Drawing.Point(107, 55);
            this.dgwDeleteAuthor.Name = "dgwDeleteAuthor";
            this.dgwDeleteAuthor.RowTemplate.Height = 30;
            this.dgwDeleteAuthor.Size = new System.Drawing.Size(602, 150);
            this.dgwDeleteAuthor.TabIndex = 10;
            // 
            // DeleteAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwDeleteAuthor);
            this.Controls.Add(this.btmDeleteAuthor);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeleteAuthor";
            this.Text = "Delete Author";
            this.Load += new System.EventHandler(this.DeleteAuthor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxDeleteAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeleteAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDeleteAuthorWoman;
        private System.Windows.Forms.RadioButton rbDeleteAuthorMan;
        private System.Windows.Forms.DateTimePicker dtpDeleteAuthorYearOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDeleteNationality;
        private System.Windows.Forms.TextBox txtDeleteAuthorSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btmDeleteAuthor;
        private System.Windows.Forms.TextBox txtDeleteAuthorName;
        private System.Windows.Forms.PictureBox ptxDeleteAuthor;
        private System.Windows.Forms.DataGridView dgwDeleteAuthor;
    }
}
