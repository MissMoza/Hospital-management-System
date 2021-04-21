using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class seeMedical : Form
    {
        public seeMedical()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            //String query2 = "Select first_name,date, measurement_type,description from measurement,measure_patient,patient WHERE patient.patient_id=measure_patient.patient_id AND measurement.measument_id=measure_patient.measurement_id AND patient.first_name='" + textBox1.Text + "' ";
            String query2 = "Select first_name,date, measurement_type,description from measurement,patient WHERE patient.patient_id=measurement.patient_id  AND patient.first_name='" + textBox1.Text + "' "; 
            

            SqlCommand query3 = new SqlCommand(query2, con);

            SqlDataAdapter adap1 = new SqlDataAdapter(query3);
            DataSet se1 = new DataSet();
            adap1.Fill(se1);

            dataGridView1.DataSource = se1.Tables[0];
        }
    }
}
