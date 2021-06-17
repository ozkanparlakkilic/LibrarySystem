
namespace Library.Forms.OperationForm
{
    partial class PersonelPanelForm
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
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnTheBookBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(53, 111);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(135, 53);
            this.btnAddAuthor.TabIndex = 5;
            this.btnAddAuthor.Text = "ADD BOOK";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRapor.Location = new System.Drawing.Point(462, 111);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(135, 53);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "RAPOR";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnTheBookBack
            // 
            this.btnTheBookBack.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheBookBack.Location = new System.Drawing.Point(259, 111);
            this.btnTheBookBack.Name = "btnTheBookBack";
            this.btnTheBookBack.Size = new System.Drawing.Size(135, 53);
            this.btnTheBookBack.TabIndex = 7;
            this.btnTheBookBack.Text = "THE BOOK BACK";
            this.btnTheBookBack.UseVisualStyleBackColor = true;
            this.btnTheBookBack.Click += new System.EventHandler(this.btnTheBookBack_Click);
            // 
            // PersonelPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 323);
            this.Controls.Add(this.btnTheBookBack);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnAddAuthor);
            this.Name = "PersonelPanelForm";
            this.Text = "Personel Panel Form";
            this.Load += new System.EventHandler(this.PersonelPanelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnTheBookBack;
    }
}
