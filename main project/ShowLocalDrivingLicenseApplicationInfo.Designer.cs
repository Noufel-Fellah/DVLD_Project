namespace DVLD
{
    partial class ShowLocalDrivingLicenseApplicationInfo
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
            this.showingLDLAppInfo1 = new DVLD.ShowingLDLAppInfo();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showingLDLAppInfo1
            // 
            this.showingLDLAppInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.showingLDLAppInfo1.Location = new System.Drawing.Point(0, 0);
            this.showingLDLAppInfo1.Name = "showingLDLAppInfo1";
            this.showingLDLAppInfo1.Size = new System.Drawing.Size(768, 365);
            this.showingLDLAppInfo1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(681, 373);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowLocalDrivingLicenseApplicationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 408);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.showingLDLAppInfo1);
            this.Name = "ShowLocalDrivingLicenseApplicationInfo";
            this.Text = "Show Local Driving License Application Info";
            this.ResumeLayout(false);

        }

        #endregion

        private ShowingLDLAppInfo showingLDLAppInfo1;
        private System.Windows.Forms.Button btnClose;
    }
}