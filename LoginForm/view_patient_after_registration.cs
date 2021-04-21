using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class view_patient_after_registration : Form
    {
        public view_patient_after_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String query2 = "Select first_name, Last_name,  Age,Gender, Address,  date  from patient WHERE patient.first_name='" + textBox1.Text + "' ";

            SqlCommand query3 = new SqlCommand(query2, con);

            SqlDataAdapter adap1 = new SqlDataAdapter(query3);
            DataSet se2 = new DataSet();
            adap1.Fill(se2);

            dataGridView1.DataSource = se2.Tables[0];
            
        }

        private void view_patient_after_registration_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
