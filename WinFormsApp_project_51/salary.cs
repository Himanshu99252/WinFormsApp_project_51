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
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91931\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf;Integrated Security=True");
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
        }
        public void FillSalaryDGV()
        {
            con.Open();
            String myquery = "Select * from Salary_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            SalaryDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void salary_Load(object sender, EventArgs e)
        {
            fillUsnCb();
            fecthdata();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (SalaryIdTB.Text == "")
            {
                MessageBox.Show("Enter The Payment Id Correctly");
            }
            else
            {

                string Salaryperiode;
                Salaryperiode = DateCb.Value.Month.ToString() + DateCb.Value.Year.ToString();
                con.Open();
                string query = "update Salary_tbl set SalEmpId='" + EmployeeIdCb.SelectedValue.ToString() + "',SalEmpName='" + EmpNameTb.Text + "',SalEmpPosition='" + EmpPosTb.Text + "',SalMonth='" + Salaryperiode + "',SalAmount='" + AmountTb.Text + "' where SalId='" + SalaryIdTB.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Updated Sucessfully");

                FillSalaryDGV();
                con.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SalaryIdTB.Text == "")
            {
                MessageBox.Show("Enter Payment Id Correctly");
            }
            else
            {
                con.Open();
                string query = "delete from Salary_tbl where SalId='" + SalaryIdTB.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salary Details Deleted Sucessfully");
                con.Close();
                FillSalaryDGV();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salary_Load_1(object sender, EventArgs e)
        {

            fillUsnCb();
            fillUsnCb();
            fecthdata();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SalaryIdTB.Text == "" || EmpNameTb.Text == "" || EmpNameTb.Text == "" || EmpPosTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                string Salaryperiode;
                Salaryperiode = DateCb.Value.Month.ToString() + "/" + DateCb.Value.Year.ToString();

                {
                    con.Open();
                    string query = "insert into Salary_tbl values('" + SalaryIdTB.Text + "','" + EmployeeIdCb.SelectedValue.ToString() + "','" + EmpNameTb.Text + "','" + EmpPosTb.Text + "','" + Salaryperiode + "','" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Sucess");
                    con.Close();
                }
            }
            con.Close();
        }
    }
}



