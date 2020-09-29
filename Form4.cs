
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

namespace Gym_Mangement_System
{
    public partial class SearchMember : Form
    {
        public SearchMember()
        {
            InitializeComponent();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

          //  string local = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocal = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
            string kk1 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk11 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            con.ConnectionString = kk11;
            con.Open();
            string k = "select * from gymtable";
            
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
           

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            string local = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocall = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
            string kk1 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk11 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            con.ConnectionString = kk11;
            con.Open();
            string k = "select * from gymtable where firstname = " + "'"+ textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //MessageBox.Show("New Member Joinded");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
