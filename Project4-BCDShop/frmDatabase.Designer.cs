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
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.txtMins = new System.Windows.Forms.TextBox();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtLeadActors = new System.Windows.Forms.TextBox();
            this.comboCISArea = new System.Windows.Forms.ComboBox();
            this.txtISBNRight = new System.Windows.Forms.TextBox();
            this.txtISBNLeft = new System.Windows.Forms.TextBox();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.lblPanelChamber = new System.Windows.Forms.Label();
            this.pnlChamber = new System.Windows.Forms.Panel();
            this.lblInstruments = new System.Windows.Forms.Label();
            this.lblPanelOrchestral = new System.Windows.Forms.Label();
            this.pnlOrchestral = new System.Windows.Forms.Panel();
            this.lblConductor = new System.Windows.Forms.Label();
            this.lblPanelCDClassical = new System.Windows.Forms.Label();
            this.pnlCDClassical = new System.Windows.Forms.Panel();
            this.lblArtists = new System.Windows.Forms.Label();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblPanelDVD = new System.Windows.Forms.Label();
            this.pnlDVD = new System.Windows.Forms.Panel();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblReleaseDate = new System.Windows.Forms.Label();
            this.lblLeadActors = new System.Windows.Forms.Label();
            this.lblPanelBookCIS = new System.Windows.Forms.Label();
            this.pnlBookCIS = new System.Windows.Forms.Panel();
            this.lblCISArea = new System.Windows.Forms.Label();
            this.lblPanelBook = new System.Windows.Forms.Label();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.lblPages = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblISBNSplitter = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUPC = new System.Windows.Forms.Label();
            this.lblPanelProduct = new System.Windows.Forms.Label();
            this.pnlDataControls = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveUpdates = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnterUPC = new System.Windows.Forms.Button();
            this.lblDataProcess2 = new System.Windows.Forms.Label();
            this.lblDataProcess1 = new System.Windows.Forms.Label();
            this.lblPanelDataControls = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.txtInstruments = new System.Windows.Forms.TextBox();
            this.pnlTransactions.SuspendLayout();
            this.pnlProduct.SuspendLayout();
            this.pnlChamber.SuspendLayout();
            this.pnlOrchestral.SuspendLayout();
            this.pnlCDClassical.SuspendLayout();
            this.pnlDVD.SuspendLayout();
            this.pnlBookCIS.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlDataControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(240, 9);
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
            this.btnCreateBook.Click += new System.EventHandler(this.btnCreateBook_Click);
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
            this.txtPrice.Enabled = false;
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
            this.txtTitle.Enabled = false;
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
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(790, 20);
            this.txtQuantity.MaxLength = 1000;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 30);
            this.txtQuantity.TabIndex = 11;
            this.tipEnteringData.SetToolTip(this.txtQuantity, "How many of this product do we have?\r\nNo decimal values allowed.");
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(300, 22);
            this.txtAuthor.MaxLength = 1000;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(338, 30);
            this.txtAuthor.TabIndex = 14;
            this.tipEnteringData.SetToolTip(this.txtAuthor, "Enter the full names of authors.\r\nUse commas to separate their names if more than" +
        " one.");
            // 
            // txtPages
            // 
            this.txtPages.Location = new System.Drawing.Point(729, 22);
            this.txtPages.MaxLength = 1000;
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(82, 30);
            this.txtPages.TabIndex = 14;
            this.tipEnteringData.SetToolTip(this.txtPages, "How many pages are in the book.");
            // 
            // txtMins
            // 
            this.txtMins.Location = new System.Drawing.Point(729, 18);
            this.txtMins.MaxLength = 1000;
            this.txtMins.Name = "txtMins";
            this.txtMins.Size = new System.Drawing.Size(82, 30);
            this.txtMins.TabIndex = 19;
            this.tipEnteringData.SetToolTip(this.txtMins, "The runtime of the CD in minutes.");
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(7, 44);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(365, 30);
            this.txtConductor.TabIndex = 1;
            this.tipEnteringData.SetToolTip(this.txtConductor, "Enter only one conductor\'s name.\r\nYou can make it last name only, or a full name." +
        "\r\nHyphens are allowed.");
            // 
            // txtArtists
            // 
            this.txtArtists.Location = new System.Drawing.Point(355, 22);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(456, 30);
            this.txtArtists.TabIndex = 26;
            this.tipEnteringData.SetToolTip(this.txtArtists, "Enter the full name of the artists.\r\nSeparate names with a comma if more than one" +
        ".");
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(67, 22);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(210, 30);
            this.txtLabel.TabIndex = 24;
            this.tipEnteringData.SetToolTip(this.txtLabel, "What label released this CD?");
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(521, 18);
            this.dtpReleaseDate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(135, 30);
            this.dtpReleaseDate.TabIndex = 22;
            this.tipEnteringData.SetToolTip(this.dtpReleaseDate, "Choose the release date in the calendar picker below.");
            this.dtpReleaseDate.Value = new System.DateTime(2020, 4, 10, 0, 0, 0, 0);
            // 
            // txtLeadActors
            // 
            this.txtLeadActors.Location = new System.Drawing.Point(120, 18);
            this.txtLeadActors.Name = "txtLeadActors";
            this.txtLeadActors.Size = new System.Drawing.Size(278, 30);
            this.txtLeadActors.TabIndex = 20;
            this.tipEnteringData.SetToolTip(this.txtLeadActors, "Enter the full names of actors.\r\nUse commas to separate names if more than one.\r\n" +
        "");
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
            this.tipEnteringData.SetToolTip(this.comboCISArea, "Choose one of the possible areas in the dropdown box.");
            // 
            // txtISBNRight
            // 
            this.txtISBNRight.Location = new System.Drawing.Point(138, 22);
            this.txtISBNRight.MaxLength = 3;
            this.txtISBNRight.Name = "txtISBNRight";
            this.txtISBNRight.Size = new System.Drawing.Size(51, 30);
            this.txtISBNRight.TabIndex = 16;
            this.tipEnteringData.SetToolTip(this.txtISBNRight, "This is the \"right side\" of the ISBN");
            // 
            // txtISBNLeft
            // 
            this.txtISBNLeft.Location = new System.Drawing.Point(59, 22);
            this.txtISBNLeft.MaxLength = 3;
            this.txtISBNLeft.Name = "txtISBNLeft";
            this.txtISBNLeft.Size = new System.Drawing.Size(51, 30);
            this.txtISBNLeft.TabIndex = 15;
            this.tipEnteringData.SetToolTip(this.txtISBNLeft, "This is the \"left side\" of the ISBN.");
            // 
            // pnlProduct
            // 
            this.pnlProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProduct.Controls.Add(this.lblPanelChamber);
            this.pnlProduct.Controls.Add(this.pnlChamber);
            this.pnlProduct.Controls.Add(this.lblPanelOrchestral);
            this.pnlProduct.Controls.Add(this.pnlOrchestral);
            this.pnlProduct.Controls.Add(this.lblPanelCDClassical);
            this.pnlProduct.Controls.Add(this.pnlCDClassical);
            this.pnlProduct.Controls.Add(this.lblPanelDVD);
            this.pnlProduct.Controls.Add(this.pnlDVD);
            this.pnlProduct.Controls.Add(this.lblPanelBookCIS);
            this.pnlProduct.Controls.Add(this.pnlBookCIS);
            this.pnlProduct.Controls.Add(this.lblPanelBook);
            this.pnlProduct.Controls.Add(this.pnlBook);
            this.pnlProduct.Controls.Add(this.txtQuantity);
            this.pnlProduct.Controls.Add(this.lblQuantity);
            this.pnlProduct.Controls.Add(this.txtTitle);
            this.pnlProduct.Controls.Add(this.lblTitle);
            this.pnlProduct.Controls.Add(this.txtPrice);
            this.pnlProduct.Controls.Add(this.lblPrice);
            this.pnlProduct.Controls.Add(this.txtUPC);
            this.pnlProduct.Controls.Add(this.lblUPC);
            this.pnlProduct.Font = new System.Drawing.Font("Gadugi", 10F);
            this.pnlProduct.Location = new System.Drawing.Point(10, 205);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(951, 506);
            this.pnlProduct.TabIndex = 5;
            // 
            // lblPanelChamber
            // 
            this.lblPanelChamber.AutoSize = true;
            this.lblPanelChamber.Enabled = false;
            this.lblPanelChamber.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelChamber.Location = new System.Drawing.Point(460, 380);
            this.lblPanelChamber.Name = "lblPanelChamber";
            this.lblPanelChamber.Size = new System.Drawing.Size(89, 24);
            this.lblPanelChamber.TabIndex = 22;
            this.lblPanelChamber.Text = "Chamber";
            this.lblPanelChamber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChamber
            // 
            this.pnlChamber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChamber.Controls.Add(this.txtInstruments);
            this.pnlChamber.Controls.Add(this.lblInstruments);
            this.pnlChamber.Enabled = false;
            this.pnlChamber.Location = new System.Drawing.Point(460, 391);
            this.pnlChamber.Name = "pnlChamber";
            this.pnlChamber.Size = new System.Drawing.Size(423, 85);
            this.pnlChamber.TabIndex = 21;
            // 
            // lblInstruments
            // 
            this.lblInstruments.AutoSize = true;
            this.lblInstruments.Location = new System.Drawing.Point(1, 21);
            this.lblInstruments.Name = "lblInstruments";
            this.lblInstruments.Size = new System.Drawing.Size(104, 20);
            this.lblInstruments.TabIndex = 0;
            this.lblInstruments.Text = "Instruments:";
            // 
            // lblPanelOrchestral
            // 
            this.lblPanelOrchestral.AutoSize = true;
            this.lblPanelOrchestral.Enabled = false;
            this.lblPanelOrchestral.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelOrchestral.Location = new System.Drawing.Point(60, 380);
            this.lblPanelOrchestral.Name = "lblPanelOrchestral";
            this.lblPanelOrchestral.Size = new System.Drawing.Size(99, 24);
            this.lblPanelOrchestral.TabIndex = 21;
            this.lblPanelOrchestral.Text = "Orchestral";
            this.lblPanelOrchestral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrchestral
            // 
            this.pnlOrchestral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrchestral.Controls.Add(this.txtConductor);
            this.pnlOrchestral.Controls.Add(this.lblConductor);
            this.pnlOrchestral.Enabled = false;
            this.pnlOrchestral.Location = new System.Drawing.Point(60, 391);
            this.pnlOrchestral.Name = "pnlOrchestral";
            this.pnlOrchestral.Size = new System.Drawing.Size(383, 85);
            this.pnlOrchestral.TabIndex = 20;
            // 
            // lblConductor
            // 
            this.lblConductor.AutoSize = true;
            this.lblConductor.Location = new System.Drawing.Point(1, 21);
            this.lblConductor.Name = "lblConductor";
            this.lblConductor.Size = new System.Drawing.Size(94, 20);
            this.lblConductor.TabIndex = 0;
            this.lblConductor.Text = "Conductor:";
            // 
            // lblPanelCDClassical
            // 
            this.lblPanelCDClassical.AutoSize = true;
            this.lblPanelCDClassical.Enabled = false;
            this.lblPanelCDClassical.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelCDClassical.Location = new System.Drawing.Point(60, 290);
            this.lblPanelCDClassical.Name = "lblPanelCDClassical";
            this.lblPanelCDClassical.Size = new System.Drawing.Size(113, 24);
            this.lblPanelCDClassical.TabIndex = 19;
            this.lblPanelCDClassical.Text = "CD Classical";
            this.lblPanelCDClassical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCDClassical
            // 
            this.pnlCDClassical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCDClassical.Controls.Add(this.txtArtists);
            this.pnlCDClassical.Controls.Add(this.lblArtists);
            this.pnlCDClassical.Controls.Add(this.txtLabel);
            this.pnlCDClassical.Controls.Add(this.lblLabel);
            this.pnlCDClassical.Enabled = false;
            this.pnlCDClassical.Location = new System.Drawing.Point(60, 303);
            this.pnlCDClassical.Name = "pnlCDClassical";
            this.pnlCDClassical.Size = new System.Drawing.Size(823, 65);
            this.pnlCDClassical.TabIndex = 18;
            // 
            // lblArtists
            // 
            this.lblArtists.AutoSize = true;
            this.lblArtists.Location = new System.Drawing.Point(296, 25);
            this.lblArtists.Name = "lblArtists";
            this.lblArtists.Size = new System.Drawing.Size(60, 20);
            this.lblArtists.TabIndex = 25;
            this.lblArtists.Text = "Artists:";
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(8, 25);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(53, 20);
            this.lblLabel.TabIndex = 0;
            this.lblLabel.Text = "Label:";
            // 
            // lblPanelDVD
            // 
            this.lblPanelDVD.AutoSize = true;
            this.lblPanelDVD.Enabled = false;
            this.lblPanelDVD.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelDVD.Location = new System.Drawing.Point(60, 210);
            this.lblPanelDVD.Name = "lblPanelDVD";
            this.lblPanelDVD.Size = new System.Drawing.Size(50, 24);
            this.lblPanelDVD.TabIndex = 17;
            this.lblPanelDVD.Text = "DVD";
            this.lblPanelDVD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDVD
            // 
            this.pnlDVD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDVD.Controls.Add(this.txtMins);
            this.pnlDVD.Controls.Add(this.lblMins);
            this.pnlDVD.Controls.Add(this.dtpReleaseDate);
            this.pnlDVD.Controls.Add(this.lblReleaseDate);
            this.pnlDVD.Controls.Add(this.txtLeadActors);
            this.pnlDVD.Controls.Add(this.lblLeadActors);
            this.pnlDVD.Enabled = false;
            this.pnlDVD.Location = new System.Drawing.Point(60, 221);
            this.pnlDVD.Name = "pnlDVD";
            this.pnlDVD.Size = new System.Drawing.Size(823, 55);
            this.pnlDVD.TabIndex = 16;
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(662, 21);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(49, 20);
            this.lblMins.TabIndex = 23;
            this.lblMins.Text = "Mins:";
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.AutoSize = true;
            this.lblReleaseDate.Location = new System.Drawing.Point(404, 21);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(111, 20);
            this.lblReleaseDate.TabIndex = 21;
            this.lblReleaseDate.Text = "Release Date:";
            // 
            // lblLeadActors
            // 
            this.lblLeadActors.AutoSize = true;
            this.lblLeadActors.Location = new System.Drawing.Point(8, 21);
            this.lblLeadActors.Name = "lblLeadActors";
            this.lblLeadActors.Size = new System.Drawing.Size(112, 20);
            this.lblLeadActors.TabIndex = 19;
            this.lblLeadActors.Text = "Lead Actor(s):";
            this.lblLeadActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPanelBookCIS
            // 
            this.lblPanelBookCIS.AutoSize = true;
            this.lblPanelBookCIS.Enabled = false;
            this.lblPanelBookCIS.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelBookCIS.Location = new System.Drawing.Point(110, 136);
            this.lblPanelBookCIS.Name = "lblPanelBookCIS";
            this.lblPanelBookCIS.Size = new System.Drawing.Size(88, 24);
            this.lblPanelBookCIS.TabIndex = 15;
            this.lblPanelBookCIS.Text = "Book CIS";
            this.lblPanelBookCIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBookCIS
            // 
            this.pnlBookCIS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBookCIS.Controls.Add(this.comboCISArea);
            this.pnlBookCIS.Controls.Add(this.lblCISArea);
            this.pnlBookCIS.Enabled = false;
            this.pnlBookCIS.Location = new System.Drawing.Point(110, 148);
            this.pnlBookCIS.Name = "pnlBookCIS";
            this.pnlBookCIS.Size = new System.Drawing.Size(773, 49);
            this.pnlBookCIS.TabIndex = 14;
            // 
            // lblCISArea
            // 
            this.lblCISArea.AutoSize = true;
            this.lblCISArea.Location = new System.Drawing.Point(3, 17);
            this.lblCISArea.Name = "lblCISArea";
            this.lblCISArea.Size = new System.Drawing.Size(78, 20);
            this.lblCISArea.TabIndex = 19;
            this.lblCISArea.Text = "CIS Area:";
            this.lblCISArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPanelBook
            // 
            this.lblPanelBook.AutoSize = true;
            this.lblPanelBook.Enabled = false;
            this.lblPanelBook.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lblPanelBook.Location = new System.Drawing.Point(60, 60);
            this.lblPanelBook.Name = "lblPanelBook";
            this.lblPanelBook.Size = new System.Drawing.Size(55, 24);
            this.lblPanelBook.TabIndex = 13;
            this.lblPanelBook.Text = "Book";
            this.lblPanelBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBook
            // 
            this.pnlBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBook.Controls.Add(this.txtPages);
            this.pnlBook.Controls.Add(this.lblPages);
            this.pnlBook.Controls.Add(this.lblAuthor);
            this.pnlBook.Controls.Add(this.txtAuthor);
            this.pnlBook.Controls.Add(this.lblISBNSplitter);
            this.pnlBook.Controls.Add(this.txtISBNRight);
            this.pnlBook.Controls.Add(this.txtISBNLeft);
            this.pnlBook.Controls.Add(this.lblISBN);
            this.pnlBook.Enabled = false;
            this.pnlBook.Location = new System.Drawing.Point(60, 70);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(823, 60);
            this.pnlBook.TabIndex = 12;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(653, 25);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(58, 20);
            this.lblPages.TabIndex = 14;
            this.lblPages.Text = "Pages:";
            this.lblPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(216, 25);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 20);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author(s):";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblQuantity.Enabled = false;
            this.lblQuantity.Location = new System.Drawing.Point(705, 20);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Enabled = false;
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
            this.lblPrice.Enabled = false;
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
            // pnlDataControls
            // 
            this.pnlDataControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataControls.Controls.Add(this.btnDelete);
            this.pnlDataControls.Controls.Add(this.btnSaveUpdates);
            this.pnlDataControls.Controls.Add(this.btnEdit);
            this.pnlDataControls.Controls.Add(this.btnFind);
            this.pnlDataControls.Controls.Add(this.btnEnterUPC);
            this.pnlDataControls.Controls.Add(this.lblDataProcess2);
            this.pnlDataControls.Controls.Add(this.lblDataProcess1);
            this.pnlDataControls.Location = new System.Drawing.Point(10, 733);
            this.pnlDataControls.Name = "pnlDataControls";
            this.pnlDataControls.Size = new System.Drawing.Size(951, 131);
            this.pnlDataControls.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(790, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 47);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.Location = new System.Drawing.Point(603, 73);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(145, 47);
            this.btnSaveUpdates.TabIndex = 14;
            this.btnSaveUpdates.Text = "Save Updates";
            this.btnSaveUpdates.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(404, 73);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 47);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit / Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(200, 73);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(145, 47);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Find / Display";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnEnterUPC
            // 
            this.btnEnterUPC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEnterUPC.ForeColor = System.Drawing.Color.White;
            this.btnEnterUPC.Location = new System.Drawing.Point(7, 73);
            this.btnEnterUPC.Name = "btnEnterUPC";
            this.btnEnterUPC.Size = new System.Drawing.Size(145, 47);
            this.btnEnterUPC.TabIndex = 11;
            this.btnEnterUPC.Text = "Enter UPC";
            this.btnEnterUPC.UseVisualStyleBackColor = false;
            // 
            // lblDataProcess2
            // 
            this.lblDataProcess2.AutoSize = true;
            this.lblDataProcess2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataProcess2.ForeColor = System.Drawing.Color.Red;
            this.lblDataProcess2.Location = new System.Drawing.Point(4, 46);
            this.lblDataProcess2.Name = "lblDataProcess2";
            this.lblDataProcess2.Size = new System.Drawing.Size(606, 24);
            this.lblDataProcess2.TabIndex = 10;
            this.lblDataProcess2.Text = "Press the \"Clear Form\" button when the operation is complete.";
            // 
            // lblDataProcess1
            // 
            this.lblDataProcess1.AutoSize = true;
            this.lblDataProcess1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataProcess1.ForeColor = System.Drawing.Color.Red;
            this.lblDataProcess1.Location = new System.Drawing.Point(4, 22);
            this.lblDataProcess1.Name = "lblDataProcess1";
            this.lblDataProcess1.Size = new System.Drawing.Size(788, 24);
            this.lblDataProcess1.TabIndex = 9;
            this.lblDataProcess1.Text = "These items require an entry of an item UPC (above) before they can be executed.";
            // 
            // lblPanelDataControls
            // 
            this.lblPanelDataControls.AutoSize = true;
            this.lblPanelDataControls.Location = new System.Drawing.Point(10, 719);
            this.lblPanelDataControls.Name = "lblPanelDataControls";
            this.lblPanelDataControls.Size = new System.Drawing.Size(258, 24);
            this.lblPanelDataControls.TabIndex = 8;
            this.lblPanelDataControls.Text = "Controls for Data Processing";
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.Firebrick;
            this.btnClearForm.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.ForeColor = System.Drawing.Color.White;
            this.btnClearForm.Location = new System.Drawing.Point(10, 870);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(338, 47);
            this.btnClearForm.TabIndex = 16;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.Firebrick;
            this.btnExitProgram.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitProgram.ForeColor = System.Drawing.Color.White;
            this.btnExitProgram.Location = new System.Drawing.Point(623, 870);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(338, 47);
            this.btnExitProgram.TabIndex = 17;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // txtInstruments
            // 
            this.txtInstruments.Location = new System.Drawing.Point(5, 44);
            this.txtInstruments.Name = "txtInstruments";
            this.txtInstruments.Size = new System.Drawing.Size(406, 30);
            this.txtInstruments.TabIndex = 27;
            this.tipEnteringData.SetToolTip(this.txtInstruments, "Enter the names of instruments that played in this CD.\r\nSeparate instrument names" +
        " with a comma if more than one.");
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 920);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.lblPanelDataControls);
            this.Controls.Add(this.pnlDataControls);
            this.Controls.Add(this.lblPanelProduct);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlProduct);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Book, CD, and DVD Shop";
            this.pnlTransactions.ResumeLayout(false);
            this.pnlProduct.ResumeLayout(false);
            this.pnlProduct.PerformLayout();
            this.pnlChamber.ResumeLayout(false);
            this.pnlChamber.PerformLayout();
            this.pnlOrchestral.ResumeLayout(false);
            this.pnlOrchestral.PerformLayout();
            this.pnlCDClassical.ResumeLayout(false);
            this.pnlCDClassical.PerformLayout();
            this.pnlDVD.ResumeLayout(false);
            this.pnlDVD.PerformLayout();
            this.pnlBookCIS.ResumeLayout(false);
            this.pnlBookCIS.PerformLayout();
            this.pnlBook.ResumeLayout(false);
            this.pnlBook.PerformLayout();
            this.pnlDataControls.ResumeLayout(false);
            this.pnlDataControls.PerformLayout();
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
        internal System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.ToolTip tipEnteringData;
        private System.Windows.Forms.Panel pnlProduct;
        internal System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        internal System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUPC;
        private System.Windows.Forms.Label lblPanelProduct;
        private System.Windows.Forms.Label lblPanelBook;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPanelBookCIS;
        private System.Windows.Forms.Panel pnlBookCIS;
        private System.Windows.Forms.ComboBox comboCISArea;
        private System.Windows.Forms.Label lblCISArea;
        internal System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Label lblAuthor;
        internal System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblISBNSplitter;
        internal System.Windows.Forms.TextBox txtISBNRight;
        internal System.Windows.Forms.TextBox txtISBNLeft;
        private System.Windows.Forms.Label lblPanelDVD;
        private System.Windows.Forms.Panel pnlDVD;
        internal System.Windows.Forms.TextBox txtMins;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label lblReleaseDate;
        internal System.Windows.Forms.TextBox txtLeadActors;
        private System.Windows.Forms.Label lblLeadActors;
        private System.Windows.Forms.Label lblPanelChamber;
        private System.Windows.Forms.Panel pnlChamber;
        private System.Windows.Forms.Label lblInstruments;
        private System.Windows.Forms.Label lblPanelOrchestral;
        private System.Windows.Forms.Panel pnlOrchestral;
        internal System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.Label lblConductor;
        private System.Windows.Forms.Label lblPanelCDClassical;
        private System.Windows.Forms.Panel pnlCDClassical;
        internal System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label lblArtists;
        internal System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Panel pnlDataControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveUpdates;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEnterUPC;
        private System.Windows.Forms.Label lblDataProcess2;
        private System.Windows.Forms.Label lblDataProcess1;
        private System.Windows.Forms.Label lblPanelDataControls;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExitProgram;
        internal System.Windows.Forms.TextBox txtInstruments;
    }
}

