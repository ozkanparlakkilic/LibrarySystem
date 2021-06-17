
namespace Library.Forms
{
    partial class AddPublisher
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
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.grbYayinEvi = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpYayinEvi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtYayinEviName = new System.Windows.Forms.TextBox();
            this.grbYayinEvi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYayinEviEkle.Location = new System.Drawing.Point(255, 522);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(151, 53);
            this.btnYayinEviEkle.TabIndex = 14;
            this.btnYayinEviEkle.Text = "ADD PUBLISHER";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // grbYayinEvi
            // 
            this.grbYayinEvi.Controls.Add(this.txtAddress);
            this.grbYayinEvi.Controls.Add(this.dtpYayinEvi);
            this.grbYayinEvi.Controls.Add(this.label8);
            this.grbYayinEvi.Controls.Add(this.label9);
            this.grbYayinEvi.Controls.Add(this.label11);
            this.grbYayinEvi.Controls.Add(this.txtYayinEviName);
            this.grbYayinEvi.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbYayinEvi.Location = new System.Drawing.Point(204, 208);
            this.grbYayinEvi.Name = "grbYayinEvi";
            this.grbYayinEvi.Size = new System.Drawing.Size(385, 288);
            this.grbYayinEvi.TabIndex = 13;
            this.grbYayinEvi.TabStop = false;
            this.grbYayinEvi.Text = "ADD PUBLISHER";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(185, 91);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 74);
            this.txtAddress.TabIndex = 9;
            // 
            // dtpYayinEvi
            // 
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
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 768);
            this.Controls.Add(this.btnYayinEviEkle);
            this.Controls.Add(this.grbYayinEvi);
            this.Name = "AddPublisher";
            this.Text = "Add Publisher";
            this.Load += new System.EventHandler(this.AddPublisher_Load);
            this.grbYayinEvi.ResumeLayout(false);
            this.grbYayinEvi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYayinEviEkle;
        private System.Windows.Forms.GroupBox grbYayinEvi;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpYayinEvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYayinEviName;
    }
}
