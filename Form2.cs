
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
            DataSet sadatset = new DataSet();


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
    }
}
