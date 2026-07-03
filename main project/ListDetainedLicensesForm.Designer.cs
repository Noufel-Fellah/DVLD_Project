namespace DVLD
{
    partial class ListDetainedLicensesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDetainedLicensesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.cbIsReleasedChoices = new System.Windows.Forms.ComboBox();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.cbFilteredList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvDetainedLicensesTable = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonsLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonsLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonsLicenseHostoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetaineLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of detained license";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRelease);
            this.groupBox2.Controls.Add(this.btnDetain);
            this.groupBox2.Controls.Add(this.cbIsReleasedChoices);
            this.groupBox2.Controls.Add(this.tbSearchBar);
            this.groupBox2.Controls.Add(this.cbFilteredList);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 37);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(747, 10);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 23);
            this.btnRelease.TabIndex = 5;
            this.btnRelease.Text = "Released";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(847, 10);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(75, 23);
            this.btnDetain.TabIndex = 4;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // cbIsReleasedChoices
            // 
            this.cbIsReleasedChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsReleasedChoices.FormattingEnabled = true;
            this.cbIsReleasedChoices.Items.AddRange(new object[] {
            "All ",
            "Released",
            "Not released"});
            this.cbIsReleasedChoices.Location = new System.Drawing.Point(295, 11);
            this.cbIsReleasedChoices.Name = "cbIsReleasedChoices";
            this.cbIsReleasedChoices.Size = new System.Drawing.Size(150, 21);
            this.cbIsReleasedChoices.TabIndex = 3;
            this.cbIsReleasedChoices.Visible = false;
            // 
            // tbSearchBar
            // 
            this.tbSearchBar.Location = new System.Drawing.Point(295, 12);
            this.tbSearchBar.Name = "tbSearchBar";
            this.tbSearchBar.Size = new System.Drawing.Size(165, 20);
            this.tbSearchBar.TabIndex = 2;
            this.tbSearchBar.Visible = false;
            this.tbSearchBar.TextChanged += new System.EventHandler(this.tbSearchBar_TextChanged);
            // 
            // cbFilteredList
            // 
            this.cbFilteredList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilteredList.FormattingEnabled = true;
            this.cbFilteredList.Items.AddRange(new object[] {
            "None",
            "Detain License ID",
            "Is Released",
            "National number",
            "Full Name",
            "Released application ID"});
            this.cbFilteredList.Location = new System.Drawing.Point(97, 11);
            this.cbFilteredList.Name = "cbFilteredList";
            this.cbFilteredList.Size = new System.Drawing.Size(170, 21);
            this.cbFilteredList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Filter by: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRecords);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 43);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Location = new System.Drawing.Point(92, 21);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(22, 13);
            this.lbRecords.TabIndex = 2;
            this.lbRecords.Text = "///";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "#Records  ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(847, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvDetainedLicensesTable
            // 
            this.dgvDetainedLicensesTable.AllowUserToAddRows = false;
            this.dgvDetainedLicensesTable.AllowUserToDeleteRows = false;
            this.dgvDetainedLicensesTable.AllowUserToOrderColumns = true;
            this.dgvDetainedLicensesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetainedLicensesTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetainedLicensesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicensesTable.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDetainedLicensesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetainedLicensesTable.Location = new System.Drawing.Point(0, 202);
            this.dgvDetainedLicensesTable.Name = "dgvDetainedLicensesTable";
            this.dgvDetainedLicensesTable.ReadOnly = true;
            this.dgvDetainedLicensesTable.Size = new System.Drawing.Size(934, 270);
            this.dgvDetainedLicensesTable.TabIndex = 3;
            this.dgvDetainedLicensesTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetainedLicensesTable_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonsLicenseToolStripMenuItem,
            this.showPersonsLicenseToolStripMenuItem1,
            this.showPersonsLicenseHostoryToolStripMenuItem,
            this.releaseDetaineLicenseToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 114);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonsLicenseToolStripMenuItem
            // 
            this.showPersonsLicenseToolStripMenuItem.Name = "showPersonsLicenseToolStripMenuItem";
            this.showPersonsLicenseToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.showPersonsLicenseToolStripMenuItem.Text = "Show person\'s details";
            this.showPersonsLicenseToolStripMenuItem.Click += new System.EventHandler(this.showPersonsLicenseToolStripMenuItem_Click);
            // 
            // showPersonsLicenseToolStripMenuItem1
            // 
            this.showPersonsLicenseToolStripMenuItem1.Name = "showPersonsLicenseToolStripMenuItem1";
            this.showPersonsLicenseToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.showPersonsLicenseToolStripMenuItem1.Text = "Show person\'s license";
            this.showPersonsLicenseToolStripMenuItem1.Click += new System.EventHandler(this.showPersonsLicenseToolStripMenuItem1_Click);
            // 
            // showPersonsLicenseHostoryToolStripMenuItem
            // 
            this.showPersonsLicenseHostoryToolStripMenuItem.Name = "showPersonsLicenseHostoryToolStripMenuItem";
            this.showPersonsLicenseHostoryToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.showPersonsLicenseHostoryToolStripMenuItem.Text = "Show person\'s license hostory";
            this.showPersonsLicenseHostoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonsLicenseHostoryToolStripMenuItem_Click);
            // 
            // releaseDetaineLicenseToolStripMenuItem
            // 
            this.releaseDetaineLicenseToolStripMenuItem.Enabled = false;
            this.releaseDetaineLicenseToolStripMenuItem.Name = "releaseDetaineLicenseToolStripMenuItem";
            this.releaseDetaineLicenseToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.releaseDetaineLicenseToolStripMenuItem.Text = "Release Detaine License";
            this.releaseDetaineLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetaineLicenseToolStripMenuItem_Click);
            // 
            // ListDetainedLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 515);
            this.Controls.Add(this.dgvDetainedLicensesTable);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListDetainedLicensesForm";
            this.Text = "ListDetainedLicensesForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicensesTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIsReleasedChoices;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.ComboBox cbFilteredList;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvDetainedLicensesTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonsLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonsLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPersonsLicenseHostoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetaineLicenseToolStripMenuItem;
    }
}