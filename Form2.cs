
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class Employees_info : Form
    {
        SqlConnection conn = new SqlConnection("server=SQLNCLIRDA11;Data Source=DESKTOP-467C815\\HOSSAM;Integrated Security=SSPI;Initial Catalog=Employeess");

        void fillcombo()
        {
            conn.Open();
            String q = "select * from Nationalities";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();


            adapter.Fill(datatable);
//
            CombNat.DataSource = datatable;

            CombNat.DisplayMember = "Nationality";

            conn.Close();

        }
        public Employees_info()
        {
            InitializeComponent();
            fillcombo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CombNat_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String gender = "Not Set", hoppy = "Not Set";
            // Check if the the are andy selected
            if (Rdm.Checked == true)
            {
                gender = "Male";
            } else {
                gender = "Famel";
                    };
            if (sport.Checked == true)
            {
                hoppy = "Sports";
            }
            if(reading.Checked == true)
            {
                hoppy = "Reading";
            };

            String q = "insert into Emps_info values ('"+ textID.Text + "' , '" + textFname.Text + "' , '" + textSname.Text + "' , '" + textLname.Text + "'  , '" + DOB.Value + "' ,'" + CombNat.Text + "' ,'" + gender + "','" + hoppy + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);


        }
    }
}
