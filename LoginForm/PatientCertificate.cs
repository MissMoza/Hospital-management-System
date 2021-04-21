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
    public partial class PatientCertificate : Form
    {
        public PatientCertificate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                //if (textBox2.Text == null || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                //{
                   // MessageBox.Show("One of the input is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                //else
                //{
                    String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
                    SqlConnection con = new SqlConnection(co);
                    con.Open();
                    String query1 = "SELECT patient_id,Age,address from patient WHERE CONCAT(first_name,'  ',Last_name) = '" + txtfname.Text + "'";
                    SqlCommand com2 = new SqlCommand(query1, con);
                   SqlDataAdapter adap1 = new SqlDataAdapter(com2);
                    DataTable t1 = new DataTable();
                    adap1.Fill(t1);
                    if (t1.Rows.Count > 0)
                    {


                        DataRow r1 = t1.Rows[0];
                        String patient_id = r1["patient_id"].ToString();


                    }

        }
    }
}
