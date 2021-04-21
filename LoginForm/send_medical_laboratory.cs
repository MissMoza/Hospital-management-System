using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class send_medical_laboratory : Form
    {
        public send_medical_laboratory()
        {
            InitializeComponent();
        }
        private void send_medical_laboratory_Load(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();


            SqlCommand com2 = new SqlCommand("SELECT * FROM patient", con);
            SqlDataReader r2 = com2.ExecuteReader();
            while (r2.Read() == true)
            {
                String x3 = r2["Last_name"].ToString();
                String x2 = r2["first_name"].ToString();
                comboBox1.Items.Add(x2 + "  " + x3);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

                if (textBox2.Text == null || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("One of the input is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
                    SqlConnection con = new SqlConnection(co);
                    con.Open();
                    String query1 = "SELECT patient_id from patient WHERE CONCAT(first_name,'  ',Last_name) = '" + comboBox1.SelectedItem + "'";
                    SqlCommand com2 = new SqlCommand(query1, con);
                   SqlDataAdapter adap1 = new SqlDataAdapter(com2);
                    DataTable t1 = new DataTable();
                    adap1.Fill(t1);
                    if (t1.Rows.Count > 0)
                    {
                        

                        DataRow r1 = t1.Rows[0];
                        String patient_id = r1["patient_id"].ToString();
                       // MessageBox.Show(patient_id);
                        String type = comboBox2.SelectedItem.ToString();
                        SqlCommand run1 = new SqlCommand("INSERT INTO measurement VALUES ('" + type + "','" + textBox2.Text + "')", con);
                        
                        run1.ExecuteNonQuery();
                        //MessageBox.Show(type); 


                        //MessageBox.Show(textBox2.Text);
                        //MessageBox.Show("The measurement inserted", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                       
                        SqlCommand run2 = new SqlCommand("SELECT measument_id FROM measurement WHERE measurement_type = '" + type + "' AND description = '" + textBox2.Text + "'", con);
                        SqlDataAdapter adap2 = new SqlDataAdapter(run2);
                        DataTable t3 = new DataTable();
                        adap2.Fill(t3);
                        DataRow r4 = t3.Rows[0];
                        String measure = r4["measument_id"].ToString();

                        String query2 = "INSERT INTO measure_patient (patient_id,measurement_id) VALUES ('" + patient_id + "','" + measure + "')";

                        SqlCommand com6 = new SqlCommand(query2, con);
                        int xxx = com6.ExecuteNonQuery();
                        if (xxx != 0)
                        {
                            MessageBox.Show("The measurement inserted", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }
                        this.Hide();

                        
                    }

                }

            }

         

        }
    }

