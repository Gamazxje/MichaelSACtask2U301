namespace MichaelSACtask_2
{
    partial class Form1
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
            this.btnFile = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.textBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(79, 124);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(167, 51);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Choose a file";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textBook,
            this.subject,
            this.seller,
            this.purchaser,
            this.purchasePrice,
            this.salePrice,
            this.profit});
            this.dgvSales.Location = new System.Drawing.Point(28, 230);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.RowHeadersWidth = 82;
            this.dgvSales.RowTemplate.Height = 33;
            this.dgvSales.Size = new System.Drawing.Size(1283, 396);
            this.dgvSales.TabIndex = 1;
            // 
            // textBook
            // 
            this.textBook.HeaderText = "Text Book";
            this.textBook.MinimumWidth = 10;
            this.textBook.Name = "textBook";
            this.textBook.Width = 200;
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 10;
            this.subject.Name = "subject";
            this.subject.Width = 200;
            // 
            // seller
            // 
            this.seller.HeaderText = "Seller";
            this.seller.MinimumWidth = 10;
            this.seller.Name = "seller";
            this.seller.Width = 200;
            // 
            // purchaser
            // 
            this.purchaser.HeaderText = "Purchaser";
            this.purchaser.MinimumWidth = 10;
            this.purchaser.Name = "purchaser";
            this.purchaser.Width = 200;
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 10;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.Width = 200;
            // 
            // salePrice
            // 
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.MinimumWidth = 10;
            this.salePrice.Name = "salePrice";
            this.salePrice.Width = 200;
            // 
            // profit
            // 
            this.profit.HeaderText = "Profit";
            this.profit.MinimumWidth = 10;
            this.profit.Name = "profit";
            this.profit.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1350, 728);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn textBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
    }
}

