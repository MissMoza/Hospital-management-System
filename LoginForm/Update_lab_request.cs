using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Update_lab_request : Form
    {
        public Update_lab_request()
        {
            InitializeComponent();
        }

        

        private void Update_lab_request_Load(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            SqlCommand moza = new SqlCommand("select l_r_id, first_name,Last_name,date,result from patient,measure_patient,lab_result where patient.patient_id=measure_patient.patient_id AND measure_patient.m_p_id=lab_result.m_p_id", con);
            SqlDataAdapter cmd = new SqlDataAdapter(moza);
            DataSet set = new DataSet();
            cmd.Fill(set);

            dataGridView1.DataSource = set.Tables[0];

        }
        String x;
        Int64 Mo;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {

                x = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            panel1.Visible = true;


            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String cmd = "select l_r_id,first_name,result from patient,measure_patient,lab_result where patient.patient_id=measure_patient.patient_id AND measure_patient.m_p_id=lab_result.m_p_id AND lab_result.l_r_id='" + x + "'";
            SqlCommand chota = new SqlCommand(cmd, con);
            SqlDataAdapter adapt = new SqlDataAdapter(chota);
            DataSet set1 = new DataSet();
            adapt.Fill(set1);
            Mo = Int64.Parse(set1.Tables[0].Rows[0][0].ToString());
            textBox2.Text = set1.Tables[0].Rows[0][1].ToString();
            textBox1.Text = set1.Tables[0].Rows[0][2].ToString();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            string query = "UPDATE lab_result SET result='" + textBox1.Text + "' WHERE  lab_result.l_r_id='" + x + "'";
            SqlCommand moza = new SqlCommand(query, con);
            moza.ExecuteNonQuery();
            MessageBox.Show("Patient update successfully");
            //this.Hide();
            var y = new Update_lab_request();
            y.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String delete = "DELETE FROM lab_result WHERE lab_result.l_r_id = '" + x + "'";
            SqlCommand del = new SqlCommand(delete, con);
            del.ExecuteNonQuery();
            MessageBox.Show("You delete the patient","Warning");
            //this.Hide();
            var me = new view_patient();
            me.Show();
        }
    }
}
