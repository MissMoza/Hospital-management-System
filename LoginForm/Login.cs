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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            try
            {
                //string co = @"Data Source=.\sqlexpress;Initial catalog=example;Integrated Security=True;";
                string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
                string user = firstname.Text.ToString();
                string pass = password.Text.ToString();


                if (user != "" && pass != "")
                {
                    SqlConnection con = new SqlConnection(co);
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE username=@Username AND password=@Password", con);

                    cmd.Parameters.AddWithValue("@Username", user);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {

                        if (dr["Role"].ToString() == "doctor" && dr["user_status"].ToString() == "admin" && dr["status"].ToString() == "active")
                        {
                            DialogResult moza = MessageBox.Show("Welcome " + dr["username"].ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (moza == DialogResult.Yes)
                            {
                                Home frm1 = new Home();
                                frm1.Show();
                                this.Hide();
                            }
                            if (moza == DialogResult.No)
                            {
                                Login c = new Login();
                                c.Show();
                            }

                            //MessageBox.Show("The patient inserted succesfully", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            //MessageBox.Show("Welcome " + dr["username"].ToString());


                        }
                        else if (dr["Role"].ToString() == "reception" && dr["user_status"].ToString() == "user" && dr["status"].ToString() == "active")
                        {

                            DialogResult moza = MessageBox.Show("Welcome " + dr["Role"].ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (moza == DialogResult.Yes)
                            {
                                HomeReception frm2 = new HomeReception();
                                frm2.Show();
                            }
                            if (moza == DialogResult.No)
                            {
                                Login c = new Login();
                                c.Show();
                            } this.Hide();
                            //MessageBox.Show("Welcome " + dr["username"].ToString());
                            //var frm2 = new HomeReception();
                            //f//rm2.Show();
                        }

                        else if (dr["Role"].ToString() == "laboratory" && dr["user_status"].ToString() == "user" && dr["status"].ToString() == "active")
                        {

                            DialogResult moza = MessageBox.Show("Welcome " + dr["Role"].ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (moza == DialogResult.Yes)
                            {
                                LaboratoryLogin frm2 = new LaboratoryLogin();
                                frm2.Show();
                            }
                            //if (moza == DialogResult.No)
                            else
                            {
                                Login c = new Login();
                                c.Show();
                            }
                            this.Hide();
                        }

                        else if (dr["Role"].ToString() == "phamacy" && dr["user_status"].ToString() == "user" && dr["status"].ToString() == "active")
                        {

                            DialogResult moza = MessageBox.Show("Welcome " + dr["Role"].ToString(), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (moza == DialogResult.Yes)
                            {
                                MedicineLogin frm2 = new MedicineLogin();
                                frm2.Show();
                            }
                            if (moza == DialogResult.No)
                            {
                                Login c = new Login();
                                c.Show();
                            }
                        } this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("One of the field is Empty");
                    }
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           first_page moza = new first_page();
           moza.Show();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
