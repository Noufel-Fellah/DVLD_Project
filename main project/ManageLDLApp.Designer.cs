namespace DVLD
{
    partial class ManageLDLApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLDLApp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNumOfRecords = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLDLapp = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTesttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoryTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praticalTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonsDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltrationList = new System.Windows.Forms.ComboBox();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cbStatusAndDrivingClassItems = new System.Windows.Forms.ComboBox();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLapp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNumOfRecords);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 490);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbNumOfRecords
            // 
            this.lbNumOfRecords.AutoSize = true;
            this.lbNumOfRecords.Location = new System.Drawing.Point(96, 31);
            this.lbNumOfRecords.Name = "lbNumOfRecords";
            this.lbNumOfRecords.Size = new System.Drawing.Size(13, 13);
            this.lbNumOfRecords.TabIndex = 2;
            this.lbNumOfRecords.Text = "0";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Records #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(761, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Local driving obj applications";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLDLapp
            // 
            this.dgvLDLapp.AllowUserToAddRows = false;
            this.dgvLDLapp.AllowUserToDeleteRows = false;
            this.dgvLDLapp.AllowUserToOrderColumns = true;
            this.dgvLDLapp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLDLapp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLDLapp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLapp.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvLDLapp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLDLapp.Location = new System.Drawing.Point(0, 227);
            this.dgvLDLapp.Name = "dgvLDLapp";
            this.dgvLDLapp.ReadOnly = true;
            this.dgvLDLapp.Size = new System.Drawing.Size(857, 263);
            this.dgvLDLapp.TabIndex = 2;
            this.dgvLDLapp.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLDLapp_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.sechduleTestsToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonsDrivingLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 202);
            this.contextMenuStrip1.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.contextMenuStrip1_Closed);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show application details";
            this.showApplicationDetailsToolStripMenuItem.Click += new System.EventHandler(this.showApplicationDetailsToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Enabled = false;
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Enabled = false;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechduleTestsToolStripMenuItem
            // 
            this.sechduleTestsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTesttToolStripMenuItem,
            this.theoryTestToolStripMenuItem,
            this.praticalTestToolStripMenuItem});
            this.sechduleTestsToolStripMenuItem.Enabled = false;
            this.sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            this.sechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.sechduleTestsToolStripMenuItem.Text = "Sechdule tests";
            // 
            // visionTesttToolStripMenuItem
            // 
            this.visionTesttToolStripMenuItem.Enabled = false;
            this.visionTesttToolStripMenuItem.Name = "visionTesttToolStripMenuItem";
            this.visionTesttToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.visionTesttToolStripMenuItem.Text = "Vision test";
            this.visionTesttToolStripMenuItem.Click += new System.EventHandler(this.visionTesttToolStripMenuItem_Click);
            // 
            // theoryTestToolStripMenuItem
            // 
            this.theoryTestToolStripMenuItem.Enabled = false;
            this.theoryTestToolStripMenuItem.Name = "theoryTestToolStripMenuItem";
            this.theoryTestToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.theoryTestToolStripMenuItem.Text = "Theory test";
            this.theoryTestToolStripMenuItem.Click += new System.EventHandler(this.theoryTestToolStripMenuItem_Click);
            // 
            // praticalTestToolStripMenuItem
            // 
            this.praticalTestToolStripMenuItem.Enabled = false;
            this.praticalTestToolStripMenuItem.Name = "praticalTestToolStripMenuItem";
            this.praticalTestToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.praticalTestToolStripMenuItem.Text = "Pratical test";
            this.praticalTestToolStripMenuItem.Click += new System.EventHandler(this.praticalTestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving obj (First time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Enabled = false;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showLicenseToolStripMenuItem.Text = "Show obj";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonsDrivingLicenseToolStripMenuItem
            // 
            this.showPersonsDrivingLicenseToolStripMenuItem.Enabled = false;
            this.showPersonsDrivingLicenseToolStripMenuItem.Name = "showPersonsDrivingLicenseToolStripMenuItem";
            this.showPersonsDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showPersonsDrivingLicenseToolStripMenuItem.Text = "Show Person\'s driving obj history";
            this.showPersonsDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.showPersonsDrivingLicenseToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter by:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFiltrationList
            // 
            this.cbFiltrationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltrationList.FormattingEnabled = true;
            this.cbFiltrationList.Items.AddRange(new object[] {
            "none",
            "LDLApp",
            "NationalNo",
            "DrivingClass",
            "FullName",
            "_applicationDate",
            "ApplicationStatus",
            "passedTests"});
            this.cbFiltrationList.Location = new System.Drawing.Point(99, 195);
            this.cbFiltrationList.Name = "cbFiltrationList";
            this.cbFiltrationList.Size = new System.Drawing.Size(146, 21);
            this.cbFiltrationList.TabIndex = 4;
            this.cbFiltrationList.SelectedIndexChanged += new System.EventHandler(this.cbFiltrationList_SelectedIndexChanged);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(284, 195);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(146, 20);
            this.tbSearchBar.TabIndex = 5;
            this.tbSearchBar.Visible = false;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add an application.png");
            // 
            // cbStatusAndDrivingClassItems
            // 
            this.cbStatusAndDrivingClassItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusAndDrivingClassItems.FormattingEnabled = true;
            this.cbStatusAndDrivingClassItems.Items.AddRange(new object[] {
            "none",
            "LDLApp",
            "NationalNo",
            "DrivingClass",
            "FullName",
            "_applicationDate",
            "ApplicationStatus",
            "passedTests"});
            this.cbStatusAndDrivingClassItems.Location = new System.Drawing.Point(284, 196);
            this.cbStatusAndDrivingClassItems.Name = "cbStatusAndDrivingClassItems";
            this.cbStatusAndDrivingClassItems.Size = new System.Drawing.Size(146, 21);
            this.cbStatusAndDrivingClassItems.TabIndex = 7;
            this.cbStatusAndDrivingClassItems.Visible = false;
            this.cbStatusAndDrivingClassItems.SelectedIndexChanged += new System.EventHandler(this.cbStatusAndDrivingClassItems_SelectedIndexChanged);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.ImageIndex = 0;
            this.btnAddApplication.ImageList = this.imageList1;
            this.btnAddApplication.Location = new System.Drawing.Point(761, 186);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(84, 38);
            this.btnAddApplication.TabIndex = 6;
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ManageLDLApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 555);
            this.Controls.Add(this.cbStatusAndDrivingClassItems);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.cbFiltrationList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvLDLapp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageLDLApp";
            this.Text = "ManageLDLApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLapp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNumOfRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLDLapp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltrationList;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cbStatusAndDrivingClassItems;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonsDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTesttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoryTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praticalTestToolStripMenuItem;
    }
}