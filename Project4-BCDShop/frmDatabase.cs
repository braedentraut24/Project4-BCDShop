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
                    
                    toggleTopLevelControls(true);
                    lblPanelBook.Enabled = true;
                    pnlBook.Enabled = true;
                    btnCreateBookCIS.Enabled = false;
                    btnCreateDVD.Enabled = false;
                    btnCreateCDOrchl.Enabled = false;
                    btnCreateCDChmbr.Enabled = false;
                    pnlDataControls.Enabled = false;
                    lblPanelDataControls.Enabled = false;
                    break;
                case "save":
                    creationStage = "create";
                    btnCreateBook.Text = "Create Book";
                    toggleTopLevelControls(false);
                    lblPanelBook.Enabled = false;
                    pnlBook.Enabled = false;
                    btnCreateBookCIS.Enabled = true;
                    btnCreateDVD.Enabled = true;
                    btnCreateCDOrchl.Enabled = true;
                    btnCreateCDChmbr.Enabled = true;
                    pnlDataControls.Enabled = true;
                    lblPanelDataControls.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Error occured, close the program.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void toggleTopLevelControls(bool onOrOff)
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

        private void toggleTransactionButtons(bool onOrOff)
        {
            if (onOrOff == true)
            {

            }
        }
    }
}
