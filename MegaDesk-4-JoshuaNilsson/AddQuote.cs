using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_JoshuaNilsson
{
    public partial class AddQuote : Form
    {
        private string CustomerName = string.Empty;
        // initialize width, depth, etc.
        // create new form window when "Add" button within AddQuote is selected, which will display
        // the output of width, depth, rushdays, materials, etc.
        // look at screenshots
        // Also, you need to include Materials within AddQuote. Again, look at screenshots for ideas

        public AddQuote()
        {
            InitializeComponent();
            AddQuoteMaterialType.Items.Add("Laminate");
            AddQuoteMaterialType.Items.Add("Oak");
            AddQuoteMaterialType.Items.Add("Rosewood");
            AddQuoteMaterialType.Items.Add("Veneer");
            AddQuoteMaterialType.Items.Add("Pine");

            AddQuoteDays.Items.Add("3");
            AddQuoteDays.Items.Add("5");
            AddQuoteDays.Items.Add("7");
            AddQuoteDays.Items.Add("14");
        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            CustomerName = addQuoteCustomerInput.Text;
            // embed within try
            // get width depth rush materials methods calculations and return integer, etc. (in DeskQuote.cs)
            // int.parse
            //DeskQuote DeskQuote = new DeskQuote(DeskWidth, DeskDepth, DeskNumDrawers, DeskMaterialType, DeskRushDays);
            //TotalCost = DeskQuote.CalculateTotalCost();
            DisplayQuote displayQuoteForm = new DisplayQuote();
            displayQuoteForm.Tag = this;
            displayQuoteForm.Show(this);
            Hide();
        }

        private void DepthValidating(object sender, CancelEventArgs e)
        {
            int depth;
            // validate the depth field
            if (int.TryParse(addQuoteDepthInput.Text, out depth))
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
