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
    public partial class updat_laboratory : Form
    {
        public updat_laboratory()
        {
            InitializeComponent();
        }

        
        private void updat_laboratory_Load(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_laboratory_Load(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            SqlCommand query1 = new SqlCommand("    select   measument_id, first_name,measurement_type,description from patient,measurement,measure_patient where patient.patient_id=measure_patient.patient_id AND measurement.measument_id=measure_patient.measurement_id ", con);
            SqlDataAdapter cmd = new SqlDataAdapter(query1);
            DataSet get = new DataSet();
            cmd.Fill(get);

            dataGridView1.DataSource = get.Tables[0];
        }
        String tatma;
        Int64 Mo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {

                tatma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            panel1.Visible = true;

            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String cmd = "    select   measument_id, first_name,measurement_type,description from patient,measurement,measure_patient where patient.patient_id=measure_patient.patient_id AND measurement.measument_id=measure_patient.measurement_id AND measument_id='" + tatma + "'";
            SqlCommand chota = new SqlCommand(cmd, con);
            SqlDataAdapter adapt = new SqlDataAdapter(chota);
            DataSet set1 = new DataSet();
            adapt.Fill(set1);
            Mo = Int64.Parse(set1.Tables[0].Rows[0][0].ToString());
            textBox1.Text = set1.Tables[0].Rows[0][1].ToString();
            textBox3.Text = set1.Tables[0].Rows[0][2].ToString();
            textBox2.Text = set1.Tables[0].Rows[0][3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            string query = "UPDATE measurement SET measurement_type='" + textBox3.Text + "',description='" + textBox2.Text + "' WHERE  measurement.measument_id='" + tatma + "'";
            SqlCommand moza = new SqlCommand(query, con);
            moza.ExecuteNonQuery();

            MessageBox.Show("Patient update successfully");
           // this.Hide();
            var x = new updat_laboratory();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String delete = "DELETE FROM measurement WHERE measurement.measument_id = '" + tatma + "'";
            SqlCommand del = new SqlCommand(delete, con);
            MessageBox.Show("Patient Delete from the system");
            del.ExecuteNonQuery();
            //this.Hide();
            var x = new updat_laboratory();
            x.Show();
        }
    }
}
