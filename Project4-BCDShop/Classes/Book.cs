using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_BCDShop.Classes
{
    class Book : Product
    {

        private int hiddenISBN;
        private string hiddenAuthors;
        private int hiddenPageCount;

        public Book(int UPC, decimal price, string title, int quantity, 
            int ISBN, string authors, int pageCount) : base(UPC, price, title, quantity)
        {
            this.hiddenISBN = ISBN;
            this.hiddenAuthors = authors;
            this.hiddenPageCount = pageCount;
        }

        public int BookISBN
        {
            get
            {
                return hiddenISBN;
            }
            set
            {
                hiddenISBN = value;
            }
        }

        public string BookAuthors
        {
            get
            {
                return hiddenAuthors;
            }
            set
            {
                hiddenAuthors = value;
            }
        }

        public int BookPageCount
        {
            get
            {
                return hiddenPageCount;
            }
            set
            {
                hiddenPageCount = value;
            }
        }

        public override void Save(frmDatabase f)
        {
            base.Save(f);
            string fullISBN = f.txtISBNLeft.Text + f.txtISBNRight.Text;
            hiddenISBN = Convert.ToInt32(fullISBN);
            hiddenAuthors = f.txtAuthor.Text;
            hiddenPageCount = Convert.ToInt32(f.txtPages);
        }

        public override void Display(frmDatabase f)
        {
            base.Display(f);
            int leftISBN = hiddenISBN / 1000;
            int rightISBN = hiddenISBN % 1000;
            f.txtISBNLeft.Text = leftISBN.ToString();
            f.txtISBNRight.Text = rightISBN.ToString();
            f.txtAuthor.Text = hiddenAuthors;
            f.txtPages.Text = hiddenPageCount.ToString();
        }

        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Book Info: " + hiddenISBN + hiddenAuthors + hiddenPageCount;
            return s;
        }
    }
}
