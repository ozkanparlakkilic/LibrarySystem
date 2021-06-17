
namespace Library
{
    partial class MemberBookPurchase
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
            this.dgwMemberPurchase = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIsbnNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLibraryName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtShelfNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBookPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMemberPurchase
            // 
            this.dgwMemberPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMemberPurchase.Location = new System.Drawing.Point(79, 43);
            this.dgwMemberPurchase.Name = "dgwMemberPurchase";
            this.dgwMemberPurchase.RowTemplate.Height = 30;
            this.dgwMemberPurchase.Size = new System.Drawing.Size(465, 150);
            this.dgwMemberPurchase.TabIndex = 0;
            this.dgwMemberPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMemberPurchase_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(177, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN NO :";
            // 
            // txtIsbnNo
            // 
            this.txtIsbnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsbnNo.Location = new System.Drawing.Point(321, 252);
            this.txtIsbnNo.Name = "txtIsbnNo";
            this.txtIsbnNo.Size = new System.Drawing.Size(121, 20);
            this.txtIsbnNo.TabIndex = 2;
            this.txtIsbnNo.TextChanged += new System.EventHandler(this.txtIsbnNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAME :";
            // 
            // cmbLibraryName
            // 
            this.cmbLibraryName.FormattingEnabled = true;
            this.cmbLibraryName.Items.AddRange(new object[] {
            "Beyazıt Kütüphanesi",
            "Süleymaniye Kütüphanesi"});
            this.cmbLibraryName.Location = new System.Drawing.Point(321, 336);
            this.cmbLibraryName.Name = "cmbLibraryName";
            this.cmbLibraryName.Size = new System.Drawing.Size(121, 21);
            this.cmbLibraryName.TabIndex = 4;
            this.cmbLibraryName.SelectedIndexChanged += new System.EventHandler(this.cmbLibraryName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(177, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "LIBRARY NAME :";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(321, 294);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(121, 20);
            this.txtBookName.TabIndex = 6;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // txtShelfNo
            // 
            this.txtShelfNo.Location = new System.Drawing.Point(321, 378);
            this.txtShelfNo.Name = "txtShelfNo";
            this.txtShelfNo.Size = new System.Drawing.Size(121, 20);
            this.txtShelfNo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(177, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "SHELF NO :";
            // 
            // btnBookPurchase
            // 
            this.btnBookPurchase.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnBookPurchase.Location = new System.Drawing.Point(215, 436);
            this.btnBookPurchase.Name = "btnBookPurchase";
            this.btnBookPurchase.Size = new System.Drawing.Size(199, 39);
            this.btnBookPurchase.TabIndex = 9;
            this.btnBookPurchase.Text = "BOOK PURCHASE";
            this.btnBookPurchase.UseVisualStyleBackColor = true;
            this.btnBookPurchase.Click += new System.EventHandler(this.btnBookPurchase_Click);
            // 
            // MemberBookPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 535);
            this.Controls.Add(this.btnBookPurchase);
            this.Controls.Add(this.txtShelfNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLibraryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsbnNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMemberPurchase);
            this.Name = "MemberBookPurchase";
            this.Text = "MemberBookPurchase";
            this.Load += new System.EventHandler(this.MemberBookPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMemberPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMemberPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbnNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLibraryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtShelfNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBookPurchase;
    }
}