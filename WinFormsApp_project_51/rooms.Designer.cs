namespace WinFormsApp_project_51
{
    partial class rooms
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
            label2 = new Label();
            RoomDGV = new DataGridView();
            label3 = new Label();
            panel3 = new Panel();
            RoomStatusCb = new ComboBox();
            label5 = new Label();
            YesRadio = new RadioButton();
            NoRadio = new RadioButton();
            panel4 = new Panel();
            label6 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            RoomNumtb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1476, 129);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.FlatStyle = FlatStyle.System;
            button6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(1286, 21);
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
            label1.Size = new Size(327, 32);
            label1.TabIndex = 0;
            label1.Text = "ROOM INFORMATION";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(0, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(1476, 23);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(1018, 193);
            label2.Name = "label2";
            label2.Size = new Size(120, 28);
            label2.TabIndex = 2;
            label2.Text = "Room List";
            // 
            // RoomDGV
            // 
            RoomDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomDGV.Location = new Point(708, 237);
            RoomDGV.Name = "RoomDGV";
            RoomDGV.RowHeadersWidth = 51;
            RoomDGV.RowTemplate.Height = 25;
            RoomDGV.Size = new Size(736, 508);
            RoomDGV.TabIndex = 3;
            RoomDGV.CellContentClick += RoomDGV_CellContentClick;
            RoomDGV.RowHeaderMouseClick += RoomDGV_RowHeaderMouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(135, 272);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 4;
            label3.Text = "ROOM NUMBER";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Location = new Point(135, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 10);
            panel3.TabIndex = 5;
            // 
            // RoomStatusCb
            // 
            RoomStatusCb.AutoCompleteCustomSource.AddRange(new string[] { "Active", "NotActive" });
            RoomStatusCb.FormattingEnabled = true;
            RoomStatusCb.Items.AddRange(new object[] { "Active ", "NotActive" });
            RoomStatusCb.Location = new Point(326, 367);
            RoomStatusCb.Name = "RoomStatusCb";
            RoomStatusCb.Size = new Size(165, 23);
            RoomStatusCb.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(149, 433);
            label5.Name = "label5";
            label5.Size = new Size(112, 31);
            label5.TabIndex = 8;
            label5.Text = "BOOKED";
            label5.Click += label5_Click;
            // 
            // YesRadio
            // 
            YesRadio.AutoSize = true;
            YesRadio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            YesRadio.ForeColor = SystemColors.Highlight;
            YesRadio.Location = new Point(326, 429);
            YesRadio.Name = "YesRadio";
            YesRadio.Size = new Size(65, 34);
            YesRadio.TabIndex = 9;
            YesRadio.TabStop = true;
            YesRadio.Text = "YES";
            YesRadio.UseVisualStyleBackColor = true;
            // 
            // NoRadio
            // 
            NoRadio.AutoSize = true;
            NoRadio.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            NoRadio.ForeColor = SystemColors.Highlight;
            NoRadio.Location = new Point(428, 429);
            NoRadio.Name = "NoRadio";
            NoRadio.Size = new Size(63, 34);
            NoRadio.TabIndex = 10;
            NoRadio.TabStop = true;
            NoRadio.Text = "NO";
            NoRadio.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 770);
            panel4.Name = "panel4";
            panel4.Size = new Size(1476, 48);
            panel4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(593, 8);
            label6.Name = "label6";
            label6.Size = new Size(327, 32);
            label6.TabIndex = 0;
            label6.Text = "ROOM INFORMATION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(135, 367);
            label4.Name = "label4";
            label4.Size = new Size(158, 26);
            label4.TabIndex = 12;
            label4.Text = "ROOM STATUS";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(135, 576);
            button1.Name = "button1";
            button1.Size = new Size(82, 31);
            button1.TabIndex = 13;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(275, 576);
            button2.Name = "button2";
            button2.Size = new Size(103, 31);
            button2.TabIndex = 13;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(409, 576);
            button3.Name = "button3";
            button3.Size = new Size(82, 31);
            button3.TabIndex = 13;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(251, 671);
            button4.Name = "button4";
            button4.Size = new Size(127, 31);
            button4.TabIndex = 13;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RoomNumtb
            // 
            RoomNumtb.Location = new Point(138, 308);
            RoomNumtb.Margin = new Padding(3, 2, 3, 2);
            RoomNumtb.Name = "RoomNumtb";
            RoomNumtb.Size = new Size(353, 23);
            RoomNumtb.TabIndex = 14;
            // 
            // rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 814);
            Controls.Add(RoomNumtb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(panel4);
            Controls.Add(NoRadio);
            Controls.Add(YesRadio);
            Controls.Add(label5);
            Controls.Add(RoomStatusCb);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(RoomDGV);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "rooms";
            Load += rooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView RoomDGV;
        private Label label3;
        private Panel panel3;
        private ComboBox RoomStatusCb;
        private Label label5;
        private RadioButton YesRadio;
        private RadioButton NoRadio;
        private Panel panel4;
        private Label label6;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox RoomNumtb;
        private Button button6;
    }
}