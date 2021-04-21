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
    public partial class add_patient2 : Form
    {
        public add_patient2()
        {
            InitializeComponent();
        }
        
        private void btnView_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();
            String name = txtfname.Text;
            String lname = txtsurname.Text;
            String age = txtGender.Text;
            String address = txtAddress.Text;

            String gender = String.Empty;
            if (radioButton1.Checked)
            {
                gender = "Female";
            }
            else if (radioButton2.Checked)
            {
                gender = "Male";
            }
            String phone = textBox1.Text;

            if (name != "" && lname != "" && age != "" && address != "" && phone != "")
            {


                SqlCommand cmd = new SqlCommand("INSERT into patient (first_name,Last_name,Age,Gender,Address,date)VALUES(@name,@lname,@age,@gender,@address,@our_date)", con);


                cmd.Parameters.Add(new SqlParameter("@name", name));
                cmd.Parameters.Add(new SqlParameter("@lname", lname));
                cmd.Parameters.Add(new SqlParameter("@gender", gender));
                cmd.Parameters.Add(new SqlParameter("@age", age));
                cmd.Parameters.Add(new SqlParameter("@address", address));

                cmd.Parameters.Add(new SqlParameter("@our_date", this.dateTimePicker1.Value));

                int mz = cmd.ExecuteNonQuery();
                if (mz == 0)
                {
                    MessageBox.Show("Fail To Insert Data ");
                }
                else if (mz == 1)
                {
                    //MessageBox.Show("The patient inserted succesfully");
                    MessageBox.Show("The patient inserted succesfully", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Home frm1 = new Home();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("User does not exist");
                }
            }
           else

            {
                MessageBox.Show("Fill the form");
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
