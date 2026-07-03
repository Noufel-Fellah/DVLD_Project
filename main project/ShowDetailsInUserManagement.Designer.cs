namespace DVLD
{
    partial class ShowDetailsInUserManagement
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
            this.showUserInformation1 = new DVLD.showUserInformation();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showUserInformation1
            // 
            this.showUserInformation1.Location = new System.Drawing.Point(2, 0);
            this.showUserInformation1.Name = "showUserInformation1";
            this.showUserInformation1.Size = new System.Drawing.Size(884, 496);
            this.showUserInformation1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(768, 487);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowDetailsInUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 522);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.showUserInformation1);
            this.Name = "ShowDetailsInUserManagement";
            this.Text = "ShowDetailsInUserManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private showUserInformation showUserInformation1;
        private System.Windows.Forms.Button btnClose;
    }
}