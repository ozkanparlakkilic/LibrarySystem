
namespace Library.Forms.BookForms
{
    partial class AddBook
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
            this.panelYazar = new System.Windows.Forms.Panel();
            this.dgwAuthor = new System.Windows.Forms.DataGridView();
            this.grbYazar = new System.Windows.Forms.GroupBox();
            this.ptxAddAuthor = new System.Windows.Forms.PictureBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.dtpYearOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbNationality = new System.Windows.Forms.ComboBox();
            this.txtYazarSurname = new System.Windows.Forms.TextBox();
            this.txtYazarName = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelYayinEvi = new System.Windows.Forms.Panel();
            this.grbYayinEvi = new System.Windows.Forms.GroupBox();
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpYayinEvi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYayinEviName = new System.Windows.Forms.TextBox();
            this.dgwPublisher = new System.Windows.Forms.DataGridView();
            this.panelBook = new System.Windows.Forms.Panel();
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.grbKitapEkle = new System.Windows.Forms.GroupBox();
            this.btnSaveBook = new System.Windows.Forms.Button();
            this.cmbAddLanguage = new System.Windows.Forms.ComboBox();
            this.txtAddPublisherId = new System.Windows.Forms.TextBox();
            this.txtAddAuthorId = new System.Windows.Forms.TextBox();
            this.txtAddPageNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAddBookName = new System.Windows.Forms.TextBox();
            this.txtAddISBN_NO = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.panelYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthor)).BeginInit();
            this.grbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddAuthor)).BeginInit();
            this.panelYayinEvi.SuspendLayout();
            this.grbYayinEvi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPublisher)).BeginInit();
            this.panelBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.grbKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelYazar
            // 
            this.panelYazar.Controls.Add(this.dgwAuthor);
            this.panelYazar.Controls.Add(this.grbYazar);
            this.panelYazar.Controls.Add(this.btnAddAuthor);
            this.panelYazar.Controls.Add(this.label1);
            this.panelYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelYazar.Location = new System.Drawing.Point(111, 24);
            this.panelYazar.Name = "panelYazar";
            this.panelYazar.Size = new System.Drawing.Size(655, 656);
            this.panelYazar.TabIndex = 0;
            // 
            // dgwAuthor
            // 
            this.dgwAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAuthor.Location = new System.Drawing.Point(71, 82);
            this.dgwAuthor.Name = "dgwAuthor";
            this.dgwAuthor.Size = new System.Drawing.Size(508, 150);
            this.dgwAuthor.TabIndex = 7;
            this.dgwAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYazar_CellClick);
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
            this.grbYazar.Controls.Add(this.label6);
            this.grbYazar.Controls.Add(this.cmbNationality);
            this.grbYazar.Controls.Add(this.txtYazarSurname);
            this.grbYazar.Controls.Add(this.txtYazarName);
            this.grbYazar.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYazar.Location = new System.Drawing.Point(103, 253);
            this.grbYazar.Name = "grbYazar";
            this.grbYazar.Size = new System.Drawing.Size(425, 300);
            this.grbYazar.TabIndex = 5;
            this.grbYazar.TabStop = false;
            this.grbYazar.Text = "ADD AUTHOR";
            // 
            // ptxAddAuthor
            // 
            this.ptxAddAuthor.Image = global::Library.Properties.Resources.ImageIcon;
            this.ptxAddAuthor.Location = new System.Drawing.Point(316, 25);
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
            this.rbWoman.CheckedChanged += new System.EventHandler(this.rbWoman_CheckedChanged);
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
            this.rbMan.CheckedChanged += new System.EventHandler(this.rbMan_CheckedChanged);
            // 
            // dtpYearOfBirth
            // 
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "NAME";
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
            this.cmbNationality.SelectedIndexChanged += new System.EventHandler(this.cmbNationality_SelectedIndexChanged);
            // 
            // txtYazarSurname
            // 
            this.txtYazarSurname.Location = new System.Drawing.Point(171, 100);
            this.txtYazarSurname.Name = "txtYazarSurname";
            this.txtYazarSurname.Size = new System.Drawing.Size(121, 26);
            this.txtYazarSurname.TabIndex = 1;
            this.txtYazarSurname.TextChanged += new System.EventHandler(this.txtYazarSurname_TextChanged);
            // 
            // txtYazarName
            // 
            this.txtYazarName.Location = new System.Drawing.Point(171, 57);
            this.txtYazarName.Name = "txtYazarName";
            this.txtYazarName.Size = new System.Drawing.Size(121, 26);
            this.txtYazarName.TabIndex = 0;
            this.txtYazarName.TextChanged += new System.EventHandler(this.txtYazarName_TextChanged);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(240, 575);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(135, 53);
            this.btnAddAuthor.TabIndex = 6;
            this.btnAddAuthor.Text = "ADD AUTHOR";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Page One";
            // 
            // panelYayinEvi
            // 
            this.panelYayinEvi.Controls.Add(this.grbYayinEvi);
            this.panelYayinEvi.Controls.Add(this.dgwPublisher);
            this.panelYayinEvi.Controls.Add(this.label12);
            this.panelYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelYayinEvi.Location = new System.Drawing.Point(111, 24);
            this.panelYayinEvi.Name = "panelYayinEvi";
            this.panelYayinEvi.Size = new System.Drawing.Size(655, 656);
            this.panelYayinEvi.TabIndex = 1;
            // 
            // grbYayinEvi
            // 
            this.grbYayinEvi.Controls.Add(this.btnYayinEviEkle);
            this.grbYayinEvi.Controls.Add(this.txtAddress);
            this.grbYayinEvi.Controls.Add(this.dtpYayinEvi);
            this.grbYayinEvi.Controls.Add(this.label8);
            this.grbYayinEvi.Controls.Add(this.label9);
            this.grbYayinEvi.Controls.Add(this.label11);
            this.grbYayinEvi.Controls.Add(this.txtYayinEviName);
            this.grbYayinEvi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYayinEvi.Location = new System.Drawing.Point(141, 255);
            this.grbYayinEvi.Name = "grbYayinEvi";
            this.grbYayinEvi.Size = new System.Drawing.Size(385, 367);
            this.grbYayinEvi.TabIndex = 15;
            this.grbYayinEvi.TabStop = false;
            this.grbYayinEvi.Text = "ADD PUBLISHER";
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYayinEviEkle.Location = new System.Drawing.Point(118, 273);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(151, 53);
            this.btnYayinEviEkle.TabIndex = 16;
            this.btnYayinEviEkle.Text = "ADD PUBLISHER";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 91);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 74);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // dtpYayinEvi
            // 
            this.dtpYayinEvi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYayinEvi.Location = new System.Drawing.Point(218, 191);
            this.dtpYayinEvi.Name = "dtpYayinEvi";
            this.dtpYayinEvi.Size = new System.Drawing.Size(121, 26);
            this.dtpYayinEvi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "YEAR OF FOUNDATION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "ADDRESS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "NAME";
            // 
            // txtYayinEviName
            // 
            this.txtYayinEviName.Location = new System.Drawing.Point(187, 43);
            this.txtYayinEviName.Name = "txtYayinEviName";
            this.txtYayinEviName.Size = new System.Drawing.Size(154, 26);
            this.txtYayinEviName.TabIndex = 0;
            this.txtYayinEviName.TextChanged += new System.EventHandler(this.txtYayinEviName_TextChanged);
            // 
            // dgwPublisher
            // 
            this.dgwPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPublisher.Location = new System.Drawing.Point(57, 73);
            this.dgwPublisher.Name = "dgwPublisher";
            this.dgwPublisher.Size = new System.Drawing.Size(544, 153);
            this.dgwPublisher.TabIndex = 7;
            this.dgwPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPublisher_CellClick);
            // 
            // panelBook
            // 
            this.panelBook.Controls.Add(this.dgwBook);
            this.panelBook.Controls.Add(this.grbKitapEkle);
            this.panelBook.Controls.Add(this.label14);
            this.panelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelBook.Location = new System.Drawing.Point(111, 24);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(655, 655);
            this.panelBook.TabIndex = 2;
            // 
            // dgwBook
            // 
            this.dgwBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBook.Location = new System.Drawing.Point(57, 73);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.Size = new System.Drawing.Size(544, 150);
            this.dgwBook.TabIndex = 25;
            this.dgwBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBook_CellClick);
            // 
            // grbKitapEkle
            // 
            this.grbKitapEkle.Controls.Add(this.btnSaveBook);
            this.grbKitapEkle.Controls.Add(this.cmbAddLanguage);
            this.grbKitapEkle.Controls.Add(this.txtAddPublisherId);
            this.grbKitapEkle.Controls.Add(this.txtAddAuthorId);
            this.grbKitapEkle.Controls.Add(this.txtAddPageNumber);
            this.grbKitapEkle.Controls.Add(this.label7);
            this.grbKitapEkle.Controls.Add(this.label18);
            this.grbKitapEkle.Controls.Add(this.label17);
            this.grbKitapEkle.Controls.Add(this.label13);
            this.grbKitapEkle.Controls.Add(this.label10);
            this.grbKitapEkle.Controls.Add(this.label15);
            this.grbKitapEkle.Controls.Add(this.txtAddBookName);
            this.grbKitapEkle.Controls.Add(this.txtAddISBN_NO);
            this.grbKitapEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKitapEkle.Location = new System.Drawing.Point(146, 254);
            this.grbKitapEkle.Name = "grbKitapEkle";
            this.grbKitapEkle.Size = new System.Drawing.Size(373, 363);
            this.grbKitapEkle.TabIndex = 24;
            this.grbKitapEkle.TabStop = false;
            this.grbKitapEkle.Text = "ADD BOOK";
            // 
            // btnSaveBook
            // 
            this.btnSaveBook.Location = new System.Drawing.Point(108, 287);
            this.btnSaveBook.Name = "btnSaveBook";
            this.btnSaveBook.Size = new System.Drawing.Size(125, 46);
            this.btnSaveBook.TabIndex = 18;
            this.btnSaveBook.Text = "SAVE BOOK";
            this.btnSaveBook.UseVisualStyleBackColor = true;
            this.btnSaveBook.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAddLanguage
            // 
            this.cmbAddLanguage.FormattingEnabled = true;
            this.cmbAddLanguage.Items.AddRange(new object[] {
            "Turkish",
            "French",
            "English"});
            this.cmbAddLanguage.Location = new System.Drawing.Point(185, 151);
            this.cmbAddLanguage.Name = "cmbAddLanguage";
            this.cmbAddLanguage.Size = new System.Drawing.Size(121, 27);
            this.cmbAddLanguage.TabIndex = 17;
            this.cmbAddLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbAddLanguage_SelectedIndexChanged);
            // 
            // txtAddPublisherId
            // 
            this.txtAddPublisherId.Enabled = false;
            this.txtAddPublisherId.Location = new System.Drawing.Point(185, 224);
            this.txtAddPublisherId.Name = "txtAddPublisherId";
            this.txtAddPublisherId.Size = new System.Drawing.Size(121, 26);
            this.txtAddPublisherId.TabIndex = 16;
            // 
            // txtAddAuthorId
            // 
            this.txtAddAuthorId.Enabled = false;
            this.txtAddAuthorId.Location = new System.Drawing.Point(185, 188);
            this.txtAddAuthorId.Name = "txtAddAuthorId";
            this.txtAddAuthorId.Size = new System.Drawing.Size(121, 26);
            this.txtAddAuthorId.TabIndex = 15;
            // 
            // txtAddPageNumber
            // 
            this.txtAddPageNumber.Location = new System.Drawing.Point(185, 115);
            this.txtAddPageNumber.Name = "txtAddPageNumber";
            this.txtAddPageNumber.Size = new System.Drawing.Size(121, 26);
            this.txtAddPageNumber.TabIndex = 14;
            this.txtAddPageNumber.TextChanged += new System.EventHandler(this.txtAddPageNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "LANGUAGE";
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
            this.label13.Size = new System.Drawing.Size(135, 19);
            this.label13.TabIndex = 5;
            this.label13.Text = "PAGE NUMBER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 4;
            this.label10.Text = "ISBN_NO";
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
            // txtAddBookName
            // 
            this.txtAddBookName.Location = new System.Drawing.Point(185, 79);
            this.txtAddBookName.Name = "txtAddBookName";
            this.txtAddBookName.Size = new System.Drawing.Size(121, 26);
            this.txtAddBookName.TabIndex = 1;
            this.txtAddBookName.TextChanged += new System.EventHandler(this.txtAddBookName_TextChanged);
            // 
            // txtAddISBN_NO
            // 
            this.txtAddISBN_NO.Location = new System.Drawing.Point(185, 43);
            this.txtAddISBN_NO.Name = "txtAddISBN_NO";
            this.txtAddISBN_NO.Size = new System.Drawing.Size(121, 26);
            this.txtAddISBN_NO.TabIndex = 0;
            this.txtAddISBN_NO.TextChanged += new System.EventHandler(this.txtAddISBN_NO_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Page Three";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Page Two";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(454, 703);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 53);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(259, 703);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(135, 53);
            this.btnPrev.TabIndex = 8;
            this.btnPrev.Text = "PREV";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(339, 703);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(151, 53);
            this.btnGo.TabIndex = 18;
            this.btnGo.Text = "ADD BOOK INFORMATION";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Visible = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 789);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.panelYayinEvi);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.panelYazar);
            this.Controls.Add(this.btnPrev);
            this.Name = "AddBook";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.panelYazar.ResumeLayout(false);
            this.panelYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAuthor)).EndInit();
            this.grbYazar.ResumeLayout(false);
            this.grbYazar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxAddAuthor)).EndInit();
            this.panelYayinEvi.ResumeLayout(false);
            this.panelYayinEvi.PerformLayout();
            this.grbYayinEvi.ResumeLayout(false);
            this.grbYayinEvi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPublisher)).EndInit();
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.grbKitapEkle.ResumeLayout(false);
            this.grbKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbYazar;
        private System.Windows.Forms.PictureBox ptxAddAuthor;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.DateTimePicker dtpYearOfBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbNationality;
        private System.Windows.Forms.TextBox txtYazarSurname;
        private System.Windows.Forms.TextBox txtYazarName;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.DataGridView dgwAuthor;
        private System.Windows.Forms.Panel panelYayinEvi;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.DataGridView dgwPublisher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnYayinEviEkle;
        private System.Windows.Forms.GroupBox grbYayinEvi;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpYayinEvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYayinEviName;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grbKitapEkle;
        private System.Windows.Forms.Button btnSaveBook;
        private System.Windows.Forms.ComboBox cmbAddLanguage;
        private System.Windows.Forms.TextBox txtAddPublisherId;
        private System.Windows.Forms.TextBox txtAddAuthorId;
        private System.Windows.Forms.TextBox txtAddPageNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAddBookName;
        private System.Windows.Forms.TextBox txtAddISBN_NO;
        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.Button btnGo;
    }
}
