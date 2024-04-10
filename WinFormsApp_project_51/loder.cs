using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_project_51
{
    public partial class loder : Form
    {
        public loder()
        {
            InitializeComponent();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rooms r = new rooms();
            r.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            student stu = new student();
            stu.Show();
        }

        private void emToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fees f = new fees();
            f.Show();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            salary s = new salary();
            s.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
