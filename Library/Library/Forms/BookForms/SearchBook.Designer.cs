
namespace Library
{
    partial class SearchBook
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
            this.dgwSearchBook = new System.Windows.Forms.DataGridView();
            this.grbKitapEkle = new System.Windows.Forms.GroupBox();
            this.cmbSearchLanguage = new System.Windows.Forms.ComboBox();
            this.txtSearchPublisherId = new System.Windows.Forms.TextBox();
            this.txtSearchAuthorId = new System.Windows.Forms.TextBox();
            this.txtSearchPageNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSearchBookName = new System.Windows.Forms.TextBox();
            this.txtSearchISBN_NO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchBook)).BeginInit();
            this.grbKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSearchBook
            // 
            this.dgwSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearchBook.Location = new System.Drawing.Point(157, 143);
            this.dgwSearchBook.Name = "dgwSearchBook";
            this.dgwSearchBook.Size = new System.Drawing.Size(513, 150);
            this.dgwSearchBook.TabIndex = 21;
            // 
            // grbKitapEkle
            // 
            this.grbKitapEkle.Controls.Add(this.cmbSearchLanguage);
            this.grbKitapEkle.Controls.Add(this.txtSearchPublisherId);
            this.grbKitapEkle.Controls.Add(this.txtSearchAuthorId);
            this.grbKitapEkle.Controls.Add(this.txtSearchPageNumber);
            this.grbKitapEkle.Controls.Add(this.label12);
            this.grbKitapEkle.Controls.Add(this.label18);
            this.grbKitapEkle.Controls.Add(this.label17);
            this.grbKitapEkle.Controls.Add(this.label13);
            this.grbKitapEkle.Controls.Add(this.label14);
            this.grbKitapEkle.Controls.Add(this.label15);
            this.grbKitapEkle.Controls.Add(this.txtSearchBookName);
            this.grbKitapEkle.Controls.Add(this.txtSearchISBN_NO);
            this.grbKitapEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKitapEkle.Location = new System.Drawing.Point(227, 322);
            this.grbKitapEkle.Name = "grbKitapEkle";
            this.grbKitapEkle.Size = new System.Drawing.Size(373, 288);
            this.grbKitapEkle.TabIndex = 20;
            this.grbKitapEkle.TabStop = false;
            this.grbKitapEkle.Text = "SEARCH BOOK";
            // 
            // cmbSearchLanguage
            // 
            this.cmbSearchLanguage.FormattingEnabled = true;
            this.cmbSearchLanguage.Items.AddRange(new object[] {
            "Turkish",
            "French",
            "English"});
            this.cmbSearchLanguage.Location = new System.Drawing.Point(185, 151);
            this.cmbSearchLanguage.Name = "cmbSearchLanguage";
            this.cmbSearchLanguage.Size = new System.Drawing.Size(121, 27);
            this.cmbSearchLanguage.TabIndex = 17;
            this.cmbSearchLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbSearchLANGUAGE_SelectedIndexChanged);
            // 
            // txtSearchPublisherId
            // 
            this.txtSearchPublisherId.Location = new System.Drawing.Point(185, 224);
            this.txtSearchPublisherId.Name = "txtSearchPublisherId";
            this.txtSearchPublisherId.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPublisherId.TabIndex = 16;
            this.txtSearchPublisherId.TextChanged += new System.EventHandler(this.txtSearchPublisherId_TextChanged);
            // 
            // txtSearchAuthorId
            // 
            this.txtSearchAuthorId.Location = new System.Drawing.Point(185, 188);
            this.txtSearchAuthorId.Name = "txtSearchAuthorId";
            this.txtSearchAuthorId.Size = new System.Drawing.Size(121, 26);
            this.txtSearchAuthorId.TabIndex = 15;
            this.txtSearchAuthorId.TextChanged += new System.EventHandler(this.txtSearchAuthorId_TextChanged);
            // 
            // txtSearchPageNumber
            // 
            this.txtSearchPageNumber.Location = new System.Drawing.Point(185, 115);
            this.txtSearchPageNumber.Name = "txtSearchPageNumber";
            this.txtSearchPageNumber.Size = new System.Drawing.Size(121, 26);
            this.txtSearchPageNumber.TabIndex = 14;
            this.txtSearchPageNumber.TextChanged += new System.EventHandler(this.txtSearchPageNumber_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "LANGUAGE";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 231);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 19);
            this.label18.TabIndex = 13;
            this.label18.Text = "PUBLISHER_ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 19);
            this.label17.TabIndex = 10;
            this.label17.Text = "AUTHOR_ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "Page_NUMBER";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "ISBN_NO";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "NAME";
            // 
            // txtSearchBookName
            // 
            this.txtSearchBookName.Location = new System.Drawing.Point(185, 79);
            this.txtSearchBookName.Name = "txtSearchBookName";
            this.txtSearchBookName.Size = new System.Drawing.Size(121, 26);
            this.txtSearchBookName.TabIndex = 1;
            this.txtSearchBookName.TextChanged += new System.EventHandler(this.txtSearchBookName_TextChanged);
            // 
            // txtSearchISBN_NO
            // 
            this.txtSearchISBN_NO.Location = new System.Drawing.Point(185, 43);
            this.txtSearchISBN_NO.Name = "txtSearchISBN_NO";
            this.txtSearchISBN_NO.Size = new System.Drawing.Size(121, 26);
            this.txtSearchISBN_NO.TabIndex = 0;
            this.txtSearchISBN_NO.TextChanged += new System.EventHandler(this.txtSearchISBN_NO_TextChanged);
            // 
            // SearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwSearchBook);
            this.Controls.Add(this.grbKitapEkle);
            this.Name = "SearchBook";
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.SearchBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchBook)).EndInit();
            this.grbKitapEkle.ResumeLayout(false);
            this.grbKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSearchBook;
        private System.Windows.Forms.GroupBox grbKitapEkle;
        private System.Windows.Forms.ComboBox cmbSearchLanguage;
        private System.Windows.Forms.TextBox txtSearchPublisherId;
        private System.Windows.Forms.TextBox txtSearchAuthorId;
        private System.Windows.Forms.TextBox txtSearchPageNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSearchBookName;
        private System.Windows.Forms.TextBox txtSearchISBN_NO;
    }
}
