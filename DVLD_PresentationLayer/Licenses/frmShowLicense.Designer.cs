namespace DVLD_PresentationLayer.Licenses
{
    partial class frmShowLicense
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
            this.btnClose = new System.Windows.Forms.Button();
            this.imgPeople = new System.Windows.Forms.PictureBox();
            this.ctrlLicenseCard1 = new DVLD_PresentationLayer.Licenses.ctrlLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTital
            // 
            this.lblTital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital.ForeColor = System.Drawing.Color.Red;
            this.lblTital.Location = new System.Drawing.Point(159, 118);
            this.lblTital.Name = "lblTital";
            this.lblTital.Size = new System.Drawing.Size(510, 31);
            this.lblTital.TabIndex = 24;
            this.lblTital.Text = "Driver License Info";
            this.lblTital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(692, 497);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgPeople
            // 
            this.imgPeople.Image = global::DVLD_PresentationLayer.Properties.Resources.LicenseView_400;
            this.imgPeople.Location = new System.Drawing.Point(329, 12);
            this.imgPeople.Name = "imgPeople";
            this.imgPeople.Size = new System.Drawing.Size(162, 103);
            this.imgPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPeople.TabIndex = 23;
            this.imgPeople.TabStop = false;
            // 
            // ctrlLicenseCard1
            // 
            this.ctrlLicenseCard1.Location = new System.Drawing.Point(12, 169);
            this.ctrlLicenseCard1.Name = "ctrlLicenseCard1";
            this.ctrlLicenseCard1.Size = new System.Drawing.Size(786, 322);
            this.ctrlLicenseCard1.TabIndex = 26;
            // 
            // frmShowLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 545);
            this.Controls.Add(this.ctrlLicenseCard1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.imgPeople);
            this.Controls.Add(this.lblTital);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License Info";
            this.Load += new System.EventHandler(this.frmShowLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imgPeople;
        private System.Windows.Forms.Label lblTital;
        private System.Windows.Forms.Button btnClose;
        private ctrlLicenseCard ctrlLicenseCard1;
    }
}