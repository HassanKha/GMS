using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using static System.Data.DataSet;
namespace WindowsFormsApp1
{
    public partial class Newmember : Form
    {
        public Newmember()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string fname = fn.Text;
           // string lname = ln.Text;
            string startd = dttb.Text;
            string endd = edtb.Text;
            string Prise = pptb.Text;

            string mobilen = mntb.Text;
          //  string id = idtb.Text;



            
            SqlConnection con = new SqlConnection();
            string local = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocall = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
            string kk1 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk11 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            con.ConnectionString = kk11;
            con.Open();
            string k = "insert into gymtable (firstname,startdate,enddate,mobile,price) values(" + "'" + fname + "','" + startd + "','" + endd + "','" + mobilen + "','" + Prise + "')"; 
            SqlCommand cmd = new SqlCommand(k,con);
            //string h= "insert into gymtable (id,firstname,lastname,startdate,enddate,mobile,price) values(" + id + "," + fname + "," + lname + "," + startd + "," + endd + "," + mobilen + "," + Prise + ")";
            //cmd.CommandText = "insert into gymtable (id,firstname,lastname,startdate,enddate,mobile,price) values('" + id + "','" + fname + "','" + lname + "','" + startd + "','" + endd + "','" + mobilen + "','" + Prise + "')";
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("New Member Joinded");
            
            

           

            
        }
    





        private void button2_Click(object sender, EventArgs e)
        {
           fn.Clear();
            
            pptb.Clear();
           edtb.ResetText();
           dttb.ResetText();
           mntb.Clear();
          
        }

        private void Newmember_Load(object sender, EventArgs e)
        {
           


        }
    }
}
