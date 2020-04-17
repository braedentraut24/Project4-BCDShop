using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_BCDShop.Classes
{
    class BookCIS : Book
    {
        private string hiddenAreas;

        public BookCIS(int UPC, decimal price, string title, int quantity,
            int ISBN, string authors, int pageCount, string areas) : base(UPC, price, title, quantity, ISBN, authors, pageCount)
        {
            this.hiddenAreas = areas;
        }

        public string BookCISAreas
        {
            get
            {
                return hiddenAreas;
            }
            set
            {
                hiddenAreas = value;
            }
        }


        public override void Save(frmDatabase f)
        {
            base.Save(f);
            hiddenAreas = f.comboCISArea.SelectedItem.ToString();
        }

        public override void Display(frmDatabase f)
        {
            base.Display(f);
            //Idk what to do with the dropdown
        }

        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "BookCIS Info: " + hiddenAreas;
            return s;
        }
    }
}
