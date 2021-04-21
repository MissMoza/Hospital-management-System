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
    public partial class tryMeasurement : Form
    {
        public tryMeasurement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String type = comboBox2.SelectedItem.ToString();
            SqlCommand run1 = new SqlCommand("INSERT INTO measurement VALUES ('" + type + "','" + textBox2.Text + "')", con);
            run1.ExecuteNonQuery();
            MessageBox.Show("The measurement inserted", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


            SqlCommand run2 = new SqlCommand("SELECT measument_id FROM measurement WHERE measurement_type = '" + type + "' AND description = '" + textBox2.Text + "'", con);
            SqlDataAdapter adap2 = new SqlDataAdapter(run2);
            DataTable t3 = new DataTable();
            adap2.Fill(t3);
        }

        private void tryMeasurement_Load(object sender, EventArgs e)
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

    }
}
