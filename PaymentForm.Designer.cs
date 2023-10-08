namespace SimpleClinic
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datepickerPay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpaymethod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numPayment = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdditionNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblChoosenTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datepickerPay
            // 
            this.datepickerPay.Location = new System.Drawing.Point(74, 93);
            this.datepickerPay.Name = "datepickerPay";
            this.datepickerPay.Size = new System.Drawing.Size(215, 20);
            this.datepickerPay.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "Pick Payment Date :";
            // 
            // txtpaymethod
            // 
            this.txtpaymethod.Location = new System.Drawing.Point(74, 146);
            this.txtpaymethod.Name = "txtpaymethod";
            this.txtpaymethod.Size = new System.Drawing.Size(215, 20);
            this.txtpaymethod.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 111;
            this.label2.Text = "Payment Method :";
            // 
            // numPayment
            // 
            this.numPayment.BackColor = System.Drawing.SystemColors.WindowText;
            this.numPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numPayment.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPayment.Location = new System.Drawing.Point(74, 326);
            this.numPayment.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numPayment.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPayment.Name = "numPayment";
            this.numPayment.Size = new System.Drawing.Size(215, 23);
            this.numPayment.TabIndex = 112;
            this.numPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPayment.ThousandsSeparator = true;
            this.numPayment.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numPayment.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 113;
            this.label3.Text = "Amount Paid :";
            // 
            // txtAdditionNote
            // 
            this.txtAdditionNote.Location = new System.Drawing.Point(74, 214);
            this.txtAdditionNote.Multiline = true;
            this.txtAdditionNote.Name = "txtAdditionNote";
            this.txtAdditionNote.Size = new System.Drawing.Size(215, 63);
            this.txtAdditionNote.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Additional Notes :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblChoosenTime);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 50);
            this.panel2.TabIndex = 116;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(129)))), ((int)(((byte)(246)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(734, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 106;
            this.button1.Text = "Patients Info";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblChoosenTime
            // 
            this.lblChoosenTime.AutoSize = true;
            this.lblChoosenTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblChoosenTime.Location = new System.Drawing.Point(430, 19);
            this.lblChoosenTime.Name = "lblChoosenTime";
            this.lblChoosenTime.Size = new System.Drawing.Size(64, 17);
            this.lblChoosenTime.TabIndex = 115;
            this.lblChoosenTime.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleClinic.Properties.Resources.receive_cashBlack_30px_1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblMode.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblMode.Location = new System.Drawing.Point(69, 14);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(106, 29);
            this.lblMode.TabIndex = 13;
            this.lblMode.Text = "Payment";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(129)))), ((int)(((byte)(246)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(263, 432);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(92, 30);
            this.btnPay.TabIndex = 117;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(367, 474);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdditionNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpaymethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datepickerPay);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.numPayment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datepickerPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpaymethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdditionNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblChoosenTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnPay;
    }
}