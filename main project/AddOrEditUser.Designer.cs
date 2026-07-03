namespace DVLD
{
    partial class AddOrEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditUser));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbSearchGroup = new System.Windows.Forms.GroupBox();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSearchAboutPerson = new System.Windows.Forms.Button();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.cbSearchBarChoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.showDetails1 = new DVLD.ShowDetails();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.btnpervious = new System.Windows.Forms.Button();
            this.mtbConfirmedPassword = new System.Windows.Forms.MaskedTextBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnColse = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbSearchGroup.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbSearchGroup);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.showDetails1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(978, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PersonalInfo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbSearchGroup
            // 
            this.gbSearchGroup.Controls.Add(this.btnRemovePerson);
            this.gbSearchGroup.Controls.Add(this.btnAddUser);
            this.gbSearchGroup.Controls.Add(this.btnSearchAboutPerson);
            this.gbSearchGroup.Controls.Add(this.tbSearchBar);
            this.gbSearchGroup.Controls.Add(this.cbSearchBarChoices);
            this.gbSearchGroup.Controls.Add(this.label1);
            this.gbSearchGroup.Location = new System.Drawing.Point(4, 6);
            this.gbSearchGroup.Name = "gbSearchGroup";
            this.gbSearchGroup.Size = new System.Drawing.Size(975, 53);
            this.gbSearchGroup.TabIndex = 3;
            this.gbSearchGroup.TabStop = false;
            this.gbSearchGroup.Text = "search bar";
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePerson.ImageIndex = 5;
            this.btnRemovePerson.ImageList = this.imageList1;
            this.btnRemovePerson.Location = new System.Drawing.Point(550, 16);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(30, 23);
            this.btnRemovePerson.TabIndex = 5;
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "add person.png");
            this.imageList1.Images.SetKeyName(2, "PersonID.png");
            this.imageList1.Images.SetKeyName(3, "name.png");
            this.imageList1.Images.SetKeyName(4, "password.png");
            this.imageList1.Images.SetKeyName(5, "remove.png");
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ImageIndex = 1;
            this.btnAddUser.ImageList = this.imageList1;
            this.btnAddUser.Location = new System.Drawing.Point(502, 16);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(30, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSearchAboutPerson
            // 
            this.btnSearchAboutPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAboutPerson.ImageKey = "search.png";
            this.btnSearchAboutPerson.ImageList = this.imageList1;
            this.btnSearchAboutPerson.Location = new System.Drawing.Point(452, 16);
            this.btnSearchAboutPerson.Name = "btnSearchAboutPerson";
            this.btnSearchAboutPerson.Size = new System.Drawing.Size(30, 23);
            this.btnSearchAboutPerson.TabIndex = 3;
            this.btnSearchAboutPerson.UseVisualStyleBackColor = true;
            this.btnSearchAboutPerson.Click += new System.EventHandler(this.btnSearchAboutPerson_Click);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(306, 16);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(126, 20);
            this.tbSearchBar.TabIndex = 2;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // cbSearchBarChoices
            // 
            this.cbSearchBarChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBarChoices.FormattingEnabled = true;
            this.cbSearchBarChoices.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbSearchBarChoices.Location = new System.Drawing.Point(153, 16);
            this.cbSearchBarChoices.Name = "cbSearchBarChoices";
            this.cbSearchBarChoices.Size = new System.Drawing.Size(133, 21);
            this.cbSearchBarChoices.TabIndex = 1;
            this.cbSearchBarChoices.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(886, 468);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 38);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // showDetails1
            // 
            this.showDetails1.Location = new System.Drawing.Point(3, 65);
            this.showDetails1.Name = "showDetails1";
            this.showDetails1.Size = new System.Drawing.Size(976, 397);
            this.showDetails1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbIsActive);
            this.tabPage2.Controls.Add(this.btnpervious);
            this.tabPage2.Controls.Add(this.mtbConfirmedPassword);
            this.tabPage2.Controls.Add(this.lbUserID);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.mtbPassword);
            this.tabPage2.Controls.Add(this.tbUserName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(978, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LoginInfo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(183, 263);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(64, 17);
            this.cbIsActive.TabIndex = 12;
            this.cbIsActive.Text = "IsActive";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnpervious
            // 
            this.btnpervious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpervious.Location = new System.Drawing.Point(886, 465);
            this.btnpervious.Name = "btnpervious";
            this.btnpervious.Size = new System.Drawing.Size(84, 38);
            this.btnpervious.TabIndex = 2;
            this.btnpervious.Text = "previous";
            this.btnpervious.UseVisualStyleBackColor = true;
            this.btnpervious.Click += new System.EventHandler(this.btnpervious_Click);
            // 
            // mtbConfirmedPassword
            // 
            this.mtbConfirmedPassword.Enabled = false;
            this.mtbConfirmedPassword.Location = new System.Drawing.Point(183, 215);
            this.mtbConfirmedPassword.Name = "mtbConfirmedPassword";
            this.mtbConfirmedPassword.Size = new System.Drawing.Size(171, 20);
            this.mtbConfirmedPassword.TabIndex = 11;
            this.mtbConfirmedPassword.Validating += new System.ComponentModel.CancelEventHandler(this.mtbConfirmedPassword_Validating);
            // 
            // lbUserID
            // 
            this.lbUserID.Location = new System.Drawing.Point(189, 84);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(71, 14);
            this.lbUserID.TabIndex = 10;
            this.lbUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.ImageKey = "name.png";
            this.label9.ImageList = this.imageList1;
            this.label9.Location = new System.Drawing.Point(147, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 30);
            this.label9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.ImageKey = "password.png";
            this.label8.ImageList = this.imageList1;
            this.label8.Location = new System.Drawing.Point(147, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 30);
            this.label8.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.ImageKey = "password.png";
            this.label7.ImageList = this.imageList1;
            this.label7.Location = new System.Drawing.Point(147, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 30);
            this.label7.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.ImageKey = "PersonID.png";
            this.label6.ImageList = this.imageList1;
            this.label6.Location = new System.Drawing.Point(147, 76);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(30, 30);
            this.label6.TabIndex = 6;
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(183, 175);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(171, 20);
            this.mtbPassword.TabIndex = 5;
            this.mtbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPassword_Validating);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(183, 126);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(171, 20);
            this.tbUserName.TabIndex = 4;
            this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.tbUserName_Validating);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(69, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "UserName";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(69, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirmed password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(84, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 53);
            this.panel1.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbTitle.Location = new System.Drawing.Point(405, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(199, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add  new user";
            // 
            // btnColse
            // 
            this.btnColse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColse.Location = new System.Drawing.Point(899, 10);
            this.btnColse.Name = "btnColse";
            this.btnColse.Size = new System.Drawing.Size(84, 38);
            this.btnColse.TabIndex = 0;
            this.btnColse.Text = "Close";
            this.btnColse.UseVisualStyleBackColor = true;
            this.btnColse.Click += new System.EventHandler(this.btnColse_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(778, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnColse);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 60);
            this.panel2.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 644);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddOrEditUser";
            this.Text = "AddNewUser";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbSearchGroup.ResumeLayout(false);
            this.gbSearchGroup.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
        private ShowDetails showDetails1;
        private System.Windows.Forms.Button btnColse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox gbSearchGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.ComboBox cbSearchBarChoices;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchAboutPerson;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.MaskedTextBox mtbConfirmedPassword;
        private System.Windows.Forms.Button btnpervious;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbIsActive;
    }
}