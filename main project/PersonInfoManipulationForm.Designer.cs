namespace DVLD
{
    partial class PersonInfoManipulationForm
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
            this.fillForm1 = new DVLD.fillForm();
            this.SuspendLayout();
            // 
            // fillForm1
            // 
            this.fillForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillForm1.Location = new System.Drawing.Point(0, 0);
            this.fillForm1.Name = "fillForm1";
            this.fillForm1.Size = new System.Drawing.Size(800, 525);
            this.fillForm1.TabIndex = 0;
            this.fillForm1.close_Form += new System.Action<object, System.EventArgs>(this.fillForm1_close_Form);
            // 
            // PersonInfoManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.fillForm1);
            this.Name = "PersonInfoManipulationForm";
            this.Text = "PersonInfoManipulationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private fillForm fillForm1;
    }
}