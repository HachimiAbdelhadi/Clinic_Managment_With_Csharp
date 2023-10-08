namespace SimpleClinic
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExamiationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todaySessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4, 2, 0, 4);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.appointmentaToolStripMenuItem,
            this.ExamiationToolStripMenuItem,
            this.todaySessionsToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(200, 610);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(100, 450);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(199, 561);
            this.menuStrip1.TabIndex = 213;
            this.menuStrip1.Text = "Patients";
            // 
            // patientsToolStripMenuItem
            // 
            this.patientsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.patientsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.patientsToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Patient;
            this.patientsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
            this.patientsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.patientsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patientsToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.patientsToolStripMenuItem.Tag = "0";
            this.patientsToolStripMenuItem.Text = "             Patients";
            this.patientsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.doctorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.doctorToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Doctor;
            this.doctorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.doctorToolStripMenuItem.MergeIndex = 0;
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.doctorToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.doctorToolStripMenuItem.Tag = "1";
            this.doctorToolStripMenuItem.Text = "              Doctors ";
            this.doctorToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorToolStripMenuItem.Click += new System.EventHandler(this.doctorToolStripMenuItem_Click);
            // 
            // appointmentaToolStripMenuItem
            // 
            this.appointmentaToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.appointmentaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.appointmentaToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Appointments;
            this.appointmentaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.appointmentaToolStripMenuItem.Name = "appointmentaToolStripMenuItem";
            this.appointmentaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.appointmentaToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.appointmentaToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.appointmentaToolStripMenuItem.Tag = "2";
            this.appointmentaToolStripMenuItem.Text = "   Appointments ";
            this.appointmentaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.appointmentaToolStripMenuItem.Click += new System.EventHandler(this.appointmentaToolStripMenuItem_Click);
            // 
            // ExamiationToolStripMenuItem
            // 
            this.ExamiationToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.ExamiationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ExamiationToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.health_checkup_96px;
            this.ExamiationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.ExamiationToolStripMenuItem.Name = "ExamiationToolStripMenuItem";
            this.ExamiationToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.ExamiationToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExamiationToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.ExamiationToolStripMenuItem.Tag = "3";
            this.ExamiationToolStripMenuItem.Text = "         Examiation";
            this.ExamiationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExamiationToolStripMenuItem.Click += new System.EventHandler(this.ExamiationToolStripMenuItem_Click);
            // 
            // todaySessionsToolStripMenuItem
            // 
            this.todaySessionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.todaySessionsToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Sessions;
            this.todaySessionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.todaySessionsToolStripMenuItem.Name = "todaySessionsToolStripMenuItem";
            this.todaySessionsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.todaySessionsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.todaySessionsToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.todaySessionsToolStripMenuItem.Text = "  Today Sessions";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Tool;
            this.toolsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.toolsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.toolsToolStripMenuItem.Tag = "6";
            this.toolsToolStripMenuItem.Text = "                   &Tools";
            this.toolsToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.helpToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.infoBlack_30px_2;
            this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.helpToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(188, 45);
            this.helpToolStripMenuItem.Tag = "7";
            this.helpToolStripMenuItem.Text = "                    &Help";
            this.helpToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(160, 30);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.settingsToolStripMenuItem.Image = global::SimpleClinic.Properties.Resources.Setting;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8);
            this.settingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(198, 45);
            this.settingsToolStripMenuItem.Text = "           Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 214;
            this.label1.Text = "Created by Hacimi Abdelhadi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(526, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 215;
            this.label2.Text = "2023/2024";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SimpleClinic.Properties.Resources.HeakthyBackground;
            this.ClientSize = new System.Drawing.Size(973, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Light";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todaySessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExamiationToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}