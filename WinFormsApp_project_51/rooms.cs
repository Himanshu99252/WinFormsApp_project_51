using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp_project_51
{

    public partial class rooms : Form
    {

        public rooms()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91931\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf;Integrated Security=True");
        void FillRoomDGV()
        {
            con.Open();
            String myquery = "Select * from Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string RoomBooked;
        private void button1_Click(object sender, EventArgs e)
        {
            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (YesRadio.Checked == true)
                {
                    RoomBooked = "Busy";
                }
                else
                {
                    RoomBooked = "Free";
                }

                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM room_tbl WHERE RoomNum = " + RoomNumtb.Text;
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Room with this number already exists in the database.");
                }
                else
                {

                    string insertQuery = "INSERT INTO room_tbl VALUES(" + RoomNumtb.Text + ",'" + RoomStatusCb.SelectedItem.ToString() + "','" + RoomBooked + "')";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Room Added Successfully");
                    FillRoomDGV();
                }

                con.Close();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                con.Open();
                string query = "delete from Room_tbl where RoomNum=" + RoomNumtb.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Room Deleted Sucessfully");

                con.Close();
                FillRoomDGV();
            }
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            FillRoomDGV();
        }

        private void RoomDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumtb.Text = RoomDGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (RoomNumtb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (RoomNumtb.Text == "")
                {
                    MessageBox.Show("Enter The Room Number");

                }
                else
                {
                    if (YesRadio.Checked == true)
                    {
                        RoomBooked = "Busy";
                    }
                    else
                    {
                        RoomBooked = "Free";
                    }
                    con.Open();
                    string query = "update Room_tbl set Roomstatus='" + RoomStatusCb.SelectedItem.ToString() + "',Booked='" + RoomBooked + "' where RoomNum=" + RoomNumtb.Text + "";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    DialogResult = MessageBox.Show("Room Updated Sucessfully");
                    con.Close();
                    FillRoomDGV();
                }
            }
        }

        private void RoomDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            RoomNumtb.Text = RoomDGV.SelectedRows[0].Cells[0].Value.ToString();
            if (RoomDGV.SelectedRows[0].Cells[1].Value.ToString() == "Active")
            {
                RoomStatusCb.Text = "Active";
            }
            else
            {
                RoomStatusCb.Text = "NotActive";
            }
            if (RoomDGV.SelectedRows[0].Cells[2].Value.ToString() == "Yes")
            {
                YesRadio.Checked = true;
            }
            else
            {
                NoRadio.Checked = true;
            }
        }
    }
}
