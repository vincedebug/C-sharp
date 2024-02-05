namespace Lab01_Ermino
{
    partial class frmNewStudent
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
            lblLastName = new Label();
            lblStatus = new Label();
            v = new TextBox();
            btnOkay = new Button();
            btnCancel = new Button();
            txtFirstName = new TextBox();
            txtAddress = new TextBox();
            textBox3 = new TextBox();
            lblEmail = new Label();
            lblAddress = new Label();
            lblFirstName = new Label();
            SuspendLayout();
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(12, 31);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(96, 19);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.LightGreen;
            lblStatus.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(45, 266);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(283, 35);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "New Student Added!";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += label5_Click;
            // 
            // v
            // 
            v.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            v.Location = new Point(131, 24);
            v.Name = "v";
            v.Size = new Size(181, 26);
            v.TabIndex = 5;
            // 
            // btnOkay
            // 
            btnOkay.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOkay.Location = new Point(131, 218);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(89, 35);
            btnOkay.TabIndex = 9;
            btnOkay.Text = "OK";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += button1_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(226, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 35);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(131, 56);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(181, 26);
            txtFirstName.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAddress.Location = new Point(131, 172);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(181, 26);
            txtAddress.TabIndex = 12;
            txtAddress.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(131, 88);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Vertical;
            textBox3.Size = new Size(181, 78);
            textBox3.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(57, 19);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            lblEmail.Click += label1_Click;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(12, 88);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 19);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Address:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(12, 63);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 19);
            lblFirstName.TabIndex = 16;
            lblFirstName.Text = "First Name:";
            // 
            // frmNewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 309);
            Controls.Add(lblFirstName);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(textBox3);
            Controls.Add(txtAddress);
            Controls.Add(txtFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnOkay);
            Controls.Add(v);
            Controls.Add(lblStatus);
            Controls.Add(lblLastName);
            Name = "frmNewStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "    ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLastName;
        private Label lblStatus;
        private TextBox v;
        private Button btnOkay;
        private Button btnCancel;
        private TextBox txtFirstName;
        private TextBox txtAddress;
        private TextBox textBox3;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblFirstName;
    }
}