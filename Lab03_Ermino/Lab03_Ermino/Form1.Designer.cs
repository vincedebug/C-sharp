namespace Lab03_Ermino
{
    partial class lotCalculatorForm
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
            lotOwnerTxt = new Label();
            tLotSizeTxt = new Label();
            lotSoldTxt = new Label();
            lotPriceTxt = new Label();
            costTxt = new Label();
            displayCostBtn = new Button();
            lotOwnerTxtb = new TextBox();
            tLotSizeTxtB = new TextBox();
            lotSoldTxtB = new TextBox();
            costTxtB = new TextBox();
            lotPriceTxtB = new TextBox();
            percentTxt = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 30);
            label1.TabIndex = 0;
            label1.Text = "Lot Calculator App";
            label1.Click += label1_Click;
            // 
            // lotOwnerTxt
            // 
            lotOwnerTxt.AutoSize = true;
            lotOwnerTxt.Font = new Font("Microsoft Sans Serif", 14.25F);
            lotOwnerTxt.Location = new Point(35, 81);
            lotOwnerTxt.Name = "lotOwnerTxt";
            lotOwnerTxt.Size = new Size(102, 24);
            lotOwnerTxt.TabIndex = 1;
            lotOwnerTxt.Text = "Lot Owner:";
            // 
            // tLotSizeTxt
            // 
            tLotSizeTxt.AutoSize = true;
            tLotSizeTxt.Font = new Font("Microsoft Sans Serif", 14.25F);
            tLotSizeTxt.Location = new Point(46, 115);
            tLotSizeTxt.Name = "tLotSizeTxt";
            tLotSizeTxt.Size = new Size(180, 24);
            tLotSizeTxt.TabIndex = 2;
            tLotSizeTxt.Text = "Total Lot Size (sqm):";
            // 
            // lotSoldTxt
            // 
            lotSoldTxt.AutoSize = true;
            lotSoldTxt.Font = new Font("Microsoft Sans Serif", 14.25F);
            lotSoldTxt.Location = new Point(35, 152);
            lotSoldTxt.Name = "lotSoldTxt";
            lotSoldTxt.Size = new Size(136, 24);
            lotSoldTxt.TabIndex = 3;
            lotSoldTxt.Text = "Lot Sold (sqm):";
            // 
            // lotPriceTxt
            // 
            lotPriceTxt.AutoSize = true;
            lotPriceTxt.Font = new Font("Microsoft Sans Serif", 14.25F);
            lotPriceTxt.Location = new Point(35, 189);
            lotPriceTxt.Name = "lotPriceTxt";
            lotPriceTxt.Size = new Size(174, 24);
            lotPriceTxt.TabIndex = 4;
            lotPriceTxt.Text = "Lot Price (per sqm):";
            lotPriceTxt.Click += label5_Click;
            // 
            // costTxt
            // 
            costTxt.AutoSize = true;
            costTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costTxt.Location = new Point(46, 309);
            costTxt.Name = "costTxt";
            costTxt.Size = new Size(56, 25);
            costTxt.TabIndex = 5;
            costTxt.Text = "Cost";
            // 
            // displayCostBtn
            // 
            displayCostBtn.BackColor = Color.FromArgb(224, 224, 224);
            displayCostBtn.FlatStyle = FlatStyle.Popup;
            displayCostBtn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayCostBtn.ForeColor = SystemColors.ControlText;
            displayCostBtn.Location = new Point(252, 226);
            displayCostBtn.Name = "displayCostBtn";
            displayCostBtn.Size = new Size(127, 55);
            displayCostBtn.TabIndex = 6;
            displayCostBtn.Text = "Dispay Cost";
            displayCostBtn.UseVisualStyleBackColor = false;
            displayCostBtn.Click += button1_Click;
            // 
            // lotOwnerTxtb
            // 
            lotOwnerTxtb.BackColor = SystemColors.ButtonHighlight;
            lotOwnerTxtb.BorderStyle = BorderStyle.FixedSingle;
            lotOwnerTxtb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lotOwnerTxtb.ForeColor = SystemColors.MenuHighlight;
            lotOwnerTxtb.Location = new Point(252, 82);
            lotOwnerTxtb.Name = "lotOwnerTxtb";
            lotOwnerTxtb.Size = new Size(193, 29);
            lotOwnerTxtb.TabIndex = 7;
            lotOwnerTxtb.TextChanged += lotOwnerTxtb_TextChanged;
            // 
            // tLotSizeTxtB
            // 
            tLotSizeTxtB.BorderStyle = BorderStyle.FixedSingle;
            tLotSizeTxtB.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            tLotSizeTxtB.ForeColor = SystemColors.ControlText;
            tLotSizeTxtB.Location = new Point(252, 119);
            tLotSizeTxtB.Name = "tLotSizeTxtB";
            tLotSizeTxtB.PlaceholderText = "0.0";
            tLotSizeTxtB.RightToLeft = RightToLeft.Yes;
            tLotSizeTxtB.Size = new Size(127, 26);
            tLotSizeTxtB.TabIndex = 8;
            // 
            // lotSoldTxtB
            // 
            lotSoldTxtB.BorderStyle = BorderStyle.FixedSingle;
            lotSoldTxtB.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lotSoldTxtB.ForeColor = SystemColors.ControlText;
            lotSoldTxtB.Location = new Point(252, 153);
            lotSoldTxtB.Name = "lotSoldTxtB";
            lotSoldTxtB.PlaceholderText = "0.0";
            lotSoldTxtB.RightToLeft = RightToLeft.Yes;
            lotSoldTxtB.Size = new Size(127, 26);
            lotSoldTxtB.TabIndex = 10;
            lotSoldTxtB.TextChanged += textBox4_TextChanged;
            // 
            // costTxtB
            // 
            costTxtB.BorderStyle = BorderStyle.FixedSingle;
            costTxtB.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            costTxtB.Location = new Point(252, 302);
            costTxtB.Name = "costTxtB";
            costTxtB.ReadOnly = true;
            costTxtB.RightToLeft = RightToLeft.Yes;
            costTxtB.Size = new Size(193, 35);
            costTxtB.TabIndex = 11;
            costTxtB.TextChanged += costTxtB_TextChanged;
            // 
            // lotPriceTxtB
            // 
            lotPriceTxtB.BorderStyle = BorderStyle.FixedSingle;
            lotPriceTxtB.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            lotPriceTxtB.ForeColor = SystemColors.ControlText;
            lotPriceTxtB.Location = new Point(252, 189);
            lotPriceTxtB.Name = "lotPriceTxtB";
            lotPriceTxtB.PlaceholderText = "0.0";
            lotPriceTxtB.RightToLeft = RightToLeft.Yes;
            lotPriceTxtB.Size = new Size(127, 26);
            lotPriceTxtB.TabIndex = 12;
            // 
            // percentTxt
            // 
            percentTxt.AutoSize = true;
            percentTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            percentTxt.Location = new Point(382, 156);
            percentTxt.Name = "percentTxt";
            percentTxt.Size = new Size(23, 21);
            percentTxt.TabIndex = 13;
            percentTxt.Text = "%";
            // 
            // lotCalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 363);
            Controls.Add(percentTxt);
            Controls.Add(lotPriceTxtB);
            Controls.Add(costTxtB);
            Controls.Add(lotSoldTxtB);
            Controls.Add(tLotSizeTxtB);
            Controls.Add(lotOwnerTxtb);
            Controls.Add(displayCostBtn);
            Controls.Add(costTxt);
            Controls.Add(lotPriceTxt);
            Controls.Add(lotSoldTxt);
            Controls.Add(tLotSizeTxt);
            Controls.Add(lotOwnerTxt);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "lotCalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Department of Public Works and Highways";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lotOwnerTxt;
        private Label tLotSizeTxt;
        private Label lotSoldTxt;
        private Label lotPriceTxt;
        private Label costTxt;
        private Button displayCostBtn;
        private TextBox lotOwnerTxtb;
        private TextBox tLotSizeTxtB;
        private TextBox lotSoldTxtB;
        private TextBox costTxtB;
        private TextBox lotPriceTxtB;
        private Label percentTxt;
    }
}
