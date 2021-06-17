
namespace Library.Forms
{
    partial class SearchPublisher
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearchPusblisherId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSearchPublisherName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgwSearchPublisher = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSearchPusblisherId);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSearchPublisherName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(182, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 315);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEARCH PUBLISHER";
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Location = new System.Drawing.Point(254, 182);
            this.txtSearchAddress.Multiline = true;
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(154, 74);
            this.txtSearchAddress.TabIndex = 13;
            this.txtSearchAddress.TextChanged += new System.EventHandler(this.txtSearchAddress_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "ADDRESS :";
            // 
            // txtSearchPusblisherId
            // 
            this.txtSearchPusblisherId.Location = new System.Drawing.Point(254, 45);
            this.txtSearchPusblisherId.Name = "txtSearchPusblisherId";
            this.txtSearchPusblisherId.Size = new System.Drawing.Size(100, 26);
            this.txtSearchPusblisherId.TabIndex = 7;
            this.txtSearchPusblisherId.TextChanged += new System.EventHandler(this.txtSearchPusblisherId_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "PUBLISHER ID :";
            // 
            // txtSearchPublisherName
            // 
            this.txtSearchPublisherName.Location = new System.Drawing.Point(254, 98);
            this.txtSearchPublisherName.Name = "txtSearchPublisherName";
            this.txtSearchPublisherName.Size = new System.Drawing.Size(100, 26);
            this.txtSearchPublisherName.TabIndex = 5;
            this.txtSearchPublisherName.TextChanged += new System.EventHandler(this.txtSearchPublisherName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "PUBLISHER NAME :";
            // 
            // dgwSearchPublisher
            // 
            this.dgwSearchPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearchPublisher.Location = new System.Drawing.Point(182, 105);
            this.dgwSearchPublisher.Name = "dgwSearchPublisher";
            this.dgwSearchPublisher.Size = new System.Drawing.Size(447, 150);
            this.dgwSearchPublisher.TabIndex = 14;
            // 
            // SearchPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwSearchPublisher);
            this.Name = "SearchPublisher";
            this.Text = "Search Publisher";
            this.Load += new System.EventHandler(this.SearchPublisher_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearchPublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSearchPusblisherId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchPublisherName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwSearchPublisher;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.Label label9;
    }
}
