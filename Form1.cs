namespace WinFormsApp_project_51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rooms r1= new rooms();
            r1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            student s= new student();   
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employee e1= new employee();
            e1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fees f1 = new fees();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            salary s1 = new salary();
            s1.Show();
            this.Hide();
        }
    }
}