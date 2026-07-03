namespace DVLD
{
    partial class ReleasingDetainedLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReleasingDetainedLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.searchForDrivingLicense1 = new DVLD.SearchForDrivingLicense();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.llShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.llShowReleasedLicense = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCreator = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.lbFineFees = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbTotalFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.llbDetainedDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDetainedLicenseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(731, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Release detained license";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchForDrivingLicense1
            // 
            this.searchForDrivingLicense1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForDrivingLicense1.Location = new System.Drawing.Point(0, 24);
            this.searchForDrivingLicense1.Name = "searchForDrivingLicense1";
            this.searchForDrivingLicense1.Size = new System.Drawing.Size(731, 438);
            this.searchForDrivingLicense1.TabIndex = 1;
            this.searchForDrivingLicense1.GetLicence += new System.Action<bst.clsLicenses>(this.searchForDrivingLicense1_GetLicence);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRelease);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.llShowLicenseHistory);
            this.groupBox1.Controls.Add(this.llShowReleasedLicense);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 599);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 37);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnRelease
            // 
            this.btnRelease.Enabled = false;
            this.btnRelease.Location = new System.Drawing.Point(563, 9);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(73, 26);
            this.btnRelease.TabIndex = 3;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(652, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 26);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // llShowLicenseHistory
            // 
            this.llShowLicenseHistory.AutoSize = true;
            this.llShowLicenseHistory.Enabled = false;
            this.llShowLicenseHistory.Location = new System.Drawing.Point(149, 16);
            this.llShowLicenseHistory.Name = "llShowLicenseHistory";
            this.llShowLicenseHistory.Size = new System.Drawing.Size(103, 13);
            this.llShowLicenseHistory.TabIndex = 1;
            this.llShowLicenseHistory.TabStop = true;
            this.llShowLicenseHistory.Text = "Show license history";
            this.llShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistory_LinkClicked);
            // 
            // llShowReleasedLicense
            // 
            this.llShowReleasedLicense.AutoSize = true;
            this.llShowReleasedLicense.Enabled = false;
            this.llShowReleasedLicense.Location = new System.Drawing.Point(23, 16);
            this.llShowReleasedLicense.Name = "llShowReleasedLicense";
            this.llShowReleasedLicense.Size = new System.Drawing.Size(122, 13);
            this.llShowReleasedLicense.TabIndex = 0;
            this.llShowReleasedLicense.TabStop = true;
            this.llShowReleasedLicense.Text = "Show Released License";
            this.llShowReleasedLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowReleasedLicense_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCreator);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbFineFees);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbApplicationID);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbLicenseID);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lbTotalFees);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbAppFees);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.llbDetainedDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbDetainedLicenseID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 462);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 137);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain info";
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.Location = new System.Drawing.Point(542, 118);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(47, 13);
            this.lbCreator.TabIndex = 23;
            this.lbCreator.Text = "////////";
            // 
            // label7
            // 
            this.label7.ImageKey = "Name.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(488, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 35);
            this.label7.TabIndex = 22;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Driving class.png");
            this.imageList1.Images.SetKeyName(1, "Name.png");
            this.imageList1.Images.SetKeyName(2, "ID.png");
            this.imageList1.Images.SetKeyName(3, "fees.png");
            this.imageList1.Images.SetKeyName(4, "Date.png");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(383, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Created by";
            // 
            // lbFineFees
            // 
            this.lbFineFees.AutoSize = true;
            this.lbFineFees.Location = new System.Drawing.Point(542, 92);
            this.lbFineFees.Name = "lbFineFees";
            this.lbFineFees.Size = new System.Drawing.Size(37, 13);
            this.lbFineFees.TabIndex = 20;
            this.lbFineFees.Text = "//////";
            // 
            // label14
            // 
            this.label14.ImageKey = "fees.png";
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(488, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 35);
            this.label14.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(383, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Fine fees";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.AutoSize = true;
            this.lbApplicationID.Location = new System.Drawing.Point(542, 62);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(32, 13);
            this.lbApplicationID.TabIndex = 17;
            this.lbApplicationID.Text = "/////";
            // 
            // label17
            // 
            this.label17.ImageKey = "ID.png";
            this.label17.ImageList = this.imageList1;
            this.label17.Location = new System.Drawing.Point(488, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 19);
            this.label17.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(383, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Application ID";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Location = new System.Drawing.Point(542, 27);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(37, 13);
            this.lbLicenseID.TabIndex = 14;
            this.lbLicenseID.Text = "//////";
            // 
            // label20
            // 
            this.label20.ImageKey = "ID.png";
            this.label20.ImageList = this.imageList1;
            this.label20.Location = new System.Drawing.Point(488, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 19);
            this.label20.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(383, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 12;
            this.label21.Text = "License ID";
            // 
            // lbTotalFees
            // 
            this.lbTotalFees.AutoSize = true;
            this.lbTotalFees.Location = new System.Drawing.Point(171, 118);
            this.lbTotalFees.Name = "lbTotalFees";
            this.lbTotalFees.Size = new System.Drawing.Size(47, 13);
            this.lbTotalFees.TabIndex = 11;
            this.lbTotalFees.Text = "////////";
            // 
            // label11
            // 
            this.label11.ImageKey = "fees.png";
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(117, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 35);
            this.label11.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Total fees";
            // 
            // lbAppFees
            // 
            this.lbAppFees.AutoSize = true;
            this.lbAppFees.Location = new System.Drawing.Point(171, 92);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(37, 13);
            this.lbAppFees.TabIndex = 8;
            this.lbAppFees.Text = "//////";
            // 
            // label8
            // 
            this.label8.ImageKey = "fees.png";
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(117, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 35);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Application fees";
            // 
            // llbDetainedDate
            // 
            this.llbDetainedDate.AutoSize = true;
            this.llbDetainedDate.Location = new System.Drawing.Point(171, 62);
            this.llbDetainedDate.Name = "llbDetainedDate";
            this.llbDetainedDate.Size = new System.Drawing.Size(32, 13);
            this.llbDetainedDate.TabIndex = 5;
            this.llbDetainedDate.Text = "/////";
            // 
            // label5
            // 
            this.label5.ImageKey = "Date.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(117, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 35);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Detained date";
            // 
            // lbDetainedLicenseID
            // 
            this.lbDetainedLicenseID.AutoSize = true;
            this.lbDetainedLicenseID.Location = new System.Drawing.Point(171, 27);
            this.lbDetainedLicenseID.Name = "lbDetainedLicenseID";
            this.lbDetainedLicenseID.Size = new System.Drawing.Size(37, 13);
            this.lbDetainedLicenseID.TabIndex = 2;
            this.lbDetainedLicenseID.Text = "//////";
            // 
            // label3
            // 
            this.label3.ImageKey = "ID.png";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(117, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detained license ID";
            // 
            // ReleasingDetainedLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchForDrivingLicense1);
            this.Controls.Add(this.label1);
            this.Name = "ReleasingDetainedLicense";
            this.Text = "ReleasingDetainedLicense";
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
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowLicenseHistory;
        private System.Windows.Forms.LinkLabel llShowReleasedLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDetainedLicenseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbTotalFees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label llbDetainedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbFineFees;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}