namespace Lab01_Ermino
{
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "New Student Added!";
            lblStatus.BackColor = Color.LightGreen;
            lblStatus.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Operation Cancelled";
            lblStatus.BackColor = Color.HotPink;
            lblStatus.Visible = true;
        }
    }
}