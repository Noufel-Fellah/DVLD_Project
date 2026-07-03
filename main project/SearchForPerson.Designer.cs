namespace DVLD
{
    partial class SearchForPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForPerson));
            this.gbSearchGroup = new System.Windows.Forms.GroupBox();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSearchAboutPerson = new System.Windows.Forms.Button();
            this.tbSearchBar = new System.Windows.Forms.TextBox();
            this.cbSearchBarChoices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showDetails1 = new DVLD.ShowDetails();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnNext = new System.Windows.Forms.Button();
            this.gbSearchGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchGroup
            // 
            this.gbSearchGroup.Controls.Add(this.btnRemovePerson);
            this.gbSearchGroup.Controls.Add(this.btnAddUser);
            this.gbSearchGroup.Controls.Add(this.btnSearchAboutPerson);
            this.gbSearchGroup.Controls.Add(this.tbSearchBar);
            this.gbSearchGroup.Controls.Add(this.cbSearchBarChoices);
            this.gbSearchGroup.Controls.Add(this.label1);
            this.gbSearchGroup.Location = new System.Drawing.Point(0, 3);
            this.gbSearchGroup.Name = "gbSearchGroup";
            this.gbSearchGroup.Size = new System.Drawing.Size(850, 53);
            this.gbSearchGroup.TabIndex = 5;
            this.gbSearchGroup.TabStop = false;
            this.gbSearchGroup.Text = "search bar";
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePerson.ImageIndex = 0;
            this.btnRemovePerson.ImageList = this.imageList1;
            this.btnRemovePerson.Location = new System.Drawing.Point(550, 16);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(30, 23);
            this.btnRemovePerson.TabIndex = 5;
            this.btnRemovePerson.UseVisualStyleBackColor = true;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePerson_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.ImageIndex = 2;
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
            // showDetails1
            // 
            this.showDetails1.Location = new System.Drawing.Point(0, 62);
            this.showDetails1.Name = "showDetails1";
            this.showDetails1.Size = new System.Drawing.Size(850, 397);
            this.showDetails1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "remove.png");
            this.imageList1.Images.SetKeyName(1, "search.png");
            this.imageList1.Images.SetKeyName(2, "add person.png");
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(766, 462);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(84, 38);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // SearchAboutPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.gbSearchGroup);
            this.Controls.Add(this.showDetails1);
            this.Name = "SearchAboutPerson";
            this.Size = new System.Drawing.Size(853, 503);
            this.gbSearchGroup.ResumeLayout(false);
            this.gbSearchGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchGroup;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchAboutPerson;
        private System.Windows.Forms.TextBox tbSearchBar;
        private System.Windows.Forms.ComboBox cbSearchBarChoices;
        private System.Windows.Forms.Label label1;
        private ShowDetails showDetails1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnNext;
    }
}
