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
    public partial class DoAppointment : Form
    {
        public DoAppointment()
        {
            InitializeComponent();

        }
        public static int MedicalRecordID { get; set; }
        public static int AppointmentID { get; set; }
        clsAppointments Appointment;
        private void btnExaminitionEnd_Click(object sender, EventArgs e)
        {
            Appointment.MedicalRecordID = MedicalRecordID;
            if (Appointment.Save())
            {
                MessageBox.Show("Medical Record Add To Appointment Successfully");
                MedicalRecordID = -1;
                this.Close();
            }
            else
                MessageBox.Show("Medical Record Don't Add To Appointment Successfully");


        }

        private void btnValideRecord_Click(object sender, EventArgs e)
        {
            if(txtVisitDes.Text != "" && txtDiagno.Text!="")
            {
                clsMedicalRecords MedicalRecord = new clsMedicalRecords();
                MedicalRecord.VisitDescription = txtVisitDes.Text;
                MedicalRecord.Diagnosis = txtDiagno.Text;
                MedicalRecord.AdditionalNotes = txtNotes.Text;
                if(MedicalRecord.Save())
                {
                    MedicalRecordID = MedicalRecord.MedicalRecordID;
                    MessageBox.Show("Medical Record for this Patient Added Seccussfully");
                    grbMedRecord.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Medical Record for this Patient Don't Added Seccussfully");
                    txtVisitDes.BackColor = Color.OrangeRed;
                    txtDiagno.BackColor = Color.OrangeRed;
                }

            }
            else
            {
                MessageBox.Show("Medical Record is Empty Don't Added Seccussfully");
                txtVisitDes.BackColor = Color.OrangeRed;
                txtDiagno.BackColor = Color.OrangeRed;
            }
        }

        private void btnPrescAddToRecrd_Click(object sender, EventArgs e)
        {
            if(txtMedName.Text !="" && txtDos.Text != "" && txtFrequ.Text != "")
            {
                clsPrescriptions prescription = new clsPrescriptions();
                prescription.MedicationName = txtMedName.Text;
                prescription.Dosage = txtDos.Text;
                prescription.Frequency = txtFrequ.Text;
                prescription.StartDate = dateTimeStart.Value;
                prescription.EndDate = dateTimeEnd.Value;
                prescription.SpecialInstructions = txtInstruc.Text;
                prescription.MedicalRecordID = DoAppointment.MedicalRecordID;

                if(prescription.Save())
                {
                    MessageBox.Show("prescription added Seccussfully");
                    foreach(Control C in groupBox2.Controls)
                    {
                        if(C is TextBox)
                        {
                            C.Text = "";
                        }
                    }
                }
            }
        }

        private void dateTimeStart_Enter(object sender, EventArgs e)
        {
            dateTimeEnd.Value = dateTimeEnd.Value.AddDays(7);
        }

        private void DoAppointment_Load(object sender, EventArgs e)
        {
            Appointment = clsAppointments.FindAppointment(AppointmentID);
            if(Appointment != null)
            { 
                clsPatients Patient = clsPatients.FindPatient(Appointment.PatientID);
                if(Patient != null) 
                {
                    labelID.Text = Patient._PatientID.ToString();
                    labelFName.Text = Patient._FristName + Patient._LastName;
                    labelAddre.Text = Patient._Address;
                    labelPh.Text = Patient._PhoneNumber;
                    labelDate.Text = Patient._DateOfBirth.ToString();
                }
            }
        }
    }
}
