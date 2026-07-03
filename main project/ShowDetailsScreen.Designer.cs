namespace DVLD
{
    partial class ShowDetailsScreen
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
            this.showDetails1 = new DVLD.ShowDetails();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showDetails1
            // 
            this.showDetails1.Location = new System.Drawing.Point(12, 12);
            this.showDetails1.Name = "showDetails1";
            this.showDetails1.Size = new System.Drawing.Size(947, 450);
            this.showDetails1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(860, 483);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowDetailsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 525);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.showDetails1);
            this.Name = "ShowDetailsScreen";
            this.Text = "ShowDetailsScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private ShowDetails showDetails1;
        private System.Windows.Forms.Button btnClose;
    }
}