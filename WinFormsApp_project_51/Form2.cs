using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_project_51
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        int sp = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {


            sp = sp + 10;
            progressBar1.Value = sp;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer2.Stop();
                Form2 l1 = new Form2();
                l1.Show();
                this.Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
