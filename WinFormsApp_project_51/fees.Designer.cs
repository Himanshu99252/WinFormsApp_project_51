namespace WinFormsApp_project_51
{
    partial class fees
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
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            UsnCb = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            label7 = new Label();
            Periode = new DateTimePicker();
            label8 = new Label();
            AmountTb = new TextBox();
            panel9 = new Panel();
            label9 = new Label();
            PaymentDGV = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label10 = new Label();
            StudentNameTb = new TextBox();
            PaymentIdTb = new TextBox();
            RoomNumTb = new TextBox();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 129);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(3, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(1476, 23);
            panel2.TabIndex = 3;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.System;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1363, 11);
            button6.Name = "button6";
            button6.Size = new Size(61, 39);
            button6.TabIndex = 2;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(593, 50);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 0;
            label1.Text = "FEES PAYMENT";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Location = new Point(0, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1476, 23);
            panel3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(97, 223);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(81, 240);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 16;
            label2.Text = "Payment ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(82, 310);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 16;
            label3.Text = "USN";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(82, 286);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 10);
            panel4.TabIndex = 17;
            // 
            // UsnCb
            // 
            UsnCb.FormattingEnabled = true;
            UsnCb.Location = new Point(190, 314);
            UsnCb.Name = "UsnCb";
            UsnCb.Size = new Size(121, 23);
            UsnCb.TabIndex = 18;
            UsnCb.SelectionChangeCommitted += UsnCb_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(81, 392);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 19;
            label5.Text = "Student Name";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Location = new Point(85, 501);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 12);
            panel5.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(81, 459);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 20;
            label6.Text = "Room Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(81, 532);
            label7.Name = "label7";
            label7.Size = new Size(74, 23);
            label7.TabIndex = 21;
            label7.Text = "Month";
            label7.Click += label7_Click;
            // 
            // Periode
            // 
            Periode.CalendarForeColor = SystemColors.Highlight;
            Periode.CalendarMonthBackground = SystemColors.MenuHighlight;
            Periode.CalendarTitleBackColor = SystemColors.Highlight;
            Periode.Location = new Point(190, 532);
            Periode.Name = "Periode";
            Periode.Size = new Size(200, 23);
            Periode.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(81, 576);
            label8.Name = "label8";
            label8.Size = new Size(88, 23);
            label8.TabIndex = 24;
            label8.Text = "Amount";
            // 
            // AmountTb
            // 
            AmountTb.Location = new Point(190, 576);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(100, 23);
            AmountTb.TabIndex = 25;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Red;
            panel9.Controls.Add(label9);
            panel9.Location = new Point(0, 769);
            panel9.Name = "panel9";
            panel9.Size = new Size(1476, 48);
            panel9.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(593, 8);
            label9.Name = "label9";
            label9.Size = new Size(249, 32);
            label9.TabIndex = 0;
            label9.Text = "FEES PAYMENTS";
            // 
            // PaymentDGV
            // 
            PaymentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentDGV.Location = new Point(595, 231);
            PaymentDGV.Name = "PaymentDGV";
            PaymentDGV.RowHeadersWidth = 51;
            PaymentDGV.RowTemplate.Height = 25;
            PaymentDGV.Size = new Size(736, 508);
            PaymentDGV.TabIndex = 32;
            PaymentDGV.CellContentClick += PaymentDGV_CellContentClick;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(184, 708);
            button4.Name = "button4";
            button4.Size = new Size(127, 31);
            button4.TabIndex = 28;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(342, 637);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 29;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(208, 637);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 30;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(73, 637);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 31;
            button1.Text = "PAY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(892, 177);
            label10.Name = "label10";
            label10.Size = new Size(143, 25);
            label10.TabIndex = 27;
            label10.Text = "PAYMENTS";
            // 
            // StudentNameTb
            // 
            StudentNameTb.Location = new Point(82, 430);
            StudentNameTb.Margin = new Padding(3, 2, 3, 2);
            StudentNameTb.Name = "StudentNameTb";
            StudentNameTb.Size = new Size(268, 23);
            StudentNameTb.TabIndex = 34;
            StudentNameTb.TextChanged += textBox2_TextChanged;
            // 
            // PaymentIdTb
            // 
            PaymentIdTb.Location = new Point(81, 274);
            PaymentIdTb.Margin = new Padding(3, 2, 3, 2);
            PaymentIdTb.Name = "PaymentIdTb";
            PaymentIdTb.Size = new Size(268, 23);
            PaymentIdTb.TabIndex = 34;
            PaymentIdTb.TextChanged += textBox2_TextChanged;
            // 
            // RoomNumTb
            // 
            RoomNumTb.Location = new Point(88, 490);
            RoomNumTb.Margin = new Padding(3, 2, 3, 2);
            RoomNumTb.Name = "RoomNumTb";
            RoomNumTb.Size = new Size(269, 23);
            RoomNumTb.TabIndex = 34;
            RoomNumTb.TextChanged += textBox2_TextChanged;
            // 
            // fees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1476, 815);
            Controls.Add(PaymentIdTb);
            Controls.Add(RoomNumTb);
            Controls.Add(StudentNameTb);
            Controls.Add(panel9);
            Controls.Add(PaymentDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(AmountTb);
            Controls.Add(label8);
            Controls.Add(Periode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(label5);
            Controls.Add(UsnCb);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment ID";
            Load += fees_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private ComboBox UsnCb;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private DateTimePicker Periode;
        private Label label8;
        private TextBox AmountTb;
        private Panel panel9;
        private Label label9;
        private DataGridView PaymentDGV;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label10;
        private TextBox StudentNameTb;
        private TextBox PaymentIdTb;
        private TextBox RoomNumTb;
    }
}