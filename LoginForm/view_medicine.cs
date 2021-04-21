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
    public partial class view_medicine : Form
    {
        public view_medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String query2 = "Select first_name,date, medicine_name,medicine.description from medicine,medicine_patient,patient WHERE patient.patient_id=medicine_patient.patient_id AND medicine.medicine_id=medicine_patient.medicine_id   AND patient.first_name='" + textBox1.Text + "' ";
           

            SqlCommand query3 = new SqlCommand(query2, con);

            SqlDataAdapter adap1 = new SqlDataAdapter(query3);
            DataSet se1 = new DataSet();
            adap1.Fill(se1);

            dataGridView1.DataSource = se1.Tables[0];


        }

        private void view_medicine_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     
    }
}
