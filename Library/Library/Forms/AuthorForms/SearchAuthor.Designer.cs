
namespace Library.Forms
{
    partial class SearchAuthor
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
            this.rbSearchAuthorWoman = new System.Windows.Forms.RadioButton();
            this.rbSearchAuthorMan = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.txtSearchAuthorSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchAuthorId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearchAuthorName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dgwSearchAuthor = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSearchAuthorWoman);
            this.groupBox1.Controls.Add(this.rbSearchAuthorMan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbNationality);
            this.groupBox1.Controls.Add(this.txtSearchAuthorSurname);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSearchAuthorId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSearchAuthorName);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(114, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(588, 281);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEARCH AUTHOR";
            // 
            // rbSearchAuthorWoman
            // 
            this.rbSearchAuthorWoman.AutoSize = true;
            this.rbSearchAuthorWoman.Location = new System.Drawing.Point(417, 224);
            this.rbSearchAuthorWoman.Name = "rbSearchAuthorWoman";
            this.rbSearchAuthorWoman.Size = new System.Drawing.Size(87, 23);
            this.rbSearchAuthorWoman.TabIndex = 20;
            this.rbSearchAuthorWoman.TabStop = true;
            this.rbSearchAuthorWoman.Text = "Woman";
            this.rbSearchAuthorWoman.UseVisualStyleBackColor = true;
            this.rbSearchAuthorWoman.CheckedChanged += new System.EventHandler(this.rbSearchAuthorWoman_CheckedChanged);
            // 
            // rbSearchAuthorMan
            // 
            this.rbSearchAuthorMan.AutoSize = true;
            this.rbSearchAuthorMan.Location = new System.Drawing.Point(348, 224);
            this.rbSearchAuthorMan.Name = "rbSearchAuthorMan";
            this.rbSearchAuthorMan.Size = new System.Drawing.Size(63, 23);
            this.rbSearchAuthorMan.TabIndex = 19;
            this.rbSearchAuthorMan.TabStop = true;
            this.rbSearchAuthorMan.Text = "Man";
            this.rbSearchAuthorMan.UseVisualStyleBackColor = true;
            this.rbSearchAuthorMan.CheckedChanged += new System.EventHandler(this.rbSearchAuthorMan_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "GENDER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "NATIONALITY :";
            // 
            // cmbNationality
            // 
            this.cmbNationality.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNationality.FormattingEnabled = true;
            this.cmbNationality.Items.AddRange(new object[] {
            "TURKEY",
            "FRANCE",
            "UNITED KINGDOM"});
            this.cmbNationality.Location = new System.Drawing.Point(348, 177);
            this.cmbNationality.Name = "cmbNationality";
            this.cmbNationality.Size = new System.Drawing.Size(121, 23);
            this.cmbNationality.TabIndex = 14;
            this.cmbNationality.SelectedIndexChanged += new System.EventHandler(this.cmbNationality_SelectedIndexChanged);
            // 
            // txtSearchAuthorSurname
            // 
            this.txtSearchAuthorSurname.Location = new System.Drawing.Point(348, 131);
            this.txtSearchAuthorSurname.Name = "txtSearchAuthorSurname";
            this.txtSearchAuthorSurname.Size = new System.Drawing.Size(100, 26);
            this.txtSearchAuthorSurname.TabIndex = 13;
            this.txtSearchAuthorSurname.TextChanged += new System.EventHandler(this.txtSearchAuthorSurname_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(55, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = "AUTHOR SURNAME :";
            // 
            // txtSearchAuthorId
            // 
            this.txtSearchAuthorId.Location = new System.Drawing.Point(348, 45);
            this.txtSearchAuthorId.Name = "txtSearchAuthorId";
            this.txtSearchAuthorId.Size = new System.Drawing.Size(100, 26);
            this.txtSearchAuthorId.TabIndex = 11;
            this.txtSearchAuthorId.TextChanged += new System.EventHandler(this.txtSearchAuthorId_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "AUTHOR ID :";
            // 
            // txtSearchAuthorName
            // 
            this.txtSearchAuthorName.Location = new System.Drawing.Point(348, 88);
            this.txtSearchAuthorName.Name = "txtSearchAuthorName";
            this.txtSearchAuthorName.Size = new System.Drawing.Size(100, 26);
            this.txtSearchAuthorName.TabIndex = 9;
            this.txtSearchAuthorName.TextChanged += new System.EventHandler(this.txtSearchAuthorName_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 19);
            this.label14.TabIndex = 8;
            this.label14.Text = "AUTHOR NAME :";
            // 
            // dgwSearchAuthor
            // 
            this.dgwSearchAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearchAuthor.Location = new System.Drawing.Point(114, 128);
            this.dgwSearchAuthor.Name = "dgwSearchAuthor";
            this.dgwSearchAuthor.Size = new System.Drawing.Size(588, 150);
            this.dgwSearchAuthor.TabIndex = 4;
            // 
            // SearchAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwSearchAuthor);
            this.Name = "SearchAuthor";
            this.Text = "Search Author";
            this.Load += new System.EventHandler(this.SearchAuthor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchAuthorSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchAuthorId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearchAuthorName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgwSearchAuthor;
        private System.Windows.Forms.RadioButton rbSearchAuthorWoman;
        private System.Windows.Forms.RadioButton rbSearchAuthorMan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNationality;
    }
}
