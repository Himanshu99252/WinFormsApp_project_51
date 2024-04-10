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
    public partial class employee : Form
    {
        void FillEmployeeDGV()
        {
            con.Open();
            String myquery = "Select * from Employee_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmployeeDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aditya Mishra\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf"";Integrated Security=True");
        public employee()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpIdTb.Text == "" || EmpPhoneTb.Text == "" || EmpAddTb.Text == "")
            {
                MessageBox.Show("Empty Field Cannot be Accepted");
            }
            else
            {
                con.Open();
                string query = "insert into Employee_tbl values('" +EmpIdTb.Text+ "','"+ EmpNameTb.Text +"','"+ EmpPhoneTb.Text + "','" + EmpAddTb.Text+"','"+EmpPosiotionCb.SelectedItem.ToString()+"','"+EmpStatusCb.SelectedItem.ToString()+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Data Added Sucessfully");
                con.Close();
                FillEmployeeDGV();
                // FillRoomCombobox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EmpIdTb.Text =="" || EmpNameTb.Text=="" || EmpPhoneTb.Text=="" || EmpAddTb.Text=="" || EmpPosiotionCb.SelectedItem.ToString()=="" || EmpStatusCb.SelectedItem.ToString()=="")
            {
                MessageBox.Show("Kindly Fill All Deatils To Continue");
            }
           else
                {
                    con.Open();
                    string query1 = "update Employee_tbl set EmpName='" + EmpNameTb.Text + "',EmpPhone='" + EmpPhoneTb.Text + "',EmpAddress='" +EmpAddTb.Text + "',EmpPos='" + EmpPosiotionCb.SelectedItem.ToString() + "',EmpStatus='" + EmpStatusCb.SelectedItem.ToString() + "' where EmpId='" + EmpIdTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated Sucessfully");
                    con.Close();
                FillEmployeeDGV();
                    //  FillRoomCombobox();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (EmpIdTb.Text == "")
            {
                MessageBox.Show("Enter The Employee Number");
            }
            else
            {
                con.Open();
                string query = "delete from Employee_tbl where EmpId='" + EmpIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Sucessfully");
                con.Close();
                //  updateBookedStatusOndelete();
               FillEmployeeDGV();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            FillEmployeeDGV();
        }

        private void EmployeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpIdTb.Text = EmployeeDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpNameTb.Text = EmployeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPhoneTb.Text = EmployeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpAddTb.Text = EmployeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPosiotionCb.SelectedItem= EmployeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            EmpStatusCb.SelectedItem= EmployeeDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
