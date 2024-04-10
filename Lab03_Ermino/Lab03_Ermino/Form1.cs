namespace Lab03_Ermino
{
    public partial class lotCalculatorForm : Form
    {

        public lotCalculatorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    
        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal totalLotSize = decimal.Parse(tLotSizeTxtB.Text);
            decimal lotSold =  decimal.Parse(lotSoldTxtB.Text);
            decimal lotPrice = decimal.Parse(lotPriceTxtB.Text);

            decimal cost = ((totalLotSize * lotSold) * lotPrice) / 100;

            costTxtB.Text = cost.ToString("N2");

        }

        private void lotOwnerTxtb_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void costTxtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
