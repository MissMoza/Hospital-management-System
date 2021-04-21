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
    public partial class Home : Form
    {
        public string user, pass;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void labResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewPatientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add_patient form1 = new add_patient();
            //form1.Show();
        }

        private void patientInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_patient_after_registration form2 = new view_patient_after_registration();
            form2.Show();
            
                
        }

        private void labResultToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            send_medical_laboratory form2 = new send_medical_laboratory();
            form2.Show();

           
            
        }

        private void sendRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lab_result form4 = new lab_result();
            form4.Show();
            
        }

        private void allMedicalLaboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_lab lab = new view_lab();
            lab.Show();
            
        }

        private void viewResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_doctor_measurement form10= new view_doctor_measurement() ;
            form10.Show();
           
        }

        private void labResultToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            view_lab_result h = new view_lab_result();
            h.Show();
           
        }

        private void doctorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_lab_request shida = new Update_lab_request();
            shida.Show();
        }

        private void updateMedicalLaboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updat_laboratory me = new updat_laboratory();
            me.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login me = new Login();
            me.Show();
            this.Hide();
        }

        private void sendMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send_medicine send = new Send_medicine();
            send.Show();
        }

        private void viewPatientMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_medicine medicine = new view_medicine();
            medicine.Show();

        }

        private void sendPatientMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChetiChaMgonjwa cheti = new ChetiChaMgonjwa();
            cheti.Show();
        }
    }
}
