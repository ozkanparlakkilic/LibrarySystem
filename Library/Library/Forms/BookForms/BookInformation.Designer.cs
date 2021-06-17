
namespace Library
{
    partial class BookInformation
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
            this.panelBookInformation = new System.Windows.Forms.Panel();
            this.btnAddBookInformation = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBookShelf = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBookIsbnNo = new System.Windows.Forms.TextBox();
            this.panelBookInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBookInformation
            // 
            this.panelBookInformation.Controls.Add(this.btnAddBookInformation);
            this.panelBookInformation.Controls.Add(this.label22);
            this.panelBookInformation.Controls.Add(this.label16);
            this.panelBookInformation.Controls.Add(this.txtAmount);
            this.panelBookInformation.Controls.Add(this.label19);
            this.panelBookInformation.Controls.Add(this.txtBookShelf);
            this.panelBookInformation.Controls.Add(this.label20);
            this.panelBookInformation.Controls.Add(this.txtLibraryName);
            this.panelBookInformation.Controls.Add(this.label21);
            this.panelBookInformation.Controls.Add(this.txtBookIsbnNo);
            this.panelBookInformation.Location = new System.Drawing.Point(35, 25);
            this.panelBookInformation.Name = "panelBookInformation";
            this.panelBookInformation.Size = new System.Drawing.Size(655, 655);
            this.panelBookInformation.TabIndex = 19;
            // 
            // btnAddBookInformation
            // 
            this.btnAddBookInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBookInformation.Location = new System.Drawing.Point(262, 411);
            this.btnAddBookInformation.Name = "btnAddBookInformation";
            this.btnAddBookInformation.Size = new System.Drawing.Size(131, 45);
            this.btnAddBookInformation.TabIndex = 10;
            this.btnAddBookInformation.Text = "Save";
            this.btnAddBookInformation.UseVisualStyleBackColor = true;
            this.btnAddBookInformation.Click += new System.EventHandler(this.btnAddBookInformation_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(36, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 19);
            this.label22.TabIndex = 9;
            this.label22.Text = "Page Four";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(204, 212);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 21);
            this.label16.TabIndex = 1;
            this.label16.Text = "ISBN NO :";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAmount.Location = new System.Drawing.Point(382, 353);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(204, 259);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "LIBRARY NAME  :";
            // 
            // txtBookShelf
            // 
            this.txtBookShelf.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBookShelf.Location = new System.Drawing.Point(382, 306);
            this.txtBookShelf.Name = "txtBookShelf";
            this.txtBookShelf.Size = new System.Drawing.Size(100, 27);
            this.txtBookShelf.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(204, 306);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 21);
            this.label20.TabIndex = 3;
            this.label20.Text = "BOOK SHELF :";
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLibraryName.Location = new System.Drawing.Point(382, 259);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.Size = new System.Drawing.Size(100, 27);
            this.txtLibraryName.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(204, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 21);
            this.label21.TabIndex = 4;
            this.label21.Text = "AMOUNT :";
            // 
            // txtBookIsbnNo
            // 
            this.txtBookIsbnNo.Enabled = false;
            this.txtBookIsbnNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookIsbnNo.Location = new System.Drawing.Point(382, 212);
            this.txtBookIsbnNo.Name = "txtBookIsbnNo";
            this.txtBookIsbnNo.Size = new System.Drawing.Size(100, 27);
            this.txtBookIsbnNo.TabIndex = 5;
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 751);
            this.Controls.Add(this.panelBookInformation);
            this.Name = "BookInformation";
            this.Text = "BookInformation";
            this.Load += new System.EventHandler(this.BookInformation_Load);
            this.panelBookInformation.ResumeLayout(false);
            this.panelBookInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBookInformation;
        private System.Windows.Forms.Button btnAddBookInformation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBookShelf;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtBookIsbnNo;
    }
}