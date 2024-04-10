using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_project_51
{
    public partial class salary : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aditya Mishra\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf"";Integrated Security=True");
        public salary()
        {
            InitializeComponent();
        }
        public void fillUsnCb()
        {
            con.Open();
            string query = "select Empid from Employee_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Empid", typeof(String));
            dt.Load(rdr);
            EmployeeIdCb.ValueMember = "Empid";
            EmployeeIdCb.DataSource = dt;
            con.Close();
        }
        public void fecthdata()
        {
            con.Open();
            string query = "select * from Employee_tbl where Empid='" + EmployeeIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                string EmpName, EmpPos;
                EmpName = dr["Empid"].ToString();
                EmpPos = dr["EmpPos"].ToString();
                EmpNameTb.Text = EmpName;
                EmpPosTb.Text = EmpPos;

            }
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salary_Load(object sender, EventArgs e)
        {
            fillUsnCb();
            fecthdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SalaryIdTB.Text == "" || EmployeeIdCb.Text == "" || EmpNameTb.Text == "" || DateCb.Text == "")
            {
                MessageBox.Show("Empty Field Cannot be Accepted");
            }
            else
            {
                con.Open();
                string query = "insert into Employee_tbl values('" + EmpIdTb.Text + "','" + EmpNameTb.Text + "','" + EmpPhoneTb.Text + "','" + EmpAddTb.Text + "','" + EmpPosiotionCb.SelectedItem.ToString() + "','" + EmpStatusCb.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Data Added Sucessfully");
                con.Close();
                //FillSalaryDGV();
            }
    }
}
