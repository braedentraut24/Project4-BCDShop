// Validators Class
// Responsible for all validation processing.  Includes validators that are part of VB but not CSHarp 
// Written in CSharp by Frank Friedman     Spring 2016

// Revised: June 16, 2017
// Revised: June 27, 2018

// This class contains "static" methods to handle required data validations for this Temple Owl project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace Project4_BCDShop
{
    // This class cannot be instantiated
    // It contains a collection of methods called to validate all input data from our Form
    public static class Validators
    {
        // Validate Form data for a Product
        public static bool ValidateProduct
           (string UPC, string price, string title, string quantity)
        {
            if (ValidateProductUPC(UPC) && ValidateProductPrice(price) && ValidateProductTitle(title) && ValidateProductQuantity(quantity))
                return true;
            else
                return false;
        }  // end ValidateProduct

        public static bool ValidateBook(string ISBN, string authors, string pageCount)
        {
            if (ValidateBookISBN(ISBN) && ValidateBookAuthors(authors) && ValidateBookPageCount(pageCount))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool ValidateBookCIS(string ISBN, string authors, string pageCount, string CISAreas)
        {
            if (ValidateBook(ISBN, authors, pageCount) && ValidateBookCISAreas(CISAreas))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateDVD(string actors, string releaseDate, string runTime)
        {
            if (ValidateDVDActors(actors) && ValidateDVDReleaseDate(releaseDate) && ValidateDVDRunTime(runTime))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCDClassical(string label, string artists)
        {
            if (ValidateCDLabel(label) && ValidateCDArtists(artists))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCDOrchestra(string label, string artists, string conductor)
        {
            if (ValidateCDClassical(label, artists) && ValidateCDConductor(conductor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateCDChamber(string label, string artists, string instruments)
        {
            if (ValidateCDClassical(label, artists) && ValidateCDInstruments(instruments))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Validate Product UPC
        public static bool ValidateProductUPC
            (string UPC)    // IN: Product's UPC (must be a 5 digit value with no preceding 0)
        {
            if (UPC == "" || UPC.Length != 5)
            {
                MessageBox.Show("Product UPC was blank or not exactly 5 characters. Re-enter.", "Product UPC Error");
                return false;
            }  // end Product UP blank

            if (UPC[0] == '0')
            {
                MessageBox.Show("Product UPC was began with a 0. Re-enter.", "Product UPC Error");
                return false;
            }

            // Using Regex to validate the Product UPC text box to contain exactly 5 digits 
            if (!System.Text.RegularExpressions.Regex.IsMatch(UPC, @"^[0-9]{5}$"))
            {
                MessageBox.Show("Product UPC must be a 5 digit value with no leading zeros. Reenter.",
                    "Regex Product UPC Error");
                return false;
            }  // end Product UPC Regex test
            return true;   // Passed all tests
        }  // end Validate ProductUPC

        public static bool ValidateProductPrice(string price)
        {
            if (price == "")
            {
                MessageBox.Show("Product UPC was blank. Re-enter.", "Product price Error");
                return false;
            }


            if (!System.Text.RegularExpressions.Regex.IsMatch(price, @"^[0-9]+\.[0-9]{2}"))
            {
                MessageBox.Show("Product UPC must be a decimal value that is not 0. Reenter.",
                        "Regex Product Price Error");
                return false;
            }

            if (Convert.ToDecimal(price) == 0.00m)
            {
                MessageBox.Show("Product price must not be 0. Re-enter.", "Product price Error");
                return false;
            }
            return true;
        }

        public static bool ValidateProductTitle(string title)
        {
            if (title == "")
            {
                MessageBox.Show("Product Title was blank. Re-enter.", "Product title Error");
                return false;
            }

            return true;
        }

        public static bool ValidateProductQuantity(string quantity)
        {
            if (quantity == "")
            {
                MessageBox.Show("Product quantity was blank. Re-enter.", "Product quantity Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(quantity, @"^\d+$"))
            {
                MessageBox.Show("Product UPC must be an integer value that is not 0. Reenter.",
                        "Regex Product quantity Error");
                return false;
            }

            if (Convert.ToInt32(quantity) <= 0)
            {
                MessageBox.Show("Product quanity must be greater than 0. Re-enter.", "Product quantity Error");
            }

            return true;
        }

        public static bool ValidateBookISBN(string ISBN)
        {
            if (ISBN == "")
            {
                MessageBox.Show("Book ISBN was blank. Re-enter.", "Book ISBN Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(ISBN, @"^\d{6}$"))
            {
                MessageBox.Show("Book ISBN must be an integer value that is 6 digits long. Reenter.",
                        "Regex Book ISBN Error");
                return false;
            }

            return true;
        }

        public static bool ValidateBookAuthors(string authors)
        {
            if (authors == "")
            {
                MessageBox.Show("Book Author(s) was blank. Re-enter.", "Book Authors Error");
                return false;
            }



            if (!System.Text.RegularExpressions.Regex.IsMatch(authors, @"^(?:[A-Z][a-z]+ [A-Z][a-z]+(?:, |$))+$"))
            {
                MessageBox.Show("Book Author(s) must have a first and last name both capitalized, if there is more than 1 name separate them by commas. Reenter.",
                        "Regex Book Author Error");
                return false;
            }

            return true;
        }

        public static bool ValidateBookPageCount(string pageCount)
        {
            if (pageCount == "")
            {
                MessageBox.Show("Book page count was blank. Re-enter.", "Book page count Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(pageCount, @"^\d+$"))
            {
                MessageBox.Show("Book page count must be an integer value that is not 0. Reenter.",
                        "Regex Book page count Error");
                return false;
            }

            if (Convert.ToInt32(pageCount) <= 0)
            {
                MessageBox.Show("Book page count must be greater than 0. Re-enter.", "Book page count Error");
                return false;
            }

            return true;
        }

        public static bool ValidateBookCISAreas(string areas)
        {
            if (areas == "")
            {
                MessageBox.Show("BookCIS areas was blank. Re-enter.", "Book page count Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(areas, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("BookCIS areas must a list of one word areas separated by spaces with only alphabet characters. Reenter.",
                        "Regex BookCIS areas Error");
                return false;
            }

            return true;
        }

        public static bool ValidateDVDActors(string actors)
        {
            if (actors == "")
            {
                MessageBox.Show("DVD Actors was blank. Re-enter.", "DVD Actors count Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(actors, @"^(?:[A-Z][a-z]+ [A-Z][a-z]+(?:, |$))+$"))
            {
                MessageBox.Show("DVD Actors must have a first and last name both capitalized, if there is more than 1 name separate them by commas. Reenter.",
                        "Regex DVD Actors Error");
                return false;
            }

            return true;
        }

        public static bool ValidateDVDReleaseDate(string date)
        {
            if (date == "")
            {
                MessageBox.Show("DVD release date was blank. Re-enter.", "DVD release date count Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(date, @"^\d{1,2}\/\d{1,2}\/\d{4}$"))
            {
                MessageBox.Show("DVD release date must be in MM/DD/YYYY format. Reenter.",
                        "DVD release date Error");
                return false;
            }

            if (Convert.ToDateTime(date) < Convert.ToDateTime("01/01/1980") || Convert.ToDateTime(date) > DateTime.Now)
            {
                MessageBox.Show("DVD release date must be after January 1st 1980 and before todays date. Reenter.",
                        "DVD release date Error");
                return false;
            }

            return true;
        }

        public static bool ValidateDVDRunTime(string time)
        {
            if (time == "")
            {
                MessageBox.Show("DVD run time was blank. Re-enter.", "DVD run time count Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(time, @"^\d+$"))
            {
                MessageBox.Show("DVD run time must be an integer value. Reenter.",
                        "Regex DVD run time Error");
                return false;
            }

            if (Convert.ToInt32(time) <= 0 || Convert.ToInt32(time) >= 240)
            {
                MessageBox.Show("DVD run time must be between 0 and 240. Reenter.",
                        "Regex DVD run time Error");
                return false;
            }

            return true;
        }

        public static bool ValidateCDLabel(string label)
        {
            if (label == "")
            {
                MessageBox.Show("CD label was blank. Re-enter.", "CD label Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(label, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("CD labels must a list of one word areas separated by spaces with only alphabet characters. Reenter.",
                        "Regex CD label Error");
                return false;
            }

            return true;
        }

        public static bool ValidateCDArtists(string artists)
        {
            if (artists == "")
            {
                MessageBox.Show("CD artists was blank. Re-enter.", "CD artists Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(artists, @"^(?:[A-Z][a-z]+ [A-Z][a-z]+(?:, |$))+$"))
            {
                MessageBox.Show("CD artists must have a first and last name both capitalized, if there is more than 1 name separate them by commas. Reenter.",
                        "Regex CD artists Error");
                return false;
            }

            return true;
        }

        public static bool ValidateCDConductor(string conductor)
        {
            if (conductor == "")
            {
                MessageBox.Show("CD conductor was blank. Re-enter.", "CD conductor Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(conductor, @"^[A-Z][a-z]+ [A-Z][-a-zA-Z]+$"))
            {
                MessageBox.Show("CD conductor must have a first and last name both capitalized. Reenter.",
                        "Regex CD conductor Error");
                return false;
            }

            return true;
        }

        public static bool ValidateCDInstruments(string instruments)
        {
            if (instruments == "")
            {
                MessageBox.Show("CD instruments was blank. Re-enter.", "CD artists Error");
                return false;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(instruments, @"^(?:\D+(?:, |$))+$"))
            {
                MessageBox.Show("CD instruments may not have anything but alphabet characters and spaces, if there is more than 1 instrument separate them by commas. Reenter.",
                        "Regex CD artists Error");
                return false;
            }

            return true;
        }

    }

}



