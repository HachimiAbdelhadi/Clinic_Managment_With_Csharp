using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleClinicBusinussLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace SimpleClinic
{
    public partial class smpclinicMainFrm : Form
    {
        public smpclinicMainFrm()
        {
            InitializeComponent();
        }

        

        private void smpclinicMainFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsDoctors.GetAllDoctors();
            dataGridView2.DataSource = clsPatients.GetAllPatients();
        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            clsDoctors Doctors = new clsDoctors();
            Doctors.DoctorID = -1;
            Doctors._FristName = textBox1.Text;
            Doctors._LastName = textBox2.Text;
            Doctors._PhoneNumber = textBox5.Text;
            Doctors._Email = textBox6.Text;
            Doctors._Address = textBox7.Text;
            Doctors._DateOfBirth = date1.Value;
            Doctors._Gender = (checkBox1.Checked) ? 'M' : 'F';
            Doctors.Specialization = textBox9.Text;
            if (Doctors.Save())
            {
                MessageBox.Show("Doctor Added Seccessfully");
                txtDRID.Text = Doctors.DoctorID.ToString();
            }
            else
                MessageBox.Show("Doctor Don't Added Seccessfully");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(clsDoctors.IsDoctorExist(int.Parse(txtDRID.Text)))
            {
                if (clsDoctors.DeleteDoctor(int.Parse(txtDRID.Text)))
                {
                    MessageBox.Show("Doctor Deleted Seccussfully");
                }
                else
                    MessageBox.Show("Doctor Don't Deleted Seccussfully");
            }
            else
                MessageBox.Show("Doctor Not Exist");


        }

        private void button3_Click(object sender, EventArgs e)
        {
             
            if (clsDoctors.IsDoctorExist(int.Parse(txtDRID.Text)))
            {
                clsDoctors Doctors = clsDoctors.FindDoctor(int.Parse(txtDRID.Text));
                Doctors._FristName = textBox1.Text;
                Doctors._LastName = textBox2.Text;
                Doctors._PhoneNumber = textBox5.Text;
                Doctors._Email = textBox6.Text;
                Doctors._Address = textBox7.Text;
                Doctors._DateOfBirth = date1.Value;
                Doctors._Gender = (checkBox1.Checked) ? 'M' : 'F';
                Doctors.Specialization = textBox9.Text;
            }
            else
                MessageBox.Show("Doctor Not Found");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsDoctors Doctors = clsDoctors.FindDoctor(int.Parse(txtDRID.Text));
            if (Doctors != null)
            {
                textBox1.Text = Doctors._FristName;
                textBox2.Text = Doctors._LastName;
                textBox5.Text = Doctors._PhoneNumber;
                textBox6.Text = Doctors._Email;
                textBox7.Text = Doctors._Address;
                date1.Value = Doctors._DateOfBirth;
                checkBox1.Checked = (Doctors._Gender == 'M') ? true : false;
                textBox9.Text = Doctors.Specialization;
            }
            else
                MessageBox.Show("Doctor Not Found");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clsDoctors.IsDoctorExist(int.Parse(txtDRID.Text)))
            {
                clsDoctors Doctors = clsDoctors.FindDoctor(int.Parse(txtDRID.Text));
                Doctors._FristName = textBox1.Text;
                Doctors._LastName = textBox2.Text;
                Doctors._PhoneNumber = textBox5.Text;
                Doctors._Email = textBox6.Text;
                Doctors._Address = textBox7.Text;
                Doctors._DateOfBirth = date1.Value;
                Doctors._Gender = (checkBox1.Checked) ? 'M' : 'F';
                Doctors.Specialization = textBox9.Text;
                if(Doctors.Save())
                {
                    MessageBox.Show("Doctor Updated Successfully ");
                }
                else
                    MessageBox.Show("Doctor Don't Updated Successfully ");
            }
            else
                MessageBox.Show("Doctor Not Found");
        }

        private void btnaddNewPateint_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form frm = new ApointmentsForm();
            frm.ShowDialog();
        }
    }
}
