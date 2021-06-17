
namespace Library
{
    partial class UpdateBook
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
            this.dgwUpdateBook = new System.Windows.Forms.DataGridView();
            this.grbKitapEkle = new System.Windows.Forms.GroupBox();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.cmbUpdateLanguage = new System.Windows.Forms.ComboBox();
            this.txtUpdatePublisherId = new System.Windows.Forms.TextBox();
            this.txtUpdateAuthorId = new System.Windows.Forms.TextBox();
            this.txtUpdatePageNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUpdateBookName = new System.Windows.Forms.TextBox();
            this.txtUpdateISBN_NO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdateBook)).BeginInit();
            this.grbKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUpdateBook
            // 
            this.dgwUpdateBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdateBook.Location = new System.Drawing.Point(159, 109);
            this.dgwUpdateBook.Name = "dgwUpdateBook";
            this.dgwUpdateBook.Size = new System.Drawing.Size(513, 150);
            this.dgwUpdateBook.TabIndex = 23;
            this.dgwUpdateBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdateBook_CellClick);
            // 
            // grbKitapEkle
            // 
            this.grbKitapEkle.Controls.Add(this.btnUpdateBook);
            this.grbKitapEkle.Controls.Add(this.cmbUpdateLanguage);
            this.grbKitapEkle.Controls.Add(this.txtUpdatePublisherId);
            this.grbKitapEkle.Controls.Add(this.txtUpdateAuthorId);
            this.grbKitapEkle.Controls.Add(this.txtUpdatePageNumber);
            this.grbKitapEkle.Controls.Add(this.label12);
            this.grbKitapEkle.Controls.Add(this.label18);
            this.grbKitapEkle.Controls.Add(this.label17);
            this.grbKitapEkle.Controls.Add(this.label13);
            this.grbKitapEkle.Controls.Add(this.label14);
            this.grbKitapEkle.Controls.Add(this.label15);
            this.grbKitapEkle.Controls.Add(this.txtUpdateBookName);
            this.grbKitapEkle.Controls.Add(this.txtUpdateISBN_NO);
            this.grbKitapEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKitapEkle.Location = new System.Drawing.Point(229, 288);
            this.grbKitapEkle.Name = "grbKitapEkle";
            this.grbKitapEkle.Size = new System.Drawing.Size(373, 350);
            this.grbKitapEkle.TabIndex = 22;
            this.grbKitapEkle.TabStop = false;
            this.grbKitapEkle.Text = "SEARCH BOOK";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(82, 276);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(166, 46);
            this.btnUpdateBook.TabIndex = 18;
            this.btnUpdateBook.Text = "Update Book";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // cmbUpdateLanguage
            // 
            this.cmbUpdateLanguage.FormattingEnabled = true;
            this.cmbUpdateLanguage.Items.AddRange(new object[] {
            "Turkish",
            "French",
            "English"});
            this.cmbUpdateLanguage.Location = new System.Drawing.Point(185, 151);
            this.cmbUpdateLanguage.Name = "cmbUpdateLanguage";
            this.cmbUpdateLanguage.Size = new System.Drawing.Size(121, 27);
            this.cmbUpdateLanguage.TabIndex = 17;
            this.cmbUpdateLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateLANGUAGE_SelectedIndexChanged);
            // 
            // txtUpdatePublisherId
            // 
            this.txtUpdatePublisherId.Location = new System.Drawing.Point(185, 224);
            this.txtUpdatePublisherId.Name = "txtUpdatePublisherId";
            this.txtUpdatePublisherId.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePublisherId.TabIndex = 16;
            this.txtUpdatePublisherId.TextChanged += new System.EventHandler(this.txtUpdatePublisherId_TextChanged);
            // 
            // txtUpdateAuthorId
            // 
            this.txtUpdateAuthorId.Location = new System.Drawing.Point(185, 188);
            this.txtUpdateAuthorId.Name = "txtUpdateAuthorId";
            this.txtUpdateAuthorId.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateAuthorId.TabIndex = 15;
            this.txtUpdateAuthorId.TextChanged += new System.EventHandler(this.txtUpdateAuthorId_TextChanged);
            // 
            // txtUpdatePageNumber
            // 
            this.txtUpdatePageNumber.Location = new System.Drawing.Point(185, 115);
            this.txtUpdatePageNumber.Name = "txtUpdatePageNumber";
            this.txtUpdatePageNumber.Size = new System.Drawing.Size(121, 26);
            this.txtUpdatePageNumber.TabIndex = 14;
            this.txtUpdatePageNumber.TextChanged += new System.EventHandler(this.txtUpdatePageNumber_TextChanged);
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
            // txtUpdateBookName
            // 
            this.txtUpdateBookName.Location = new System.Drawing.Point(185, 79);
            this.txtUpdateBookName.Name = "txtUpdateBookName";
            this.txtUpdateBookName.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateBookName.TabIndex = 1;
            this.txtUpdateBookName.TextChanged += new System.EventHandler(this.txtUpdateBookName_TextChanged);
            // 
            // txtUpdateISBN_NO
            // 
            this.txtUpdateISBN_NO.Location = new System.Drawing.Point(185, 43);
            this.txtUpdateISBN_NO.Name = "txtUpdateISBN_NO";
            this.txtUpdateISBN_NO.Size = new System.Drawing.Size(121, 26);
            this.txtUpdateISBN_NO.TabIndex = 0;
            this.txtUpdateISBN_NO.TextChanged += new System.EventHandler(this.txtUpdateISBN_NO_TextChanged);
            // 
            // UpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.dgwUpdateBook);
            this.Controls.Add(this.grbKitapEkle);
            this.Name = "UpdateBook";
            this.Text = "Update Book";
            this.Load += new System.EventHandler(this.UpdateBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdateBook)).EndInit();
            this.grbKitapEkle.ResumeLayout(false);
            this.grbKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUpdateBook;
        private System.Windows.Forms.GroupBox grbKitapEkle;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.ComboBox cmbUpdateLanguage;
        private System.Windows.Forms.TextBox txtUpdatePublisherId;
        private System.Windows.Forms.TextBox txtUpdateAuthorId;
        private System.Windows.Forms.TextBox txtUpdatePageNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUpdateBookName;
        private System.Windows.Forms.TextBox txtUpdateISBN_NO;
    }
}
