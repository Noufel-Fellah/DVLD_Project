namespace DVLD
{
    partial class InternationalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternationalDrivingLicenseApplication));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.llShowLicensesHistory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbCreatedByUserID = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.lbExpirationDate = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbLocalDrivingLicenseID = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LocalDrivingLicenseID = new System.Windows.Forms.Label();
            this.lbInternationalDriivngLicenseID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbFees = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbIssueDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchForDrivingLicense2 = new DVLD.SearchForDrivingLicense();
            this.searchForDrivingLicense1 = new DVLD.SearchForDrivingLicense();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "International driving obj application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llShowLicenseInfo);
            this.groupBox1.Controls.Add(this.llShowLicensesHistory);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnIssue);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 610);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llShowLicenseInfo
            // 
            this.llShowLicenseInfo.AutoSize = true;
            this.llShowLicenseInfo.Enabled = false;
            this.llShowLicenseInfo.Location = new System.Drawing.Point(172, 16);
            this.llShowLicenseInfo.Name = "llShowLicenseInfo";
            this.llShowLicenseInfo.Size = new System.Drawing.Size(72, 17);
            this.llShowLicenseInfo.TabIndex = 3;
            this.llShowLicenseInfo.TabStop = true;
            this.llShowLicenseInfo.Text = "Show obj info";
            this.llShowLicenseInfo.UseCompatibleTextRendering = true;
            this.llShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseInfo_LinkClicked);
            // 
            // llShowLicensesHistory
            // 
            this.llShowLicensesHistory.AutoSize = true;
            this.llShowLicensesHistory.Location = new System.Drawing.Point(39, 16);
            this.llShowLicensesHistory.Name = "llShowLicensesHistory";
            this.llShowLicensesHistory.Size = new System.Drawing.Size(108, 13);
            this.llShowLicensesHistory.TabIndex = 2;
            this.llShowLicensesHistory.TabStop = true;
            this.llShowLicensesHistory.Text = "Show licenses history";
            this.llShowLicensesHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicensesHistory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(568, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(647, 6);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(65, 26);
            this.btnIssue.TabIndex = 0;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbCreatedByUserID);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.lbExpirationDate);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.lbLocalDrivingLicenseID);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.LocalDrivingLicenseID);
            this.groupBox2.Controls.Add(this.lbInternationalDriivngLicenseID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbFees);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbIssueDate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbAppDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lbApplicationID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 136);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "application info";
            // 
            // lbCreatedByUserID
            // 
            this.lbCreatedByUserID.Location = new System.Drawing.Point(485, 110);
            this.lbCreatedByUserID.Name = "lbCreatedByUserID";
            this.lbCreatedByUserID.Size = new System.Drawing.Size(35, 26);
            this.lbCreatedByUserID.TabIndex = 23;
            this.lbCreatedByUserID.Text = "//////";
            // 
            // label23
            // 
            this.label23.ImageKey = "createdByUser.png";
            this.label23.ImageList = this.imageList1;
            this.label23.Location = new System.Drawing.Point(444, 110);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 26);
            this.label23.TabIndex = 22;
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Driving class.png");
            this.imageList1.Images.SetKeyName(1, "Date.png");
            this.imageList1.Images.SetKeyName(2, "ID.png");
            this.imageList1.Images.SetKeyName(3, "createdByUser.png");
            this.imageList1.Images.SetKeyName(4, "fees.png");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(351, 117);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Created by user ID";
            // 
            // lbExpirationDate
            // 
            this.lbExpirationDate.Location = new System.Drawing.Point(485, 78);
            this.lbExpirationDate.Name = "lbExpirationDate";
            this.lbExpirationDate.Size = new System.Drawing.Size(107, 26);
            this.lbExpirationDate.TabIndex = 20;
            this.lbExpirationDate.Text = "//////";
            // 
            // label20
            // 
            this.label20.ImageKey = "Date.png";
            this.label20.ImageList = this.imageList1;
            this.label20.Location = new System.Drawing.Point(444, 78);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 26);
            this.label20.TabIndex = 19;
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(351, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Expiration date";
            // 
            // lbLocalDrivingLicenseID
            // 
            this.lbLocalDrivingLicenseID.Location = new System.Drawing.Point(485, 52);
            this.lbLocalDrivingLicenseID.Name = "lbLocalDrivingLicenseID";
            this.lbLocalDrivingLicenseID.Size = new System.Drawing.Size(35, 26);
            this.lbLocalDrivingLicenseID.TabIndex = 17;
            this.lbLocalDrivingLicenseID.Text = "//////";
            // 
            // label17
            // 
            this.label17.ImageKey = "ID.png";
            this.label17.ImageList = this.imageList1;
            this.label17.Location = new System.Drawing.Point(444, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 26);
            this.label17.TabIndex = 16;
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LocalDrivingLicenseID
            // 
            this.LocalDrivingLicenseID.AutoSize = true;
            this.LocalDrivingLicenseID.Location = new System.Drawing.Point(351, 59);
            this.LocalDrivingLicenseID.Name = "LocalDrivingLicenseID";
            this.LocalDrivingLicenseID.Size = new System.Drawing.Size(75, 13);
            this.LocalDrivingLicenseID.TabIndex = 15;
            this.LocalDrivingLicenseID.Text = "Local D.obj ID";
            // 
            // lbInternationalDriivngLicenseID
            // 
            this.lbInternationalDriivngLicenseID.Location = new System.Drawing.Point(485, 16);
            this.lbInternationalDriivngLicenseID.Name = "lbInternationalDriivngLicenseID";
            this.lbInternationalDriivngLicenseID.Size = new System.Drawing.Size(35, 26);
            this.lbInternationalDriivngLicenseID.TabIndex = 14;
            this.lbInternationalDriivngLicenseID.Text = "//////";
            // 
            // label14
            // 
            this.label14.ImageKey = "ID.png";
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(444, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 26);
            this.label14.TabIndex = 13;
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(351, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "I.D obj ID";
            // 
            // lbFees
            // 
            this.lbFees.Location = new System.Drawing.Point(146, 110);
            this.lbFees.Name = "lbFees";
            this.lbFees.Size = new System.Drawing.Size(120, 26);
            this.lbFees.TabIndex = 11;
            this.lbFees.Text = "//////";
            // 
            // label11
            // 
            this.label11.ImageKey = "fees.png";
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(105, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 26);
            this.label11.TabIndex = 10;
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Fees";
            // 
            // lbIssueDate
            // 
            this.lbIssueDate.Location = new System.Drawing.Point(146, 78);
            this.lbIssueDate.Name = "lbIssueDate";
            this.lbIssueDate.Size = new System.Drawing.Size(120, 26);
            this.lbIssueDate.TabIndex = 8;
            this.lbIssueDate.Text = "//////";
            // 
            // label8
            // 
            this.label8.ImageKey = "Date.png";
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(105, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 26);
            this.label8.TabIndex = 7;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Issue date";
            // 
            // lbAppDate
            // 
            this.lbAppDate.Location = new System.Drawing.Point(146, 52);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(120, 26);
            this.lbAppDate.TabIndex = 5;
            this.lbAppDate.Text = "//////";
            // 
            // label5
            // 
            this.label5.ImageKey = "Date.png";
            this.label5.ImageList = this.imageList1;
            this.label5.Location = new System.Drawing.Point(105, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 26);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "application date";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.Location = new System.Drawing.Point(146, 16);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(35, 26);
            this.lbApplicationID.TabIndex = 2;
            this.lbApplicationID.Text = "//////";
            // 
            // label3
            // 
            this.label3.ImageKey = "ID.png";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(105, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 26);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "I.L application ID";
            // 
            // searchForDrivingLicense2
            // 
            this.searchForDrivingLicense2.Location = new System.Drawing.Point(0, 0);
            this.searchForDrivingLicense2.Name = "searchForDrivingLicense2";
            this.searchForDrivingLicense2.Size = new System.Drawing.Size(719, 436);
            this.searchForDrivingLicense2.TabIndex = 4;
            this.searchForDrivingLicense2.GetLicence += new System.Action<bst.clsLicenses>(this.searchForDrivingLicense2_GetLicence);
            // 
            // searchForDrivingLicense1
            // 
            this.searchForDrivingLicense1.Location = new System.Drawing.Point(-1, 33);
            this.searchForDrivingLicense1.Name = "searchForDrivingLicense1";
            this.searchForDrivingLicense1.Size = new System.Drawing.Size(719, 435);
            this.searchForDrivingLicense1.TabIndex = 0;
            // 
            // InternationalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 648);
            this.Controls.Add(this.searchForDrivingLicense2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchForDrivingLicense1);
            this.Name = "InternationalDrivingLicenseApplication";
            this.Text = "InternationalDrivingLicenseApplication";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SearchForDrivingLicense searchForDrivingLicense1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbCreatedByUserID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbExpirationDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbLocalDrivingLicenseID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LocalDrivingLicenseID;
        private System.Windows.Forms.Label lbInternationalDriivngLicenseID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbFees;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private SearchForDrivingLicense searchForDrivingLicense2;
        private System.Windows.Forms.LinkLabel llShowLicenseInfo;
        private System.Windows.Forms.LinkLabel llShowLicensesHistory;
    }
}