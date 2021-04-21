using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class HomeReception : Form
    {
        public HomeReception()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void patientInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void viewPatientToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void patientToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeReception_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_patient2 moza = new add_patient2();
            moza.Show();
        }

        private void viewPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_patient chota = new view_patient();
            chota.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login poly = new Login();
            poly.Show();

            this.Hide();


           
        }

        private void viewMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_medicine_result me = new view_medicine_result();
            me.Show();
        }

        private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_all_partient_process me = new view_all_partient_process();
            me.Show();
        }
    }
}
