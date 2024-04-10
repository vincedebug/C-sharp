/* Project:     
 * Date: April 3, 2024
 * Programmer: Vince Ermino
 * Description: This project inputs sales information for clothing.
 * It Calculates the extended price and discount for a sale.
 * Uses variables, constants, and calculations.
 * Note that no error trapping is included in this version 
 * of the program
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


// 

namespace Lab06_Ermino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declare the constant
        private const decimal DEC_DISCOUNT_RATE = 0.3M;
        private decimal decTotalAmount;
        private int intNumberTransactions;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate the discount and amount due.
            // Declare the variables.

            int intQuantity;
            decimal decPrice, decExtendedPrice,
                decDiscount, decAmountDue;

            try
            {
                // Convert input values to numeric and assign
                intQuantity = int.Parse(txtQuantity.Text);

                try
                {
                    decPrice = decimal.Parse(txtPrice.Text);

                    // Calculate values.
                    decExtendedPrice = intQuantity * decPrice;
                    decDiscount = Decimal.Round((decExtendedPrice * DEC_DISCOUNT_RATE), 2);
                    decAmountDue = decExtendedPrice - decDiscount;
                    decTotalAmount += decAmountDue;
                    intNumberTransactions++;

                    // Formal and Display answers.
                    txtExtendedPrice.Text = decExtendedPrice.ToString("C");
                    txtDiscount.Text = decDiscount.ToString("N");
                    txtAmountDue.Text = decAmountDue.ToString("C");

                    // Format and Display summary information
                    txtTotalAmount.Text = decTotalAmount.ToString("C");
                    txtNumberTransactions.Text  = intNumberTransactions.ToString();

                }   


                catch
                {
                    // Invalid Price.
                    MessageBox.Show("Invalid Price.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrice.Focus();
                    txtPrice.SelectAll();
                }
            }
            catch
            {
                // Invalid quantity.
                MessageBox.Show("Invalid quantity.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantity.Focus();
                txtQuantity.SelectAll();
            }

            decTotalAmount = 0m;
            intNumberTransactions = 0;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtExtendedPrice.Clear();
            txtAmountDue.Clear();
            txtQuantity.Focus();

            decTotalAmount = 0m;
            intNumberTransactions = 0; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // end the program.
            this.Close();
        }
    }
}
