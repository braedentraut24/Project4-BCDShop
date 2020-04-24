using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_BCDShop.Classes
{
    class CDChamber : CDClassical
    {
        private string hiddenInstruments;

        // Parameterized Constructor
        public CDChamber(int UPC, decimal price, string title, int quantity,
            string label, string artists, string instruments) : base(UPC, price, title, quantity, label, artists)
        {
            this.hiddenInstruments = instruments;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for CD Label
        public string CDChamberInstruments
        {
            get
            {
                return hiddenInstruments;
            }  // end get
            set   // (string value)
            {
                hiddenInstruments = value;
            }  // end get
        }  // end Property



        // Save data from form to object
        public override void Save(frmDatabase f)
        {
            base.Save(f);
            hiddenInstruments = f.txtInstruments.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmDatabase f)
        {
            base.Display(f);
            f.txtInstruments.Text = hiddenInstruments;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CDChamber Info: " + hiddenInstruments;
            return s;
        }
    }
}
