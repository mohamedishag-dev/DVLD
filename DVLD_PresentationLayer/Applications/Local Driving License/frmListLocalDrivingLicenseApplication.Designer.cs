namespace DVLD_PresentationLayer.Tests
{
    partial class frmListLocalDrivingLicenseApplication
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
            this.components = new System.ComponentModel.Container();
            this.lblTital = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.lblFelter = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDitelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.schduletestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDirvingLicenseFindTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showhistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDrivingLicenseApp = new System.Windows.Forms.DataGridView();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgPeople = new System.Windows.Forms.PictureBox();
            this.btnAddLocalDrivingLicenseApplication = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmsApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenseApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTital
            // 
            this.lblTital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital.ForeColor = System.Drawing.Color.Red;
            this.lblTital.Location = new System.Drawing.Point(309, 130);
            this.lblTital.Name = "lblTital";
            this.lblTital.Size = new System.Drawing.Size(510, 31);
            this.lblTital.TabIndex = 32;
            this.lblTital.Text = "Local Driving License Application";
            this.lblTital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFilterValue.Location = new System.Drawing.Point(265, 178);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(175, 26);
            this.txtFilterValue.TabIndex = 30;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // lblFelter
            // 
            this.lblFelter.AutoSize = true;
            this.lblFelter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFelter.Location = new System.Drawing.Point(14, 184);
            this.lblFelter.Name = "lblFelter";
            this.lblFelter.Size = new System.Drawing.Size(72, 20);
            this.lblFelter.TabIndex = 29;
            this.lblFelter.Text = "Felter By";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(92, 178);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(167, 28);
            this.cbFilterBy.TabIndex = 23;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(95, 511);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(16, 18);
            this.lblRecordsCount.TabIndex = 27;
            this.lblRecordsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "# Records:";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(270, 6);
            // 
            // cmsApplication
            // 
            this.cmsApplication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsApplication.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.cmsApplication.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.cmsApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDitelsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cancelToolStripMenuItem,
            this.toolStripMenuItem3,
            this.schduletestsToolStripMenuItem,
            this.toolStripMenuItem4,
            this.issueDirvingLicenseFindTimeToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showhistoryToolStripMenuItem});
            this.cmsApplication.Name = "contextMenuStrip1";
            this.cmsApplication.Size = new System.Drawing.Size(274, 318);
            this.cmsApplication.Opening += new System.ComponentModel.CancelEventHandler(this.cmsApplication_Opening);
            // 
            // showDitelsToolStripMenuItem
            // 
            this.showDitelsToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.PersonDetails_32;
            this.showDitelsToolStripMenuItem.Name = "showDitelsToolStripMenuItem";
            this.showDitelsToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.showDitelsToolStripMenuItem.Text = "Show Application Ditels";
            this.showDitelsToolStripMenuItem.Click += new System.EventHandler(this.showDitelsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.editToolStripMenuItem.Text = "Edit Application";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Delete_32_2;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.deleteToolStripMenuItem.Text = "Delete Application";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(270, 6);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Delete_32;
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.cancelToolStripMenuItem.Text = "Cancel Application";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(270, 6);
            // 
            // schduletestsToolStripMenuItem
            // 
            this.schduletestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWrittenTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.schduletestsToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Schedule_Test_32;
            this.schduletestsToolStripMenuItem.Name = "schduletestsToolStripMenuItem";
            this.schduletestsToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.schduletestsToolStripMenuItem.Text = "Schdule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Vision_Test_32;
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.scheduleVisionTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleVisionTestToolStripMenuItem_Click);
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            this.scheduleWrittenTestToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Written_Test_32;
            this.scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            this.scheduleWrittenTestToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.scheduleWrittenTestToolStripMenuItem.Text = "Schedule WrittenTest";
            this.scheduleWrittenTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleWrittenTestToolStripMenuItem_Click);
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(206, 32);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.scheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.scheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(270, 6);
            // 
            // issueDirvingLicenseFindTimeToolStripMenuItem
            // 
            this.issueDirvingLicenseFindTimeToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Lost_Driving_License_32;
            this.issueDirvingLicenseFindTimeToolStripMenuItem.Name = "issueDirvingLicenseFindTimeToolStripMenuItem";
            this.issueDirvingLicenseFindTimeToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.issueDirvingLicenseFindTimeToolStripMenuItem.Text = "Issue Dirving License (Find Time)";
            this.issueDirvingLicenseFindTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDirvingLicenseFindTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(270, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.Lost_Driving_License_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(270, 6);
            // 
            // showhistoryToolStripMenuItem
            // 
            this.showhistoryToolStripMenuItem.Image = global::DVLD_PresentationLayer.Properties.Resources.PersonLicenseHistory_32;
            this.showhistoryToolStripMenuItem.Name = "showhistoryToolStripMenuItem";
            this.showhistoryToolStripMenuItem.Size = new System.Drawing.Size(273, 32);
            this.showhistoryToolStripMenuItem.Text = "Show Person License History";
            this.showhistoryToolStripMenuItem.Click += new System.EventHandler(this.showhistoryToolStripMenuItem_Click);
            // 
            // dgvDrivingLicenseApp
            // 
            this.dgvDrivingLicenseApp.AllowUserToAddRows = false;
            this.dgvDrivingLicenseApp.AllowUserToDeleteRows = false;
            this.dgvDrivingLicenseApp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDrivingLicenseApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrivingLicenseApp.ContextMenuStrip = this.cmsApplication;
            this.dgvDrivingLicenseApp.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvDrivingLicenseApp.Location = new System.Drawing.Point(14, 212);
            this.dgvDrivingLicenseApp.Name = "dgvDrivingLicenseApp";
            this.dgvDrivingLicenseApp.ReadOnly = true;
            this.dgvDrivingLicenseApp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrivingLicenseApp.Size = new System.Drawing.Size(1070, 285);
            this.dgvDrivingLicenseApp.TabIndex = 24;
            // 
            // cbStatus
            // 
            this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Canceled",
            "Completed"});
            this.cbStatus.Location = new System.Drawing.Point(265, 178);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 28);
            this.cbStatus.TabIndex = 34;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.Local_321;
            this.pictureBox1.Location = new System.Drawing.Point(598, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // imgPeople
            // 
            this.imgPeople.Image = global::DVLD_PresentationLayer.Properties.Resources.Applications;
            this.imgPeople.Location = new System.Drawing.Point(443, 3);
            this.imgPeople.Name = "imgPeople";
            this.imgPeople.Size = new System.Drawing.Size(198, 124);
            this.imgPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPeople.TabIndex = 31;
            this.imgPeople.TabStop = false;
            // 
            // btnAddLocalDrivingLicenseApplication
            // 
            this.btnAddLocalDrivingLicenseApplication.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.New_Application_64;
            this.btnAddLocalDrivingLicenseApplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLocalDrivingLicenseApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLocalDrivingLicenseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocalDrivingLicenseApplication.Location = new System.Drawing.Point(1026, 161);
            this.btnAddLocalDrivingLicenseApplication.Name = "btnAddLocalDrivingLicenseApplication";
            this.btnAddLocalDrivingLicenseApplication.Size = new System.Drawing.Size(58, 43);
            this.btnAddLocalDrivingLicenseApplication.TabIndex = 28;
            this.btnAddLocalDrivingLicenseApplication.UseVisualStyleBackColor = true;
            this.btnAddLocalDrivingLicenseApplication.Click += new System.EventHandler(this.btnAddLocalDrivingLicenseApplication_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(978, 509);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmListLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 556);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgPeople);
            this.Controls.Add(this.lblTital);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.lblFelter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnAddLocalDrivingLicenseApplication);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvDrivingLicenseApp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListLocalDrivingLicenseApplication";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Local Driving License Application";
            this.Load += new System.EventHandler(this.frmListLocalDrivingLicenseApplication_Load);
            this.cmsApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrivingLicenseApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPeople;
        private System.Windows.Forms.Label lblTital;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label lblFelter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddLocalDrivingLicenseApplication;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem showhistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDitelsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplication;
        private System.Windows.Forms.ToolStripMenuItem schduletestsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDrivingLicenseApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ToolStripMenuItem issueDirvingLicenseFindTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}