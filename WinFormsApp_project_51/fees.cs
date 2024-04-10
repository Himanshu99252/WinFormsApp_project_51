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
    public partial class fees : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\91931\Downloads\WinFormsApp_project_51\WinFormsApp_project_51\Hostelmgmt.mdf;Integrated Security=True");
        public fees()
        {
            InitializeComponent();
        }
        void FillFeesDGV()
        {
            con.Open();
            String myquery = "Select * from Student_tbl";
            SqlDataAdapter da = new SqlDataAdapter(myquery, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        public void fillUsnCb()
        {
            con.Open();
            string query = "select StdUsn from Student_tbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdUsn", typeof(String));
            dt.Load(rdr);
            UsnCb.ValueMember = "StdUsn";
            UsnCb.DataSource = dt;
            con.Close();
        }
        string studname, roomname;
        public void fecthdata()
        {
            con.Open();
            string query = "select * from Student_tbl where StdUsn='" + UsnCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                studname = dr["StdName"].ToString();
                roomname = dr["StdRoom"].ToString();
                StudentNameTb.Text = studname;
                RoomNumTb.Text = roomname;

            }
            con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsnCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fecthdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PaymentIdTb.Text == "" || StudentNameTb.Text == "" || UsnCb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                string paymentperiode;
                paymentperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Fees_tbl where StudentUSN='" + UsnCb.SelectedValue.ToString() + "' and PaymentMonth='" + paymentperiode.ToString() + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is No Due For this Month");
                }
                else
                {
                    //  con.Open();
                    string query = "insert into Fees_tbl values(" + PaymentIdTb.Text + ",'" + UsnCb.SelectedItem.ToString() + "','" + StudentNameTb.Text + "'," + RoomNumTb.Text + ",'" + paymentperiode + "','" + AmountTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment Sucess");
                    con.Close();
                    FillFeesDGV();
                    // FillRoomDGV();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (PaymentIdTb.Text == "")
            {
                MessageBox.Show("Enter Payment Id Correctly");
            }
            else
            {
                con.Open();
                string query = "delete from Fees_tbl where PaymentId='" + PaymentIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Payment Deleted Sucessfully");
                con.Close();
                FillFeesDGV();
            }
        }

        private void PaymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PaymentIdTb.Text = PaymentDGV.SelectedRows[0].Cells[0].Value.ToString();
            UsnCb.SelectedItem = PaymentDGV.SelectedRows[0].Cells[1].Value.ToString();
            StudentNameTb.Text = PaymentDGV.SelectedRows[0].Cells[2].Value.ToString();
            RoomNumTb.Text = PaymentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AmountTb.Text = PaymentDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PaymentIdTb.Text == "")
            {
                MessageBox.Show("Enter The Room Number");
            }
            else
            {
                if (PaymentIdTb.Text == "")
                {
                    MessageBox.Show("Enter The Payment Id Correctly");
                }
                else
                {
                    string paymentperiode;
                    paymentperiode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString();
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Fees_tbl where StudentUSN='" + UsnCb.SelectedValue.ToString() + "' and PaymentMonth='" + paymentperiode.ToString() + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("There is No Due For this Month");
                    }
                    else
                    {
                        con.Open();
                        string query = "update Room_tbl set StudentUSN='" + UsnCb.SelectedItem.ToString() + "',Studentname='" + StudentNameTb.Text + "',StdRoom='" + RoomNumTb.Text + "',PayemntMonth='" + paymentperiode + "' where PaymentId=" + PaymentIdTb.Text + "";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Room Updated Sucessfully");
                        con.Close();
                        FillFeesDGV();
                        // FillRoomDGV();
                    }
                }
            }
        }

        private void fees_Load(object sender, EventArgs e)
        {
            fillUsnCb();
            FillFeesDGV();


        }
    }
}
