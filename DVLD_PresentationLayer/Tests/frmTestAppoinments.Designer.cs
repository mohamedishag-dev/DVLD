namespace DVLD_PresentationLayer.Applications
{
    partial class frmTestAppoinments
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
            this.lblAppoinments = new System.Windows.Forms.Label();
            this.dgvAppoinments = new System.Windows.Forms.DataGridView();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddPreson = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlAppointmentCard1 = new DVLD_PresentationLayer.Applications.Controls.ctrlAppointmentCard();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppoinments
            // 
            this.lblAppoinments.AutoSize = true;
            this.lblAppoinments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppoinments.Location = new System.Drawing.Point(8, 465);
            this.lblAppoinments.Name = "lblAppoinments";
            this.lblAppoinments.Size = new System.Drawing.Size(103, 20);
            this.lblAppoinments.TabIndex = 25;
            this.lblAppoinments.Text = "Appoinments";
            // 
            // dgvAppoinments
            // 
            this.dgvAppoinments.AllowUserToAddRows = false;
            this.dgvAppoinments.AllowUserToDeleteRows = false;
            this.dgvAppoinments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAppoinments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoinments.Location = new System.Drawing.Point(8, 491);
            this.dgvAppoinments.Name = "dgvAppoinments";
            this.dgvAppoinments.ReadOnly = true;
            this.dgvAppoinments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppoinments.Size = new System.Drawing.Size(681, 133);
            this.dgvAppoinments.TabIndex = 23;
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordsCount.Location = new System.Drawing.Point(89, 644);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(16, 18);
            this.lblRecordsCount.TabIndex = 22;
            this.lblRecordsCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "# Records:";
            // 
            // btnAddPreson
            // 
            this.btnAddPreson.BackgroundImage = global::DVLD_PresentationLayer.Properties.Resources.AddAppointment_32;
            this.btnAddPreson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPreson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPreson.Location = new System.Drawing.Point(646, 456);
            this.btnAddPreson.Name = "btnAddPreson";
            this.btnAddPreson.Size = new System.Drawing.Size(43, 29);
            this.btnAddPreson.TabIndex = 24;
            this.btnAddPreson.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::DVLD_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(583, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(106, 38);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.Vision_512;
            this.pictureBox1.Location = new System.Drawing.Point(268, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(194, 84);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(331, 31);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Vision Test Appoinments";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlAppointmentCard1
            // 
            this.ctrlAppointmentCard1.Location = new System.Drawing.Point(8, 118);
            this.ctrlAppointmentCard1.Name = "ctrlAppointmentCard1";
            this.ctrlAppointmentCard1.Size = new System.Drawing.Size(687, 331);
            this.ctrlAppointmentCard1.TabIndex = 28;
            // 
            // frmTestAppoinments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 671);
            this.Controls.Add(this.ctrlAppointmentCard1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAppoinments);
            this.Controls.Add(this.btnAddPreson);
            this.Controls.Add(this.dgvAppoinments);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTestAppoinments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vision Test Appoinments";
            this.Load += new System.EventHandler(this.frmSechduleTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppoinments;
        private System.Windows.Forms.Button btnAddPreson;
        private System.Windows.Forms.DataGridView dgvAppoinments;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlAppointmentCard ctrlAppointmentCard1;
    }
}