namespace DVLD
{
    partial class IssueingForLostOrDamagedLicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueingForLostOrDamagedLicenseForm));
            this.lbTilte = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.llShowNewLicense = new System.Windows.Forms.LinkLabel();
            this.llShowLicenseHistrory = new System.Windows.Forms.LinkLabel();
            this.btnIssueLicense = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDamagedLicense = new System.Windows.Forms.RadioButton();
            this.rbLostLicense = new System.Windows.Forms.RadioButton();
            this.lbCreatedByUSER = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lbOldLicenseID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbReplacedLicenseID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbApplicationFees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbApplicationDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchForDrivingLicense1 = new DVLD.SearchForDrivingLicense();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTilte
            // 
            this.lbTilte.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTilte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTilte.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTilte.Location = new System.Drawing.Point(0, 0);
            this.lbTilte.Name = "lbTilte";
            this.lbTilte.Size = new System.Drawing.Size(711, 23);
            this.lbTilte.TabIndex = 0;
            this.lbTilte.Text = "Replacement For damaged license";
            this.lbTilte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.llShowNewLicense);
            this.groupBox1.Controls.Add(this.llShowLicenseHistrory);
            this.groupBox1.Controls.Add(this.btnIssueLicense);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 559);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // llShowNewLicense
            // 
            this.llShowNewLicense.AutoSize = true;
            this.llShowNewLicense.Enabled = false;
            this.llShowNewLicense.Location = new System.Drawing.Point(159, 17);
            this.llShowNewLicense.Name = "llShowNewLicense";
            this.llShowNewLicense.Size = new System.Drawing.Size(93, 13);
            this.llShowNewLicense.TabIndex = 3;
            this.llShowNewLicense.TabStop = true;
            this.llShowNewLicense.Text = "Show new license";
            this.llShowNewLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowNewLicense_LinkClicked);
            // 
            // llShowLicenseHistrory
            // 
            this.llShowLicenseHistrory.AutoSize = true;
            this.llShowLicenseHistrory.Enabled = false;
            this.llShowLicenseHistrory.Location = new System.Drawing.Point(21, 17);
            this.llShowLicenseHistrory.Name = "llShowLicenseHistrory";
            this.llShowLicenseHistrory.Size = new System.Drawing.Size(106, 13);
            this.llShowLicenseHistrory.TabIndex = 2;
            this.llShowLicenseHistrory.TabStop = true;
            this.llShowLicenseHistrory.Text = "Show license histrory";
            this.llShowLicenseHistrory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowLicenseHistrory_LinkClicked);
            // 
            // btnIssueLicense
            // 
            this.btnIssueLicense.Enabled = false;
            this.btnIssueLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueLicense.Location = new System.Drawing.Point(430, 12);
            this.btnIssueLicense.Name = "btnIssueLicense";
            this.btnIssueLicense.Size = new System.Drawing.Size(185, 23);
            this.btnIssueLicense.TabIndex = 1;
            this.btnIssueLicense.Text = "Replacement For DamagedLicense";
            this.btnIssueLicense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssueLicense.UseVisualStyleBackColor = true;
            this.btnIssueLicense.Click += new System.EventHandler(this.btnIssueLicense_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(630, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lbCreatedByUSER);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbOldLicenseID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lbReplacedLicenseID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lbApplicationFees);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbApplicationDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbApplicationID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 459);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 104);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "application info for replacement license";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDamagedLicense);
            this.groupBox3.Controls.Add(this.rbLostLicense);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(511, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 85);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacement for";
            // 
            // rbDamagedLicense
            // 
            this.rbDamagedLicense.AutoSize = true;
            this.rbDamagedLicense.Checked = true;
            this.rbDamagedLicense.Location = new System.Drawing.Point(19, 56);
            this.rbDamagedLicense.Name = "rbDamagedLicense";
            this.rbDamagedLicense.Size = new System.Drawing.Size(107, 17);
            this.rbDamagedLicense.TabIndex = 1;
            this.rbDamagedLicense.TabStop = true;
            this.rbDamagedLicense.Text = "Damaged license";
            this.rbDamagedLicense.UseVisualStyleBackColor = true;
            this.rbDamagedLicense.CheckedChanged += new System.EventHandler(this.rbDamagedLicense_CheckedChanged);
            // 
            // rbLostLicense
            // 
            this.rbLostLicense.AutoSize = true;
            this.rbLostLicense.Location = new System.Drawing.Point(19, 23);
            this.rbLostLicense.Name = "rbLostLicense";
            this.rbLostLicense.Size = new System.Drawing.Size(81, 17);
            this.rbLostLicense.TabIndex = 0;
            this.rbLostLicense.Text = "Lost license";
            this.rbLostLicense.UseVisualStyleBackColor = true;
            // 
            // lbCreatedByUSER
            // 
            this.lbCreatedByUSER.Location = new System.Drawing.Point(398, 81);
            this.lbCreatedByUSER.Name = "lbCreatedByUSER";
            this.lbCreatedByUSER.Size = new System.Drawing.Size(107, 13);
            this.lbCreatedByUSER.TabIndex = 17;
            this.lbCreatedByUSER.Text = "/////";
            // 
            // label6
            // 
            this.label6.ImageKey = "user.png";
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(357, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 31);
            this.label6.TabIndex = 16;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Driving class.png");
            this.imageList1.Images.SetKeyName(1, "ID.png");
            this.imageList1.Images.SetKeyName(2, "Date (2).png");
            this.imageList1.Images.SetKeyName(3, "fees.png");
            this.imageList1.Images.SetKeyName(4, "user.png");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Created By";
            // 
            // lbOldLicenseID
            // 
            this.lbOldLicenseID.Location = new System.Drawing.Point(398, 50);
            this.lbOldLicenseID.Name = "lbOldLicenseID";
            this.lbOldLicenseID.Size = new System.Drawing.Size(69, 13);
            this.lbOldLicenseID.TabIndex = 14;
            this.lbOldLicenseID.Text = "/////";
            // 
            // label11
            // 
            this.label11.ImageKey = "ID.png";
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(357, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(245, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Old License ID";
            // 
            // lbReplacedLicenseID
            // 
            this.lbReplacedLicenseID.Location = new System.Drawing.Point(398, 25);
            this.lbReplacedLicenseID.Name = "lbReplacedLicenseID";
            this.lbReplacedLicenseID.Size = new System.Drawing.Size(69, 13);
            this.lbReplacedLicenseID.TabIndex = 11;
            this.lbReplacedLicenseID.Text = "/////";
            // 
            // label14
            // 
            this.label14.ImageKey = "ID.png";
            this.label14.ImageList = this.imageList1;
            this.label14.Location = new System.Drawing.Point(357, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(245, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Replaced License ID";
            // 
            // lbApplicationFees
            // 
            this.lbApplicationFees.Location = new System.Drawing.Point(146, 81);
            this.lbApplicationFees.Name = "lbApplicationFees";
            this.lbApplicationFees.Size = new System.Drawing.Size(69, 13);
            this.lbApplicationFees.TabIndex = 8;
            this.lbApplicationFees.Text = "/////";
            // 
            // label7
            // 
            this.label7.ImageKey = "fees.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(105, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 31);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Application fees";
            // 
            // lbApplicationDate
            // 
            this.lbApplicationDate.Location = new System.Drawing.Point(146, 50);
            this.lbApplicationDate.Name = "lbApplicationDate";
            this.lbApplicationDate.Size = new System.Drawing.Size(106, 13);
            this.lbApplicationDate.TabIndex = 5;
            this.lbApplicationDate.Text = "/////";
            // 
            // label4
            // 
            this.label4.ImageKey = "Date (2).png";
            this.label4.ImageList = this.imageList1;
            this.label4.Location = new System.Drawing.Point(105, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 31);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Application date";
            // 
            // lbApplicationID
            // 
            this.lbApplicationID.Location = new System.Drawing.Point(146, 25);
            this.lbApplicationID.Name = "lbApplicationID";
            this.lbApplicationID.Size = new System.Drawing.Size(69, 13);
            this.lbApplicationID.TabIndex = 2;
            this.lbApplicationID.Text = "/////";
            // 
            // label2
            // 
            this.label2.ImageKey = "ID.png";
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(105, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.L.Application ID";
            // 
            // searchForDrivingLicense1
            // 
            this.searchForDrivingLicense1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchForDrivingLicense1.Location = new System.Drawing.Point(0, 23);
            this.searchForDrivingLicense1.Name = "searchForDrivingLicense1";
            this.searchForDrivingLicense1.Size = new System.Drawing.Size(711, 436);
            this.searchForDrivingLicense1.TabIndex = 1;
            this.searchForDrivingLicense1.GetLicence += new System.Action<bst.clsLicenses>(this.searchForDrivingLicense1_GetLicence);
            // 
            // IssueingForLostOrDamagedLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchForDrivingLicense1);
            this.Controls.Add(this.lbTilte);
            this.Name = "IssueingForLostOrDamagedLicenseForm";
            this.Text = "IssueingForLostOrDamagedLicenseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTilte;
        private SearchForDrivingLicense searchForDrivingLicense1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIssueLicense;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel llShowNewLicense;
        private System.Windows.Forms.LinkLabel llShowLicenseHistrory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbApplicationFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbApplicationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbApplicationID;
        private System.Windows.Forms.Label lbCreatedByUSER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbOldLicenseID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbReplacedLicenseID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbDamagedLicense;
        private System.Windows.Forms.RadioButton rbLostLicense;
    }
}