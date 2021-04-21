using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class view_patient : Form
    {
        public view_patient()
        {
            InitializeComponent();
        }

        private void view_patient_Load(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();


            SqlCommand moza = new SqlCommand("Select*from patient", con);
            SqlDataAdapter cmd = new SqlDataAdapter(moza);
            DataSet set = new DataSet();
            cmd.Fill(set);

            dataGridView1.DataSource = set.Tables[0];

        }

        String y;
        Int64 Mo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
            {

                y = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            }
            panel1.Visible = true;

            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();


            String cmd = "Select * from patient where patient_id =" + y + "";
            SqlCommand chota = new SqlCommand(cmd, con);
            SqlDataAdapter adapt = new SqlDataAdapter(chota);
            DataSet set1 = new DataSet();
            adapt.Fill(set1);
            Mo = Int64.Parse(set1.Tables[0].Rows[0][0].ToString());
            text1.Text = set1.Tables[0].Rows[0][1].ToString();
            text2.Text = set1.Tables[0].Rows[0][2].ToString();
            comboBox1.SelectedItem = set1.Tables[0].Rows[0][4].ToString();
            text4.Text = set1.Tables[0].Rows[0][3].ToString();
            text5.Text = set1.Tables[0].Rows[0][5].ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            string query = "UPDATE patient SET first_name='" + text1.Text + "', Last_name= '" + text2.Text + "', Gender='" + comboBox1.SelectedItem + "', Age='" + text4.Text + "', Address='" + text5.Text + "' WHERE  patient.patient_id='" + y + "'";
            SqlCommand moza = new SqlCommand(query, con);
            moza.ExecuteNonQuery();

            MessageBox.Show("Patient update successfully");
            this.Hide();
            var x = new view_patient();
            x.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String delete = "DELETE FROM patient WHERE patient.patient_id = '"+y+"'";
            SqlCommand del = new SqlCommand(delete,con);
            del.ExecuteNonQuery();
            this.Hide();
            var x = new view_patient();
            x.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
