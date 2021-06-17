
namespace Library
{
    partial class DeleteBook
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
            this.dgwRemoveBook = new System.Windows.Forms.DataGridView();
            this.grbKitapEkle = new System.Windows.Forms.GroupBox();
            this.btnRemoveBook = new System.Windows.Forms.Button();
            this.cmbRemoveLanguage = new System.Windows.Forms.ComboBox();
            this.txtRemovePublisherId = new System.Windows.Forms.TextBox();
            this.txtRemoveAuthorId = new System.Windows.Forms.TextBox();
            this.txtRemovePageNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRemoveBookName = new System.Windows.Forms.TextBox();
            this.txtRemoveISBN_NO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemoveBook)).BeginInit();
            this.grbKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRemoveBook
            // 
            this.dgwRemoveBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRemoveBook.Location = new System.Drawing.Point(162, 112);
            this.dgwRemoveBook.Name = "dgwRemoveBook";
            this.dgwRemoveBook.Size = new System.Drawing.Size(513, 150);
            this.dgwRemoveBook.TabIndex = 23;
            this.dgwRemoveBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwRemoveBook_CellClick);
            // 
            // grbKitapEkle
            // 
            this.grbKitapEkle.Controls.Add(this.btnRemoveBook);
            this.grbKitapEkle.Controls.Add(this.cmbRemoveLanguage);
            this.grbKitapEkle.Controls.Add(this.txtRemovePublisherId);
            this.grbKitapEkle.Controls.Add(this.txtRemoveAuthorId);
            this.grbKitapEkle.Controls.Add(this.txtRemovePageNumber);
            this.grbKitapEkle.Controls.Add(this.label12);
            this.grbKitapEkle.Controls.Add(this.label18);
            this.grbKitapEkle.Controls.Add(this.label17);
            this.grbKitapEkle.Controls.Add(this.label13);
            this.grbKitapEkle.Controls.Add(this.label14);
            this.grbKitapEkle.Controls.Add(this.label15);
            this.grbKitapEkle.Controls.Add(this.txtRemoveBookName);
            this.grbKitapEkle.Controls.Add(this.txtRemoveISBN_NO);
            this.grbKitapEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKitapEkle.Location = new System.Drawing.Point(232, 305);
            this.grbKitapEkle.Name = "grbKitapEkle";
            this.grbKitapEkle.Size = new System.Drawing.Size(373, 363);
            this.grbKitapEkle.TabIndex = 22;
            this.grbKitapEkle.TabStop = false;
            this.grbKitapEkle.Text = "SEARCH BOOK";
            // 
            // btnRemoveBook
            // 
            this.btnRemoveBook.Location = new System.Drawing.Point(108, 287);
            this.btnRemoveBook.Name = "btnRemoveBook";
            this.btnRemoveBook.Size = new System.Drawing.Size(125, 46);
            this.btnRemoveBook.TabIndex = 18;
            this.btnRemoveBook.Text = "REMOVE";
            this.btnRemoveBook.UseVisualStyleBackColor = true;
            this.btnRemoveBook.Click += new System.EventHandler(this.btnRemoveBook_Click);
            // 
            // cmbRemoveLanguage
            // 
            this.cmbRemoveLanguage.FormattingEnabled = true;
            this.cmbRemoveLanguage.Items.AddRange(new object[] {
            "Turkish",
            "French",
            "English"});
            this.cmbRemoveLanguage.Location = new System.Drawing.Point(185, 151);
            this.cmbRemoveLanguage.Name = "cmbRemoveLanguage";
            this.cmbRemoveLanguage.Size = new System.Drawing.Size(121, 27);
            this.cmbRemoveLanguage.TabIndex = 17;
            this.cmbRemoveLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbRemoveLANGUAGE_SelectedIndexChanged);
            // 
            // txtRemovePublisherId
            // 
            this.txtRemovePublisherId.Location = new System.Drawing.Point(185, 224);
            this.txtRemovePublisherId.Name = "txtRemovePublisherId";
            this.txtRemovePublisherId.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePublisherId.TabIndex = 16;
            this.txtRemovePublisherId.TextChanged += new System.EventHandler(this.txtRemovePublisherId_TextChanged);
            // 
            // txtRemoveAuthorId
            // 
            this.txtRemoveAuthorId.Location = new System.Drawing.Point(185, 188);
            this.txtRemoveAuthorId.Name = "txtRemoveAuthorId";
            this.txtRemoveAuthorId.Size = new System.Drawing.Size(121, 26);
            this.txtRemoveAuthorId.TabIndex = 15;
            this.txtRemoveAuthorId.TextChanged += new System.EventHandler(this.txtRemoveAuthorId_TextChanged);
            // 
            // txtRemovePageNumber
            // 
            this.txtRemovePageNumber.Location = new System.Drawing.Point(185, 115);
            this.txtRemovePageNumber.Name = "txtRemovePageNumber";
            this.txtRemovePageNumber.Size = new System.Drawing.Size(121, 26);
            this.txtRemovePageNumber.TabIndex = 14;
            this.txtRemovePageNumber.TextChanged += new System.EventHandler(this.txtRemovePageNumber_TextChanged);
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
            // txtRemoveBookName
            // 
            this.txtRemoveBookName.Location = new System.Drawing.Point(185, 79);
            this.txtRemoveBookName.Name = "txtRemoveBookName";
            this.txtRemoveBookName.Size = new System.Drawing.Size(121, 26);
            this.txtRemoveBookName.TabIndex = 1;
            this.txtRemoveBookName.TextChanged += new System.EventHandler(this.txtRemoveBookName_TextChanged);
            // 
            // txtRemoveISBN_NO
            // 
            this.txtRemoveISBN_NO.Location = new System.Drawing.Point(185, 43);
            this.txtRemoveISBN_NO.Name = "txtRemoveISBN_NO";
            this.txtRemoveISBN_NO.Size = new System.Drawing.Size(121, 26);
            this.txtRemoveISBN_NO.TabIndex = 0;
            this.txtRemoveISBN_NO.TextChanged += new System.EventHandler(this.txtRemoveISBN_NO_TextChanged);
            // 
            // DeleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwRemoveBook);
            this.Controls.Add(this.grbKitapEkle);
            this.Name = "DeleteBook";
            this.Text = "Delete Book";
            this.Load += new System.EventHandler(this.DeleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRemoveBook)).EndInit();
            this.grbKitapEkle.ResumeLayout(false);
            this.grbKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRemoveBook;
        private System.Windows.Forms.GroupBox grbKitapEkle;
        private System.Windows.Forms.Button btnRemoveBook;
        private System.Windows.Forms.ComboBox cmbRemoveLanguage;
        private System.Windows.Forms.TextBox txtRemovePublisherId;
        private System.Windows.Forms.TextBox txtRemoveAuthorId;
        private System.Windows.Forms.TextBox txtRemovePageNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRemoveBookName;
        private System.Windows.Forms.TextBox txtRemoveISBN_NO;
    }
}
