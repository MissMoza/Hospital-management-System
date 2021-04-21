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
using DGVPrinterHelper;

namespace LoginForm
{
    public partial class view_all_partient_process : Form
    {
        public view_all_partient_process()
        {
            InitializeComponent();
        }
      
        private void view_all_partient_process_Load(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();


            SqlCommand work = new SqlCommand("Select CONCAT (first_name,' ',Last_name)AS Patient_name,Address,date,measurement.measurement_type,lab_result.result, medicine.medicine_name,medicine.description from  lab_result,medicine,medicine_patient,patient,measurement,measure_patient WHERE patient.patient_id=medicine_patient.patient_id AND medicine.medicine_id=medicine_patient.medicine_id AND measure_patient.m_p_id=lab_result.m_p_id AND  patient.patient_id=measure_patient.patient_id  AND measurement.measument_id=measure_patient.measurement_id ", con);
            SqlDataAdapter cmd = new SqlDataAdapter(work);
            DataSet set = new DataSet();
            cmd.Fill(set);

            dataGridView1.DataSource = set.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Patient Certificates Report";
            printer.SubTitle = String.Format("Date : {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Moza && Chota";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
