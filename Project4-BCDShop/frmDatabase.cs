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
        /// <param name="onOrOff"></param>
        /// <param name="sender"></param>
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
    }
}
