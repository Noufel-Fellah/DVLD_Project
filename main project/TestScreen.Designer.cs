namespace DVLD
{
    partial class TestScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNumberOfRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddApointment = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTestAppointmentsTable = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTheTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbPictureofTile = new System.Windows.Forms.PictureBox();
            this.showingLDLAppInfo1 = new DVLD.ShowingLDLAppInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureofTile)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(282, 80);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(186, 16);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Vision test";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNumberOfRecords);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 601);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(769, 45);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lbNumberOfRecords
            // 
            this.lbNumberOfRecords.AutoSize = true;
            this.lbNumberOfRecords.Location = new System.Drawing.Point(93, 21);
            this.lbNumberOfRecords.Name = "lbNumberOfRecords";
            this.lbNumberOfRecords.Size = new System.Drawing.Size(17, 13);
            this.lbNumberOfRecords.TabIndex = 2;
            this.lbNumberOfRecords.Text = "//";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "# Record : ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(682, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddApointment);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 37);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnAddApointment
            // 
            this.btnAddApointment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddApointment.BackColor = System.Drawing.Color.White;
            this.btnAddApointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApointment.ImageKey = "icons8-create-order-50.png";
            this.btnAddApointment.ImageList = this.imageList1;
            this.btnAddApointment.Location = new System.Drawing.Point(714, 8);
            this.btnAddApointment.Name = "btnAddApointment";
            this.btnAddApointment.Size = new System.Drawing.Size(49, 23);
            this.btnAddApointment.TabIndex = 6;
            this.btnAddApointment.UseVisualStyleBackColor = false;
            this.btnAddApointment.Click += new System.EventHandler(this.btnAddApointment_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-create-order-50.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Appointments";
            // 
            // dgvTestAppointmentsTable
            // 
            this.dgvTestAppointmentsTable.AllowUserToAddRows = false;
            this.dgvTestAppointmentsTable.AllowUserToDeleteRows = false;
            this.dgvTestAppointmentsTable.AllowUserToOrderColumns = true;
            this.dgvTestAppointmentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTestAppointmentsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTestAppointmentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTestAppointmentsTable.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTestAppointmentsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTestAppointmentsTable.Location = new System.Drawing.Point(0, 475);
            this.dgvTestAppointmentsTable.Name = "dgvTestAppointmentsTable";
            this.dgvTestAppointmentsTable.ReadOnly = true;
            this.dgvTestAppointmentsTable.Size = new System.Drawing.Size(769, 126);
            this.dgvTestAppointmentsTable.TabIndex = 4;
            this.dgvTestAppointmentsTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTestAppointmentsTable_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTheTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTheTestToolStripMenuItem
            // 
            this.takeTheTestToolStripMenuItem.Name = "takeTheTestToolStripMenuItem";
            this.takeTheTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTheTestToolStripMenuItem.Text = "Take the test";
            this.takeTheTestToolStripMenuItem.Click += new System.EventHandler(this.takeTheTestToolStripMenuItem_Click);
            // 
            // pbPictureofTile
            // 
            this.pbPictureofTile.Image = global::DVLD.Properties.Resources.pratical_test;
            this.pbPictureofTile.Location = new System.Drawing.Point(276, 0);
            this.pbPictureofTile.Name = "pbPictureofTile";
            this.pbPictureofTile.Size = new System.Drawing.Size(206, 77);
            this.pbPictureofTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureofTile.TabIndex = 0;
            this.pbPictureofTile.TabStop = false;
            // 
            // showingLDLAppInfo1
            // 
            this.showingLDLAppInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.showingLDLAppInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.showingLDLAppInfo1.Location = new System.Drawing.Point(0, 99);
            this.showingLDLAppInfo1.Name = "showingLDLAppInfo1";
            this.showingLDLAppInfo1.Size = new System.Drawing.Size(769, 333);
            this.showingLDLAppInfo1.TabIndex = 1;
            // 
            // TestScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 646);
            this.Controls.Add(this.dgvTestAppointmentsTable);
            this.Controls.Add(this.pbPictureofTile);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.showingLDLAppInfo1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestScreen";
            this.Text = "TestScreen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointmentsTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureofTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ShowingLDLAppInfo showingLDLAppInfo1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvTestAppointmentsTable;
        private System.Windows.Forms.Button btnAddApointment;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pbPictureofTile;
        private System.Windows.Forms.Label lbNumberOfRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTheTestToolStripMenuItem;
    }
}