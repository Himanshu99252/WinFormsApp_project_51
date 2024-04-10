namespace WinFormsApp_project_51
{
    partial class loder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loder));
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            emToolStripMenuItem = new ToolStripMenuItem();
            feesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            xToolStripMenuItem = new ToolStripMenuItem();
            salaryToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Red;
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, roomsToolStripMenuItem, emToolStripMenuItem, feesToolStripMenuItem, toolStripMenuItem2, xToolStripMenuItem, salaryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 5, 0, 5);
            menuStrip1.Size = new Size(1907, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            studentToolStripMenuItem.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            studentToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            studentToolStripMenuItem.Margin = new Padding(5, 0, 0, 0);
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Padding = new Padding(16, 0, 16, 0);
            studentToolStripMenuItem.Size = new Size(280, 35);
            studentToolStripMenuItem.Text = "            Student        ";
            studentToolStripMenuItem.TextImageRelation = TextImageRelation.Overlay;
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            roomsToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            roomsToolStripMenuItem.Margin = new Padding(10, 0, 0, 0);
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(296, 35);
            roomsToolStripMenuItem.Text = "        Rooms                   ";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // emToolStripMenuItem
            // 
            emToolStripMenuItem.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            emToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            emToolStripMenuItem.Margin = new Padding(10, 0, 0, 0);
            emToolStripMenuItem.Name = "emToolStripMenuItem";
            emToolStripMenuItem.Size = new Size(252, 35);
            emToolStripMenuItem.Text = "        Employee        ";
            emToolStripMenuItem.Click += emToolStripMenuItem_Click;
            // 
            // feesToolStripMenuItem
            // 
            feesToolStripMenuItem.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            feesToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            feesToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            feesToolStripMenuItem.Size = new Size(316, 35);
            feesToolStripMenuItem.Text = "              Fees                    ";
            feesToolStripMenuItem.Click += feesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuItem2.ForeColor = SystemColors.ButtonHighlight;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Padding = new Padding(34, 0, 4, 0);
            toolStripMenuItem2.Size = new Size(301, 35);
            toolStripMenuItem2.Text = "           Salary                   ";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // xToolStripMenuItem
            // 
            xToolStripMenuItem.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            xToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            xToolStripMenuItem.Name = "xToolStripMenuItem";
            xToolStripMenuItem.Padding = new Padding(34, 0, 4, 0);
            xToolStripMenuItem.Size = new Size(358, 35);
            xToolStripMenuItem.Text = "                                   X             ";
            xToolStripMenuItem.Click += xToolStripMenuItem_Click;
            // 
            // salaryToolStripMenuItem
            // 
            salaryToolStripMenuItem.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            salaryToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            salaryToolStripMenuItem.Size = new Size(437, 35);
            salaryToolStripMenuItem.Text = "                                         X               ";
            salaryToolStripMenuItem.Click += salaryToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1616, 710);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(527, 233);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 480);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 964);
            panel1.Name = "panel1";
            panel1.Size = new Size(1947, 44);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mistral", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(852, 0);
            label1.Name = "label1";
            label1.Size = new Size(377, 34);
            label1.TabIndex = 0;
            label1.Text = "Prepared By Himanshu And Aditya";
            // 
            // loder
            // 
            AutoScaleDimensions = new SizeF(18F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1907, 1061);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Palatino Linotype", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(8);
            Name = "loder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loder";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem emToolStripMenuItem;
        private ToolStripMenuItem feesToolStripMenuItem;
        private ToolStripMenuItem salaryToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private ToolStripMenuItem xToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}