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
    public partial class AccessDoctorForm : Form
    {
        public AccessDoctorForm()
        {
            InitializeComponent();
        }
        private int DoctorID { get; set; }

       


        private void ShowNumberOfDoctors()
        {
            lbl_Totall_Doctor.Text = clsDoctors.GetAllDoctors().Rows.Count.ToString();
        }

        private void AccessDoctorForm_Load(object sender, EventArgs e)
        {
            ShowNumberOfDoctors();
        }
        private void txtDoctorID_MouseLeave(object sender, EventArgs e)
        {
            if (int.TryParse(txtDoctorID.Text, out int ID))
            {
                DoctorID = ID;
                btnDelDoctor.Enabled = true;
                btnUpdDoctor.Enabled = true;
                btnFinDoctor.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please Enter A Numbr ID Field Don't Accept Charaqueter"
                    , "Warning", MessageBoxButtons.OK);
                btnDelDoctor.Enabled = false;
                btnUpdDoctor.Enabled = false;
                btnFinDoctor.Enabled = false;
            }
        }

        //--------------Part Of Doctors --------------------------\\
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to ADD THis Doctor", "Warning", MessageBoxButtons.OKCancel
              , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                clsDoctors Doctors = new clsDoctors();
                Doctors.DoctorID = -1;
                Doctors._FristName = txtDFirtName.Text;
                Doctors._LastName = txtDLastName.Text;
                Doctors._PhoneNumber = txtPhonNumber.Text;
                Doctors._Email = txtDemail.Text;
                Doctors._Address = txtDaddress.Text;
                Doctors._DateOfBirth = dateDoctor.Value;
                Doctors._Gender = (rdbMale.Checked) ? 'M' : 'F';
                Doctors.Specialization = textBox9.Text;
                if (Doctors.Save())
                {
                    MessageBox.Show("Doctor Added Seccessfully");
                    txtDoctorID.Text = Doctors.DoctorID.ToString();
                    ShowNumberOfDoctors();
                }
                else
                    MessageBox.Show("Doctor Don't Added Seccessfully");

            }

        }
        private void btnFinDoctor_Click(object sender, EventArgs e)
        {
            clsDoctors Doctors = clsDoctors.FindDoctor(DoctorID);
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
        private void btnDelDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete THis Doctor", "Warning", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsDoctors.IsDoctorExist(DoctorID))
                {
                    if (clsDoctors.DeleteDoctor(DoctorID))
                    {
                        MessageBox.Show("Doctor Deleted Seccussfully");
                        foreach (Control C in Controls)
                        {
                            if (C is TextBox)
                            {
                                C.Text = "";
                            }
                        }

                        ShowNumberOfDoctors();
                    }
                    else
                        MessageBox.Show("Doctor Don't Deleted Seccussfully");
                }
                else
                    MessageBox.Show("Doctor Not Exist");
            }
        }
        private void btnUpdDoctor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update THis Doctor", "Warning", MessageBoxButtons.OKCancel
               , MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (clsDoctors.IsDoctorExist(DoctorID))
                {
                    clsDoctors Doctors = clsDoctors.FindDoctor(DoctorID);

                    Doctors._FristName = txtDFirtName.Text;
                    Doctors._LastName = txtDLastName.Text;
                    Doctors._PhoneNumber = txtPhonNumber.Text;
                    Doctors._Email = txtDemail.Text;
                    Doctors._Address = txtDaddress.Text;
                    Doctors._DateOfBirth = dateDoctor.Value;
                    Doctors._Gender = (rdbMale.Checked) ? 'M' : 'F';
                    Doctors.Specialization = textBox9.Text;


                    if (Doctors.Save())
                    {
                        MessageBox.Show("Doctor Updated Successfully ");
                    }
                    else
                        MessageBox.Show("Doctor Don't Updated Successfully ");
                }
                else
                    MessageBox.Show("Doctor Not Found");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt= new DataTable();
            if (int.TryParse(txtSearch.Text,out int ID))
            {
                clsDoctors dr= clsDoctors.FindDoctor(ID);
                if(dr !=null)
                {
                    dt.Columns.Add("DoctorID", typeof(int));
                    dt.Columns.Add("FirstName", typeof(string));
                    dt.Columns.Add("LastName", typeof(string));
                    dt.Columns.Add("Specialization", typeof(string));
                    dt.Columns.Add("DateOfBirth", typeof(DateTime));
                    dt.Columns.Add("Email", typeof(string));
                    dt.Columns.Add("Address", typeof(string));
                    dt.Columns.Add("PhoneNumber", typeof(string));
                    dt.Columns.Add("Gender", typeof(char));
                    object[] value = {dr.DoctorID,dr._FristName,dr._LastName,dr.Specialization ,dr._DateOfBirth
                ,dr._Email,dr._Address,dr._PhoneNumber,dr._Gender};

                    dt.Rows.Add(value);
                    dataGridView1.DataSource = dt;
                    lblResult.Text = "1";
                }
            }
            else
            {
                if (txtSearch.Text == "")
                {
                    tabPage5_Enter(sender, e);
                }
                else if (txtSearch.Text.StartsWith(" "))
                {
                    dt= clsDoctors.GetAllRecordsLike(txtSearch.Text);
                    dataGridView1.DataSource = dt;
                    lblResult.Text =dt.Rows.Count.ToString();
                }
                else
                {
                    dt = clsDoctors.GetAllRecordsStartWith(txtSearch.Text);
                    dataGridView1.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
            }
        }
        private void tabPage5_Enter(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsDoctors.GetAllDoctors();
        }
        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (int.TryParse(txtSearch2.Text, out int ID))
            {
                dt = clsDoctors.GetAllHestoryRecords(ID);
                
                dataGridView2.DataSource = dt;
                
            }
            else
            {
                if (txtSearch2.Text == "")
                {
                    dt.Clear();
                    dataGridView2.DataSource = dt;
                }
                else if (txtSearch2.Text.StartsWith(" "))
                {
                    dt = clsDoctors.GetAllHestoryRecordsLike(txtSearch2.Text);
                    dataGridView2.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
                else
                {
                    dt = clsDoctors.GetAllHestoryRecordsStartWith(txtSearch2.Text);
                    dataGridView2.DataSource = dt;
                    lblResult.Text = dt.Rows.Count.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
