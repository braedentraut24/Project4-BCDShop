using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_BCDShop
{
    public partial class frmDatabase : Form
    {
        Classes.ProductDB dbFunctions = new Classes.ProductDB();

        String creationStage = "create";

        public frmDatabase()
        {
            InitializeComponent();
            dtpReleaseDate.MaxDate = DateTime.Now;
        }

        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
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

                    creationStage = "create";
                    btnCreateBook.Text = "Create Book";
                    lblPanelBook.Enabled = false;
                    pnlBook.Enabled = false;

                    toggleProductControls(false);
                    toggleDataControls(true);
                    toggleTransactionButtons(true, sender);

                    string fullISBN = txtISBNLeft.Text + txtISBNRight.Text;

                    dbFunctions.InsertProduct(Convert.ToInt32(txtUPC.Text), Convert.ToDecimal(txtPrice.Text),
                    txtTitle.Text, Convert.ToInt32(txtQuantity.Text), "Book");
                    dbFunctions.InsertBook(Convert.ToInt32(txtUPC.Text), Convert.ToInt32(fullISBN), txtAuthor.Text, Convert.ToInt32(txtPages.Text));

                    btnClearForm_Click(sender, new EventArgs());

                    


                    break;

                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
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
        /// Toggles the transaction choice buttons, but keeps the "sender" button active.
        /// </summary>
        /// <param name="onOrOff"> Set to true to enable, false to disable. </param>
        /// <param name="sender"> This should be the sender parameter from the same method this method is called in. </param>
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
                    creationStage = "create";
                    btnCreateDVD.Text = "Create DVD";
                    pnlDVD.Enabled = false;
                    lblPanelDVD.Enabled = false;

                    toggleProductControls(false);
                    toggleDataControls(true);
                    toggleTransactionButtons(true, sender);
                    btnClearForm_Click(sender, new EventArgs());
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
                    break;
                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        // Validate Product data
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


    }
}
