using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4_BCDShop.Classes
{
    class CDOrchestra : CDClassical
    {
        private string hiddenConductor;

        // Parameterized Constructor
        public CDOrchestra(int UPC, decimal price, string title, int quantity,
            string label, string artists, string conductor) : base(UPC, price, title, quantity, label, artists)
        {
            this.hiddenConductor = conductor;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for CD Label
        public string CDOrchestraConductor
        {
            get
            {
                return hiddenConductor;
            }  // end get
            set   // (string value)
            {
                hiddenConductor = value;
            }  // end get
        }  // end Property



        // Save data from form to object
        public override void Save(frmDatabase f)
        {
            base.Save(f);
            hiddenConductor = f.txtConductor.Text;
        } // end Save


        // Display data in object on form
        public override void Display(frmDatabase f)
        {
            base.Display(f);
            f.txtConductor.Text = hiddenConductor;
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "CDOrchestra Info: " + hiddenConductor;
            return s;
        }
    }
}
