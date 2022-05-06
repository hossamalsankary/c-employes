
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
    public partial class mobile_shop : Form
    {
        SqlConnection conn = new SqlConnection("server=SQLNCLIRDA11;Data Source=DESKTOP-467C815\\HOSSAM;Integrated Security=SSPI;Initial Catalog=mopile_shop");
        String imgName = "";
        String ImgUrl = "";
        void fillcombo()
        {
            conn.Open();
            String q = "select * from brand";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();


            adapter.Fill(datatable);
//
            CombNat.DataSource = datatable;

            CombNat.DisplayMember = "brand";

            conn.Close();

        }
        void fillgridViwe()
        {
            conn.Open();
            String q = "select * from Prodect_info_add";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();


            adapter.Fill(datatable);
            //
            dataGridView1.DataSource = datatable;

            conn.Close();

        }

        public mobile_shop()
        {
            InitializeComponent();
            fillcombo();
            fillgridViwe(); 
        }
        public String status = "Not Set";


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
                status = "Available";
            } else {
                status = "UnAvailable";
                    };
          
            if (textID.Text == "" || Pname.Text == " " || Pname.Text == " " || des.Text == "")
            {
                MessageBox.Show("Plaze fill All Data");
                textID.Clear();
                Pname.Clear();
            }
            else
            {
                try
                {
                    String q = "insert into Prodect_info_add values ('" + textID.Text + "' , '" + Pname.Text + "' , '" + des.Text + "'  , '" + DOB.Value + "' ,'" + CombNat.Text + "' ,'" + status + "' ,'" + File.ReadAllBytes(ImgUrl) + "' ,'" + ImgUrl + "'  )";
                    SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
                    DataTable datatable = new DataTable();
                    adapter.Fill(datatable);
                    fillgridViwe();

                    textID.Clear();
                    Pname.Clear();
                    Pname.Clear();
                    des.Clear();
                    MessageBox.Show("Employe has bee Add");
                }
                catch (Exception error){
                    MessageBox.Show(error.Message);

                }



            }

        }

        private void dataGridView1_CellContentClick(object sender,DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            textID.Text = (String)dataGridView1[0, rowIndex].Value;
            Pname.Text = (String)dataGridView1[1, rowIndex].Value;
            des.Text = (String)dataGridView1[2, rowIndex].Value;
            Pname.Text = (String)dataGridView1[3, rowIndex].Value;
            DOB.Value = (DateTime)dataGridView1[4, rowIndex].Value;
            CombNat.Text = (String)dataGridView1[5, rowIndex].Value;

           if(  (String)dataGridView1[6, rowIndex].Value == "Unavailable")
            {
                Rdm.Checked = true;
            }
            else
            {
                Rdm.Checked = false;

            }

        




        }

        private void button3_Click(object sender, EventArgs e)
        {
            String q = "Delete from Prodect_info_add where ID ='" + textID.Text + "' ";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            MessageBox.Show("Deleted");

            fillgridViwe();
        }

        private void Employees_info_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            String q = "Update Prodect_info_add set Pname =  '" + Pname.Text + "' , Description = '" + des.Text + "'  , Pdate = '" + DOB.Value + "' , Brand =  '" + CombNat.Text + "' ,Status = '" + status + "' where ID ='" + textID.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(q, conn);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            MessageBox.Show("Update");

            fillgridViwe();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Select_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Images|*.jpg;*.png;*.gif;.bmp";
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            of.FilterIndex = 0;
            if (of.ShowDialog() == DialogResult.OK)
            {
                imgName = of.FileName;
                ImgUrl = imgName;

                pictureBox.Image = Image.FromFile(of.FileName);
            }
        }
       

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
