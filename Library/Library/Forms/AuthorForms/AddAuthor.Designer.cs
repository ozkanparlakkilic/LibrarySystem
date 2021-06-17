
namespace Library.Forms
{
    partial class AddAuthor
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
            this.ptxAddAuthor = new System.Windows.Forms.PictureBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.dtpYearOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.txtYazarSurname = new System.Windows.Forms.TextBox();
            this.txtYazarName = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // grbYazar
            // 
            this.grbYazar.Controls.Add(this.ptxAddAuthor);
            this.grbYazar.Controls.Add(this.rbWoman);
            this.grbYazar.Controls.Add(this.rbMan);
            this.grbYazar.Controls.Add(this.dtpYearOfBirth);
            this.grbYazar.Controls.Add(this.label5);
            this.grbYazar.Controls.Add(this.label4);
            this.grbYazar.Controls.Add(this.label3);
            this.grbYazar.Controls.Add(this.label2);
            this.grbYazar.Controls.Add(this.label1);
            this.grbYazar.Controls.Add(this.cmbNationality);
            this.grbYazar.Controls.Add(this.txtYazarSurname);
            this.grbYazar.Controls.Add(this.txtYazarName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(193, 203);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(425, 300);
            this.grbYazar.TabIndex = 3;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "ADD AUTHOR";
            // 
            // ptxAddAuthor
            // 
            this.ptxAddAuthor.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxAddAuthor.Location = new System.Drawing.Point(319, 25);
            this.ptxAddAuthor.Name = "ptxAddAuthor";
            this.ptxAddAuthor.Size = new System.Drawing.Size(100, 105);
            this.ptxAddAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxAddAuthor.TabIndex = 11;
            this.ptxAddAuthor.TabStop = false;
            this.ptxAddAuthor.Click += new System.EventHandler(this.ptxAddAuthor_Click);
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(240, 187);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(87, 23);
            this.rbWoman.TabIndex = 10;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Woman";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(171, 187);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(63, 23);
            this.rbMan.TabIndex = 9;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // dtpYearOfBirth
            // 
            this.dtpYearOfBirth.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpYearOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYearOfBirth.Location = new System.Drawing.Point(171, 226);
            this.dtpYearOfBirth.Name = "dtpYearOfBirth";
            this.dtpYearOfBirth.Size = new System.Drawing.Size(121, 26);
            this.dtpYearOfBirth.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "DATE OF BIRTH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "GENDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NATIONALITY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 103);
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
            // cmbNationality
            // 
            this.cmbNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbNationality.Location = new System.Drawing.Point(171, 143);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbNationality.TabIndex = 2;
            // 
            // txtYazarSurname
            // 
            this.txtYazarSurname.Location = new System.Drawing.Point(171, 100);
            this.txtYazarSurname.Name = "txtYazarSurname";
            this.txtYazarSurname.Size = new System.Drawing.Size(121, 26);
            this.txtYazarSurname.TabIndex = 1;
            // 
            // txtYazarName
            // 
            this.txtYazarName.Location = new System.Drawing.Point(171, 57);
            this.txtYazarName.Name = "txtYazarName";
            this.txtYazarName.Size = new System.Drawing.Size(121, 26);
            this.txtYazarName.TabIndex = 0;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(338, 534);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(135, 53);
            this.btnAddAuthor.TabIndex = 4;
            this.btnAddAuthor.Text = "ADD AUTHOR";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // AddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.grbYazar);
            this.Controls.Add(this.btnAddAuthor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AddAuthor";
            this.Text = "Add Author";
            this.Load += new System.EventHandler(this.AddAuthor_Load);
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.PictureBox ptxAddAuthor;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.DateTimePicker dtpYearOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.TextBox txtYazarSurname;
        private System.Windows.Forms.TextBox txtYazarName;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}
