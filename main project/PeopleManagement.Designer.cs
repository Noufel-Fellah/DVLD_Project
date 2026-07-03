namespace DVLD
{
    partial class PeopleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeopleManagement));
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecords = new System.Windows.Forms.Label();
            this.gbButtomOne = new System.Windows.Forms.GroupBox();
            this.lbNumOfRecords = new System.Windows.Forms.Label();
            this.gbUpperOne = new System.Windows.Forms.GroupBox();
            this.lbManagePeople = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbFilter = new System.Windows.Forms.Label();
            this.cbFilterByCollection = new System.Windows.Forms.ComboBox();
            this.tbFilteredValue = new System.Windows.Forms.TextBox();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.gbButtomOne.SuspendLayout();
            this.gbUpperOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(782, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.Location = new System.Drawing.Point(21, 18);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(52, 23);
            this.lbRecords.TabIndex = 1;
            this.lbRecords.Text = "#Record:";
            this.lbRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbButtomOne
            // 
            this.gbButtomOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbButtomOne.Controls.Add(this.lbNumOfRecords);
            this.gbButtomOne.Controls.Add(this.btnClose);
            this.gbButtomOne.Controls.Add(this.lbRecords);
            this.gbButtomOne.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtomOne.Location = new System.Drawing.Point(0, 503);
            this.gbButtomOne.Name = "gbButtomOne";
            this.gbButtomOne.Size = new System.Drawing.Size(887, 48);
            this.gbButtomOne.TabIndex = 2;
            this.gbButtomOne.TabStop = false;
            // 
            // lbNumOfRecords
            // 
            this.lbNumOfRecords.Location = new System.Drawing.Point(79, 18);
            this.lbNumOfRecords.Name = "lbNumOfRecords";
            this.lbNumOfRecords.Size = new System.Drawing.Size(46, 23);
            this.lbNumOfRecords.TabIndex = 2;
            this.lbNumOfRecords.Text = "0";
            this.lbNumOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbUpperOne
            // 
            this.gbUpperOne.Controls.Add(this.lbManagePeople);
            this.gbUpperOne.Controls.Add(this.pictureBox1);
            this.gbUpperOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbUpperOne.Location = new System.Drawing.Point(0, 0);
            this.gbUpperOne.Name = "gbUpperOne";
            this.gbUpperOne.Size = new System.Drawing.Size(887, 179);
            this.gbUpperOne.TabIndex = 3;
            this.gbUpperOne.TabStop = false;
            // 
            // lbManagePeople
            // 
            this.lbManagePeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbManagePeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManagePeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbManagePeople.Location = new System.Drawing.Point(370, 104);
            this.lbManagePeople.Name = "lbManagePeople";
            this.lbManagePeople.Size = new System.Drawing.Size(191, 30);
            this.lbManagePeople.TabIndex = 1;
            this.lbManagePeople.Text = "Manage people";
            this.lbManagePeople.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::DVLD.Properties.Resources.people;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(370, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.menu;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 230);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(887, 269);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDetails,
            this.addNewToolStripMenuItem,
            this.peToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(181, 158);
      //      this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // ShowDetails
            // 
            this.ShowDetails.Image = global::DVLD.Properties.Resources.account_settings;
            this.ShowDetails.Name = "ShowDetails";
            this.ShowDetails.Size = new System.Drawing.Size(180, 22);
            this.ShowDetails.Text = "Show details";
            this.ShowDetails.Click += new System.EventHandler(this.showDeToolStripMenuItem_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewToolStripMenuItem.Text = "Add new person";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // peToolStripMenuItem
            // 
            this.peToolStripMenuItem.Name = "peToolStripMenuItem";
            this.peToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peToolStripMenuItem.Text = "Edit";
            this.peToolStripMenuItem.Click += new System.EventHandler(this.peToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phoneCallToolStripMenuItem.Text = "Phone call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // lbFilter
            // 
            this.lbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilter.Location = new System.Drawing.Point(12, 193);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(81, 23);
            this.lbFilter.TabIndex = 4;
            this.lbFilter.Text = "Filter by";
            this.lbFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFilterByCollection
            // 
            this.cbFilterByCollection.AllowDrop = true;
            this.cbFilterByCollection.DisplayMember = "0";
            this.cbFilterByCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterByCollection.FormattingEnabled = true;
            this.cbFilterByCollection.Items.AddRange(new object[] {
            "none",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Gender",
            "CountryName",
            "Phone",
            "Email"});
            this.cbFilterByCollection.Location = new System.Drawing.Point(99, 194);
            this.cbFilterByCollection.Name = "cbFilterByCollection";
            this.cbFilterByCollection.Size = new System.Drawing.Size(156, 21);
            this.cbFilterByCollection.TabIndex = 5;
            this.cbFilterByCollection.ValueMember = "0";
            this.cbFilterByCollection.SelectedIndexChanged += new System.EventHandler(this.cbFilterByCollection_SelectedIndexChanged);
            // 
            // tbFilteredValue
            // 
            this.tbFilteredValue.Location = new System.Drawing.Point(261, 194);
            this.tbFilteredValue.Name = "tbFilteredValue";
            this.tbFilteredValue.Size = new System.Drawing.Size(200, 20);
            this.tbFilteredValue.TabIndex = 6;
            this.tbFilteredValue.Visible = false;
            this.tbFilteredValue.TextChanged += new System.EventHandler(this.tbFilteredValue_TextChanged);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPerson.BackgroundImage")));
            this.btnAddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPerson.Location = new System.Drawing.Point(771, 185);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(104, 39);
            this.btnAddPerson.TabIndex = 7;
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // PeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 551);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.tbFilteredValue);
            this.Controls.Add(this.cbFilterByCollection);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbUpperOne);
            this.Controls.Add(this.gbButtomOne);
            this.Name = "PeopleManagement";
            this.Text = "fr_PeopleManagement";
         //   this.Load += new System.EventHandler(this.PeopleManagement_Load);
            this.gbButtomOne.ResumeLayout(false);
            this.gbUpperOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.GroupBox gbButtomOne;
        private System.Windows.Forms.Label lbNumOfRecords;
        private System.Windows.Forms.GroupBox gbUpperOne;
        private System.Windows.Forms.Label lbManagePeople;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.ComboBox cbFilterByCollection;
        private System.Windows.Forms.TextBox tbFilteredValue;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ToolStripMenuItem ShowDetails;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menu;
    }
}