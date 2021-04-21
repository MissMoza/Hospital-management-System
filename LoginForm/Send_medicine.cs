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
    public partial class Send_medicine : Form
    {
        public Send_medicine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || textBox1.Text == null)
            {
                MessageBox.Show("One of the input is Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
                SqlConnection con = new SqlConnection(co);
                con.Open();
                String combo = comboBox1.SelectedItem.ToString();
                String query1 = "SELECT patient_id from patient WHERE CONCAT(first_name,'  ',Last_name) = '" + combo + "'";
                SqlCommand com2 = new SqlCommand(query1, con);
                SqlDataAdapter adap1 = new SqlDataAdapter(com2);
                DataTable t1 = new DataTable();
                adap1.Fill(t1);
                if (t1.Rows.Count > 0)
                {
                    DataRow r1 = t1.Rows[0];
                    String patient_id = r1["patient_id"].ToString();


                    String medicine = comboBox2.SelectedItem.ToString();
                    SqlCommand run1 = new SqlCommand("INSERT INTO medicine VALUES ('" + medicine + "','" + textBox1.Text + "')", con);
                    run1.ExecuteNonQuery();
                    SqlCommand run2 = new SqlCommand("SELECT medicine_id FROM medicine WHERE medicine_name = '" + medicine + "' AND description = '" + textBox1.Text + "'", con);
                    SqlDataAdapter adap2 = new SqlDataAdapter(run2);
                    DataTable t3 = new DataTable();
                    adap2.Fill(t3);
                    DataRow r4 = t3.Rows[0];
                    String medicine1 = r4["medicine_id"].ToString();

                    String query2 = "INSERT INTO medicine_patient (patient_id,medicine_id) VALUES ('" + patient_id + "','" + medicine1 + "')";

                    SqlCommand com6 = new SqlCommand(query2, con);
                    int xxx = com6.ExecuteNonQuery();
                    if (xxx != 0)
                    {
                        MessageBox.Show("The medicine has been send sucessfull", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    this.Hide();
                }
            }

               }
        

        private void Send_medicine_Load(object sender, EventArgs e)
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
                comboBox1.Items.Add(x2 + "  " + x);
            }
        }
    }
}
