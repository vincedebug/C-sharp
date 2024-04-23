/*Project Name: Invoice Calculator
 * Developed by: Vince Ferreras Ermino
 * Date Accomplished: 4/21/2024
 * Description: This is a simple Invoice calculator 
 * for people running their own business 
 * or working in a financial or accounting department 
 * It displays the Discount Percent and discount amount and the total amount. 
 */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Ermino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string strCustomerType;
            string strMessage;
            decimal decSubTotal;
            decimal decDiscountPercent = .0m;

            if (txtCustomerType.Text == string.Empty)
            {
                MessageBox.Show("Invalid Customer Type. Customer Type must not be blank",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }// end if.

            if (txtSubTotal.Text != "") // Not blank.
            {
                try
                {
                    strCustomerType = txtCustomerType.Text;

                    decSubTotal = decimal.Parse(txtSubTotal.Text);

                    if (strCustomerType == "R")
                    {
                        if (decSubTotal < 100)
                            decDiscountPercent = .0m;
                        else if (decSubTotal >= 100 && decSubTotal < 250)
                            decDiscountPercent = .1m;
                        else if (decSubTotal >= 250)
                            decDiscountPercent = .25m;
                    } // end if
                    else if (strCustomerType == "C")
                    {
                        if (decSubTotal < 250)
                            decDiscountPercent = .2m;
                        else
                            decDiscountPercent = .3m;
                    } // end else if
                    else
                    {
                        decDiscountPercent = .4m;
                    } // end else

                    decimal discountAmount = decSubTotal * decDiscountPercent;
                    decimal invoiceTotal = decSubTotal - discountAmount;

                    txtDiscountPercent.Text = decDiscountPercent.ToString("p1");
                    txtDiscountAmount.Text = discountAmount.ToString("c");
                    txtTotal.Text = invoiceTotal.ToString("c");

                    txtCustomerType.Focus();
                } // end try
                catch // Nonnumeric data.
                {
                    strMessage = "Nonnumeric data entered for sub total.";
                    MessageBox.Show(strMessage, "Data Entry Error");
                } // end catch
            } // end if 
            else // for missing data.
            {
                strMessage = "The quantity is required. ";
                MessageBox.Show(strMessage, "Data entry error");
            } // end else
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



