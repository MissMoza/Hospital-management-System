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
    public partial class lab_result : Form
    {
        public lab_result()
        {
            InitializeComponent();
        }

        private void lab_result_Load(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            //String query1 = "SELECT m_p_id,measure_patient.patient_id,first_name,Last_name from patient,measure_patient WHERE patient.patient_id = measure_patient.patient_id";
            //SqlCommand com1 = new SqlCommand(query1, con);
            SqlCommand com2 = new SqlCommand("SELECT * FROM patient", con);
            SqlDataReader r2 = com2.ExecuteReader();
            while (r2.Read() == true)
            {
                String x = r2["Last_name"].ToString();
                String x2 = r2["first_name"].ToString();
                comboBox2.Items.Add(x2 + "  " + x);
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            //String combo = comboBox2.SelectedText.ToString();
            //String text = textBox2.Text.ToString();
           // if (combo != "" && text != "")
           // {
            if (comboBox2.SelectedIndex == -1 || textBox2.Text == null)
            {
                MessageBox.Show("One of the input is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                SqlConnection con = new SqlConnection(co);
                con.Open();
                String query1 = "SELECT measure_patient.m_p_id,measure_patient.patient_id FROM measure_patient,patient WHERE patient.patient_id = measure_patient.patient_id AND CONCAT(first_name,'  ',Last_name) = '" + comboBox2.SelectedItem.ToString() + "'";
                //String query1 = "SELECT measure_patient.m_p_id from measure_patient,patient WHERE patient.patient_id = measure_patient.patient_id AND CONCAT(first_name,'  ',Last_name) = 'Hamisa  Yahya' ";


                SqlCommand com2 = new SqlCommand(query1, con);
                SqlDataAdapter adap1 = new SqlDataAdapter(com2);
                DataTable t1 = new DataTable();
                adap1.Fill(t1);
                if (t1.Rows.Count > 0)
                {
                    DataRow r1 = t1.Rows[0];
                    String m_p_id = r1["m_p_id"].ToString();

                    SqlCommand run1 = new SqlCommand("INSERT INTO lab_result (m_p_id,result) VALUES ('" + m_p_id + "','" + textBox2.Text + "')", con);
                    run1.ExecuteNonQuery();
                    MessageBox.Show("The Result Submitted", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    this.Hide();
                }
            }
           // }
        //else
    //{
        //MessageBox.Show("Fill the form");
    //}
}


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
