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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
       
        
        private void btnPay_Click(object sender, EventArgs e)
        {
            clsPayments Payment = new clsPayments();
            Payment.PaymentDate = datepickerPay.Value;
            Payment.PaymentMethod = txtpaymethod.Text;
            Payment.AdditionalNotes = txtAdditionNote.Text;
            string AmountPaid = numPayment.Value.ToString();
            Payment.AmountPaid = int.Parse(AmountPaid);
            if(Payment.Save())
            {
                MessageBox.Show("Your Payment is Valid ", "Info", MessageBoxButtons.OK);
                ApointmentsForm._PaymentID= Payment.PaymentID;
            }
        }
    }
}
