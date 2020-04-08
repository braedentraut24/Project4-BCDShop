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
            this.components = new System.ComponentModel.Container();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnCreateCDChmbr = new System.Windows.Forms.Button();
            this.btnCreateCDOrchl = new System.Windows.Forms.Button();
            this.btnCreateDVD = new System.Windows.Forms.Button();
            this.btnCreateBookCIS = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.tipEnteringData = new System.Windows.Forms.ToolTip(this.components);
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblPanelProduct = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.pnlTransactions.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(218, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(507, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Data Entry and Viewing Form for Book CD and DVD Shop";
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
            this.pnlTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 161);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(724, 24);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "To search, edit, or delete, enter a UPC and then click the transaction at the bot" +
    "tom.";
            // 
            // txtUPC
            // 
            this.txtUPC.Location = new System.Drawing.Point(60, 17);
            this.txtUPC.MaxLength = 5;
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(130, 30);
            this.txtUPC.TabIndex = 4;
            this.tipEnteringData.SetToolTip(this.txtUPC, "The UPC should be a five digit number that doesn\'t start with zero.");
            // 
            // tipEnteringData
            // 
            this.tipEnteringData.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tipEnteringData.ToolTipTitle = "Tip for Entering Data";
            // 
            // pnlProduct
            // 
            this.pnlProduct.Controls.Add(this.label1);
            this.pnlProduct.Controls.Add(this.panel1);
            this.pnlProduct.Controls.Add(this.txtQuantity);
            this.pnlProduct.Controls.Add(this.lblQuantity);
            this.pnlProduct.Controls.Add(this.txtTitle);
            this.pnlProduct.Controls.Add(this.lblTitle);
            this.pnlProduct.Controls.Add(this.txtPrice);
            this.pnlProduct.Controls.Add(this.lblPrice);
            this.pnlProduct.Controls.Add(this.lblUPC);
            this.pnlProduct.Controls.Add(this.txtUPC);
            this.pnlProduct.Font = new System.Drawing.Font("Gadugi", 10F);
            this.pnlProduct.Location = new System.Drawing.Point(12, 219);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(951, 477);
            this.pnlProduct.TabIndex = 5;
            // 
            // lblPanelProduct
            // 
            this.lblPanelProduct.AutoSize = true;
            this.lblPanelProduct.Location = new System.Drawing.Point(13, 205);
            this.lblPanelProduct.Name = "lblPanelProduct";
            this.lblPanelProduct.Size = new System.Drawing.Size(79, 24);
            this.lblPanelProduct.TabIndex = 6;
            this.lblPanelProduct.Text = "Product";
            // 
            // lblUPC
            // 
            this.lblUPC.AutoSize = true;
            this.lblUPC.Location = new System.Drawing.Point(3, 20);
            this.lblUPC.Name = "lblUPC";
            this.lblUPC.Size = new System.Drawing.Size(46, 20);
            this.lblUPC.TabIndex = 5;
            this.lblUPC.Text = "UPC:";
            this.lblUPC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(196, 20);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 20);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(252, 17);
            this.txtPrice.MaxLength = 1000;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(130, 30);
            this.txtPrice.TabIndex = 7;
            this.tipEnteringData.SetToolTip(this.txtPrice, "The price should not have a \'$\' symbol or commas.\r\nAlso, you must include two dec" +
        "imal values, even if they are zeroes.");
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(388, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 20);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(439, 17);
            this.txtTitle.MaxLength = 1000;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 30);
            this.txtTitle.TabIndex = 9;
            this.tipEnteringData.SetToolTip(this.txtTitle, "Make the product\'s title anything you want.\r\nIt just can\'t be over 1,000 letters " +
        "long!");
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(716, 20);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(801, 17);
            this.txtQuantity.MaxLength = 1000;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 30);
            this.txtQuantity.TabIndex = 11;
            this.tipEnteringData.SetToolTip(this.txtQuantity, "How many of this product do we have?\r\nNo decimal values allowed.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(60, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 60);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label1.Location = new System.Drawing.Point(56, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(3, 25);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(50, 20);
            this.lblISBN.TabIndex = 14;
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lblPanelProduct);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatabase";
            this.Text = "Book, CD, and DVD Shop";
            this.pnlTransactions.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Button btnCreateCDChmbr;
        private System.Windows.Forms.Button btnCreateCDOrchl;
        private System.Windows.Forms.Button btnCreateDVD;
        private System.Windows.Forms.Button btnCreateBookCIS;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.ToolTip tipEnteringData;
        private System.Windows.Forms.Panel pnlProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblPanelProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblISBN;
    }
}

