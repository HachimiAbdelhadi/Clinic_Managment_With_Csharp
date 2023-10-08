using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClinic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessPatientForm PatientForm =new AccessPatientForm();
            PatientForm.ShowDialog();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccessDoctorForm DoctorForm = new AccessDoctorForm();
            DoctorForm.ShowDialog();
        }

        private void appointmentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApointmentsForm apointmentsForm = new ApointmentsForm();
            apointmentsForm.ShowDialog();
        }

        private void ExamiationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DoAppointment.AppointmentID !=-1 )
            {
                DoAppointment Examiation = new DoAppointment();
                Examiation.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is No Examination Now " , "INFO"
                    ,MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoAppointment.AppointmentID = -1;
        }
    }
}
