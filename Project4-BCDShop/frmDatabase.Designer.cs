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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblPanelProduct = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblISBNSplitter = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCISArea = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnlTransactions.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Location = new System.Drawing.Point(235, 9);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(507, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Data Entry and Viewing Form for Book CD and DVD Shop";
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Location = new System.Drawing.Point(10, 55);
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
            this.pnlTransactions.Location = new System.Drawing.Point(10, 82);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(951, 62);
            this.pnlTransactions.TabIndex = 2;
            // 
            // btnCreateCDChmbr
            // 
            this.btnCreateCDChmbr.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCDChmbr.Location = new System.Drawing.Point(801, 3);
            this.btnCreateCDChmbr.Name = "btnCreateCDChmbr";
            this.btnCreateCDChmbr.Size = new System.Drawing.Size(140, 55);
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
            this.btnCreateBook.Location = new System.Drawing.Point(7, 3);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(145, 55);
            this.btnCreateBook.TabIndex = 0;
            this.btnCreateBook.Text = "Create Book";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(119, 158);
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
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(801, 17);
            this.txtQuantity.MaxLength = 1000;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 30);
            this.txtQuantity.TabIndex = 11;
            this.tipEnteringData.SetToolTip(this.txtQuantity, "How many of this product do we have?\r\nNo decimal values allowed.");
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduct.Controls.Add(this.label6);
            this.pnlProduct.Controls.Add(this.panel3);
            this.pnlProduct.Controls.Add(this.label4);
            this.pnlProduct.Controls.Add(this.panel2);
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
            this.pnlProduct.Location = new System.Drawing.Point(10, 205);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(951, 443);
            this.pnlProduct.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label1.Location = new System.Drawing.Point(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Book:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lblISBNSplitter);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Location = new System.Drawing.Point(60, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 60);
            this.panel1.TabIndex = 12;
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
            // lblPanelProduct
            // 
            this.lblPanelProduct.AutoSize = true;
            this.lblPanelProduct.Location = new System.Drawing.Point(10, 190);
            this.lblPanelProduct.Name = "lblPanelProduct";
            this.lblPanelProduct.Size = new System.Drawing.Size(79, 24);
            this.lblPanelProduct.TabIndex = 6;
            this.lblPanelProduct.Text = "Product";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(59, 22);
            this.txtISBN.MaxLength = 3;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(51, 30);
            this.txtISBN.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 22);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 30);
            this.textBox1.TabIndex = 16;
            // 
            // lblISBNSplitter
            // 
            this.lblISBNSplitter.AutoSize = true;
            this.lblISBNSplitter.Location = new System.Drawing.Point(116, 25);
            this.lblISBNSplitter.Name = "lblISBNSplitter";
            this.lblISBNSplitter.Size = new System.Drawing.Size(16, 20);
            this.lblISBNSplitter.TabIndex = 17;
            this.lblISBNSplitter.Text = "-";
            this.lblISBNSplitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 22);
            this.textBox2.MaxLength = 1000;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(295, 30);
            this.textBox2.TabIndex = 14;
            this.tipEnteringData.SetToolTip(this.textBox2, "Make the product\'s title anything you want.\r\nIt just can\'t be over 1,000 letters " +
        "long!");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Author:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pages:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(674, 22);
            this.textBox3.MaxLength = 1000;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(82, 30);
            this.textBox3.TabIndex = 14;
            this.tipEnteringData.SetToolTip(this.textBox3, "How many of this product do we have?\r\nNo decimal values allowed.");
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboCISArea);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(110, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 49);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label4.Location = new System.Drawing.Point(110, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Book CIS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "CIS Area:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboCISArea
            // 
            this.comboCISArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCISArea.FormattingEnabled = true;
            this.comboCISArea.Items.AddRange(new object[] {
            "Algorithms",
            "Object Oriented Programming",
            "Data Structures",
            "Inheritance and Hierarchy"});
            this.comboCISArea.Location = new System.Drawing.Point(101, 14);
            this.comboCISArea.Name = "comboCISArea";
            this.comboCISArea.Size = new System.Drawing.Size(247, 28);
            this.comboCISArea.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(60, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 55);
            this.panel3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F);
            this.label6.Location = new System.Drawing.Point(60, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "DVD:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Lead Actor(s):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 30);
            this.textBox4.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Release Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(521, 18);
            this.dateTimePicker1.MaxDate = new System.DateTime(2020, 4, 10, 15, 52, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 30);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mins:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(717, 18);
            this.textBox5.MaxLength = 1000;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(82, 30);
            this.textBox5.TabIndex = 19;
            this.tipEnteringData.SetToolTip(this.textBox5, "How many of this product do we have?\r\nNo decimal values allowed.");
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboCISArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblISBNSplitter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
    }
}

