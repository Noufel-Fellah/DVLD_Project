namespace DVLD
{
    partial class fillForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fillForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPersonID = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gpPersonDetails = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.llSetImage = new System.Windows.Forms.LinkLabel();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmCountry = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNationalNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbSecondName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPersonIDValue = new System.Windows.Forms.Label();
            this.OFD1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbPersonIDIcon = new System.Windows.Forms.Label();
            this.gpPersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(711, 62);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Add a new person";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPersonID
            // 
            this.lbPersonID.Location = new System.Drawing.Point(8, 62);
            this.lbPersonID.Name = "lbPersonID";
            this.lbPersonID.Size = new System.Drawing.Size(62, 23);
            this.lbPersonID.TabIndex = 2;
            this.lbPersonID.Text = "Person ID:";
            this.lbPersonID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "PersonID.png");
            this.imageList1.Images.SetKeyName(1, "female.png");
            this.imageList1.Images.SetKeyName(2, "male.png");
            this.imageList1.Images.SetKeyName(3, "Email (2).png");
            this.imageList1.Images.SetKeyName(4, "country (2).png");
            this.imageList1.Images.SetKeyName(5, "phone.png");
            this.imageList1.Images.SetKeyName(6, "date of birth (2).png");
            this.imageList1.Images.SetKeyName(7, "address.png");
            this.imageList1.Images.SetKeyName(8, "name.png");
            // 
            // gpPersonDetails
            // 
            this.gpPersonDetails.Controls.Add(this.btnClose);
            this.gpPersonDetails.Controls.Add(this.btnSave);
            this.gpPersonDetails.Controls.Add(this.llSetImage);
            this.gpPersonDetails.Controls.Add(this.llRemove);
            this.gpPersonDetails.Controls.Add(this.tbAddress);
            this.gpPersonDetails.Controls.Add(this.label18);
            this.gpPersonDetails.Controls.Add(this.label17);
            this.gpPersonDetails.Controls.Add(this.cmCountry);
            this.gpPersonDetails.Controls.Add(this.label16);
            this.gpPersonDetails.Controls.Add(this.label15);
            this.gpPersonDetails.Controls.Add(this.tbEmail);
            this.gpPersonDetails.Controls.Add(this.label14);
            this.gpPersonDetails.Controls.Add(this.label13);
            this.gpPersonDetails.Controls.Add(this.label12);
            this.gpPersonDetails.Controls.Add(this.label11);
            this.gpPersonDetails.Controls.Add(this.tbPhone);
            this.gpPersonDetails.Controls.Add(this.label10);
            this.gpPersonDetails.Controls.Add(this.rbFemale);
            this.gpPersonDetails.Controls.Add(this.label9);
            this.gpPersonDetails.Controls.Add(this.rbMale);
            this.gpPersonDetails.Controls.Add(this.label8);
            this.gpPersonDetails.Controls.Add(this.pbPersonImage);
            this.gpPersonDetails.Controls.Add(this.dtpDateOfBirth);
            this.gpPersonDetails.Controls.Add(this.label7);
            this.gpPersonDetails.Controls.Add(this.label6);
            this.gpPersonDetails.Controls.Add(this.label5);
            this.gpPersonDetails.Controls.Add(this.label4);
            this.gpPersonDetails.Controls.Add(this.tbNationalNum);
            this.gpPersonDetails.Controls.Add(this.label3);
            this.gpPersonDetails.Controls.Add(this.label2);
            this.gpPersonDetails.Controls.Add(this.lbFirstName);
            this.gpPersonDetails.Controls.Add(this.lbSecondName);
            this.gpPersonDetails.Controls.Add(this.label1);
            this.gpPersonDetails.Controls.Add(this.tbSecondName);
            this.gpPersonDetails.Controls.Add(this.tbThirdName);
            this.gpPersonDetails.Controls.Add(this.tbLastName);
            this.gpPersonDetails.Controls.Add(this.tbFirstName);
            this.gpPersonDetails.Controls.Add(this.lbName);
            this.gpPersonDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gpPersonDetails.Location = new System.Drawing.Point(0, 88);
            this.gpPersonDetails.Name = "gpPersonDetails";
            this.gpPersonDetails.Size = new System.Drawing.Size(711, 414);
            this.gpPersonDetails.TabIndex = 5;
            this.gpPersonDetails.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 29);
            this.btnClose.TabIndex = 47;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(495, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 29);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // llSetImage
            // 
            this.llSetImage.AutoSize = true;
            this.llSetImage.Location = new System.Drawing.Point(551, 267);
            this.llSetImage.Name = "llSetImage";
            this.llSetImage.Size = new System.Drawing.Size(52, 13);
            this.llSetImage.TabIndex = 45;
            this.llSetImage.TabStop = true;
            this.llSetImage.Text = "set image";
            this.llSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetImage_LinkClicked);
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Location = new System.Drawing.Point(630, 267);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(42, 13);
            this.llRemove.TabIndex = 44;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "remove";
            this.llRemove.Visible = false;
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(114, 278);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(308, 84);
            this.tbAddress.TabIndex = 43;
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // label18
            // 
            this.label18.ImageKey = "address.png";
            this.label18.ImageList = this.imageList1;
            this.label18.Location = new System.Drawing.Point(61, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 28);
            this.label18.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(8, 278);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 28);
            this.label17.TabIndex = 41;
            this.label17.Text = "Address";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmCountry
            // 
            this.cmCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmCountry.FormattingEnabled = true;
            this.cmCountry.Location = new System.Drawing.Point(380, 229);
            this.cmCountry.Name = "cmCountry";
            this.cmCountry.Size = new System.Drawing.Size(121, 21);
            this.cmCountry.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.ImageKey = "country (2).png";
            this.label16.ImageList = this.imageList1;
            this.label16.Location = new System.Drawing.Point(345, 225);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 28);
            this.label16.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(289, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 28);
            this.label15.TabIndex = 38;
            this.label15.Text = "Country";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(101, 229);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(97, 20);
            this.tbEmail.TabIndex = 37;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // label14
            // 
            this.label14.ImageKey = "Email (2).png";
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(61, 225);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 28);
            this.label14.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 28);
            this.label13.TabIndex = 35;
            this.label13.Text = "Email";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.ImageKey = "phone.png";
            this.label12.ImageList = this.imageList1;
            this.label12.Location = new System.Drawing.Point(345, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 28);
            this.label12.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(289, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "Phone";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(385, 176);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(116, 20);
            this.tbPhone.TabIndex = 32;
            this.tbPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhone_Validating);
            // 
            // label10
            // 
            this.label10.ImageKey = "female.png";
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(157, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 34);
            this.label10.TabIndex = 31;
            // 
            // rbFemale
            // 
            this.rbFemale.ImageKey = "(none)";
            this.rbFemale.Location = new System.Drawing.Point(197, 172);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(60, 24);
            this.rbFemale.TabIndex = 30;
            this.rbFemale.Text = "female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.ImageKey = "male.png";
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(64, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 34);
            this.label9.TabIndex = 29;
            // 
            // rbMale
            // 
            this.rbMale.Checked = true;
            this.rbMale.ImageKey = "(none)";
            this.rbMale.Location = new System.Drawing.Point(104, 172);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 24);
            this.rbMale.TabIndex = 28;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.rbMale_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Gender";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = null;
            this.pbPersonImage.Image = global::DVLD.Properties.Resources.boy;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(516, 113);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(179, 140);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 23;
            this.pbPersonImage.TabStop = false;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(404, 121);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(95, 20);
            this.dtpDateOfBirth.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.ImageKey = "date of birth (2).png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(353, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 30);
            this.label7.TabIndex = 21;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(269, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Date of birth";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.ImageKey = "PersonID.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(61, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 28);
            this.label5.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.ImageKey = "name.png";
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(53, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 32);
            this.label4.TabIndex = 18;
            // 
            // tbNationalNum
            // 
            this.tbNationalNum.Location = new System.Drawing.Point(101, 119);
            this.tbNationalNum.Name = "tbNationalNum";
            this.tbNationalNum.Size = new System.Drawing.Size(97, 20);
            this.tbNationalNum.TabIndex = 17;
            this.tbNationalNum.Validating += new System.ComponentModel.CancelEventHandler(this.cmNationalNum_Validating);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "National num";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(552, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "last name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFirstName
            // 
            this.lbFirstName.Location = new System.Drawing.Point(101, 35);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(97, 23);
            this.lbFirstName.TabIndex = 14;
            this.lbFirstName.Text = "first name";
            this.lbFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSecondName
            // 
            this.lbSecondName.Location = new System.Drawing.Point(250, 35);
            this.lbSecondName.Name = "lbSecondName";
            this.lbSecondName.Size = new System.Drawing.Size(100, 23);
            this.lbSecondName.TabIndex = 13;
            this.lbSecondName.Text = "second name";
            this.lbSecondName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(401, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "third name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(252, 61);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(97, 20);
            this.tbSecondName.TabIndex = 11;
            this.tbSecondName.Validating += new System.ComponentModel.CancelEventHandler(this.tbSecondName_Validating);
            // 
            // tbThirdName
            // 
            this.tbThirdName.Location = new System.Drawing.Point(403, 61);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(97, 20);
            this.tbThirdName.TabIndex = 10;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(554, 61);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(97, 20);
            this.tbLastName.TabIndex = 9;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(101, 61);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(97, 20);
            this.tbFirstName.TabIndex = 8;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(8, 60);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(50, 23);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPersonIDValue
            // 
            this.lbPersonIDValue.Location = new System.Drawing.Point(111, 62);
            this.lbPersonIDValue.Name = "lbPersonIDValue";
            this.lbPersonIDValue.Size = new System.Drawing.Size(62, 23);
            this.lbPersonIDValue.TabIndex = 6;
            this.lbPersonIDValue.Text = "N\\A";
            this.lbPersonIDValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OFD1
            // 
            this.OFD1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbPersonIDIcon
            // 
            this.lbPersonIDIcon.ImageIndex = 0;
            this.lbPersonIDIcon.ImageList = this.imageList1;
            this.lbPersonIDIcon.Location = new System.Drawing.Point(76, 62);
            this.lbPersonIDIcon.Name = "lbPersonIDIcon";
            this.lbPersonIDIcon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbPersonIDIcon.Size = new System.Drawing.Size(29, 23);
            this.lbPersonIDIcon.TabIndex = 4;
            this.lbPersonIDIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPersonIDValue);
            this.Controls.Add(this.gpPersonDetails);
            this.Controls.Add(this.lbPersonIDIcon);
            this.Controls.Add(this.lbPersonID);
            this.Controls.Add(this.lbTitle);
            this.Name = "fillForm";
            this.Size = new System.Drawing.Size(711, 502);
            this.gpPersonDetails.ResumeLayout(false);
            this.gpPersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbPersonID;
        private System.Windows.Forms.Label lbPersonIDIcon;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gpPersonDetails;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPersonIDValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbNationalNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel llSetImage;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmCountry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog OFD1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
