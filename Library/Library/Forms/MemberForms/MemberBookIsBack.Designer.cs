
namespace Library
{
    partial class MemberBookIsBack
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
            this.dgwBookIsBack = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnUpdateBookIsBackStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookIsBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBookIsBack
            // 
            this.dgwBookIsBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookIsBack.Location = new System.Drawing.Point(79, 41);
            this.dgwBookIsBack.Name = "dgwBookIsBack";
            this.dgwBookIsBack.Size = new System.Drawing.Size(437, 181);
            this.dgwBookIsBack.TabIndex = 0;
            this.dgwBookIsBack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookIsBack_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(167, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name :";
            // 
            // txtBookName
            // 
            this.txtBookName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBookName.Location = new System.Drawing.Point(312, 286);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(100, 27);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserName.Location = new System.Drawing.Point(312, 331);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 27);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnUpdateBookIsBackStatus
            // 
            this.btnUpdateBookIsBackStatus.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnUpdateBookIsBackStatus.Location = new System.Drawing.Point(231, 397);
            this.btnUpdateBookIsBackStatus.Name = "btnUpdateBookIsBackStatus";
            this.btnUpdateBookIsBackStatus.Size = new System.Drawing.Size(121, 44);
            this.btnUpdateBookIsBackStatus.TabIndex = 6;
            this.btnUpdateBookIsBackStatus.Text = "Update";
            this.btnUpdateBookIsBackStatus.UseVisualStyleBackColor = true;
            this.btnUpdateBookIsBackStatus.Click += new System.EventHandler(this.btnUpdateBookIsBackStatus_Click);
            // 
            // MemberBookIsBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 541);
            this.Controls.Add(this.btnUpdateBookIsBackStatus);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwBookIsBack);
            this.Name = "MemberBookIsBack";
            this.Text = "MemberBookIsBack";
            this.Load += new System.EventHandler(this.MemberBookIsBack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookIsBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBookIsBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnUpdateBookIsBackStatus;
    }
}