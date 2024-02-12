using System.Drawing.Printing;
using System.Security.AccessControl;

namespace Lab02_Ermino
{
    public partial class frmGradeCalculator : Form
    {
        public frmGradeCalculator()
        {
            InitializeComponent();
        }

        private const decimal DEC_HOMEWORKS = .1M;
        private const decimal DEC_PROJECTS = .35M;
        private const decimal DEC_QUIZZES = .1M;
        private const decimal DEC_EXAMS = .3M;
        private const decimal DEC_FINAL_EXAM = .15M;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            decimal decHomework, decProjects,
                    decQuizzes, decExams, decFinalExam;

            decimal decWeightedAverage;

            // Get input from the textboxes;
            decHomework = decimal.Parse(txtHomework.Text);
            decProjects = decimal.Parse(txtProject.Text);
            decQuizzes = decimal.Parse(txtQuiz.Text);
            decExams = decimal.Parse(txtExams.Text);
            decFinalExam = decimal.Parse(txtFinalExam.Text);

            // Perform Calculation
            decWeightedAverage = (decHomework * DEC_HOMEWORKS) +
                (decProjects * DEC_PROJECTS) +
                (decQuizzes * DEC_QUIZZES) +
                (decExams * DEC_EXAMS) +
                (decFinalExam * DEC_FINAL_EXAM);

            // Display Weighted Average
            txtWeightedAverage.Text = decWeightedAverage.ToString("N5");


        }

        private void frmGradeCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Remove contents from textboxes during runtime
            txtHomework.Clear();
            txtProject.Clear();
            txtQuiz.Clear();    
            txtExams.Clear();
            txtFinalExam.Clear();
            txtWeightedAverage.Clear();

            // Move mouse cursor  to the homework textboxes
            txtHomework.Focus();
        }
    }
}
