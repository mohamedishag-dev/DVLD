namespace DVLD_PresentationLayer.Licenses
{
    partial class frmLicenseHistory
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
            this.lblTital = new System.Windows.Forms.Label();
            this.imgPeople = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.tcLicenses = new System.Windows.Forms.TabControl();
            this.Local = new System.Windows.Forms.TabPage();
            this.lblRecordsCountLocal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.lblLocalLicenses = new System.Windows.Forms.Label();
            this.tpInternational = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInternationalLicenses = new System.Windows.Forms.Label();
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
            this.ctrlPersonWithFilter1 = new DVLD_PresentationLayer.ctrlPersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.tcLicenses.SuspendLayout();
            this.Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.tpInternational.SuspendLayout();
            this.gbDriverLicenses.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTital
            // 
            this.lblTital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital.ForeColor = System.Drawing.Color.Red;
            this.lblTital.Location = new System.Drawing.Point(130, 9);
            this.lblTital.Name = "lblTital";
            this.lblTital.Size = new System.Drawing.Size(510, 46);
            this.lblTital.TabIndex = 26;
            this.lblTital.Text = "Driver License Info";
            this.lblTital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPeople
            // 
            this.imgPeople.Image = global::DVLD_PresentationLayer.Properties.Resources.PersonLicenseHistory_512;
            this.imgPeople.Location = new System.Drawing.Point(12, 149);
            this.imgPeople.Name = "imgPeople";
            this.imgPeople.Size = new System.Drawing.Size(159, 163);
            this.imgPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPeople.TabIndex = 25;
            this.imgPeople.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(817, 600);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvInternationalLicenses
            // 
            this.dgvInternationalLicenses.AllowUserToAddRows = false;
            this.dgvInternationalLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalLicenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicenses.Location = new System.Drawing.Point(6, 19);
            this.dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            this.dgvInternationalLicenses.ReadOnly = true;
            this.dgvInternationalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(765, 126);
            this.dgvInternationalLicenses.TabIndex = 29;
            // 
            // tcLicenses
            // 
            this.tcLicenses.Controls.Add(this.Local);
            this.tcLicenses.Controls.Add(this.tpInternational);
            this.tcLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLicenses.Location = new System.Drawing.Point(3, 16);
            this.tcLicenses.Name = "tcLicenses";
            this.tcLicenses.SelectedIndex = 0;
            this.tcLicenses.Size = new System.Drawing.Size(785, 200);
            this.tcLicenses.TabIndex = 30;
            // 
            // Local
            // 
            this.Local.Controls.Add(this.lblRecordsCountLocal);
            this.Local.Controls.Add(this.label1);
            this.Local.Controls.Add(this.dgvLocalLicenses);
            this.Local.Controls.Add(this.lblLocalLicenses);
            this.Local.Location = new System.Drawing.Point(4, 22);
            this.Local.Name = "Local";
            this.Local.Padding = new System.Windows.Forms.Padding(3);
            this.Local.Size = new System.Drawing.Size(777, 174);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCountLocal
            // 
            this.lblRecordsCountLocal.AutoSize = true;
            this.lblRecordsCountLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountLocal.Location = new System.Drawing.Point(87, 153);
            this.lblRecordsCountLocal.Name = "lblRecordsCountLocal";
            this.lblRecordsCountLocal.Size = new System.Drawing.Size(16, 18);
            this.lblRecordsCountLocal.TabIndex = 32;
            this.lblRecordsCountLocal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "# Records:";
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(6, 19);
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(765, 126);
            this.dgvLocalLicenses.TabIndex = 30;
            // 
            // lblLocalLicenses
            // 
            this.lblLocalLicenses.AutoSize = true;
            this.lblLocalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalLicenses.Location = new System.Drawing.Point(6, 3);
            this.lblLocalLicenses.Name = "lblLocalLicenses";
            this.lblLocalLicenses.Size = new System.Drawing.Size(139, 13);
            this.lblLocalLicenses.TabIndex = 1;
            this.lblLocalLicenses.Text = "Local Licenses History:";
            // 
            // tpInternational
            // 
            this.tpInternational.Controls.Add(this.label2);
            this.tpInternational.Controls.Add(this.label3);
            this.tpInternational.Controls.Add(this.lblInternationalLicenses);
            this.tpInternational.Controls.Add(this.dgvInternationalLicenses);
            this.tpInternational.Location = new System.Drawing.Point(4, 22);
            this.tpInternational.Name = "tpInternational";
            this.tpInternational.Padding = new System.Windows.Forms.Padding(3);
            this.tpInternational.Size = new System.Drawing.Size(777, 174);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "# Records:";
            // 
            // lblInternationalLicenses
            // 
            this.lblInternationalLicenses.AutoSize = true;
            this.lblInternationalLicenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblInternationalLicenses.Location = new System.Drawing.Point(6, 3);
            this.lblInternationalLicenses.Name = "lblInternationalLicenses";
            this.lblInternationalLicenses.Size = new System.Drawing.Size(179, 13);
            this.lblInternationalLicenses.TabIndex = 1;
            this.lblInternationalLicenses.Text = "International Licenses History:";
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcLicenses);
            this.gbDriverLicenses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbDriverLicenses.Location = new System.Drawing.Point(135, 375);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(791, 219);
            this.gbDriverLicenses.TabIndex = 31;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.FilterEnabled = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(177, 58);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.ShowAddPerson = true;
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(746, 327);
            this.ctrlPersonWithFilter1.TabIndex = 27;
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 641);
            this.Controls.Add(this.gbDriverLicenses);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPersonWithFilter1);
            this.Controls.Add(this.imgPeople);
            this.Controls.Add(this.lblTital);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLicenseHistory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License History";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.tcLicenses.ResumeLayout(false);
            this.Local.ResumeLayout(false);
            this.Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            this.gbDriverLicenses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPeople;
        private System.Windows.Forms.Label lblTital;
        private ctrlPersonCardWithFilter ctrlPersonWithFilter1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.TabControl tcLicenses;
        private System.Windows.Forms.TabPage Local;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.Label lblLocalLicenses;
        private System.Windows.Forms.Label lblInternationalLicenses;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.Label lblRecordsCountLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}