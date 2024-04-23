/* Project Name: Resort Booking Application
 * Developed by: Vince F. Ermino
 * Date Accomplished: 4/22/2024
 * Description: The application allows the user to enter the information for 
 * booking in a resort, it calculates the total due in accordance with the rooms and nights
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab09_Ermino
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        const int intMAX_PER_ROOM = 6;
        const decimal decDAILY_ROOM_CHARGE = 6275.0M;
        const decimal decTAX_RATE = 0.1625M;
        const decimal decDAILY_RESORT_FEE = 625.5M;
        const string strMAX_MSG = "You have exceeded the maximum guests per room";

        private int intTotalTransaction = 0;
        private int intTotalRooms = 0;
        private int intTotalGuests = 0;
        private decimal decTransactionAmount = 0;




        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare needed variables

            int intRoomReserved, intNights, intAdults,
            intChildren, intNumOfGuests;

            double dblRoomsRequired;

            decimal decTotalRoomCharge, decTax, decTotalResortFee, decTotalDue;

            string strEmptyTextMessage;

            
            // Check if all there are empty textbox
            if (txtRooms.Text == string.Empty || txtNights.Text == string.Empty || txtAdults.Text == string.Empty || txtChildren.Text == string.Empty)
            {
                strEmptyTextMessage = "The quantity is required. ";
                MessageBox.Show(strEmptyTextMessage, "Data entry error");

            }
            // check if all the textbox are not empty
            if (txtRooms.Text != string.Empty && txtNights.Text != string.Empty && txtAdults.Text != string.Empty && txtChildren.Text != string.Empty)
            {

                try
                {
                    // Get user data
                    intRoomReserved = int.Parse(txtRooms.Text);
                    intNights = int.Parse(txtNights.Text);
                    intAdults = int.Parse(txtAdults.Text);
                    intChildren = int.Parse(txtChildren.Text);

                    // Compute total number of guests
                    intNumOfGuests = intAdults + intChildren;

                    // Calculate number of rooms required
                    dblRoomsRequired = intNumOfGuests / (double)intMAX_PER_ROOM;

                    // Determine whether number of reserved rooms is 
                    // adequate and either display a message or 
                    // calculate and display the total charge
                    if (intRoomReserved < dblRoomsRequired)
                    {
                        MessageBox.Show(strMAX_MSG, "Treeline Resort",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Calculate charges
                        decTotalRoomCharge = intRoomReserved * intNights * decDAILY_ROOM_CHARGE;
                        decTax = decTotalRoomCharge * decTAX_RATE;
                        decTotalResortFee = intRoomReserved * intNights * decDAILY_RESORT_FEE;
                        decTotalDue = decTotalRoomCharge + decTax + decTotalResortFee;

                        // Display Charges
                        txtRoomCharge.Text = decTotalRoomCharge.ToString("n2");
                        txtTax.Text = decTax.ToString("n2");
                        txtResortFee.Text = decTotalResortFee.ToString("n2");
                        txtTotalDue.Text = decTotalDue.ToString("n2");

                        intTotalTransaction += 1;
                        intTotalRooms  += intRoomReserved;
                        intTotalGuests += intAdults + intChildren;
                        decTransactionAmount += decTotalDue;



    }
}

                catch(Exception error)
                {
                    
                    if (!IsNumeric(txtRooms.Text))
                    {
                        txtRooms.Clear();
                        txtRooms.Focus(); // Set focus to the 1st textbox
                        MessageBox.Show("Textbox must contain a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

            
                    if (!IsNumeric(txtNights.Text))
                    {
                        txtNights.Clear();
                        txtNights.Focus(); // Set focus to the 3rd textbox
                        MessageBox.Show("Textbox must contain a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    if (!IsNumeric(txtChildren.Text))
                    {
                        txtChildren.Clear();
                        txtChildren.Focus(); // Set focus to the 3rd textbox
                        MessageBox.Show("Textbox must contain a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    if (!IsNumeric(txtAdults.Text))
                    {
                        txtAdults.Clear();
                        txtAdults.Focus(); // Set focus to the 3rd textbox
                        MessageBox.Show("Textbox must contain a numeric value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }
                    // Handle any other exception that wasn't related to textbox validation
                    MessageBox.Show("An error occurred: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }

                

            }
            
            else // for missing data.
            {
                // Check if individual checkbox is empty
                // if its empty return the focus to that textbox

                if (txtRooms.Text == string.Empty)
                {
                    txtRooms.Focus();
                    return;
                }

                if (txtNights.Text == string.Empty)
                {
                    txtNights.Focus();
                    return;
                }
                if (txtAdults.Text == string.Empty)
                {
                    txtAdults.Focus();
                    return;
                }
                if (txtChildren.Text == string.Empty)
                {
                    txtChildren.Focus();
                    return;
                }
            } // end else



        }
                
        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _); // Try parsing as an integer
        }


        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRooms.Clear();
            txtNights.Clear();
            txtAdults.Clear();
            txtChildren.Clear(); 
            txtRoomCharge.Clear();
            txtTax.Clear();
            txtResortFee.Clear();
            txtTotalDue.Clear();
        }

        private void btnDailySummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Total Transaction {intTotalTransaction} \n" +
                $"Total Rooms {intTotalRooms} \n" +
                $"Total Guests {intTotalGuests} \n" +
                $"Transaction Amount {decTransactionAmount.ToString("n")}", 
                
                "Transaction Summary Today",
                
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
