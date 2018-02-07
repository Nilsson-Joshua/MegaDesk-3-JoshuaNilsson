using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_4_JoshuaNilsson;

namespace MegaDesk_3_JoshuaNilsson
{
    public partial class AddQuote : Form
    {
        // initialized for use
        string CustomerName = string.Empty;
        MaterialTypes MaterialTypes;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int DrawerCount = 0;
        int OrderDays = 0;
        int TotalCost = 0;

        public AddQuote()
        {
            InitializeComponent();
            //AddQuoteMaterialType.Items.Add("Laminate");
            //AddQuoteMaterialType.Items.Add("Oak");
            //AddQuoteMaterialType.Items.Add("Rosewood");
            //AddQuoteMaterialType.Items.Add("Veneer");
            //AddQuoteMaterialType.Items.Add("Pine");

            AddQuoteDays.Items.Add("3");
            AddQuoteDays.Items.Add("5");
            AddQuoteDays.Items.Add("7");
            AddQuoteDays.Items.Add("14");

            List<MaterialTypes> MaterialTypesList = Enum.GetValues(typeof(MaterialTypes))
                .Cast<MaterialTypes>().ToList();
            AddQuoteMaterialType.DataSource = MaterialTypesList;

        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            // Suggestions from meeting with Brother Blazzard:
            // embed within try-catch for error handling
            try
            {
                CustomerName = addQuoteCustomerInput.Text;
                // get width depth rush materials methods calculations and return integer, etc. (in DeskQuote.cs)
                // make sure to int.parse text boxes! so, find names of input fields
                DeskWidth = int.Parse(addQuoteWidthInput.Text);
                DeskDepth = int.Parse(addQuoteDepthInput.Text);
                DrawerCount = int.Parse(addQuoteDrawerCountInput.Text);

                string MaterialType = AddQuoteMaterialType.Items.ToString();
                Enum.TryParse(MaterialType, out MaterialTypes);

                OrderDays = int.Parse(AddQuoteDays.Items.ToString());

                // new object OrderQuote that will take all of the methods within DeskQuote for this order
                DeskQuote OrderQuote = new DeskQuote(DeskWidth, DeskDepth, DrawerCount, MaterialType, OrderDays);

                // takes new object of DeskQuote and gets the Calculated Total from DeskQuote methods
                TotalCost = OrderQuote.CalculateTotalCost();
            }
            catch (Exception ex)
            {
                // produces error 'Input string was not in a correct format'
                MessageBox.Show(ex.Message, "Please verify input field values.");
                throw;
            }

            // referencing weekly virtual lab recording - this saves a file with variable values
            try
            {
                var DeskRecord = CustomerName + ", " + DeskWidth + ", " + DeskDepth + ", "
                                 + DrawerCount + ", " + MaterialTypes + ", " + OrderDays + ", " + TotalCost;

                string cFile = @"quotes.txt";

                // if does not exist, create quotes.txt file
                if (!File.Exists(cFile))
                {
                    StreamWriter sw = File.CreateText("quotes.txt");
                }
                // write the values to quotes.txt using DeskRecord
                using (StreamWriter sw = File.AppendText("quotes.txt"))
                {
                    sw.WriteLine(DeskRecord);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error with file creation or file text appending");
                throw;
            }

            // referenced brother blazzard's github repository
            var MainMenu = (MainMenu)Tag;
            DisplayQuote displayQuoteForm = new DisplayQuote(CustomerName, DeskWidth, DeskDepth,
                DrawerCount, MaterialTypes, OrderDays, TotalCost)
            {
                Tag = MainMenu
            };

            displayQuoteForm.Show();
            this.Close();

        }

        private void DepthValidating(object sender, CancelEventArgs e)
        {
            // validate the depth field
            if (int.TryParse(addQuoteDepthInput.Text, out var depth))
            {
                if (depth < Desk.MINDEPTH || depth > Desk.MAXDEPTH)
                {
                    MessageBox.Show("Please enter a depth between " + Desk.MINDEPTH +
                                    " and " + Desk.MAXDEPTH);
                    addQuoteDepthInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid depth measurement as a whole number.");
            }
        }

        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void WidthValidating(object sender, CancelEventArgs e)
        {
            int width;
            // validate the width field
            if (int.TryParse(addQuoteWidthInput.Text, out width))
            {
                if (width < Desk.MINWIDTH || width > Desk.MAXWIDTH)
                {
                    MessageBox.Show("Please enter a width between " + Desk.MINWIDTH + 
                                    " and " + Desk.MAXWIDTH);
                    addQuoteWidthInput.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid width measurement as a whole number.");
            }
        }

        private void AddQuoteDrawerCountInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddQuoteDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddQuoteMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
