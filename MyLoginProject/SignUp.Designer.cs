namespace MyLoginProject
{
    partial class SignUp
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
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.ReEnterPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPass = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.AccNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Username.Location = new System.Drawing.Point(73, 67);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(91, 17);
            this.Username.TabIndex = 0;
            this.Username.Text = "Username :";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Password.Location = new System.Drawing.Point(73, 113);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 17);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password :";
            // 
            // ReEnterPass
            // 
            this.ReEnterPass.AutoSize = true;
            this.ReEnterPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReEnterPass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReEnterPass.Location = new System.Drawing.Point(8, 158);
            this.ReEnterPass.Name = "ReEnterPass";
            this.ReEnterPass.Size = new System.Drawing.Size(156, 17);
            this.ReEnterPass.TabIndex = 2;
            this.ReEnterPass.Text = "Re-enter Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(182, 67);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(139, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(182, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtReEnterPass
            // 
            this.txtReEnterPass.Location = new System.Drawing.Point(182, 158);
            this.txtReEnterPass.Name = "txtReEnterPass";
            this.txtReEnterPass.Size = new System.Drawing.Size(139, 22);
            this.txtReEnterPass.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(170, 262);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(75, 42);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "SignUp";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(182, 197);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(139, 22);
            this.txtAccNo.TabIndex = 9;
            // 
            // AccNo
            // 
            this.AccNo.AutoSize = true;
            this.AccNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccNo.Location = new System.Drawing.Point(23, 197);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(137, 17);
            this.AccNo.TabIndex = 8;
            this.AccNo.Text = "Account Number :";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 352);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.AccNo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtReEnterPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.ReEnterPass);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label ReEnterPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReEnterPass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Label AccNo;
    }
}