using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using test;

namespace test
{

    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("server=SQLNCLIRDA11;Data Source=DESKTOP-467C815\\HOSSAM;Integrated Security=SSPI;Initial Catalog=test");

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
                 }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String password = textBox2.Text;


            conn.Open();
            string sql = "SELECT count(*)  From users Where username='"+name+"' and password='"+password+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql , conn);
            DataTable datatable = new DataTable();

            da.Fill(datatable);
            if (datatable.Rows[0][0].ToString()=="1")
            {

                MessageBox.Show(" تم تسجيل الدخول بنجاح");
                this.Hide();

                mobile_shop open = new mobile_shop();
                open.Show();
            }
            else
            {
                MessageBox.Show("كلمة السر ليست صحيحه ");
            }



            conn.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}