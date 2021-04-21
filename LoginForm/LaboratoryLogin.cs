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
    public partial class LaboratoryLogin : Form
    {
        public LaboratoryLogin()
        {
            InitializeComponent();
        }

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_doctor_measurement form10 = new view_doctor_measurement();
            form10.Show();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab_result form4 = new lab_result();
            form4.Show();
        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_lab lab = new view_lab();
            lab.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_lab_request shida = new Update_lab_request();
            shida.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login hasuko = new Login();
            hasuko.Show();
            this.Hide();
        }

        private void LaboratoryLogin_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
