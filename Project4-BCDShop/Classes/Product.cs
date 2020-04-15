// Product Class
// Responsible for all processing related to a Product

// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016
// Modified June 17, 2017 by Frank Friedman
// Modified June 27, 2018 by Frank Friedman
// Modified June 16, 2019 by Frank Friedman

// This class contains the data and methods that are inherited
// by the Book, DVD and CD Classical classes

// Class Product must be inherited by another object to be used
// and can be serialized to a binary file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Project4_BCDShop
{
    [Serializable()]
    public abstract class Product
    {
        private int hiddenUPC;
        private decimal hiddenPrice;
        private string hiddenTitle;
        private int hiddenQuantity;

        // Parameterless Constructor
        public Product()
        {
            hiddenUPC = 0;
            hiddenPrice = 0.0m;
            hiddenTitle = "";
            hiddenQuantity = 0;
        }  // end Parameterless Constructor

        // Parameterized Constructor
        public Product(int UPC, decimal price, string title, int quantity)
        {
            hiddenUPC = UPC;
            hiddenPrice = price;
            hiddenTitle = title;
            hiddenQuantity = quantity;
        }  // end Parameterized Constructor


        // Accessor/Mutator for UPC
        public int ProductUPC
        {
            get
            {
                return hiddenUPC;
            } //  end get
            set   // (int value)
            {
                hiddenUPC = value;
            }  // end get
        }  // End Property


        // Accessor/Mutator for product price 
        public decimal ProductPrice
        {
            get
            {
                return hiddenPrice;
            } //  end get
            set
            {
                hiddenPrice = value;
            }  // end get
        }  // End Property


        // Accessor/mutator for product title
        public string ProductTitle
        {
            get
            {
                return hiddenTitle;
            }  // end get
            set   // (string value)
            {
                hiddenTitle = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for product quantity
        public int ProductQuantity
        {
            get
            {
                return hiddenQuantity;
            }  // end get
            set   // (DateTime value)
            {
                hiddenQuantity = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public virtual void Save(frmDatabase f)
        {
            hiddenUPC = Convert.ToInt32(f.txtUPC.Text);
            hiddenPrice = Convert.ToDecimal(f.txtPrice.Text);
            hiddenTitle = f.txtTitle.Text;
            hiddenQuantity = Convert.ToInt32(f.txtQuantity.Text);
        }  // end Save


        // Display data in object on form
        public virtual void Display(frmDatabase f)
        {
            f.txtUPC.Text = hiddenUPC.ToString();
            f.txtPrice.Text = hiddenPrice.ToString();
            f.txtTitle.Text = hiddenTitle;
            f.txtQuantity.Text = hiddenQuantity.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = "Object Type      : " + base.ToString() + "\n";
            s += "Product UPC      : " + hiddenUPC + "\n";
            s += "Product Title    : " + Convert.ToDecimal(hiddenPrice) + "\n";
            s += "Product Price    : " + hiddenTitle + "\n";
            s += "Product Quantity : " + Convert.ToInt32(hiddenQuantity);
            return s;
        }  // end ToString


        // Display product info in a MessageBox
        public void displayProductAsString(Product p)
        {
            string s = " ";
            s += "Product UPC       : " + p.hiddenUPC + "\n";
            s += "Product Title       : " + Convert.ToDecimal(p.hiddenPrice) + "\n";
            s += "Product Price      : " + p.hiddenTitle + "\n";
            s += "Product Quantity : " + Convert.ToInt32(p.hiddenQuantity);
            MessageBox.Show(s, "Display a Single Product in Product List");
        }

    } // end Product Class

} // end namespace

