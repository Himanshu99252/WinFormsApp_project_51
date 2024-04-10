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
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp_project_51
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aditya Mishra\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf"";Integrated Security=True");
        void FillStudentDGV()
        {
            con.Open();
            String myquery = "Select * from Student_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            con.Close();
        }    
            
            void updateBookedStatusOndelete()
            { 
            con.Open();
                String query = "update Room_tbl set Booked='"+"Free"+ "' where RoomNum=" + StudRoomCb.SelectedValue.ToString() + "";
                SqlCommand cmd= new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                con.Close();
            
            }
        
        void FillRoomCombobox()
        {
            con.Open();
            string query = "select*from Room_tbl where Roomstatus='"+"Active"+"' and Booked='"+"Busy"+"'";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader rdr;
            rdr= cmd.ExecuteReader();
            DataTable dt= new DataTable();
            dt.Columns.Add("RoomNum", typeof(int));
            dt.Load(rdr);
            StudRoomCb.ValueMember = "RoomNum";
            StudRoomCb.DataSource = dt;
            con.Close() ;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        { 
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "" || StudName.Text == "" || FatherName.Text == "" || MotherName.Text == "" || AddressTb.Text == "" || CollegeTb.Text == "")
            {
                MessageBox.Show("Empty Field Cannot be Accepted");
            }
            else
            {
                con.Open();

                // Check if the room is already allocated to three students
                string checkQuery = "SELECT COUNT(*) FROM Student_tbl WHERE StdRoom = '" + StudRoomCb.SelectedValue.ToString() + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                int count = (int)checkCmd.ExecuteScalar();
                if (count >= 3)
                {
                    MessageBox.Show("Room is already allocated to three students.");
                }
                else
                {
                    // Insert the new student into the database
                    string query = "INSERT INTO Student_tbl VALUES('" + StudUsn.Text + "','" + StudName.Text + "','" + FatherName.Text + "','" + MotherName.Text + "','" + AddressTb.Text + "','" + CollegeTb.Text + "','" + StudRoomCb.SelectedValue.ToString() + "','" + StduStatusCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Data Added Successfully");
                    con.Close();
                    FillStudentDGV();
                    FillRoomCombobox();
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (StudUsn.Text == "")
                {
                    MessageBox.Show("Enter The Room Number");
                }
                else
                {
                    con.Open();
                    string query1 = "update Student_tbl set StdName='" + StudName.Text + "',FatherName='" + FatherName.Text + "',MotherName='" + MotherName.Text + "',StdAddress='" + AddressTb.Text + "',College='" + CollegeTb.Text + "',StdRoom='" + StudRoomCb.SelectedItem.ToString() +"',StdStatus='" + StduStatusCb.SelectedItem.ToString() +"' where StdUsn='" + StudUsn.Text +"'";
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room Updated Sucessfully");
                    con.Close();
                    FillStudentDGV();
                    FillRoomCombobox();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudUsn.Text == "")
            {
                MessageBox.Show("Enter The Student Number");
            }
            else
            {
                con.Open();
                string query = "delete from Student_tbl where StdUsn='" + StudUsn.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted Sucessfully");
                con.Close();
                updateBookedStatusOndelete();
                FillStudentDGV();
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            StudUsn.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StudName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            FatherName.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            MotherName.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            CollegeTb.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void student_Load(object sender, EventArgs e)
        {
            FillStudentDGV();
            FillRoomCombobox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            StudUsn.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            StudName.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            FatherName.Text = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            MotherName.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AddressTb.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            CollegeTb.Text = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();
            StudRoomCb.Text = StudentDGV.SelectedRows[0].Cells[6].Value.ToString();
            StduStatusCb.Text = StudentDGV.SelectedRows[0].Cells[7].Value.ToString();

        }
    }
}
