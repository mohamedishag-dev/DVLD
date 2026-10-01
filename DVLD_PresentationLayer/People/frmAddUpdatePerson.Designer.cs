namespace DVLD_PresentationLayer.People
{
    partial class frmAddUpdatePerson
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.llRemoveImage = new System.Windows.Forms.LinkLabel();
            this.llOpenFileDialog = new System.Windows.Forms.LinkLabel();
            this.labelPersonID = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.leblePhone = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelNationailNO = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelGendor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(266, 120);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.rbFemale_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(166, 120);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(734, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 157;
            this.label3.Text = "Last";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(673, 51);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(154, 20);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTestBox);
            // 
            // txtThirdName
            // 
            this.txtThirdName.Location = new System.Drawing.Point(504, 51);
            this.txtThirdName.MaxLength = 50;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(154, 20);
            this.txtThirdName.TabIndex = 2;
            this.txtThirdName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTestBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 156;
            this.label4.Text = "Third";
            // 
            // llRemoveImage
            // 
            this.llRemoveImage.AutoSize = true;
            this.llRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.llRemoveImage.Location = new System.Drawing.Point(707, 310);
            this.llRemoveImage.Name = "llRemoveImage";
            this.llRemoveImage.Size = new System.Drawing.Size(65, 16);
            this.llRemoveImage.TabIndex = 13;
            this.llRemoveImage.TabStop = true;
            this.llRemoveImage.Text = "Remove";
            this.llRemoveImage.Visible = false;
            this.llRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemoveImage_LinkClicked);
            // 
            // llOpenFileDialog
            // 
            this.llOpenFileDialog.AutoSize = true;
            this.llOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.llOpenFileDialog.Location = new System.Drawing.Point(699, 291);
            this.llOpenFileDialog.Name = "llOpenFileDialog";
            this.llOpenFileDialog.Size = new System.Drawing.Size(77, 16);
            this.llOpenFileDialog.TabIndex = 12;
            this.llOpenFileDialog.TabStop = true;
            this.llOpenFileDialog.Text = "Set Image";
            this.llOpenFileDialog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOpenFileDialog_LinkClicked);
            // 
            // labelPersonID
            // 
            this.labelPersonID.AutoSize = true;
            this.labelPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelPersonID.Location = new System.Drawing.Point(41, 52);
            this.labelPersonID.Name = "labelPersonID";
            this.labelPersonID.Size = new System.Drawing.Size(79, 16);
            this.labelPersonID.TabIndex = 156;
            this.labelPersonID.Text = "Person ID:";
            // 
            // cbCountry
            // 
            this.cbCountry.BackColor = System.Drawing.SystemColors.Window;
            this.cbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(473, 149);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(154, 21);
            this.cbCountry.TabIndex = 10;
            this.cbCountry.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(473, 84);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(154, 20);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new System.DateTime(2026, 11, 17, 0, 0, 0, 0);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(166, 187);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(461, 91);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTestBox);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 150);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Location = new System.Drawing.Point(166, 84);
            this.txtNationalNo.MaxLength = 50;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(154, 20);
            this.txtNationalNo.TabIndex = 4;
            this.txtNationalNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNo_Validating);
            // 
            // txtSecondName
            // 
            this.txtSecondName.Location = new System.Drawing.Point(336, 51);
            this.txtSecondName.MaxLength = 50;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(154, 20);
            this.txtSecondName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 51);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(154, 20);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTestBox);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.ForeColor = System.Drawing.Color.Red;
            this.lblPersonID.Location = new System.Drawing.Point(181, 52);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(33, 16);
            this.lblPersonID.TabIndex = 157;
            this.lblPersonID.Text = "N/A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 137;
            this.label2.Text = "Second";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtThirdName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.llRemoveImage);
            this.panel1.Controls.Add(this.llOpenFileDialog);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pbPersonImage);
            this.panel1.Controls.Add(this.cbCountry);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNationalNo);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.leblePhone);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.labelNationailNO);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.labelDateOfBirth);
            this.panel1.Controls.Add(this.labelCountry);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelGendor);
            this.panel1.Location = new System.Drawing.Point(17, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 345);
            this.panel1.TabIndex = 154;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(473, 117);
            this.txtPhone.MaxLength = 32;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 20);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateEmptyTestBox);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox10.Image = global::DVLD_PresentationLayer.Properties.Resources.Woman_32;
            this.pictureBox10.Location = new System.Drawing.Point(228, 119);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(32, 18);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 160;
            this.pictureBox10.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::DVLD_PresentationLayer.Properties.Resources.Close_32;
            this.btnClose.Location = new System.Drawing.Point(387, 283);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 43);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DVLD_PresentationLayer.Properties.Resources.Save_32;
            this.btnSave.Location = new System.Drawing.Point(510, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 43);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbPersonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPersonImage.Location = new System.Drawing.Point(650, 88);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(183, 188);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 145;
            this.pbPersonImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "First";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox9.Image = global::DVLD_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox9.Location = new System.Drawing.Point(128, 86);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 18);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 135;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Image = global::DVLD_PresentationLayer.Properties.Resources.Man_32;
            this.pictureBox8.Location = new System.Drawing.Point(128, 119);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 18);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 134;
            this.pictureBox8.TabStop = false;
            // 
            // leblePhone
            // 
            this.leblePhone.AutoSize = true;
            this.leblePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leblePhone.Location = new System.Drawing.Point(377, 121);
            this.leblePhone.Name = "leblePhone";
            this.leblePhone.Size = new System.Drawing.Size(55, 16);
            this.leblePhone.TabIndex = 121;
            this.leblePhone.Text = "Phone:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Image = global::DVLD_PresentationLayer.Properties.Resources.Email_32;
            this.pictureBox7.Location = new System.Drawing.Point(128, 152);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 133;
            this.pictureBox7.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(23, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(52, 16);
            this.labelName.TabIndex = 118;
            this.labelName.Text = "Name:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Image = global::DVLD_PresentationLayer.Properties.Resources.Address_32;
            this.pictureBox6.Location = new System.Drawing.Point(128, 187);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 132;
            this.pictureBox6.TabStop = false;
            // 
            // labelNationailNO
            // 
            this.labelNationailNO.AutoSize = true;
            this.labelNationailNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNationailNO.Location = new System.Drawing.Point(23, 88);
            this.labelNationailNO.Name = "labelNationailNO";
            this.labelNationailNO.Size = new System.Drawing.Size(99, 16);
            this.labelNationailNO.TabIndex = 119;
            this.labelNationailNO.Text = "Nationail NO:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::DVLD_PresentationLayer.Properties.Resources.Person_321;
            this.pictureBox5.Location = new System.Drawing.Point(128, 53);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 131;
            this.pictureBox5.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(23, 154);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 16);
            this.labelEmail.TabIndex = 120;
            this.labelEmail.Text = "Email:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::DVLD_PresentationLayer.Properties.Resources.Country_32;
            this.pictureBox4.Location = new System.Drawing.Point(435, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 130;
            this.pictureBox4.TabStop = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(23, 187);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(69, 16);
            this.labelAddress.TabIndex = 122;
            this.labelAddress.Text = "Address:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = global::DVLD_PresentationLayer.Properties.Resources.Phone_32;
            this.pictureBox3.Location = new System.Drawing.Point(435, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 129;
            this.pictureBox3.TabStop = false;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(342, 88);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(90, 16);
            this.labelDateOfBirth.TabIndex = 123;
            this.labelDateOfBirth.Text = "DateOfBirth:";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(369, 154);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(63, 16);
            this.labelCountry.TabIndex = 124;
            this.labelCountry.Text = "Country:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::DVLD_PresentationLayer.Properties.Resources.Calendar_32;
            this.pictureBox2.Location = new System.Drawing.Point(435, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // labelGendor
            // 
            this.labelGendor.AutoSize = true;
            this.labelGendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGendor.Location = new System.Drawing.Point(23, 121);
            this.labelGendor.Name = "labelGendor";
            this.labelGendor.Size = new System.Drawing.Size(62, 16);
            this.labelGendor.TabIndex = 126;
            this.labelGendor.Text = "Gendor:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::DVLD_PresentationLayer.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(146, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 158;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(884, 47);
            this.lblTitle.TabIndex = 159;
            this.lblTitle.Text = "Add New Person";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 428);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelPersonID);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdatePerson";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Person Info";
            this.Load += new System.EventHandler(this.frmAddEditPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llRemoveImage;
        private System.Windows.Forms.LinkLabel llOpenFileDialog;
        private System.Windows.Forms.Label labelPersonID;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label leblePhone;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelNationailNO;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelGendor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}