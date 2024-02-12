namespace Lab02_Ermino
{
    partial class frmGradeCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtHomework = new TextBox();
            txtProject = new TextBox();
            txtQuiz = new TextBox();
            txtExams = new TextBox();
            txtFinalExam = new TextBox();
            txtWeightedAverage = new TextBox();
            btnCompute = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 31);
            label1.Name = "label1";
            label1.Size = new Size(345, 29);
            label1.TabIndex = 0;
            label1.Text = "Grade Calculator by Sir Elvin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(49, 99);
            label2.Name = "label2";
            label2.Size = new Size(142, 19);
            label2.TabIndex = 1;
            label2.Text = "Homework Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(49, 149);
            label3.Name = "label3";
            label3.Size = new Size(113, 19);
            label3.TabIndex = 2;
            label3.Text = "Project Grade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(49, 197);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 3;
            label4.Text = "Quiz Grade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 246);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 4;
            label5.Text = "Exam Grade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(49, 290);
            label6.Name = "label6";
            label6.Size = new Size(143, 19);
            label6.TabIndex = 5;
            label6.Text = "Final Exam Grade";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.Location = new Point(49, 396);
            label7.Name = "label7";
            label7.Size = new Size(152, 19);
            label7.TabIndex = 6;
            label7.Text = "Weighted Average:";
            // 
            // txtHomework
            // 
            txtHomework.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtHomework.Location = new Point(225, 92);
            txtHomework.Name = "txtHomework";
            txtHomework.Size = new Size(100, 26);
            txtHomework.TabIndex = 7;
            // 
            // txtProject
            // 
            txtProject.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtProject.Location = new Point(225, 142);
            txtProject.Name = "txtProject";
            txtProject.Size = new Size(100, 26);
            txtProject.TabIndex = 8;
            txtProject.TextChanged += textBox2_TextChanged;
            // 
            // txtQuiz
            // 
            txtQuiz.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtQuiz.Location = new Point(225, 190);
            txtQuiz.Name = "txtQuiz";
            txtQuiz.Size = new Size(100, 26);
            txtQuiz.TabIndex = 9;
            // 
            // txtExams
            // 
            txtExams.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtExams.Location = new Point(225, 239);
            txtExams.Name = "txtExams";
            txtExams.Size = new Size(100, 26);
            txtExams.TabIndex = 10;
            // 
            // txtFinalExam
            // 
            txtFinalExam.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtFinalExam.Location = new Point(225, 283);
            txtFinalExam.Name = "txtFinalExam";
            txtFinalExam.Size = new Size(100, 26);
            txtFinalExam.TabIndex = 11;
            // 
            // txtWeightedAverage
            // 
            txtWeightedAverage.Font = new Font("Arial", 12F, FontStyle.Bold);
            txtWeightedAverage.Location = new Point(225, 389);
            txtWeightedAverage.Name = "txtWeightedAverage";
            txtWeightedAverage.ReadOnly = true;
            txtWeightedAverage.Size = new Size(100, 26);
            txtWeightedAverage.TabIndex = 12;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnCompute.Location = new Point(167, 339);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(109, 33);
            btnCompute.TabIndex = 13;
            btnCompute.Text = "COMPUTE";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnClear.Location = new Point(285, 339);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(109, 33);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // frmGradeCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 484);
            Controls.Add(btnClear);
            Controls.Add(btnCompute);
            Controls.Add(txtWeightedAverage);
            Controls.Add(txtFinalExam);
            Controls.Add(txtExams);
            Controls.Add(txtQuiz);
            Controls.Add(txtProject);
            Controls.Add(txtHomework);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGradeCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grade Calculator";
            Load += frmGradeCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtHomework;
        private TextBox txtProject;
        private TextBox txtQuiz;
        private TextBox txtExams;
        private TextBox txtFinalExam;
        private TextBox txtWeightedAverage;
        private Button btnCompute;
        private Button btnClear;
    }
}
