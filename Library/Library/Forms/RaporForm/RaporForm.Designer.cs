
namespace Library.Forms.RaporForm
{
    partial class RaporForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWeeklyTopBooksRead = new System.Windows.Forms.Button();
            this.btnMonthlyTopBooksRead = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWeeklyTheMostPunished = new System.Windows.Forms.Button();
            this.btnMonthlyTheMostPunished = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWeeklyThoseWhoDontPayPenalties = new System.Windows.Forms.Button();
            this.btnMonthlyThoseWhoDontPayPenalties = new System.Windows.Forms.Button();
            this.dgwRapor = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnWeeklyBooksOutOfStock = new System.Windows.Forms.Button();
            this.btnMonthlyBooksOutOfStock = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnVipAccount = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnBlockedAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWeeklyTopBooksRead);
            this.groupBox1.Controls.Add(this.btnMonthlyTopBooksRead);
            this.groupBox1.Location = new System.Drawing.Point(47, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "En Çok Okunan Kitaplar";
            // 
            // btnWeeklyTopBooksRead
            // 
            this.btnWeeklyTopBooksRead.Location = new System.Drawing.Point(69, 103);
            this.btnWeeklyTopBooksRead.Name = "btnWeeklyTopBooksRead";
            this.btnWeeklyTopBooksRead.Size = new System.Drawing.Size(88, 30);
            this.btnWeeklyTopBooksRead.TabIndex = 1;
            this.btnWeeklyTopBooksRead.Text = "Haftalık";
            this.btnWeeklyTopBooksRead.UseVisualStyleBackColor = true;
            this.btnWeeklyTopBooksRead.Click += new System.EventHandler(this.btnWeeklyTopBooksRead_Click);
            // 
            // btnMonthlyTopBooksRead
            // 
            this.btnMonthlyTopBooksRead.Location = new System.Drawing.Point(69, 46);
            this.btnMonthlyTopBooksRead.Name = "btnMonthlyTopBooksRead";
            this.btnMonthlyTopBooksRead.Size = new System.Drawing.Size(88, 28);
            this.btnMonthlyTopBooksRead.TabIndex = 0;
            this.btnMonthlyTopBooksRead.Text = "Aylık ";
            this.btnMonthlyTopBooksRead.UseVisualStyleBackColor = true;
            this.btnMonthlyTopBooksRead.Click += new System.EventHandler(this.btnMonthlyTopBooksRead_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWeeklyTheMostPunished);
            this.groupBox2.Controls.Add(this.btnMonthlyTheMostPunished);
            this.groupBox2.Location = new System.Drawing.Point(272, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 167);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En Çok Ceza Yiyenler";
            // 
            // btnWeeklyTheMostPunished
            // 
            this.btnWeeklyTheMostPunished.Location = new System.Drawing.Point(73, 103);
            this.btnWeeklyTheMostPunished.Name = "btnWeeklyTheMostPunished";
            this.btnWeeklyTheMostPunished.Size = new System.Drawing.Size(88, 30);
            this.btnWeeklyTheMostPunished.TabIndex = 3;
            this.btnWeeklyTheMostPunished.Text = "Haftalık";
            this.btnWeeklyTheMostPunished.UseVisualStyleBackColor = true;
            this.btnWeeklyTheMostPunished.Click += new System.EventHandler(this.btnWeeklyTheMostPunished_Click);
            // 
            // btnMonthlyTheMostPunished
            // 
            this.btnMonthlyTheMostPunished.Location = new System.Drawing.Point(73, 46);
            this.btnMonthlyTheMostPunished.Name = "btnMonthlyTheMostPunished";
            this.btnMonthlyTheMostPunished.Size = new System.Drawing.Size(88, 28);
            this.btnMonthlyTheMostPunished.TabIndex = 2;
            this.btnMonthlyTheMostPunished.Text = "Aylık ";
            this.btnMonthlyTheMostPunished.UseVisualStyleBackColor = true;
            this.btnMonthlyTheMostPunished.Click += new System.EventHandler(this.btnMonthlyTheMostPunished_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWeeklyThoseWhoDontPayPenalties);
            this.groupBox3.Controls.Add(this.btnMonthlyThoseWhoDontPayPenalties);
            this.groupBox3.Location = new System.Drawing.Point(509, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 167);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ceza Ödemeyenler";
            // 
            // btnWeeklyThoseWhoDontPayPenalties
            // 
            this.btnWeeklyThoseWhoDontPayPenalties.Location = new System.Drawing.Point(78, 103);
            this.btnWeeklyThoseWhoDontPayPenalties.Name = "btnWeeklyThoseWhoDontPayPenalties";
            this.btnWeeklyThoseWhoDontPayPenalties.Size = new System.Drawing.Size(83, 30);
            this.btnWeeklyThoseWhoDontPayPenalties.TabIndex = 5;
            this.btnWeeklyThoseWhoDontPayPenalties.Text = "Haftalık";
            this.btnWeeklyThoseWhoDontPayPenalties.UseVisualStyleBackColor = true;
            this.btnWeeklyThoseWhoDontPayPenalties.Click += new System.EventHandler(this.btnWeeklyThoseWhoDontPayPenalties_Click);
            // 
            // btnMonthlyThoseWhoDontPayPenalties
            // 
            this.btnMonthlyThoseWhoDontPayPenalties.Location = new System.Drawing.Point(78, 46);
            this.btnMonthlyThoseWhoDontPayPenalties.Name = "btnMonthlyThoseWhoDontPayPenalties";
            this.btnMonthlyThoseWhoDontPayPenalties.Size = new System.Drawing.Size(83, 28);
            this.btnMonthlyThoseWhoDontPayPenalties.TabIndex = 4;
            this.btnMonthlyThoseWhoDontPayPenalties.Text = "Aylık ";
            this.btnMonthlyThoseWhoDontPayPenalties.UseVisualStyleBackColor = true;
            this.btnMonthlyThoseWhoDontPayPenalties.Click += new System.EventHandler(this.btnMonthlyThoseWhoDontPayPenalties_Click);
            // 
            // dgwRapor
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwRapor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwRapor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwRapor.Location = new System.Drawing.Point(47, 421);
            this.dgwRapor.Name = "dgwRapor";
            this.dgwRapor.Size = new System.Drawing.Size(662, 150);
            this.dgwRapor.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnWeeklyBooksOutOfStock);
            this.groupBox4.Controls.Add(this.btnMonthlyBooksOutOfStock);
            this.groupBox4.Location = new System.Drawing.Point(47, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 163);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stok Yetersizliğinden Alınamayan Kitaplar";
            // 
            // btnWeeklyBooksOutOfStock
            // 
            this.btnWeeklyBooksOutOfStock.Location = new System.Drawing.Point(69, 106);
            this.btnWeeklyBooksOutOfStock.Name = "btnWeeklyBooksOutOfStock";
            this.btnWeeklyBooksOutOfStock.Size = new System.Drawing.Size(88, 30);
            this.btnWeeklyBooksOutOfStock.TabIndex = 7;
            this.btnWeeklyBooksOutOfStock.Text = "Haftalık";
            this.btnWeeklyBooksOutOfStock.UseVisualStyleBackColor = true;
            this.btnWeeklyBooksOutOfStock.Click += new System.EventHandler(this.btnWeeklyBooksOutOfStock_Click);
            // 
            // btnMonthlyBooksOutOfStock
            // 
            this.btnMonthlyBooksOutOfStock.Location = new System.Drawing.Point(69, 49);
            this.btnMonthlyBooksOutOfStock.Name = "btnMonthlyBooksOutOfStock";
            this.btnMonthlyBooksOutOfStock.Size = new System.Drawing.Size(88, 28);
            this.btnMonthlyBooksOutOfStock.TabIndex = 6;
            this.btnMonthlyBooksOutOfStock.Text = "Aylık ";
            this.btnMonthlyBooksOutOfStock.UseVisualStyleBackColor = true;
            this.btnMonthlyBooksOutOfStock.Click += new System.EventHandler(this.btnMonthlyBooksOutOfStock_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnVipAccount);
            this.groupBox5.Location = new System.Drawing.Point(272, 229);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(216, 163);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vip Hesaplar";
            // 
            // btnVipAccount
            // 
            this.btnVipAccount.Location = new System.Drawing.Point(73, 73);
            this.btnVipAccount.Name = "btnVipAccount";
            this.btnVipAccount.Size = new System.Drawing.Size(88, 28);
            this.btnVipAccount.TabIndex = 8;
            this.btnVipAccount.Text = "Listele";
            this.btnVipAccount.UseVisualStyleBackColor = true;
            this.btnVipAccount.Click += new System.EventHandler(this.btnVipAccount_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnBlockedAccount);
            this.groupBox6.Location = new System.Drawing.Point(509, 229);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(216, 163);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bloke Hesaplar";
            // 
            // btnBlockedAccount
            // 
            this.btnBlockedAccount.Location = new System.Drawing.Point(78, 73);
            this.btnBlockedAccount.Name = "btnBlockedAccount";
            this.btnBlockedAccount.Size = new System.Drawing.Size(83, 28);
            this.btnBlockedAccount.TabIndex = 10;
            this.btnBlockedAccount.Text = "Listele";
            this.btnBlockedAccount.UseVisualStyleBackColor = true;
            this.btnBlockedAccount.Click += new System.EventHandler(this.btnBlockedAccount_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgwRapor);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RaporForm";
            this.Text = "Rapor Form";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwRapor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgwRapor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnWeeklyTopBooksRead;
        private System.Windows.Forms.Button btnMonthlyTopBooksRead;
        private System.Windows.Forms.Button btnWeeklyTheMostPunished;
        private System.Windows.Forms.Button btnMonthlyTheMostPunished;
        private System.Windows.Forms.Button btnWeeklyThoseWhoDontPayPenalties;
        private System.Windows.Forms.Button btnMonthlyThoseWhoDontPayPenalties;
        private System.Windows.Forms.Button btnWeeklyBooksOutOfStock;
        private System.Windows.Forms.Button btnMonthlyBooksOutOfStock;
        private System.Windows.Forms.Button btnVipAccount;
        private System.Windows.Forms.Button btnBlockedAccount;
    }
}