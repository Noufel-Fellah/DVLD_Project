namespace DVLD
{
    partial class NewLocalDrivingLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLocalDrivingLicense));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchAboutPerson1 = new DVLD.SearchForPerson();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmLicenseClass = new System.Windows.Forms.ComboBox();
            this.lbDLAppID = new System.Windows.Forms.Label();
            this.lbAppDate = new System.Windows.Forms.Label();
            this.lbAppFees = new System.Windows.Forms.Label();
            this.lbUserCreator = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnterInforamtionAgain = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New local driving obj application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnterInforamtionAgain);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 48);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(722, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(632, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(869, 537);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchAboutPerson1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(861, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PersonalInfo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchAboutPerson1
            // 
            this.searchAboutPerson1.Location = new System.Drawing.Point(9, 3);
            this.searchAboutPerson1.Name = "searchAboutPerson1";
            this.searchAboutPerson1.Size = new System.Drawing.Size(853, 503);
            this.searchAboutPerson1.TabIndex = 0;
            this.searchAboutPerson1.NextOption += new System.Action<bussinessLayer.clsPerson>(this.searchAboutPerson1_NextOption);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmLicenseClass);
            this.tabPage2.Controls.Add(this.lbDLAppID);
            this.tabPage2.Controls.Add(this.lbAppDate);
            this.tabPage2.Controls.Add(this.lbAppFees);
            this.tabPage2.Controls.Add(this.lbUserCreator);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(861, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "applicationInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmLicenseClass
            // 
            this.cmLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmLicenseClass.FormattingEnabled = true;
            this.cmLicenseClass.Location = new System.Drawing.Point(300, 233);
            this.cmLicenseClass.Name = "cmLicenseClass";
            this.cmLicenseClass.Size = new System.Drawing.Size(177, 21);
            this.cmLicenseClass.TabIndex = 14;
            // 
            // lbDLAppID
            // 
            this.lbDLAppID.Location = new System.Drawing.Point(297, 103);
            this.lbDLAppID.Name = "lbDLAppID";
            this.lbDLAppID.Size = new System.Drawing.Size(100, 23);
            this.lbDLAppID.TabIndex = 13;
            this.lbDLAppID.Text = "//";
            this.lbDLAppID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAppDate
            // 
            this.lbAppDate.Location = new System.Drawing.Point(297, 161);
            this.lbAppDate.Name = "lbAppDate";
            this.lbAppDate.Size = new System.Drawing.Size(100, 23);
            this.lbAppDate.TabIndex = 12;
            this.lbAppDate.Text = "//";
            this.lbAppDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAppFees
            // 
            this.lbAppFees.Location = new System.Drawing.Point(297, 303);
            this.lbAppFees.Name = "lbAppFees";
            this.lbAppFees.Size = new System.Drawing.Size(100, 23);
            this.lbAppFees.TabIndex = 11;
            this.lbAppFees.Text = "//";
            this.lbAppFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserCreator
            // 
            this.lbUserCreator.Location = new System.Drawing.Point(297, 379);
            this.lbUserCreator.Name = "lbUserCreator";
            this.lbUserCreator.Size = new System.Drawing.Size(100, 23);
            this.lbUserCreator.TabIndex = 10;
            this.lbUserCreator.Text = "//";
            this.lbUserCreator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.ImageKey = "add person.png";
            this.label11.ImageList = this.imageList1;
            this.label11.Location = new System.Drawing.Point(231, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 30);
            this.label11.TabIndex = 9;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add person.png");
            this.imageList1.Images.SetKeyName(1, "PersonID.png");
            this.imageList1.Images.SetKeyName(2, "date of birth (2).png");
            this.imageList1.Images.SetKeyName(3, "fees.png");
            this.imageList1.Images.SetKeyName(4, "title.png");
            // 
            // label10
            // 
            this.label10.ImageKey = "title.png";
            this.label10.ImageList = this.imageList1;
            this.label10.Location = new System.Drawing.Point(231, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 30);
            this.label10.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.ImageKey = "fees.png";
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(237, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 30);
            this.label9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(111, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Create by: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(111, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "_applicationDate";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.ImageKey = "date of birth (2).png";
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(234, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 30);
            this.label6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(111, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "License class";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(111, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "ApplicationFees";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ImageKey = "PersonID.png";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(231, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 30);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(111, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "DL application ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnterInforamtionAgain
            // 
            this.btnEnterInforamtionAgain.Enabled = false;
            this.btnEnterInforamtionAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterInforamtionAgain.Location = new System.Drawing.Point(569, 19);
            this.btnEnterInforamtionAgain.Name = "btnEnterInforamtionAgain";
            this.btnEnterInforamtionAgain.Size = new System.Drawing.Size(138, 23);
            this.btnEnterInforamtionAgain.TabIndex = 2;
            this.btnEnterInforamtionAgain.Text = "Enter Inforamtion again";
            this.btnEnterInforamtionAgain.UseVisualStyleBackColor = true;
            this.btnEnterInforamtionAgain.UseWaitCursor = true;
            this.btnEnterInforamtionAgain.Visible = false;
            this.btnEnterInforamtionAgain.Click += new System.EventHandler(this.btnEnterInforamtionAgain_Click);
            // 
            // NewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "NewLocalDrivingLicense";
            this.Text = "NewLocalDrivingLicense";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private SearchForPerson searchAboutPerson1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbDLAppID;
        private System.Windows.Forms.Label lbAppDate;
        private System.Windows.Forms.Label lbAppFees;
        private System.Windows.Forms.Label lbUserCreator;
        private System.Windows.Forms.ComboBox cmLicenseClass;
        private System.Windows.Forms.Button btnEnterInforamtionAgain;
    }
}