
namespace Library.Forms
{
    partial class UpdatePublisher
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
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.dtpUpdatePublisher = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdatePublisherName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgwUpdatePublisher = new System.Windows.Forms.DataGridView();
            this.btmDeletePublisher = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdateAddress);
            this.groupBox2.Controls.Add(this.dtpUpdatePublisher);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUpdatePublisherName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(179, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 325);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEARCH PUBLISHER";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Location = new System.Drawing.Point(268, 147);
            this.txtUpdateAddress.Multiline = true;
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(154, 74);
            this.txtUpdateAddress.TabIndex = 13;
            this.txtUpdateAddress.TextChanged += new System.EventHandler(this.txtUpdateAddress_TextChanged);
            // 
            // dtpUpdatePublisher
            // 
            this.dtpUpdatePublisher.Location = new System.Drawing.Point(268, 250);
            this.dtpUpdatePublisher.Name = "dtpUpdatePublisher";
            this.dtpUpdatePublisher.Size = new System.Drawing.Size(121, 26);
            this.dtpUpdatePublisher.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "YEAR OF FOUNDATION :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "ADDRESS :";
            // 
            // txtUpdatePublisherName
            // 
            this.txtUpdatePublisherName.Location = new System.Drawing.Point(268, 63);
            this.txtUpdatePublisherName.Name = "txtUpdatePublisherName";
            this.txtUpdatePublisherName.Size = new System.Drawing.Size(100, 26);
            this.txtUpdatePublisherName.TabIndex = 5;
            this.txtUpdatePublisherName.TextChanged += new System.EventHandler(this.txtUpdatePublisherName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "PUBLISHER NAME :";
            // 
            // dgwUpdatePublisher
            // 
            this.dgwUpdatePublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUpdatePublisher.Location = new System.Drawing.Point(179, 76);
            this.dgwUpdatePublisher.Name = "dgwUpdatePublisher";
            this.dgwUpdatePublisher.Size = new System.Drawing.Size(447, 150);
            this.dgwUpdatePublisher.TabIndex = 16;
            this.dgwUpdatePublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUpdatePublisher_CellClick);
            // 
            // btmDeletePublisher
            // 
            this.btmDeletePublisher.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDeletePublisher.Location = new System.Drawing.Point(305, 640);
            this.btmDeletePublisher.Name = "btmDeletePublisher";
            this.btmDeletePublisher.Size = new System.Drawing.Size(160, 47);
            this.btmDeletePublisher.TabIndex = 18;
            this.btmDeletePublisher.Text = "UPDATE";
            this.btmDeletePublisher.UseVisualStyleBackColor = true;
            this.btmDeletePublisher.Click += new System.EventHandler(this.btmDeletePublisher_Click);
            // 
            // UpdatePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.btmDeletePublisher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwUpdatePublisher);
            this.Name = "UpdatePublisher";
            this.Text = "Update Publisher";
            this.Load += new System.EventHandler(this.UpdatePublisher_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUpdatePublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.DateTimePicker dtpUpdatePublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdatePublisherName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwUpdatePublisher;
        private System.Windows.Forms.Button btmDeletePublisher;
    }
}
