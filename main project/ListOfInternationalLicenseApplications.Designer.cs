namespace DVLD
{
    partial class ListOfInternationalDrivingLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfInternationalDrivingLicenses));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInternationalLicensesTable = new System.Windows.Forms.DataGridView();
            this.btnAddNewInternationalLicense = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistroryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFiltedList = new System.Windows.Forms.ComboBox();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.cbChoicesOFIsActiveColumn = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRecords);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Location = new System.Drawing.Point(81, 22);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(19, 13);
            this.lbRecords.TabIndex = 2;
            this.lbRecords.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Records #";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(256, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "International  driving licenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInternationalLicensesTable
            // 
            this.dgvInternationalLicensesTable.AllowUserToAddRows = false;
            this.dgvInternationalLicensesTable.AllowUserToDeleteRows = false;
            this.dgvInternationalLicensesTable.AllowUserToOrderColumns = true;
            this.dgvInternationalLicensesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalLicensesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternationalLicensesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalLicensesTable.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInternationalLicensesTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInternationalLicensesTable.Location = new System.Drawing.Point(0, 200);
            this.dgvInternationalLicensesTable.Name = "dgvInternationalLicensesTable";
            this.dgvInternationalLicensesTable.ReadOnly = true;
            this.dgvInternationalLicensesTable.Size = new System.Drawing.Size(800, 204);
            this.dgvInternationalLicensesTable.TabIndex = 2;
            this.dgvInternationalLicensesTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInternationalLicensesTable_CellMouseDown);
            // 
            // btnAddNewInternationalLicense
            // 
            this.btnAddNewInternationalLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewInternationalLicense.ImageKey = "Driving class.png";
            this.btnAddNewInternationalLicense.ImageList = this.imageList1;
            this.btnAddNewInternationalLicense.Location = new System.Drawing.Point(713, 147);
            this.btnAddNewInternationalLicense.Name = "btnAddNewInternationalLicense";
            this.btnAddNewInternationalLicense.Size = new System.Drawing.Size(75, 47);
            this.btnAddNewInternationalLicense.TabIndex = 3;
            this.btnAddNewInternationalLicense.UseVisualStyleBackColor = true;
            this.btnAddNewInternationalLicense.Click += new System.EventHandler(this.btnAddNewInternationalLicense_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Driving class.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonsDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistroryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 70);
            // 
            // showPersonsDetailsToolStripMenuItem
            // 
            this.showPersonsDetailsToolStripMenuItem.Name = "showPersonsDetailsToolStripMenuItem";
            this.showPersonsDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showPersonsDetailsToolStripMenuItem.Text = "Show Person\'s details";
            this.showPersonsDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonsDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistroryToolStripMenuItem
            // 
            this.showPersonLicenseHistroryToolStripMenuItem.Name = "showPersonLicenseHistroryToolStripMenuItem";
            this.showPersonLicenseHistroryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.showPersonLicenseHistroryToolStripMenuItem.Text = "Show person obj histrory";
            this.showPersonLicenseHistroryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistroryToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter by:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFiltedList
            // 
            this.cbFiltedList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltedList.FormattingEnabled = true;
            this.cbFiltedList.Items.AddRange(new object[] {
            "none",
            "InternationalLicenseID",
            "LocalLicenseID",
            "ApplicationID",
            "IsActive",
            "CreatedByUserID   "});
            this.cbFiltedList.Location = new System.Drawing.Point(140, 160);
            this.cbFiltedList.Name = "cbFiltedList";
            this.cbFiltedList.Size = new System.Drawing.Size(143, 21);
            this.cbFiltedList.TabIndex = 6;
            this.cbFiltedList.SelectedIndexChanged += new System.EventHandler(this.cbFiltedList_SelectedIndexChanged);
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(306, 160);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(144, 20);
            this.tbSearchBar.TabIndex = 7;
            this.tbSearchBar.Visible = false;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // cbChoicesOFIsActiveColumn
            // 
            this.cbChoicesOFIsActiveColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoicesOFIsActiveColumn.FormattingEnabled = true;
            this.cbChoicesOFIsActiveColumn.Items.AddRange(new object[] {
            "All",
            "active",
            "inactive"});
            this.cbChoicesOFIsActiveColumn.Location = new System.Drawing.Point(306, 161);
            this.cbChoicesOFIsActiveColumn.Name = "cbChoicesOFIsActiveColumn";
            this.cbChoicesOFIsActiveColumn.Size = new System.Drawing.Size(121, 21);
            this.cbChoicesOFIsActiveColumn.TabIndex = 8;
            this.cbChoicesOFIsActiveColumn.Visible = false;
            this.cbChoicesOFIsActiveColumn.SelectedIndexChanged += new System.EventHandler(this.cbChoicesOFIsActiveColumn_SelectedIndexChanged);
            // 
            // ListOfInternationalDrivingLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbChoicesOFIsActiveColumn);
            this.Controls.Add(this.tbSearchBar);
            this.Controls.Add(this.cbFiltedList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddNewInternationalLicense);
            this.Controls.Add(this.dgvInternationalLicensesTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListOfInternationalDrivingLicenses";
            this.Text = "ListOfInternationalDrivingLicenses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalLicensesTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesTable;
        private System.Windows.Forms.Button btnAddNewInternationalLicense;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistroryToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFiltedList;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.ComboBox cbChoicesOFIsActiveColumn;
    }
}