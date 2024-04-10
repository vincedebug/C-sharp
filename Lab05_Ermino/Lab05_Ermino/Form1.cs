using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Ermino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void computeButton_Click(object sender, EventArgs e)
        {
            // Declaring Variables
            double itemPriceDouble, interestRateDouble, downPaymentDouble, totalDueDouble, monthlyFeeDouble, interestFeeDouble;
            const double PROCESS_FEE_DOUBLE = 350.0;
            const double TAX_RATE_DOUBLE = 0.03;
            int planMonthsInteger;
            

            // getting the input from the user and assigning a variable
            itemPriceDouble = double.Parse(itemPriceTextBox.Text);
            planMonthsInteger = int.Parse(planMonthsTextBox.Text);
            interestRateDouble = double.Parse(interestRateTextBox.Text);
            downPaymentDouble = double.Parse(downPaymentTextBox.Text);


            // my own solution to the problem
            itemPriceDouble -= downPaymentDouble;

            interestFeeDouble =  ((itemPriceDouble / planMonthsInteger) * (interestRateDouble/100) ) * planMonthsInteger;

            totalDueDouble = (((interestFeeDouble * planMonthsInteger) * TAX_RATE_DOUBLE) + (interestFeeDouble * planMonthsInteger)) + PROCESS_FEE_DOUBLE;

            monthlyFeeDouble = totalDueDouble / planMonthsInteger;

            /*
            monthlyFeeDouble = itemPriceDouble / planMonthsInteger;
            interestFeeDouble = monthlyFeeDouble * (interestRateDouble / 100.0);
            monthlyFeeDouble += interestFeeDouble;

            totalDueDouble = monthlyFeeDouble * planMonthsInteger + PROCESS_FEE_DOUBLE;
            totalDueDouble += totalDueDouble * TAX_RATE_DOUBLE;
            totalDueDouble -= downPaymentDouble;

            monthlyFeeDouble = totalDueDouble / planMonthsInteger;

            */
            // Display The Output
            monthlyInterestTextBox.Text = $"Php. {interestFeeDouble:N2}";
            totalDueTextBox.Text = $"Php. {totalDueDouble:N2}";
            monthlyFee.Text = $"Php. {monthlyFeeDouble:N2}"; 
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }



        }
    }
}
