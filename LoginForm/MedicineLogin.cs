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
    public partial class MedicineLogin : Form
    {
        public MedicineLogin()
        {
            InitializeComponent();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_medicine medicine = new view_medicine();
            medicine.Show();
        }

        private void sendPatientMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChetiChaMgonjwa cheti = new ChetiChaMgonjwa();
            cheti.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login hasuko = new Login();
            hasuko.Show();
            this.Hide();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_all_partient_process me = new view_all_partient_process();
            me.Show();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
