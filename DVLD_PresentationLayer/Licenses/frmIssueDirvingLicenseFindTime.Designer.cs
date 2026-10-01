namespace DVLD_PresentationLayer
{
    partial class frmIssueDirvingLicenseForTheFirstTime
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
            this.ctrlAppointmentCard1 = new DVLD_PresentationLayer.Applications.Controls.ctrlAppointmentCard();
            this.SuspendLayout();
            // 
            // ctrlAppointmentCard1
            // 
            this.ctrlAppointmentCard1.Location = new System.Drawing.Point(13, 33);
            this.ctrlAppointmentCard1.Name = "ctrlAppointmentCard1";
            this.ctrlAppointmentCard1.Size = new System.Drawing.Size(687, 331);
            this.ctrlAppointmentCard1.TabIndex = 0;
            // 
            // frmIssueDirvingLicenseForTheFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlAppointmentCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIssueDirvingLicenseForTheFirstTime";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Dirving License For The First Time";
            this.ResumeLayout(false);

        }

        #endregion

        private Applications.Controls.ctrlAppointmentCard ctrlAppointmentCard1;
    }
}