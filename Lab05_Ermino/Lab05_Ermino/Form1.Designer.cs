namespace Lab05_Ermino
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redbg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.costumerNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.planMonthsTextBox = new System.Windows.Forms.TextBox();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.downPaymentTextBox = new System.Windows.Forms.TextBox();
            this.totalDueTextBox = new System.Windows.Forms.TextBox();
            this.monthlyFee = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.computeButton = new System.Windows.Forms.Button();
            this.monthlyInterestTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // redbg
            // 
            this.redbg.BackColor = System.Drawing.Color.Red;
            this.redbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redbg.Location = new System.Drawing.Point(-2, -1);
            this.redbg.Name = "redbg";
            this.redbg.Size = new System.Drawing.Size(520, 113);
            this.redbg.TabIndex = 1;
            this.redbg.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Credit Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costumer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(43, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(43, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(43, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Plan Months:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(43, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Interest:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(43, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Down Payment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(43, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Interest:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(43, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Due:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(43, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Monthly Fee:";
            // 
            // costumerNameTextBox
            // 
            this.costumerNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costumerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costumerNameTextBox.Location = new System.Drawing.Point(170, 155);
            this.costumerNameTextBox.Name = "costumerNameTextBox";
            this.costumerNameTextBox.Size = new System.Drawing.Size(224, 24);
            this.costumerNameTextBox.TabIndex = 12;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(170, 194);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(224, 24);
            this.itemNameTextBox.TabIndex = 13;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceTextBox.Location = new System.Drawing.Point(170, 241);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemPriceTextBox.Size = new System.Drawing.Size(140, 24);
            this.itemPriceTextBox.TabIndex = 14;
            // 
            // planMonthsTextBox
            // 
            this.planMonthsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planMonthsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planMonthsTextBox.Location = new System.Drawing.Point(170, 281);
            this.planMonthsTextBox.Name = "planMonthsTextBox";
            this.planMonthsTextBox.Size = new System.Drawing.Size(78, 24);
            this.planMonthsTextBox.TabIndex = 15;
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.interestRateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateTextBox.Location = new System.Drawing.Point(170, 318);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(78, 24);
            this.interestRateTextBox.TabIndex = 16;
            // 
            // downPaymentTextBox
            // 
            this.downPaymentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.downPaymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downPaymentTextBox.Location = new System.Drawing.Point(170, 359);
            this.downPaymentTextBox.Name = "downPaymentTextBox";
            this.downPaymentTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.downPaymentTextBox.Size = new System.Drawing.Size(140, 24);
            this.downPaymentTextBox.TabIndex = 17;
            // 
            // totalDueTextBox
            // 
            this.totalDueTextBox.BackColor = System.Drawing.Color.Salmon;
            this.totalDueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDueTextBox.Location = new System.Drawing.Point(170, 505);
            this.totalDueTextBox.Name = "totalDueTextBox";
            this.totalDueTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalDueTextBox.Size = new System.Drawing.Size(140, 24);
            this.totalDueTextBox.TabIndex = 19;
            // 
            // monthlyFee
            // 
            this.monthlyFee.BackColor = System.Drawing.Color.Salmon;
            this.monthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFee.Location = new System.Drawing.Point(170, 550);
            this.monthlyFee.Name = "monthlyFee";
            this.monthlyFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthlyFee.Size = new System.Drawing.Size(140, 24);
            this.monthlyFee.TabIndex = 20;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gray;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(274, 395);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(105, 50);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // computeButton
            // 
            this.computeButton.BackColor = System.Drawing.Color.Red;
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.computeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computeButton.ForeColor = System.Drawing.Color.White;
            this.computeButton.Location = new System.Drawing.Point(170, 395);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(98, 50);
            this.computeButton.TabIndex = 26;
            this.computeButton.Text = "Compute";
            this.computeButton.UseVisualStyleBackColor = false;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // monthlyInterestTextBox
            // 
            this.monthlyInterestTextBox.BackColor = System.Drawing.Color.Salmon;
            this.monthlyInterestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthlyInterestTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyInterestTextBox.Location = new System.Drawing.Point(170, 462);
            this.monthlyInterestTextBox.Name = "monthlyInterestTextBox";
            this.monthlyInterestTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.monthlyInterestTextBox.Size = new System.Drawing.Size(140, 24);
            this.monthlyInterestTextBox.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 608);
            this.Controls.Add(this.monthlyInterestTextBox);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.monthlyFee);
            this.Controls.Add(this.totalDueTextBox);
            this.Controls.Add(this.downPaymentTextBox);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.planMonthsTextBox);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemNameTextBox);
            this.Controls.Add(this.costumerNameTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.redbg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label redbg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox costumerNameTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.TextBox planMonthsTextBox;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox downPaymentTextBox;
        private System.Windows.Forms.TextBox totalDueTextBox;
        private System.Windows.Forms.TextBox monthlyFee;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.TextBox monthlyInterestTextBox;
    }
}

