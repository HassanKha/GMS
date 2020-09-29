using Gym_Mangement_System;
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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class GymManagmentSystem : Form
    {
        public GymManagmentSystem()
        {
            InitializeComponent();
        }
        private void ok()
        {
            SqlConnection conn = new SqlConnection();

            string local = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocall = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
            string path = Path.GetFullPath(Environment.CurrentDirectory);
            string db = "gym1.mdf";
            string m = @"Server=.\SQLExpress; AttachDbFilename=" + path+ @"\"+db+ ";Integrated Security=True";
            string kk1 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk11 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            conn.ConnectionString = kk11;
            conn.Open();
            string kk = "INSERT INTO deletegymtable select * from gymtable where(SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > (SELECT CAST(enddate AS datetime))";
            SqlCommand cmdd = new SqlCommand(kk, conn);
            cmdd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmdd);
            daa.Fill(dtt);
        }

        void addNewMember(object sender, EventArgs e)
        {
            
            Newmember ad = new Newmember();
            ad.Show();
            ok();
        }

        private void deleteMember(object sender, EventArgs e)
        {
            Form4 ad = new Form4();
            ad.Show();
            ok();
        }
       
     
        private void searchMember(object sender, EventArgs e)
        {
              SearchMember s = new SearchMember();
               s.Show();

            SqlConnection conn = new SqlConnection();

            string local = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocall = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
            string kk1 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk11 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            conn.ConnectionString = kk11;
            //  conn.ConnectionString = kk1;
            conn.Open();
            string kk = "INSERT INTO deletegymtable select * from gymtable where(SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > (SELECT CAST(enddate AS datetime))";
            SqlCommand cmdd = new SqlCommand(kk, conn);
            cmdd.ExecuteNonQuery();
            DataTable dtt = new DataTable();
            SqlDataAdapter daa = new SqlDataAdapter(cmdd);
            daa.Fill(dtt);





            SqlConnection con = new SqlConnection();

            string locall = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hassankh\source\repos\GymMangementSystem8\GMS\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            string nlocal = @"Data Source=DESKTOP-GIQC5E8\SQLEXPRESS;Integrated Security=True";
              string m = @"Data Source=.; AttachDbFileName=|DataDirectory|\Data\gym.mdf;Initial Catalog=gym;  Integrated Security=True";
            string kgk = @"Data Source=.\SQLEXPRESS;Integrated Security=True;User Instance=True;AttachDBFilename=|DataDirectory|gym.mdf";
            string kk111 = @"Data Source=.\SQLEXPRESS;Integrated Security=True;database=gym";
            conn.ConnectionString = kk111;
            // con.ConnectionString = nlocal;
            con.Open();
            string k = "delete from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))";
            SqlCommand cmd = new SqlCommand(k, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);


           

        }

      
        private void exitAppliction(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



            ok();



          //  SqlConnection con = new SqlConnection();


         //   con.ConnectionString = "Data Source=DESKTOP-GIQC5E8;Initial Catalog=gym;Integrated Security=True";
         //   con.Open();
         //   string k = "delete from gymtable where ( SELECT FORMAT (getdate(), 'MM/dd/yyyy ')   ) > ( SELECT CAST(enddate AS datetime))";
         //   SqlCommand cmd = new SqlCommand(k, con);
        //    cmd.ExecuteNonQuery();
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);


         

            //MessageBox.Show("New Member Joinded");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeletedList l = new DeletedList();
            l.Show();
            ok();
        }
    }
}
