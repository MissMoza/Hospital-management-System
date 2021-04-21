using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class ChetiChaMgonjwa : Form
    {
        public ChetiChaMgonjwa()
        {
            InitializeComponent();
        }

        private void ChetiChaMgonjwa_Load(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String query1 = "SELECT * FROM patient";
            SqlCommand com1 = new SqlCommand(query1, con);
            SqlDataReader r1 = com1.ExecuteReader();
            while (r1.Read() == true)
            {
                String x = r1["Last_name"].ToString();
                String x2 = r1["first_name"].ToString();
                comboBox2.Items.Add(x2 + "  " + x);
            }
        }
        private void button1_Click(object sender, EventArgs e)

        {
             if    ( comboBox2.SelectedIndex == -1 || richTextBox1.Text == null )
                {
                    MessageBox.Show("One of the input is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String query1 = "SELECT medicine_patient.med_id,medicine_patient.patient_id FROM medicine_patient,patient WHERE patient.patient_id = medicine_patient.patient_id AND CONCAT(first_name,'  ',Last_name) = '" + comboBox2.SelectedItem.ToString() + "'";
            SqlCommand com2 = new SqlCommand(query1, con);
            SqlDataAdapter adap1 = new SqlDataAdapter(com2);
            DataTable t1 = new DataTable();
            adap1.Fill(t1);
            if (t1.Rows.Count > 0)
            {
                DataRow r1 = t1.Rows[0];
                String med_id = r1["med_id"].ToString();
                SqlCommand run1 = new SqlCommand("INSERT INTO medicine_result (med_id,description) VALUES ('" + med_id + "','" + richTextBox1.Text + "')", con);
                    run1.ExecuteNonQuery();
                    MessageBox.Show("The Medicine Submitted", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            this.Hide();
            }
        }
        }
    }

    

