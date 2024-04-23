namespace Lab09_Ermino
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChildren = new System.Windows.Forms.TextBox();
            this.txtAdults = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.txtRooms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtResortFee = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDailySummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab09_Ermino.Properties.Resources.Tree;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChildren);
            this.groupBox1.Controls.Add(this.txtAdults);
            this.groupBox1.Controls.Add(this.txtNights);
            this.groupBox1.Controls.Add(this.txtRooms);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(139, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number of";
            // 
            // txtChildren
            // 
            this.txtChildren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChildren.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChildren.Location = new System.Drawing.Point(103, 130);
            this.txtChildren.Name = "txtChildren";
            this.txtChildren.Size = new System.Drawing.Size(46, 21);
            this.txtChildren.TabIndex = 7;
            // 
            // txtAdults
            // 
            this.txtAdults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdults.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdults.Location = new System.Drawing.Point(19, 130);
            this.txtAdults.Name = "txtAdults";
            this.txtAdults.Size = new System.Drawing.Size(48, 21);
            this.txtAdults.TabIndex = 6;
            // 
            // txtNights
            // 
            this.txtNights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNights.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(103, 62);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(46, 21);
            this.txtNights.TabIndex = 5;
            // 
            // txtRooms
            // 
            this.txtRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRooms.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRooms.Location = new System.Drawing.Point(19, 62);
            this.txtRooms.Name = "txtRooms";
            this.txtRooms.Size = new System.Drawing.Size(48, 21);
            this.txtRooms.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Children";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adults (18+)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nights:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rooms:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalDue);
            this.groupBox2.Controls.Add(this.txtResortFee);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.txtRoomCharge);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(345, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charges";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDue.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDue.Location = new System.Drawing.Point(79, 131);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalDue.Size = new System.Drawing.Size(101, 21);
            this.txtTotalDue.TabIndex = 11;
            // 
            // txtResortFee
            // 
            this.txtResortFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResortFee.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResortFee.Location = new System.Drawing.Point(79, 100);
            this.txtResortFee.Name = "txtResortFee";
            this.txtResortFee.ReadOnly = true;
            this.txtResortFee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResortFee.Size = new System.Drawing.Size(101, 21);
            this.txtResortFee.TabIndex = 10;
            // 
            // txtTax
            // 
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax.Location = new System.Drawing.Point(79, 67);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTax.Size = new System.Drawing.Size(101, 21);
            this.txtTax.TabIndex = 9;
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoomCharge.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomCharge.Location = new System.Drawing.Point(79, 40);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.ReadOnly = true;
            this.txtRoomCharge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoomCharge.Size = new System.Drawing.Size(101, 21);
            this.txtRoomCharge.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Resort Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Room:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(418, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(186, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDailySummary
            // 
            this.btnDailySummary.AutoSize = true;
            this.btnDailySummary.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySummary.Location = new System.Drawing.Point(302, 209);
            this.btnDailySummary.Name = "btnDailySummary";
            this.btnDailySummary.Size = new System.Drawing.Size(110, 30);
            this.btnDailySummary.TabIndex = 6;
            this.btnDailySummary.Text = "Daily";
            this.btnDailySummary.UseVisualStyleBackColor = true;
            this.btnDailySummary.Click += new System.EventHandler(this.btnDailySummary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 252);
            this.Controls.Add(this.btnDailySummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treeline Resort";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChildren;
        private System.Windows.Forms.TextBox txtAdults;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.TextBox txtRooms;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.TextBox txtResortFee;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDailySummary;
    }
}

