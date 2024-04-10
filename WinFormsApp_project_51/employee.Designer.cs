namespace WinFormsApp_project_51
{
    partial class employee
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
            button6 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label6 = new Label();
            EmployeeDGV = new DataGridView();
            label8 = new Label();
            panel9 = new Panel();
            label9 = new Label();
            EmpPosiotionCb = new ComboBox();
            label7 = new Label();
            EmpStatusCb = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            EmpIdTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpPhoneTb = new TextBox();
            EmpAddTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 129);
            panel1.TabIndex = 2;
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
            label1.Size = new Size(398, 32);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE INFORMATION";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(1, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(1476, 23);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(65, 232);
            label4.Name = "label4";
            label4.Size = new Size(137, 23);
            label4.TabIndex = 15;
            label4.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(65, 302);
            label2.Name = "label2";
            label2.Size = new Size(169, 23);
            label2.TabIndex = 16;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(65, 370);
            label3.Name = "label3";
            label3.Size = new Size(157, 23);
            label3.TabIndex = 17;
            label3.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(65, 436);
            label5.Name = "label5";
            label5.Size = new Size(89, 23);
            label5.TabIndex = 18;
            label5.Text = "Address";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Highlight;
            panel4.Location = new Point(65, 278);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 10);
            panel4.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Location = new Point(65, 340);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 10);
            panel3.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Highlight;
            panel5.Location = new Point(65, 407);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 10);
            panel5.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Highlight;
            panel6.Location = new Point(65, 474);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 10);
            panel6.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(75, 525);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 20;
            label6.Text = "Position";
            // 
            // EmployeeDGV
            // 
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDGV.Location = new Point(583, 241);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersWidth = 51;
            EmployeeDGV.RowTemplate.Height = 25;
            EmployeeDGV.Size = new Size(736, 508);
            EmployeeDGV.TabIndex = 21;
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(855, 188);
            label8.Name = "label8";
            label8.Size = new Size(167, 25);
            label8.TabIndex = 22;
            label8.Text = "Employee List";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Red;
            panel9.Controls.Add(label9);
            panel9.Location = new Point(1, 771);
            panel9.Name = "panel9";
            panel9.Size = new Size(1476, 48);
            panel9.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(593, 8);
            label9.Name = "label9";
            label9.Size = new Size(398, 32);
            label9.TabIndex = 0;
            label9.Text = "EMPLOYEE INFORMATION";
            // 
            // EmpPosiotionCb
            // 
            EmpPosiotionCb.FormattingEnabled = true;
            EmpPosiotionCb.Items.AddRange(new object[] { "Mess Staff", "Accountant", "Cleaner", "Hostel Incharge" });
            EmpPosiotionCb.Location = new Point(242, 525);
            EmpPosiotionCb.Name = "EmpPosiotionCb";
            EmpPosiotionCb.Size = new Size(121, 23);
            EmpPosiotionCb.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(46, 592);
            label7.Name = "label7";
            label7.Size = new Size(176, 23);
            label7.TabIndex = 25;
            label7.Text = "Employee Status";
            // 
            // EmpStatusCb
            // 
            EmpStatusCb.FormattingEnabled = true;
            EmpStatusCb.Items.AddRange(new object[] { "Working ", "Left" });
            EmpStatusCb.Location = new Point(242, 592);
            EmpStatusCb.Name = "EmpStatusCb";
            EmpStatusCb.Size = new Size(121, 23);
            EmpStatusCb.TabIndex = 26;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(183, 718);
            button4.Name = "button4";
            button4.Size = new Size(127, 31);
            button4.TabIndex = 27;
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
            button3.Location = new Point(357, 655);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 28;
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
            button2.Location = new Point(212, 655);
            button2.Name = "button2";
            button2.Size = new Size(82, 31);
            button2.TabIndex = 29;
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
            button1.Location = new Point(65, 655);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 30;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EmpIdTb
            // 
            EmpIdTb.Location = new Point(65, 262);
            EmpIdTb.Margin = new Padding(3, 2, 3, 2);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(273, 23);
            EmpIdTb.TabIndex = 31;
            // 
            // EmpNameTb
            // 
            EmpNameTb.Location = new Point(65, 326);
            EmpNameTb.Margin = new Padding(3, 2, 3, 2);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(273, 23);
            EmpNameTb.TabIndex = 31;
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Location = new Point(63, 393);
            EmpPhoneTb.Margin = new Padding(3, 2, 3, 2);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(273, 23);
            EmpPhoneTb.TabIndex = 31;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Location = new Point(63, 459);
            EmpAddTb.Margin = new Padding(3, 2, 3, 2);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(273, 23);
            EmpAddTb.TabIndex = 31;
            // 
            // employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 815);
            Controls.Add(EmpAddTb);
            Controls.Add(EmpPhoneTb);
            Controls.Add(EmpNameTb);
            Controls.Add(EmpIdTb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EmpStatusCb);
            Controls.Add(label7);
            Controls.Add(EmpPosiotionCb);
            Controls.Add(panel9);
            Controls.Add(label8);
            Controls.Add(EmployeeDGV);
            Controls.Add(label6);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "employee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "employee";
            Load += employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Label label6;
        private DataGridView EmployeeDGV;
        private Label label8;
        private Panel panel9;
        private Label label9;
        private ComboBox EmpPosiotionCb;
        private Label label7;
        private ComboBox EmpStatusCb;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox EmpIdTb;
        private TextBox EmpNameTb;
        private TextBox EmpPhoneTb;
        private TextBox EmpAddTb;
    }
}