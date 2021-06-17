
namespace Library.Forms
{
    partial class DeletePublisher
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
            this.txtDeleteAddress = new System.Windows.Forms.TextBox();
            this.dtpDeletePublisher = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDeletePublisherName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgwDeletePublisher = new System.Windows.Forms.DataGridView();
            this.btmDeletePublisher = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeletePublisher)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDeleteAddress);
            this.groupBox2.Controls.Add(this.dtpDeletePublisher);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtDeletePublisherName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(186, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 316);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SEARCH PUBLISHER";
            // 
            // txtDeleteAddress
            // 
            this.txtDeleteAddress.Location = new System.Drawing.Point(262, 138);
            this.txtDeleteAddress.Multiline = true;
            this.txtDeleteAddress.Name = "txtDeleteAddress";
            this.txtDeleteAddress.Size = new System.Drawing.Size(154, 74);
            this.txtDeleteAddress.TabIndex = 13;
            this.txtDeleteAddress.TextChanged += new System.EventHandler(this.txtDeleteAddress_TextChanged);
            // 
            // dtpDeletePublisher
            // 
            this.dtpDeletePublisher.Location = new System.Drawing.Point(262, 241);
            this.dtpDeletePublisher.Name = "dtpDeletePublisher";
            this.dtpDeletePublisher.Size = new System.Drawing.Size(121, 26);
            this.dtpDeletePublisher.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "YEAR OF FOUNDATION :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "ADDRESS :";
            // 
            // txtDeletePublisherName
            // 
            this.txtDeletePublisherName.Location = new System.Drawing.Point(262, 54);
            this.txtDeletePublisherName.Name = "txtDeletePublisherName";
            this.txtDeletePublisherName.Size = new System.Drawing.Size(100, 26);
            this.txtDeletePublisherName.TabIndex = 5;
            this.txtDeletePublisherName.TextChanged += new System.EventHandler(this.txtDeletePublisherName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "PUBLISHER NAME :";
            // 
            // dgwDeletePublisher
            // 
            this.dgwDeletePublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDeletePublisher.Location = new System.Drawing.Point(186, 60);
            this.dgwDeletePublisher.Name = "dgwDeletePublisher";
            this.dgwDeletePublisher.Size = new System.Drawing.Size(447, 150);
            this.dgwDeletePublisher.TabIndex = 16;
            this.dgwDeletePublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDeletePublisher_CellClick);
            // 
            // btmDeletePublisher
            // 
            this.btmDeletePublisher.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmDeletePublisher.Location = new System.Drawing.Point(307, 629);
            this.btmDeletePublisher.Name = "btmDeletePublisher";
            this.btmDeletePublisher.Size = new System.Drawing.Size(160, 47);
            this.btmDeletePublisher.TabIndex = 18;
            this.btmDeletePublisher.Text = "REMOVE";
            this.btmDeletePublisher.UseVisualStyleBackColor = true;
            this.btmDeletePublisher.Click += new System.EventHandler(this.btmDeletePublisher_Click);
            // 
            // DeletePublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.btmDeletePublisher);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgwDeletePublisher);
            this.Name = "DeletePublisher";
            this.Text = "Delete Publisher";
            this.Load += new System.EventHandler(this.DeletePublisher_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDeletePublisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDeleteAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeletePublisherName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgwDeletePublisher;
        private System.Windows.Forms.Button btmDeletePublisher;
        private System.Windows.Forms.DateTimePicker dtpDeletePublisher;
        private System.Windows.Forms.Label label8;
    }
}
