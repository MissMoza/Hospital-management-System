using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class view_lab_result : Form
    {
        public view_lab_result()
        {
            InitializeComponent();
        }

        private void view_lab_result_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String query2 = " select first_name,Last_name,date,result from patient,measure_patient,lab_result where patient.patient_id=measure_patient.patient_id AND measure_patient.m_p_id=lab_result.m_p_id AND patient.first_name= '" + textBox1.Text + "' ";
            
            SqlCommand query3 = new SqlCommand(query2, con);

            SqlDataAdapter adap1 = new SqlDataAdapter(query3);
            DataSet se1 = new DataSet();
            adap1.Fill(se1);

            dataGridView1.DataSource = se1.Tables[0];
        }
    }
}
