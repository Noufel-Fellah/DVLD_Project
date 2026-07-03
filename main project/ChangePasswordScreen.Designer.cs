namespace DVLD
{
    partial class ChangePasswordScreen
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
            this.mtbOldPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtbConfirmedNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtbNewPassword = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCLose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showUserInformation1 = new DVLD.showUserInformation();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtbOldPassword
            // 
            this.mtbOldPassword.Location = new System.Drawing.Point(96, 509);
            this.mtbOldPassword.Name = "mtbOldPassword";
            this.mtbOldPassword.Size = new System.Drawing.Size(100, 20);
            this.mtbOldPassword.TabIndex = 1;
            this.mtbOldPassword.TextChanged += new System.EventHandler(this.mtbOldPassword_TextChanged);
            this.mtbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.mtbOldPassword_Validating);
            // 
            // mtbConfirmedNewPassword
            // 
            this.mtbConfirmedNewPassword.Enabled = false;
            this.mtbConfirmedNewPassword.Location = new System.Drawing.Point(383, 525);
            this.mtbConfirmedNewPassword.Name = "mtbConfirmedNewPassword";
            this.mtbConfirmedNewPassword.Size = new System.Drawing.Size(100, 20);
            this.mtbConfirmedNewPassword.TabIndex = 2;
            this.mtbConfirmedNewPassword.TextChanged += new System.EventHandler(this.mtbConfirmedNewPassword_TextChanged);
            // 
            // mtbNewPassword
            // 
            this.mtbNewPassword.Location = new System.Drawing.Point(383, 487);
            this.mtbNewPassword.Name = "mtbNewPassword";
            this.mtbNewPassword.Size = new System.Drawing.Size(100, 20);
            this.mtbNewPassword.TabIndex = 3;
            this.mtbNewPassword.TextChanged += new System.EventHandler(this.mtbNewPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "The old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "The new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "confirmed the new password";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(660, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCLose
            // 
            this.btnCLose.Location = new System.Drawing.Point(759, 509);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(75, 23);
            this.btnCLose.TabIndex = 8;
            this.btnCLose.Text = "Close";
            this.btnCLose.UseVisualStyleBackColor = true;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // showUserInformation1
            // 
            this.showUserInformation1.Location = new System.Drawing.Point(2, 0);
            this.showUserInformation1.Name = "showUserInformation1";
            this.showUserInformation1.Size = new System.Drawing.Size(884, 481);
            this.showUserInformation1.TabIndex = 0;
            // 
            // ChangePasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 550);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbNewPassword);
            this.Controls.Add(this.mtbConfirmedNewPassword);
            this.Controls.Add(this.mtbOldPassword);
            this.Controls.Add(this.showUserInformation1);
            this.Name = "ChangePasswordScreen";
            this.Text = "ChangePasswordScreen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private showUserInformation showUserInformation1;
        private System.Windows.Forms.MaskedTextBox mtbOldPassword;
        private System.Windows.Forms.MaskedTextBox mtbConfirmedNewPassword;
        private System.Windows.Forms.MaskedTextBox mtbNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}