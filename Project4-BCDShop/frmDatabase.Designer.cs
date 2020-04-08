namespace Project4_BCDShop
{
    partial class frmDatabase
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnCreateCDChmbr = new System.Windows.Forms.Button();
            this.btnCreateCDOrchl = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.pnlTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(218, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(507, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Data Entry and Viewing Form for Book CD and DVD Shop";
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Location = new System.Drawing.Point(8, 55);
            this.lblTransactions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(254, 24);
            this.lblTransactions.TabIndex = 1;
            this.lblTransactions.Text = "Choose a transaction below:";
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.btnCreateCDChmbr);
            this.pnlTransactions.Controls.Add(this.btnCreateCDOrchl);
            this.pnlTransactions.Controls.Add(this.btnCreateDVD);
            this.pnlTransactions.Controls.Add(this.btnCreateBookCIS);
            this.pnlTransactions.Controls.Add(this.btnCreateBook);
            this.pnlTransactions.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTransactions.Location = new System.Drawing.Point(12, 82);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(958, 62);
            this.pnlTransactions.TabIndex = 2;
            // 
            // btnCreateCDChmbr
            // 
            this.btnCreateCDChmbr.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCDChmbr.Location = new System.Drawing.Point(810, 3);
            this.btnCreateCDChmbr.Name = "btnCreateCDChmbr";
            this.btnCreateCDChmbr.Size = new System.Drawing.Size(145, 55);
            this.btnCreateCDChmbr.TabIndex = 4;
            this.btnCreateCDChmbr.Text = "Create CD Chamber";
            this.btnCreateCDChmbr.UseVisualStyleBackColor = true;
            // 
            // btnCreateCDOrchl
            // 
            this.btnCreateCDOrchl.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCDOrchl.Location = new System.Drawing.Point(603, 3);
            this.btnCreateCDOrchl.Name = "btnCreateCDOrchl";
            this.btnCreateCDOrchl.Size = new System.Drawing.Size(145, 55);
            this.btnCreateCDOrchl.TabIndex = 3;
            this.btnCreateCDOrchl.Text = "Create CD Orchestral";
            this.btnCreateCDOrchl.UseVisualStyleBackColor = true;
            // 
            // btnCreateDVD
            // 
            this.btnCreateDVD.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDVD.Location = new System.Drawing.Point(395, 3);
            this.btnCreateDVD.Name = "btnCreateDVD";
            this.btnCreateDVD.Size = new System.Drawing.Size(145, 55);
            this.btnCreateDVD.TabIndex = 2;
            this.btnCreateDVD.Text = "Create DVD";
            this.btnCreateDVD.UseVisualStyleBackColor = true;
            // 
            // btnCreateBookCIS
            // 
            this.btnCreateBookCIS.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBookCIS.Location = new System.Drawing.Point(193, 3);
            this.btnCreateBookCIS.Name = "btnCreateBookCIS";
            this.btnCreateBookCIS.Size = new System.Drawing.Size(145, 55);
            this.btnCreateBookCIS.TabIndex = 1;
            this.btnCreateBookCIS.Text = "Create CIS Book";
            this.btnCreateBookCIS.UseVisualStyleBackColor = true;
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateBook.Location = new System.Drawing.Point(4, 3);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(145, 55);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatabase";
            this.Text = "Book, CD, and DVD Shop";
            this.pnlTransactions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Button btnCreateCDChmbr;
        private System.Windows.Forms.Button btnCreateCDOrchl;
        private System.Windows.Forms.Button btnCreateDVD;
        private System.Windows.Forms.Button btnCreateBookCIS;
        private System.Windows.Forms.Button btnCreateBook;
    }
}

