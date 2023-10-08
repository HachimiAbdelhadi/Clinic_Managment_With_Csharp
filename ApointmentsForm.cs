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
    public partial class ApointmentsForm : Form
    {
        public static int PatientID { get; set; }
        
        public ApointmentsForm()
        {
            InitializeComponent();

        }
        public static int _AppointmentID { get; set; }
        public static int _PaymentID { get; set; }
        clsAppointments appointment;
        clsAppointments AppointmentToUpdate;
        public ApointmentsForm(int PaymentID)
        {
            _PaymentID = PaymentID;

        }
        public void SetAppointmentForPatient(int PatientID)
        {
            

            clsPatients dr = clsPatients.FindPatient(PatientID);
            if (dr != null)
            {
                textBox1.Text = dr._PatientID.ToString();
                lblPID.Text = textBox1.Text;
                lblFulNAme.Text = dr._FristName + dr._LastName;
                lblAddre.Text = dr._Address;
                lblPh.Text = dr._PhoneNumber;
                lblDt.Text = dr._DateOfBirth.ToString();
            }
            else
            {

                textBox1.Text = "";
                lblPID.Text = "";
                lblFulNAme.Text = "";
                lblAddre.Text = "";
                lblPh.Text = "";
                lblDt.Text = "";
            }
        }
        private void ChooseTime_OnClikBtn( object sender ,bool Isbutton=true)
        {

            Button Btun = (Button)sender;
            string AppointmentDateTime = mclndAppoi.SelectionRange.Start.ToString().Remove(9) + Btun.Text;
            DateTime dt = Convert.ToDateTime(AppointmentDateTime);
            int DateCompare = DateTime.Compare(DateTime.Now, dt);
            if (DateCompare < 0 || DateCompare == 0)
            {
                if (!clsAppointments.IsDateExist(AppointmentDateTime))
                {
                    lblChoosenTime.Text = AppointmentDateTime;
                    lbltm.Text = lblChoosenTime.Text;
                }
                else
                {
                    Btun.Enabled = false;
                    MessageBox.Show(" Not Available ");
                }
            }
            else
                MessageBox.Show("Date is In The Past ... Not Available ");


        }

        

        private void mclndAppoi_DateChanged(object sender, DateRangeEventArgs e)
        {

            ChooseTime_OnClikBtn(btn10,false);
            //foreach(Button btn in Controls)
            //{
            //    if(btn.Enabled ==false)
            //        btn.Enabled = true;
            //}

            btn1.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn10.Enabled = true;
            btn11.Enabled = true;
            btn12.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            DataTable dt = clsDoctors.GetAllSpecializations();
            cmbSpecialization.DataSource = dt;
            cmbSpecialization.DisplayMember = "Specialization";
            
        }

        
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            PatientID = -1;
            Form frm = new AccessPatientForm();
            frm.ShowDialog();
            SetAppointmentForPatient(PatientID);
            

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsAppointments.GetAllTodayAppointments();

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            bool IsReserveValide = true;
            string Space = "                  ";
            if (lblPID.Text == Space)
            {
                lblPID.BackColor = Color.OrangeRed;
                IsReserveValide = false;
            }
            else
                lblPID.BackColor = Color.WhiteSmoke;


            if (lblDr.Text == Space)
            {
                lblDr.BackColor = Color.OrangeRed;
                IsReserveValide = false;
            }
            else
                lblDr.BackColor = Color.WhiteSmoke;

            if (lbltm.Text == Space)
            {
                lbltm.BackColor = Color.OrangeRed;
                IsReserveValide = false;
            }
            else
                lbltm.BackColor = Color.WhiteSmoke;
            
            
            if (lblStu.Text == Space)
            {
                lblStu.BackColor = Color.OrangeRed;
                IsReserveValide = false;
            }
            else
                lblStu.BackColor = Color.WhiteSmoke;
            
            
            if(IsReserveValide)
            {
                if (MessageBox.Show("Are you sure you Want to Reserve", "Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Question
                    ,MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {
                    clsAppointments NewAppointment = new clsAppointments();
                    NewAppointment.PatientID = int.Parse(lblPID.Text);
                    NewAppointment.DoctorID = int.Parse(cbDoctors.SelectedValue.ToString());
                    NewAppointment.AppointmentDateTime = Convert.ToDateTime(lblChoosenTime.Text);
                    NewAppointment.AppointmentStatusID = clsAppointments.AppointmentStatus(lblStu.Text);
                    if (NewAppointment.Save())
                    {
                        MessageBox.Show("Your Appontment Reserved Seccussfully", "Information");
                        txtAppoId.Text = NewAppointment.AppointmentID.ToString();
                        foreach (Control C in groupBox2.Controls)
                        {
                            if(C is Label )
                            {
                                if(C.TabIndex == 1)
                                    C.Text = Space;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Your Appontment not Reserved Seccussfully", "Information");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(textBox1.Text, out int ID))
            {
                textBox1.BackColor = Color.White;
                clsPatients dr = clsPatients.FindPatient(ID);
                if (dr != null)
                {
                    textBox1.Text = dr._PatientID.ToString();
                    lblPID.Text = dr._PatientID.ToString();
                    lblFulNAme.Text = dr._FristName + dr._LastName;
                    lblAddre.Text = dr._Address;
                    lblPh.Text = dr._PhoneNumber;
                    lblDt.Text = dr._DateOfBirth.ToString();
                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    MessageBox.Show("Patient Not Found"
                        , "Warning", MessageBoxButtons.OK);
                }

            }
            else
            {
                textBox1.BackColor = Color.OrangeRed;
                MessageBox.Show("Please Enter A Numbr ID Field Don't Accept Charaqueter"
                    , "Warning", MessageBoxButtons.OK);
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(textBox1.Text, out int ID))
            {
                textBox1.BackColor = Color.White;
                clsPatients dr = clsPatients.FindPatient(ID);
                if (dr != null)
                {
                    textBox1.Text = dr._PatientID.ToString();
                    lblPID.Text = dr._PatientID.ToString();
                    lblFulNAme.Text = dr._FristName + dr._LastName;
                    lblAddre.Text = dr._Address;
                    lblPh.Text = dr._PhoneNumber;
                    lblDt.Text = dr._DateOfBirth.ToString();
                }

            }
            else
            {
                textBox1.BackColor = Color.OrangeRed;
                MessageBox.Show("Please Enter A Numbr ID Field Don't Accept Charaqueter"
                    , "Warning", MessageBoxButtons.OK);
            }
        }

        private void cbDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSpecialization_Leave_1(object sender, EventArgs e)
        {
            DataTable dt = clsDoctors.GetAllDoctorsByspecialty(cmbSpecialization.Text);
            cbDoctors.DataSource = dt;
            cbDoctors.DisplayMember = "FullName";
            cbDoctors.ValueMember = "DoctorID";
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            ChooseTime_OnClikBtn(sender);
        }

        private void cbDoctors_TextChanged(object sender, EventArgs e)
        {
            lblDr.Text = cbDoctors.Text;
        }



        private void ChangeStatus(object sender)
        {
            RadioButton rdb = (RadioButton)sender;
            lblStu.Text = rdb.Text;
        }
        private void rdbtn_unconfirmed_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void rdbtn_confirmed_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void rdbtn_Cancelled_CheckedChanged_1(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void rdbtn_NoShow_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void rdbtn_Completed_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void rdbtn_Rescheduled_CheckedChanged(object sender, EventArgs e)
        {
            ChangeStatus(sender);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(txtPatientId.Text, out int ID))
            {
                txtPatientId.BackColor = Color.White;
                clsPatients dr = clsPatients.FindPatient(ID);
                if (dr != null)
                {
                    txtPatientId.Text = dr._PatientID.ToString();
                    labelID.Text = dr._PatientID.ToString();
                    labelFName.Text = dr._FristName + dr._LastName;
                    labelAddre.Text = dr._Address;
                    labelPh.Text = dr._PhoneNumber;
                    labelDate.Text = dr._DateOfBirth.ToString();
                }
                else
                {
                    txtPatientId.BackColor = Color.Red;
                    MessageBox.Show("Patient Not Found"
                        , "Warning", MessageBoxButtons.OK);
                }

            }
            else
            {
                txtPatientId.BackColor = Color.OrangeRed;
                MessageBox.Show("Please Enter A Numbr ID Field Don't Accept Charaqueter"
                    , "Warning", MessageBoxButtons.OK);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int ID))
            {
                appointment = clsAppointments.FindAppointment(ID);
                if (appointment != null) 
                {
                    clsDoctors doctor = clsDoctors.FindDoctor(appointment.DoctorID);
                    if (doctor != null)
                    {
                        txtSp.Text = doctor.Specialization;
                        txtDr.Text = doctor._FristName + " " + doctor._LastName;

                    }
                    txtPatientId.Text = appointment.PatientID.ToString();
                    lblAppTm.Text = appointment.AppointmentDateTime.ToString();
                    labelStatus.Text = clsAppointments.AppointmentStatus(appointment.AppointmentStatusID);
                    textBox2_TextChanged(sender, e);

                    btnComplet.Enabled = true;
                }
            }
            else
            {
                btnComplet.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _AppointmentID = appointment.AppointmentID;
            Form PayForm = new PaymentForm();
            PayForm.ShowDialog();
            appointment.AppointmentStatusID = 3;
            appointment.PaymentID = _PaymentID;
            if (appointment.Save())
                MessageBox.Show("Appointment Completed Successsfully ", "Info");
            else
                MessageBox.Show("Appointment Don't Completed Successfully ", "Info");

        }

        private void whoAreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FindDr = new FindDoctorForm(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            FindDr.ShowDialog();
        }

        private void btnDoAppoi_Click(object sender, EventArgs e)
        {
            string Space = "                  ";
            if (labelID.Text != Space && textBox3.Text !="")
            {
                DoAppointment.AppointmentID = int.Parse(textBox3.Text);
                Form AppointmentEx = new DoAppointment();
                AppointmentEx.ShowDialog();
            }
            else
                MessageBox.Show("Can't Show Appointment Examing Not Found Operation Not Complete");

        }

        private void btnDelAppoin_Click(object sender, EventArgs e)
        {
            string Space = "                  ";
            if (labelID.Text != Space && textBox3.Text != "")
            {
                if(int.TryParse(textBox3.Text,out int AppoiId))
                {
                    if(clsAppointments.DeleteAppointment(AppoiId))
                    {
                        MessageBox.Show("Appointment Deleted Successfully ","Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
                MessageBox.Show("Appointment Don't Deleted Successfully ", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFindAppoi_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtAppoId.Text,out int AppoinID))
            {
                AppointmentToUpdate = clsAppointments.FindAppointment(AppoinID);
                if (AppointmentToUpdate != null)
                {
                    clsPatients patient = clsPatients.FindPatient(AppointmentToUpdate.PatientID);
                    if (patient != null)
                    {
                        lblPID.Text = patient._PatientID.ToString();
                        lblFulNAme.Text = patient._LastName + " " + patient._FristName;
                        lblDt.Text = patient._DateOfBirth.ToString();
                        lblAddre.Text = patient._Address;
                        lblPh.Text = patient._PhoneNumber;
                    }
                    clsDoctors Doctor = clsDoctors.FindDoctor(AppointmentToUpdate.DoctorID);
                    if (Doctor != null)
                    {
                        lblDr.Text = Doctor._LastName + "" + Doctor._FristName;
                    }
                    lblStu.Text = clsAppointments.AppointmentStatus(AppointmentToUpdate.AppointmentStatusID);
                    lbltm.Text = AppointmentToUpdate.AppointmentDateTime.ToString();
                    btnUpdateAppoi.Enabled = true;
                }
                else
                    MessageBox.Show("Appointment Not Found");
            }
        }

        private void btnUpdateAppoi_Click(object sender, EventArgs e)
        {
            bool IsUpdateReserveValide = true;
            string Space = "                  ";
            if (lblPID.Text == Space)
            {
                lblPID.BackColor = Color.OrangeRed;
                IsUpdateReserveValide = false;
            }
            else
                lblPID.BackColor = Color.WhiteSmoke;


            if (lblDr.Text == Space)
            {
                lblDr.BackColor = Color.OrangeRed;
                IsUpdateReserveValide = false;
            }
            else
                lblDr.BackColor = Color.WhiteSmoke;

            if (lbltm.Text == Space)
            {
                lbltm.BackColor = Color.OrangeRed;
                IsUpdateReserveValide = false;
            }
            else
                lbltm.BackColor = Color.WhiteSmoke;


            if (lblStu.Text == Space)
            {
                lblStu.BackColor = Color.OrangeRed;
                IsUpdateReserveValide = false;
            }
            else
                lblStu.BackColor = Color.WhiteSmoke;


            if (IsUpdateReserveValide)
            {
                if (MessageBox.Show("Are you sure you Want to Update Reserve", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question
                    , MessageBoxDefaultButton.Button1) == DialogResult.OK)
                {

                    AppointmentToUpdate.PatientID = int.Parse(lblPID.Text);
                    AppointmentToUpdate.DoctorID = int.Parse(cbDoctors.SelectedValue.ToString());
                    AppointmentToUpdate.AppointmentDateTime = Convert.ToDateTime(lblChoosenTime.Text);
                    AppointmentToUpdate.AppointmentStatusID = clsAppointments.AppointmentStatus(lblStu.Text);
                    if (AppointmentToUpdate.Save())
                    {
                        MessageBox.Show("Your Appontment Reserved Seccussfully", "Information");
                        txtAppoId.Text = AppointmentToUpdate.AppointmentID.ToString();
                        foreach (Control C in groupBox2.Controls)
                        {
                            if (C is Label)
                            {
                                if (C.TabIndex == 1)
                                    C.Text = Space;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Your Appontment not Reserved Seccussfully", "Information");
            }
        }
    }
}
