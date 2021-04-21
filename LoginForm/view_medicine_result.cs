using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace LoginForm
{
    public partial class view_medicine_result : Form
    {
        public view_medicine_result()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string co = "Data Source=localhost;Initial Catalog=hospital_management_system;Integrated Security=True";
            SqlConnection con = new SqlConnection(co);
            con.Open();

            String query2 = "Select first_name,Last_name,Age,date,description from medicine_result,medicine_patient,patient WHERE patient.patient_id=medicine_patient.patient_id AND medicine_patient.med_id=medicine_result.med_id   AND patient.first_name='" + textBox1.Text + "' ";


            SqlCommand query3 = new SqlCommand(query2, con);

            SqlDataAdapter adap1 = new SqlDataAdapter(query3);
            DataSet se1 = new DataSet();
            adap1.Fill(se1);

            dataGridView1.DataSource = se1.Tables[0];


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
    }
}
