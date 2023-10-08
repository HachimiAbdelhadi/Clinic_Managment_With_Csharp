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
using SimpleClinicBusinussLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleClinic
{
    public partial class AccessPatientForm : Form
    {
        public AccessPatientForm()
        {
            InitializeComponent();
        }
        private int PatientID { get; set; }
        private void ShowNumberOfPatients()
        {
            DataTable dt = clsPatients.GetAllPatients();
            if (dt != null)
            {
                lbl_Totall_Patients.Text = dt.Rows.Count.ToString();
            }
            else
                lbl_Totall_Patients.Text = "No result";

        }

        //------------- Part of Patient ----------------------------\\
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to ADD THis Patient", "Warning", MessageBoxButtons.OKCancel
            , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                clsPatients Patient = new clsPatients();
                Patient._PatientID = -1;
                Patient._FristName = txtPFirtName.Text;
                Patient._LastName = txtPLastName.Text;
                Patient._PhoneNumber = txtPhonNumber.Text;
                Patient._Email = txtPemail.Text;
                Patient._Address = txtPaddress.Text;
                Patient._DateOfBirth = datePatient.Value;
                Patient._Gender = (rdbMale.Checked) ? 'M' : 'F';
                
                if (Patient.Save())
                {
                    MessageBox.Show("Patient Added Seccessfully");
                    txtPatientID.Text = Patient._PatientID.ToString();
                    ShowNumberOfPatients();
                }
                else
                    MessageBox.Show("Patient Don't Added Seccessfully");

            }
        }        
        private void btnFinPatient_Click_1(object sender, EventArgs e)
        {
            clsPatients Patient = clsPatients.FindPatient(PatientID);
            if (Patient != null)
            {
                txtPFirtName.Text = Patient._FristName;
                txtPLastName.Text = Patient._LastName;
                txtPhonNumber.Text = Patient._PhoneNumber;
                txtPemail.Text = Patient._Email;
                txtPaddress.Text = Patient._Address;
                datePatient.Value = Patient._DateOfBirth;
                if (Patient._Gender == 'M')
                    rdbMale.Checked = true;
                else
                    rdbFemale.Checked = true;


            }
            else
                MessageBox.Show("Patient Not Found");
        }
        private void btnUpdPatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update THis Patient", "Warning", MessageBoxButtons.OKCancel
              , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsPatients.IsPatientExist(PatientID))
                {
                    clsPatients Patient = clsPatients.FindPatient(PatientID);
                    Patient._FristName = txtPFirtName.Text;
                    Patient._LastName = txtPLastName.Text;
                    Patient._PhoneNumber = txtPhonNumber.Text;
                    Patient._Email = txtPemail.Text;
                    Patient._Address = txtPaddress.Text;
                    Patient._DateOfBirth = datePatient.Value;
                    Patient._Gender = (rdbMale.Checked) ? 'M' : 'F';
                    if (Patient.Save())
                    {
                        MessageBox.Show("Patient Updated Successfully ");
                    }
                    else
                        MessageBox.Show("Patient Don't Updated Successfully ");
                }
                else
                    MessageBox.Show("Patient Not Found");
            }
        }
        private void btnDelPatient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete THis Patient", "Warning", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsPatients.IsPatientExist(PatientID))
                {
                    if (clsPatients.DeletePatient(PatientID))
                    {
                        MessageBox.Show("Patient Deleted Seccussfully");
                        ShowNumberOfPatients();
                    }
                    else
                        MessageBox.Show("Patient Don't Deleted Seccussfully");
                }
                else
                    MessageBox.Show("Patient Not Exist");
            }
        }

        private void AccessPatientForm_Load(object sender, EventArgs e)
        {
            ShowNumberOfPatients();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(textBox1.Text, out int ID))
            {
                clsPatients dr = clsPatients.FindPatient(ID);
                if (dr != null)
                {
                    dt.Columns.Add("PatientID", typeof(int));
                    dt.Columns.Add("FirstNAme", typeof(string));
                    dt.Columns.Add("LastName", typeof(string));
                    dt.Columns.Add("DateOfBirth", typeof(DateTime));
                    dt.Columns.Add("Email", typeof(string));
                    dt.Columns.Add("Address", typeof(string));
                    dt.Columns.Add("PhoneNumber", typeof(string));
                    dt.Columns.Add("Gender", typeof(char));
                    object[] value = {dr._PatientID,dr._FristName,dr._LastName, dr._DateOfBirth
                ,dr._Email,dr._Address,dr._PhoneNumber,dr._Gender};

                    dt.Rows.Add(value);
                    dataGridView2.DataSource = dt;
                }

            }
            else
            {
                if(textBox1.Text == "")
                {
                    tabPage5_Enter(sender, e);
                }
                else if (textBox1.Text.StartsWith(" "))
                {
                    dt =clsPatients.GetAllHestoryRecordsLike(textBox1.Text);
                    dataGridView2.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    dt = clsPatients.GetAllHestoryRecordsStartWith(textBox1.Text);
                    dataGridView2.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(textBox2.Text, out int ID))
            {
                clsPatients dr = clsPatients.FindPatient(ID);
                if(dr!=null)
                {
                    dt.Columns.Add("PatientID", typeof(int));
                    dt.Columns.Add("FirstNAme", typeof(string));
                    dt.Columns.Add("LastName", typeof(string));
                    dt.Columns.Add("DateOfBirth", typeof(DateTime));
                    dt.Columns.Add("Email", typeof(string));
                    dt.Columns.Add("Address", typeof(string));
                    dt.Columns.Add("PhoneNumber", typeof(string));
                    dt.Columns.Add("Gender", typeof(char));
                    object[] value = {dr._PatientID,dr._FristName,dr._LastName, dr._DateOfBirth
                ,dr._Email,dr._Address,dr._PhoneNumber,dr._Gender};

                    dt.Rows.Add(value);

                    dataGridView1.DataSource = dt;
                }
            }
            else
            {
                if(textBox2.Text=="")
                {
                    tabPage5_Enter(sender, e);
                }
                else if (textBox2.Text.StartsWith(" "))
                {
                    dt = clsPatients.GetAllPatientRecordLike(textBox2.Text);
                    dataGridView1.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    dt = clsPatients.GetAllPatientRecordsStartWith(textBox2.Text);
                    dataGridView1.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPatients.GetAllPatients();
        }

        private void txtPatientID_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtPatientID.Text, out int ID))
            {
                PatientID = ID;
                txtPatientID.BackColor = Color.White;
                btnDelPatient.Enabled = true;
                btnUpdPatient.Enabled = true;
                btnFinPatient.Enabled = true;
            }
            else
            {
                txtPatientID.BackColor = Color.OrangeRed;
                MessageBox.Show("Please Enter A Numbr ID Field Don't Accept Charaqueter"
                    , "Warning", MessageBoxButtons.OK);
                btnDelPatient.Enabled = false;
                btnUpdPatient.Enabled = false;
                btnFinPatient.Enabled = false;
            }
        }

        private void addToAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApointmentsForm.PatientID = (int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        private void tabPage7_Enter(object sender, EventArgs e)
        {
            dataGridView3.DataSource = clsPatients.GetPatientsbyFiltering(rdb18.Text,'B');    
        }
        private void ShowFiltringData(object sender)
        {
            char Gendor='B';
            RadioButton rdb = (RadioButton)sender;
            if (ckbF.Checked && !ckbM.Checked)
                Gendor = 'F';
            else if (ckbM.Checked && !ckbF.Checked)
                Gendor = 'M';
            else if ((ckbF.Checked && ckbM.Checked) || (!(ckbF.Checked && ckbM.Checked)))
                Gendor = 'B';

            if (rdb.Checked)
            {
                DataTable DataT = clsPatients.GetPatientsbyFiltering(rdb.Text, Gendor);
                
                if (DataT == null)
                {
                    lblNPati.Text = "No Result at all";
                    label13.Visible = false;
                    dataGridView3.DataSource = null;
                }
                else
                {
                    label13.Visible = true;
                    dataGridView3.DataSource = DataT;
                    lblNPati.Text = DataT.Rows.Count.ToString();
                }
            }

        }

        private void rdb18_Click(object sender, EventArgs e)
        {
            ShowFiltringData(sender);
        }

        private void rdbG50_CheckedChanged(object sender, EventArgs e)
        {
            ShowFiltringData(sender);
        }

        private void rdb30_CheckedChanged(object sender, EventArgs e)
        {
            ShowFiltringData(sender);
        }

        private void rdbL50_CheckedChanged(object sender, EventArgs e)
        {
            ShowFiltringData(sender);
        }
    }
}
