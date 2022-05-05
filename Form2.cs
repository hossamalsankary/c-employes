
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
        void fillgridViwe()
        {
            conn.Open();
            String q = "select * from Emps_info";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();


            adapter.Fill(datatable);
            //
            dataGridView1.DataSource = datatable;

            conn.Close();

        }

        public Employees_info()
        {
            InitializeComponent();
            fillcombo();
            fillgridViwe(); 
        }
      public  String gender = "Not Set", hoppy = "Not Set";


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
            }else if(reading.Checked == true)
            {
                hoppy = "Reading";
            }
            else
            {
                hoppy = "Sports & Reading";
            }
            if (textID.Text == "" || textFname.Text == " " || textLname.Text == " " || textSname.Text == "")
            {
                MessageBox.Show("Plaze fill All Data");
                textID.Clear();
                textFname.Clear();
            }
            else
            {
                try
                {
                    String q = "insert into Emps_info values ('" + textID.Text + "' , '" + textFname.Text + "' , '" + textSname.Text + "' , '" + textLname.Text + "'  , '" + DOB.Value + "' ,'" + CombNat.Text + "' ,'" + gender + "','" + hoppy + "')";
                    SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    fillgridViwe();

                    textID.Clear();
                    textFname.Clear();
                    textLname.Clear();
                    textSname.Clear();
                    MessageBox.Show("Employe has bee Add");
                }
                catch {
                    MessageBox.Show("Change the ID Filld");

                }



            }

        }

        private void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            textID.Text = (String)dataGridView1[0, rowIndex].Value;
            textFname.Text = (String)dataGridView1[1, rowIndex].Value;
            textSname.Text = (String)dataGridView1[2, rowIndex].Value;
            textLname.Text = (String)dataGridView1[3, rowIndex].Value;
            DOB.Value = (DateTime)dataGridView1[4, rowIndex].Value;
            CombNat.Text = (String)dataGridView1[5, rowIndex].Value;

           if(  (String)dataGridView1[6, rowIndex].Value == "Male")
            {
                Rdm.Checked = true;
            }
            else
            {
                Rdm.Checked = false;

            }

            if ((String)dataGridView1[7, rowIndex].Value == "Sports")
            {
                sport.Checked =true;
            }
            else if ( (String)dataGridView1[7, rowIndex].Value == "Reading")
            {
                reading.Checked = true;

            }else if ((String)dataGridView1[7, rowIndex].Value == "Sports & Reading")
            {
                reading.Checked = true;
                sport.Checked = true;

            }
            else
            {
                reading.Checked = false;
                sport.Checked = false;
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            String q = "Delete from Emps_info where ID ='" + textID.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            MessageBox.Show("Deleted");

            fillgridViwe();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String q = "Update Emps_info set Fname =  '" + textFname.Text + "' , Sname = '" + textSname.Text + "' ,  Lname = '" + textLname.Text + "'  , DOB = '" + DOB.Value + "' , Nationality =  '" + CombNat.Text + "' ,Gender = '" + gender + "',Hobbies = '" + hoppy + "' where ID ='" + textID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            MessageBox.Show("Update");

            fillgridViwe();
        }
    }
}
