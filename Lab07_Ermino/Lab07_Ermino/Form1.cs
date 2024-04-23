using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Ermino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private decimal decTotal;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            decimal decItemPrice, decQuantityOrdered;
            decimal decSubTotal = 0m;

            try
            {
                decItemPrice = decimal.Parse(txtItemPrice.Text);
                
            } 
            
            catch 
            {
                MessageBox.Show("Invalid Quantity.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItemPrice.Clear();
                txtItemPrice.Focus();
                return;
            }

            try
            {
                decQuantityOrdered = decimal.Parse(txtQuantityOrdered.Text);

                decSubTotal = decItemPrice * decQuantityOrdered;

                txtSubTotal.Text = decSubTotal.ToString("N");
            }

            catch
            {
                MessageBox.Show("Invalid Quantity.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantityOrdered.Clear();
                txtQuantityOrdered.Focus();
                return;
            }


            decTotal += decSubTotal;
            txtTotalBill.Text = decTotal.ToString("N");

            decSubTotal = 0m;

           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemPrice.Clear();
            txtQuantityOrdered.Clear();
            txtSubTotal.Clear();
            txtTotalBill.Clear();

            decTotal = 0m;
        }
    }
}
