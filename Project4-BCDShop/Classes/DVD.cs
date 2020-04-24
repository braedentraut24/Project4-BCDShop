using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_BCDShop.Classes
{
    class DVD : Product
    {

        private int hiddenRunTime;
        private string hiddenActors;
        private DateTime hiddenReleaseDate;

        public DVD(int UPC, decimal price, string title, int quantity,
            string actors, DateTime releaseDate, int runTime) : base(UPC, price, title, quantity)
        {
            this.hiddenRunTime = runTime;
            this.hiddenActors = actors;
            this.hiddenReleaseDate = releaseDate;
        }

        public int BookISBN
        {
            get
            {
                return hiddenRunTime;
            }
            set
            {
                hiddenRunTime = value;
            }
        }

        public string BookAuthors
        {
            get
            {
                return hiddenActors;
            }
            set
            {
                hiddenActors = value;
            }
        }

        public DateTime DVDReleaseDate
        {
            get
            {
                return hiddenReleaseDate;
            }
            set
            {
                hiddenReleaseDate = value;
            }
        }

        public override void Save(frmDatabase f)
        {
            base.Save(f);
            hiddenRunTime = Convert.ToInt32(f.txtMins.Text);
            hiddenActors = f.txtLeadActors.Text;
            hiddenReleaseDate = f.dtpReleaseDate.Value;
        }

        public override void Display(frmDatabase f)
        {
            base.Display(f);
            f.txtLeadActors.Text = hiddenActors;
            f.txtMins.Text = hiddenRunTime.ToString();
            f.dtpReleaseDate.Value = hiddenReleaseDate;
        }

        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "DVD info: " + hiddenActors + hiddenRunTime.ToString() + hiddenReleaseDate.ToString();
            return s;
        }
    }
}
