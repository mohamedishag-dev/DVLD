namespace DVLD.Applications.Internatioal_License.Controls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDriverLicenses = new System.Windows.Forms.GroupBox();
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
            this.dgvInternationalLicenses = new System.Windows.Forms.DataGridView();
            this.gbDriverLicenses.SuspendLayout();
            this.tcLicenses.SuspendLayout();
            this.Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDriverLicenses
            // 
            this.gbDriverLicenses.Controls.Add(this.tcLicenses);
            this.gbDriverLicenses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbDriverLicenses.Location = new System.Drawing.Point(3, 3);
            this.gbDriverLicenses.Name = "gbDriverLicenses";
            this.gbDriverLicenses.Size = new System.Drawing.Size(899, 230);
            this.gbDriverLicenses.TabIndex = 32;
            this.gbDriverLicenses.TabStop = false;
            this.gbDriverLicenses.Text = "Driver Licenses";
            // 
            // tcLicenses
            // 
            this.tcLicenses.Controls.Add(this.Local);
            this.tcLicenses.Controls.Add(this.tpInternational);
            this.tcLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLicenses.Location = new System.Drawing.Point(3, 16);
            this.tcLicenses.Name = "tcLicenses";
            this.tcLicenses.SelectedIndex = 0;
            this.tcLicenses.Size = new System.Drawing.Size(893, 211);
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
            this.Local.Size = new System.Drawing.Size(885, 185);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local";
            this.Local.UseVisualStyleBackColor = true;
            // 
            // lblRecordsCountLocal
            // 
            this.lblRecordsCountLocal.AutoSize = true;
            this.lblRecordsCountLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCountLocal.Location = new System.Drawing.Point(87, 164);
            this.lblRecordsCountLocal.Name = "lblRecordsCountLocal";
            this.lblRecordsCountLocal.Size = new System.Drawing.Size(16, 18);
            this.lblRecordsCountLocal.TabIndex = 32;
            this.lblRecordsCountLocal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 162);
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
            this.dgvLocalLicenses.Size = new System.Drawing.Size(873, 140);
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
            this.tpInternational.Size = new System.Drawing.Size(885, 185);
            this.tpInternational.TabIndex = 1;
            this.tpInternational.Text = "International";
            this.tpInternational.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 162);
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
            this.dgvInternationalLicenses.Size = new System.Drawing.Size(873, 140);
            this.dgvInternationalLicenses.TabIndex = 29;
            // 
            // ctrlDriverInternationalLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDriverLicenses);
            this.Name = "ctrlDriverInternationalLicenseInfo";
            this.Size = new System.Drawing.Size(911, 238);
            this.gbDriverLicenses.ResumeLayout(false);
            this.tcLicenses.ResumeLayout(false);
            this.Local.ResumeLayout(false);
            this.Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.tpInternational.ResumeLayout(false);
            this.tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDriverLicenses;
        private System.Windows.Forms.TabControl tcLicenses;
        private System.Windows.Forms.TabPage Local;
        private System.Windows.Forms.Label lblRecordsCountLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private System.Windows.Forms.Label lblLocalLicenses;
        private System.Windows.Forms.TabPage tpInternational;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternationalLicenses;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
    }
}
