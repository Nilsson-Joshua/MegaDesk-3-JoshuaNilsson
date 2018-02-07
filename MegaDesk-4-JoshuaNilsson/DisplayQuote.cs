using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk_4_JoshuaNilsson;

namespace MegaDesk_3_JoshuaNilsson
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string custName, int width, int depth, int drawerCount, MaterialTypes materialsType, int orderDays, int totalCost)
        {
            InitializeComponent();

            // values will be displayed inside respective text boxes
            displayQuoteCustomer.Text = custName;
            displayQuoteWidth.Text = width.ToString();
            displayQuoteDepth.Text = depth.ToString();
            displayQuoteDrawerCount.Text = drawerCount.ToString();
            displayQuoteMaterial.Text = materialsType.ToString();
            displayQuoteTotal.Text = totalCost.ToString();
        }

        private void cancelDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            var addQuote = (AddQuote)Tag;
            addQuote.Show();
            Close();
        }
    }
}
