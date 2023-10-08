using SimpleClinicBusinussLayer;
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
    public partial class FindDoctorForm : Form
    {
        public FindDoctorForm(int DoctorID)
        {
            InitializeComponent();
            txtDoctorID.Text = DoctorID.ToString() ;
        }

        private void FindDoctorForm_Load(object sender, EventArgs e)
        {
            clsDoctors Doctors = clsDoctors.FindDoctor(int.Parse(txtDoctorID.Text));
            if (Doctors != null)
            {
                txtDFirtName.Text = Doctors._FristName;
                txtDLastName.Text = Doctors._LastName;
                txtPhonNumber.Text = Doctors._PhoneNumber;
                txtDemail.Text = Doctors._Email;
                txtDaddress.Text = Doctors._Address;
                dateDoctor.Value = Doctors._DateOfBirth;
                rdbFemale.Checked = (Doctors._Gender == 'F') ? true : false;
                textBox9.Text = Doctors.Specialization;
            }
            else
                MessageBox.Show("Doctor Not Found");


        }
    }
}
