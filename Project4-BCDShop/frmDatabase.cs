using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Project4_BCDShop
{
    public partial class frmDatabase : Form
    {
        private String creationStage = "create";
        private Classes.ProductDB dbFunctions = new Classes.ProductDB();

        private Boolean readyToSave = false;
        private Boolean readyToDelete = false;

        public frmDatabase()
        {
            InitializeComponent();
            dtpReleaseDate.MaxDate = DateTime.Now;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtUPC.Text = "";
            txtPrice.Text = "";
            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtISBNLeft.Text = "";
            txtISBNRight.Text = "";
            txtAuthor.Text = "";
            txtPages.Text = "";
            comboCISArea.Text = "";
            txtLeadActors.Text = "";
            txtMins.Text = "";
            txtLabel.Text = "";
            txtArtists.Text = "";
            txtConductor.Text = "";
            txtInstruments.Text = "";
            readyToDelete = false;
            readyToSave = false;
        }

        private void btnCreateBook_Click(object sender, EventArgs e)
        {
            switch (creationStage)
            {
                case "create":
                    creationStage = "save";
                    btnCreateBook.Text = "Save Book";
                    lblPanelBook.Enabled = true;
                    pnlBook.Enabled = true;

                    toggleProductControls(true);
                    toggleDataControls(false);
                    toggleTransactionButtons(false, sender);
                    break;

                case "save":

                    string fullISBN = txtISBNLeft.Text + txtISBNRight.Text;

                    if (ValidateProduct() && Validators.ValidateBook(fullISBN, txtAuthor.Text, txtPages.Text))
                    {
                        dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Decimal.Parse(txtPrice.Text),
                        txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "Book");
                        dbFunctions.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(fullISBN), txtAuthor.Text, Convert.ToInt32(txtPages.Text));

                        creationStage = "create";
                        btnCreateBook.Text = "Create Book";
                        lblPanelBook.Enabled = false;
                        pnlBook.Enabled = false;

                        toggleProductControls(false);
                        toggleDataControls(true);
                        toggleTransactionButtons(true, sender);
                        btnClearForm_Click(sender, new EventArgs());
                    }
                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnCreateBookCIS_Click(object sender, EventArgs e)
        {
            switch (creationStage)
            {
                case "create":
                    creationStage = "save";
                    btnCreateBookCIS.Text = "Save Book CIS";
                    pnlBook.Enabled = true;
                    lblPanelBook.Enabled = true;
                    pnlBookCIS.Enabled = true;
                    lblPanelBookCIS.Enabled = true;
                    comboCISArea.Text = "Test";

                    toggleTransactionButtons(false, sender);
                    toggleProductControls(true);
                    toggleDataControls(false);
                    break;

                case "save":
                    string fullISBN = txtISBNLeft.Text + txtISBNRight.Text;

                    if (ValidateProduct() && Validators.ValidateBookCIS(fullISBN, txtAuthor.Text, txtPages.Text, comboCISArea.Text))
                    {
                        dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Decimal.Parse(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "BookCIS");
                        dbFunctions.InsertBookCIS(Convert.ToInt32(txtUPC.Text), comboCISArea.Text);

                        creationStage = "create";
                        btnCreateBookCIS.Text = "Create Book CIS";
                        pnlBook.Enabled = false;
                        pnlBookCIS.Enabled = false;
                        lblPanelBook.Enabled = false;
                        lblPanelBookCIS.Enabled = false;

                        btnClearForm_Click(sender, new EventArgs());
                        toggleDataControls(true);
                        toggleProductControls(false);
                        toggleTransactionButtons(true, sender);
                    }
                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnCreateCDChmbr_Click(object sender, EventArgs e)
        {
            switch (creationStage)
            {
                case "create":
                    creationStage = "save";
                    btnCreateCDChmbr.Text = "Save CD Chamber";
                    pnlCDClassical.Enabled = true;
                    pnlChamber.Enabled = true;
                    lblPanelCDClassical.Enabled = true;
                    lblPanelChamber.Enabled = true;

                    toggleProductControls(true);
                    toggleTransactionButtons(false, sender);
                    toggleDataControls(false);
                    break;

                case "save":
                    if (ValidateProduct() && Validators.ValidateCDChamber(txtLabel.Text, txtArtists.Text, txtInstruments.Text))
                    {
                        dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Decimal.Parse(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "CDChamber");
                        dbFunctions.InsertCDChamber(Convert.ToInt32(txtUPC.Text), txtInstruments.Text);

                        creationStage = "create";
                        btnCreateCDChmbr.Text = "Create CD Chamber";
                        pnlCDClassical.Enabled = false;
                        pnlChamber.Enabled = false;
                        lblPanelCDClassical.Enabled = false;
                        lblPanelChamber.Enabled = false;

                        toggleProductControls(false);
                        toggleTransactionButtons(true, sender);
                        toggleDataControls(true);
                        btnClearForm_Click(sender, new EventArgs());
                    }
                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnCreateCDOrchl_Click(object sender, EventArgs e)
        {
            switch (creationStage)
            {
                case "create":
                    creationStage = "save";
                    btnCreateCDOrchl.Text = "Save CD Orchestral";
                    pnlCDClassical.Enabled = true;
                    pnlOrchestral.Enabled = true;
                    lblPanelCDClassical.Enabled = true;
                    lblPanelOrchestral.Enabled = true;

                    toggleProductControls(true);
                    toggleTransactionButtons(false, sender);
                    toggleDataControls(false);
                    break;

                case "save":
                    if (ValidateProduct() && Validators.ValidateCDOrchestra(txtLabel.Text, txtArtists.Text, txtConductor.Text))
                    {
                        dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Decimal.Parse(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "CDOrchestra");
                        dbFunctions.InsertCDOrchestra(Convert.ToInt32(txtUPC.Text), txtConductor.Text);

                        creationStage = "create";
                        btnCreateCDOrchl.Text = "Create CD Orchestral";
                        pnlCDClassical.Enabled = false;
                        pnlOrchestral.Enabled = false;
                        lblPanelCDClassical.Enabled = false;
                        lblPanelOrchestral.Enabled = false;

                        toggleProductControls(false);
                        toggleTransactionButtons(true, sender);
                        toggleDataControls(true);
                        btnClearForm_Click(sender, new EventArgs());
                    }
                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btnCreateDVD_Click(object sender, EventArgs e)
        {
            switch (creationStage)
            {
                case "create":
                    creationStage = "save";
                    btnCreateDVD.Text = "Save DVD";
                    pnlDVD.Enabled = true;
                    lblPanelDVD.Enabled = true;

                    toggleProductControls(true);
                    toggleDataControls(false);
                    toggleTransactionButtons(false, sender);
                    break;

                case "save":
                    if (ValidateProduct() && Validators.ValidateDVD(txtLeadActors.Text, dtpReleaseDate.Text, txtMins.Text))
                    {
                        dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Decimal.Parse(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "DVD");
                        dbFunctions.InsertDVD(Convert.ToInt32(txtUPC.Text), txtLeadActors.Text, dtpReleaseDate.Value, Convert.ToInt32(txtMins.Text));

                        creationStage = "create";
                        btnCreateDVD.Text = "Create DVD";
                        pnlDVD.Enabled = false;
                        lblPanelDVD.Enabled = false;

                        toggleProductControls(false);
                        toggleDataControls(true);
                        toggleTransactionButtons(true, sender);
                        btnClearForm_Click(sender, new EventArgs());
                    }
                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        private void btnEnterUPC_Click(object sender, EventArgs e)
        {
            bool temp = Validators.ValidateProductUPC(txtUPC.Text); //first make sure the format is correct
            if (temp)
            {
                bool found; // boolean reference for search success
                string pstring; // Product string updated upon product DB search call.
                Product prod;

                //  this returns an OleDbDataReader object, but you don't really need to use it
                //  the boolean flag and string that are returned are important
                //  pstring will hold the attributes of a product from the database in a single string, separated by newline characters
                //  split it below

                OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtUPC.Text), out found, out pstring);

                if (!found) //not found
                {
                    MessageBox.Show("Product not found");
                    txtUPC.Clear();
                    txtUPC.Focus();
                } // Creates a new product to display in form.
                else
                {
                    readyToDelete = true;
                    string[] attributes = pstring.Split('\n'); // splits product attributes into array

                    for (int i = 0; i < attributes.Length; i++)
                    {
                        attributes[i] = attributes[i].Trim('\r'); // clears "junk" from each field
                    }

                    

                    string ptype = attributes[4]; // gets the product type from this attribute and then creates new product to display in form

                    switch (ptype)
                    {
                        case "DVD":
                            prod = new Classes.DVD(Convert.ToInt32(attributes[0]), Convert.ToDecimal(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                                attributes[5], DateTime.Parse(attributes[6]), Convert.ToInt32(attributes[7]));
                            prod.Display(this);
                            break;

                        case "Book":
                            prod = new Classes.Book(Convert.ToInt32(attributes[0]), Decimal.Parse(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                                Convert.ToInt32(attributes[5]), attributes[6], Convert.ToInt32(attributes[7]));
                            prod.Display(this);
                            break;

                        case "BookCIS":
                            prod = new Classes.BookCIS(Convert.ToInt32(attributes[0]), Decimal.Parse(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                                Convert.ToInt32(attributes[5]), attributes[6], Convert.ToInt32(attributes[7]), attributes[8]);
                            prod.Display(this);
                            break;

                        case "CDOrchestra":
                            prod = new Classes.CDOrchestra(Convert.ToInt32(attributes[0]), Decimal.Parse(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                                attributes[5], attributes[6], attributes[7]);
                            prod.Display(this);
                            break;

                        case "CDChamber":
                            prod = new Classes.CDChamber(Convert.ToInt32(attributes[0]), Decimal.Parse(attributes[1]), attributes[2], Convert.ToInt32(attributes[3]),
                                attributes[5], attributes[6], attributes[7]);
                            prod.Display(this);
                            break;

                        default:
                            MessageBox.Show("Error displaying product, please close the program.", "Error Displaying Product",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Not a valid UPC");
            }
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Toggles the bottom panel and it's label
        /// </summary>
        /// <param name="onOrOff"> Set to true to enable, false to disable </param>
        private void toggleDataControls(bool onOrOff)
        {
            if (onOrOff == true)
            {
                pnlDataControls.Enabled = true;
                lblPanelDataControls.Enabled = true;
            }
            else
            {
                pnlDataControls.Enabled = false;
                lblPanelDataControls.Enabled = false;
            }
        }

        /// <summary>
        /// Toggles the controls on the top of the form that are in the "Product" panel.
        /// Does not toggle the UPC entrance box.
        /// </summary>
        /// <param name="onOrOff"> Set to true to enable, false to disable </param>
        private void toggleProductControls(bool onOrOff)
        {
            if (onOrOff == true)
            {
                txtPrice.Enabled = true;
                txtTitle.Enabled = true;
                txtQuantity.Enabled = true;

                lblPrice.Enabled = true;
                lblTitle.Enabled = true;
                lblQuantity.Enabled = true;
            }
            else
            {
                txtPrice.Enabled = false;
                txtTitle.Enabled = false;
                txtQuantity.Enabled = false;

                lblPrice.Enabled = false;
                lblTitle.Enabled = false;
                lblQuantity.Enabled = false;
            }
        }

        /// <summary>
        /// Toggles the transaction choice buttons, but keeps the "sender" button active.
        /// </summary>
        /// <param name="onOrOff"> Set to true to enable, false to disable. </param>
        /// <param name="sender"> This should be the sender parameter from the same button click handler method this method is called in. </param>
        private void toggleTransactionButtons(bool onOrOff, object sender)
        {
            if (onOrOff == true)
            {
                btnCreateBook.Enabled = true;
                btnCreateBookCIS.Enabled = true;
                btnCreateCDChmbr.Enabled = true;
                btnCreateCDOrchl.Enabled = true;
                btnCreateDVD.Enabled = true;
            }
            else
            {
                btnCreateBook.Enabled = false;
                btnCreateBookCIS.Enabled = false;
                btnCreateCDChmbr.Enabled = false;
                btnCreateCDOrchl.Enabled = false;
                btnCreateDVD.Enabled = false;
            }
            ((Button)sender).Enabled = true;
        }

        private bool ValidateProduct()
        {
            if (Validators.ValidateProductUPC(txtUPC.Text) == false)
            {
                txtUPC.Text = "";
                txtUPC.Focus();
                MessageBox.Show("Product UPC not valid. Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductPrice(txtPrice.Text) == false)
            {
                txtPrice.Text = "";
                txtPrice.Focus();
                MessageBox.Show("Product Price not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductTitle(txtTitle.Text) == false)
            {
                txtTitle.Text = "";
                txtTitle.Focus();
                MessageBox.Show("Product Title not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            if (Validators.ValidateProductQuantity(txtQuantity.Text) == false)
            {
                txtQuantity.Text = "";
                txtQuantity.Focus();
                MessageBox.Show("Product Quantity not valid.  Please check that all data is entered and valid.");
                return false;
            }  // end if
            return true;
        }   // end Validate Product data

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            readyToSave = true;
            
            bool found;
            string pstring;
            
            OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtUPC.Text), out found, out pstring);
            string[] attributes = pstring.Split('\n');
            string ptype = attributes[4];
            ptype = ptype.Trim('\r');
            toggleProductControls(true);
            switch (ptype)
            {
                case "Book":
                    pnlBook.Enabled = true;
                    lblPanelBook.Enabled = true;
                    break;
                case "BookCIS":
                    pnlBook.Enabled = true;
                    lblPanelBook.Enabled = true;
                    pnlBookCIS.Enabled = true;
                    lblPanelBookCIS.Enabled = true;
                    break;
                case "DVD":
                    pnlDVD.Enabled = true;
                    lblPanelDVD.Enabled = true;
                    break;
                case "CDOrchestra":
                    pnlCDClassical.Enabled = true;
                    lblPanelCDClassical.Enabled = true;
                    pnlOrchestral.Enabled = true;
                    lblPanelOrchestral.Enabled = true;
                    break;
                case "CDChamber":
                    pnlCDClassical.Enabled = true;
                    lblPanelCDClassical.Enabled = true;
                    pnlChamber.Enabled = true;
                    lblPanelChamber.Enabled = true;
                    break;
            }
        }

        private void btnSaveUpdates_Click(object sender, EventArgs e)
        {
            if (!readyToSave)
            {
                MessageBox.Show("You have not selected an object to update yet");
            }

            else
            {
                bool found;
                string pstring;
                OleDbDataReader odb = dbFunctions.SelectProductFromProduct(Convert.ToInt32(txtUPC.Text), out found, out pstring);
                string[] attributes = pstring.Split('\n');
                string ptype = attributes[4];
                ptype = ptype.Trim('\r');

                

                if (ptype == "Book")
                {
                    string fullISBN = txtISBNLeft.Text + txtISBNRight.Text;
                    if (ValidateProduct() && Validators.ValidateBook(fullISBN, txtAuthor.Text, txtPages.Text))
                    {
                        dbFunctions.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text));
                        dbFunctions.UpdateBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(fullISBN), txtAuthor.Text, Convert.ToInt32(txtPages.Text));
                        MessageBox.Show("Product Updated");
                        readyToSave = false;
                        readyToDelete = false;
                        btnClearForm_Click(sender, new EventArgs());
                    }
                }
                else if (ptype == "BookCIS")
                {
                    string fullISBN = txtISBNLeft.Text + txtISBNRight.Text;
                    if (ValidateProduct() && Validators.ValidateBookCIS(fullISBN, txtAuthor.Text, txtPages.Text, comboCISArea.Text))
                    {
                        dbFunctions.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text));
                        dbFunctions.UpdateBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(fullISBN), txtAuthor.Text, Convert.ToInt32(txtPages.Text));
                        dbFunctions.UpdateBookCIS(Convert.ToInt32(txtUPC.Text), comboCISArea.Text);
                        MessageBox.Show("Product Updated");
                        readyToSave = false;
                        readyToDelete = false;
                        btnClearForm_Click(sender, new EventArgs());
                    }
                }
                else if (ptype == "DVD")
                {
                    if (ValidateProduct() && Validators.ValidateDVD(txtLeadActors.Text, dtpReleaseDate.Text, txtMins.Text))
                    {
                        dbFunctions.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text));
                        dbFunctions.UpdateDVD(Convert.ToInt32(txtUPC.Text), txtLeadActors.Text, Convert.ToDateTime(dtpReleaseDate.Value.Date), Convert.ToInt32(txtMins.Text));
                        MessageBox.Show("Product Updated");
                        readyToSave = false;
                        readyToDelete = false;
                        btnClearForm_Click(sender, new EventArgs());
                    }
                }
                else if (ptype == "CDOrchestra")
                {
                    if (ValidateProduct() && Validators.ValidateCDOrchestra(txtLabel.Text, txtArtists.Text, txtConductor.Text))
                    {
                        dbFunctions.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text));
                        dbFunctions.UpdateCDClassical(Convert.ToInt32(txtUPC.Text), txtLabel.Text, txtArtists.Text);
                        dbFunctions.UpdateCDOrchestra(Convert.ToInt32(txtUPC.Text), txtConductor.Text);
                        MessageBox.Show("Product Updated");
                        readyToSave = false;
                        readyToDelete = false;
                        btnClearForm_Click(sender, new EventArgs());
                    }
                }
                else if (ptype == "CDChamber")
                {
                    if (ValidateProduct() && Validators.ValidateCDChamber(txtLabel.Text, txtArtists.Text, txtInstruments.Text))
                    {
                        dbFunctions.UpdateProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text), txtTitle.Text, Convert.ToInt32(txtQuantity.Text));
                        dbFunctions.UpdateCDClassical(Convert.ToInt32(txtUPC.Text), txtLabel.Text, txtArtists.Text);
                        dbFunctions.UpdateCDChamber(Convert.ToInt32(txtUPC.Text), txtInstruments.Text);
                        MessageBox.Show("Product Updated");
                        readyToSave = false;
                        readyToDelete = false;
                        btnClearForm_Click(sender, new EventArgs());
                    }
                }

                
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!readyToDelete)
            {
                MessageBox.Show("You have not selected an object to delete yet");
            }
            else
            {
                dbFunctions.Delete(Convert.ToInt32(txtUPC.Text));
                MessageBox.Show("Object successfully deleted");
                readyToDelete = false;
                btnClearForm_Click(sender, new EventArgs());
            }
        }
    }
}