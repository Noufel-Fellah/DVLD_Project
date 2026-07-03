namespace DVLD
{
    partial class ShowPersonsdrivinglicense_history
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbLocalDrivingLicenses = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnumberOfRecordsOfIDLTable = new System.Windows.Forms.Label();
            this.dgvLocalDrivingLicenseTable = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfRecordsOfIDLTable = new System.Windows.Forms.Label();
            this.dgvInternationalDrivingLicenses = new System.Windows.Forms.DataGridView();
            this.showDetails1 = new DVLD.ShowDetails();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lbLocalDrivingLicenses.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseTable)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Person history";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 623);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 32);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(775, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbLocalDrivingLicenses);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 184);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Driver\'s licenses";
            // 
            // lbLocalDrivingLicenses
            // 
            this.lbLocalDrivingLicenses.Controls.Add(this.tabPage1);
            this.lbLocalDrivingLicenses.Controls.Add(this.tabPage2);
            this.lbLocalDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLocalDrivingLicenses.Location = new System.Drawing.Point(3, 16);
            this.lbLocalDrivingLicenses.Name = "lbLocalDrivingLicenses";
            this.lbLocalDrivingLicenses.SelectedIndex = 0;
            this.lbLocalDrivingLicenses.Size = new System.Drawing.Size(856, 165);
            this.lbLocalDrivingLicenses.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLocalDrivingLicenseTable);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(848, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local Driving licenses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvInternationalDrivingLicenses);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(848, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International DrivingLicenses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbnumberOfRecordsOfIDLTable);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(842, 30);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Records #";
            // 
            // lbnumberOfRecordsOfIDLTable
            // 
            this.lbnumberOfRecordsOfIDLTable.AutoSize = true;
            this.lbnumberOfRecordsOfIDLTable.Location = new System.Drawing.Point(69, 14);
            this.lbnumberOfRecordsOfIDLTable.Name = "lbnumberOfRecordsOfIDLTable";
            this.lbnumberOfRecordsOfIDLTable.Size = new System.Drawing.Size(19, 13);
            this.lbnumberOfRecordsOfIDLTable.TabIndex = 1;
            this.lbnumberOfRecordsOfIDLTable.Text = "00";
//            this.lbnumberOfRecordsOfIDLTable.Click += new System.EventHandler(this.lbnumberOfRecordsOfIDLTable_Click);
            // 
            // dgvLocalDrivingLicenseTable
            // 
            this.dgvLocalDrivingLicenseTable.AllowUserToAddRows = false;
            this.dgvLocalDrivingLicenseTable.AllowUserToDeleteRows = false;
            this.dgvLocalDrivingLicenseTable.AllowUserToOrderColumns = true;
            this.dgvLocalDrivingLicenseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalDrivingLicenseTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLocalDrivingLicenseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDrivingLicenseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalDrivingLicenseTable.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalDrivingLicenseTable.Name = "dgvLocalDrivingLicenseTable";
            this.dgvLocalDrivingLicenseTable.ReadOnly = true;
            this.dgvLocalDrivingLicenseTable.Size = new System.Drawing.Size(842, 103);
            this.dgvLocalDrivingLicenseTable.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumberOfRecordsOfIDLTable);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(842, 24);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "#Records :";
            // 
            // NumberOfRecordsOfIDLTable
            // 
            this.NumberOfRecordsOfIDLTable.AutoSize = true;
            this.NumberOfRecordsOfIDLTable.Location = new System.Drawing.Point(72, 11);
            this.NumberOfRecordsOfIDLTable.Name = "NumberOfRecordsOfIDLTable";
            this.NumberOfRecordsOfIDLTable.Size = new System.Drawing.Size(19, 13);
            this.NumberOfRecordsOfIDLTable.TabIndex = 1;
            this.NumberOfRecordsOfIDLTable.Text = "00";
          //  this.NumberOfRecordsOfIDLTable.Click += new System.EventHandler(this.NumberOfRecordsOfIDLTable_Click);
            // 
            // dgvInternationalDrivingLicenses
            // 
            this.dgvInternationalDrivingLicenses.AllowUserToAddRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToDeleteRows = false;
            this.dgvInternationalDrivingLicenses.AllowUserToOrderColumns = true;
            this.dgvInternationalDrivingLicenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInternationalDrivingLicenses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInternationalDrivingLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalDrivingLicenses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvInternationalDrivingLicenses.Location = new System.Drawing.Point(3, 0);
            this.dgvInternationalDrivingLicenses.Name = "dgvInternationalDrivingLicenses";
            this.dgvInternationalDrivingLicenses.ReadOnly = true;
            this.dgvInternationalDrivingLicenses.Size = new System.Drawing.Size(842, 112);
            this.dgvInternationalDrivingLicenses.TabIndex = 1;
            // 
            // showDetails1
            // 
            this.showDetails1.Location = new System.Drawing.Point(7, 38);
            this.showDetails1.Name = "showDetails1";
            this.showDetails1.Size = new System.Drawing.Size(850, 395);
            this.showDetails1.TabIndex = 0;
            // 
            // ShowPersonsdrivinglicense_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showDetails1);
            this.Name = "ShowPersonsdrivinglicense_history";
            this.Text = "Show Person\'s driving obj history";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.lbLocalDrivingLicenses.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDrivingLicenseTable)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalDrivingLicenses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ShowDetails showDetails1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl lbLocalDrivingLicenses;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvLocalDrivingLicenseTable;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbnumberOfRecordsOfIDLTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvInternationalDrivingLicenses;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label NumberOfRecordsOfIDLTable;
        private System.Windows.Forms.Label label3;
    }
}