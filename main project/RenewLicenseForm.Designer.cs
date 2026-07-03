namespace DVLD
{
    partial class RenewLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenewLicenseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchForDrivingLicense1 = new DVLD.SearchForDrivingLicense();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowNewLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowHistroyOfTheDriver = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRLAppID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbappDate = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbappFees = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLicenseFees = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbRenewedLicenseID = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbCreatedUser = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew License Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchForDrivingLicense1
            // 
            this.searchForDrivingLicense1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForDrivingLicense1.Location = new System.Drawing.Point(0, 23);
            this.searchForDrivingLicense1.Name = "searchForDrivingLicense1";
            this.searchForDrivingLicense1.Size = new System.Drawing.Size(710, 414);
            this.searchForDrivingLicense1.TabIndex = 1;
            this.searchForDrivingLicense1.GetLicence += new System.Action<bst.clsLicenses>(this.searchForDrivingLicense1_GetLicence);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenew);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.llShowNewLicenseInfo);
            this.groupBox1.Controls.Add(this.llShowHistroyOfTheDriver);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 671);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 33);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRenew
            // 
            this.btnRenew.Enabled = false;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Location = new System.Drawing.Point(533, 10);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(75, 23);
            this.btnRenew.TabIndex = 3;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(629, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowNewLicenseInfo
            // 
            this.llShowNewLicenseInfo.AutoSize = true;
            this.llShowNewLicenseInfo.Enabled = false;
            this.llShowNewLicenseInfo.Location = new System.Drawing.Point(149, 15);
            this.llShowNewLicenseInfo.Name = "llShowNewLicenseInfo";
            this.llShowNewLicenseInfo.Size = new System.Drawing.Size(120, 13);
            this.llShowNewLicenseInfo.TabIndex = 1;
            this.llShowNewLicenseInfo.TabStop = true;
            this.llShowNewLicenseInfo.Text = "Show New License Info";
            this.llShowNewLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicenseInfo_LinkClicked);
            // 
            // llShowHistroyOfTheDriver
            // 
            this.llShowHistroyOfTheDriver.AutoSize = true;
            this.llShowHistroyOfTheDriver.Enabled = false;
            this.llShowHistroyOfTheDriver.Location = new System.Drawing.Point(12, 15);
            this.llShowHistroyOfTheDriver.Name = "llShowHistroyOfTheDriver";
            this.llShowHistroyOfTheDriver.Size = new System.Drawing.Size(114, 13);
            this.llShowHistroyOfTheDriver.TabIndex = 0;
            this.llShowHistroyOfTheDriver.TabStop = true;
            this.llShowHistroyOfTheDriver.Text = "Show Licenses Histroy";
            this.llShowHistroyOfTheDriver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowHistroyOfTheDriver_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ID.png");
            this.imageList1.Images.SetKeyName(1, "Date.png");
            this.imageList1.Images.SetKeyName(2, "fees.png");
            this.imageList1.Images.SetKeyName(3, "Driving class.png");
            this.imageList1.Images.SetKeyName(4, "User.png");
            this.imageList1.Images.SetKeyName(5, "Notes.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "R.L.Application ID";
            // 
            // label3
            // 
            this.label3.ImageKey = "ID.png";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(111, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            // 
            // lbRLAppID
            // 
            this.lbRLAppID.Location = new System.Drawing.Point(152, 25);
            this.lbRLAppID.Name = "lbRLAppID";
            this.lbRLAppID.Size = new System.Drawing.Size(35, 13);
            this.lbRLAppID.TabIndex = 2;
            this.lbRLAppID.Text = "////////";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Application date";
            // 
            // label5
            // 
            this.label5.ImageKey = "Date.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(111, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 31);
            this.label5.TabIndex = 4;
            // 
            // lbappDate
            // 
            this.lbappDate.Location = new System.Drawing.Point(152, 56);
            this.lbappDate.Name = "lbappDate";
            this.lbappDate.Size = new System.Drawing.Size(73, 13);
            this.lbappDate.TabIndex = 5;
            this.lbappDate.Text = "////////";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 87);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Issue date";
            // 
            // label17
            // 
            this.label17.ImageKey = "Date.png";
            this.label17.ImageList = this.imageList1;
            this.label17.Location = new System.Drawing.Point(111, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 31);
            this.label17.TabIndex = 16;
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.Location = new System.Drawing.Point(152, 87);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(73, 13);
            this.lbIssueDate.TabIndex = 17;
            this.lbIssueDate.Text = "////////";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Application fees";
            // 
            // label8
            // 
            this.label8.ImageKey = "fees.png";
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(111, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 31);
            this.label8.TabIndex = 19;
            // 
            // lbappFees
            // 
            this.lbappFees.Location = new System.Drawing.Point(152, 118);
            this.lbappFees.Name = "lbappFees";
            this.lbappFees.Size = new System.Drawing.Size(35, 13);
            this.lbappFees.TabIndex = 20;
            this.lbappFees.Text = "////////";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "License fees";
            // 
            // label11
            // 
            this.label11.ImageKey = "fees.png";
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(111, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 31);
            this.label11.TabIndex = 22;
            // 
            // lbLicenseFees
            // 
            this.lbLicenseFees.Location = new System.Drawing.Point(152, 149);
            this.lbLicenseFees.Name = "lbLicenseFees";
            this.lbLicenseFees.Size = new System.Drawing.Size(35, 13);
            this.lbLicenseFees.TabIndex = 23;
            this.lbLicenseFees.Text = "////////";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(373, 25);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 13);
            this.label22.TabIndex = 24;
            this.label22.Text = "Renewed License ID";
            // 
            // label29
            // 
            this.label29.ImageKey = "ID.png";
            this.label29.ImageList = this.imageList1;
            this.label29.Location = new System.Drawing.Point(486, 25);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 25;
            // 
            // lbRenewedLicenseID
            // 
            this.lbRenewedLicenseID.Location = new System.Drawing.Point(527, 25);
            this.lbRenewedLicenseID.Name = "lbRenewedLicenseID";
            this.lbRenewedLicenseID.Size = new System.Drawing.Size(35, 13);
            this.lbRenewedLicenseID.TabIndex = 26;
            this.lbRenewedLicenseID.Text = "////////";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(373, 56);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Old obj ID";
            // 
            // label26
            // 
            this.label26.ImageKey = "ID.png";
            this.label26.ImageList = this.imageList1;
            this.label26.Location = new System.Drawing.Point(486, 47);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(35, 31);
            this.label26.TabIndex = 28;
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.Location = new System.Drawing.Point(527, 56);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(73, 13);
            this.lbOldLicenseID.TabIndex = 29;
            this.lbOldLicenseID.Text = "////////";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(373, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "expiration date";
            // 
            // label23
            // 
            this.label23.ImageKey = "Date.png";
            this.label23.ImageList = this.imageList1;
            this.label23.Location = new System.Drawing.Point(486, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 31);
            this.label23.TabIndex = 31;
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.Location = new System.Drawing.Point(527, 87);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(73, 13);
            this.lbExpirationDate.TabIndex = 32;
            this.lbExpirationDate.Text = "////////";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(373, 118);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "created by";
            // 
            // label20
            // 
            this.label20.ImageKey = "User.png";
            this.label20.ImageList = this.imageList1;
            this.label20.Location = new System.Drawing.Point(486, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 31);
            this.label20.TabIndex = 34;
            // 
            // lbCreatedUser
            // 
            this.lbCreatedUser.Location = new System.Drawing.Point(527, 118);
            this.lbCreatedUser.Name = "lbCreatedUser";
            this.lbCreatedUser.Size = new System.Drawing.Size(35, 13);
            this.lbCreatedUser.TabIndex = 35;
            this.lbCreatedUser.Text = "////////";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(373, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Total fees";
            // 
            // label14
            // 
            this.label14.ImageKey = "fees.png";
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(486, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 31);
            this.label14.TabIndex = 37;
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.Location = new System.Drawing.Point(527, 149);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(35, 13);
            this.lbTotalFees.TabIndex = 38;
            this.lbTotalFees.Text = "////////";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Notes";
            // 
            // label7
            // 
            this.label7.ImageKey = "Notes.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(111, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 39);
            this.label7.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbTotalFees);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbCreatedUser);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lbExpirationDate);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbOldLicenseID);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.lbRenewedLicenseID);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lbLicenseFees);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbappFees);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbIssueDate);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbappDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbRLAppID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(0, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 242);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "application new Oldlicense info";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 52);
            this.textBox1.TabIndex = 41;
            // 
            // RenewLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 704);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchForDrivingLicense1);
            this.Controls.Add(this.label1);
            this.Name = "RenewLicenseForm";
            this.Text = "RenewLicenseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private SearchForDrivingLicense searchForDrivingLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowNewLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowHistroyOfTheDriver;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRLAppID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbappDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbappFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbLicenseFees;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbRenewedLicenseID;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbCreatedUser;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}