
namespace PasswordGenerator
{
    partial class WelcomePage
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
            this.lblPasswordGen = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreviousPasswords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPasswordGen
            // 
            this.lblPasswordGen.AutoSize = true;
            this.lblPasswordGen.Font = new System.Drawing.Font("Vivaldi", 45F);
            this.lblPasswordGen.Location = new System.Drawing.Point(182, 9);
            this.lblPasswordGen.Name = "lblPasswordGen";
            this.lblPasswordGen.Size = new System.Drawing.Size(445, 71);
            this.lblPasswordGen.TabIndex = 0;
            this.lblPasswordGen.Text = "Password Generator";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16F);
            this.lblNewPassword.Location = new System.Drawing.Point(29, 114);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(223, 30);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Your New Passwords:";
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.Location = new System.Drawing.Point(33, 338);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(220, 65);
            this.btnGeneratePassword.TabIndex = 2;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(595, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 65);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnPreviousPasswords
            // 
            this.btnPreviousPasswords.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPreviousPasswords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPreviousPasswords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnPreviousPasswords.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPasswords.Location = new System.Drawing.Point(474, 114);
            this.btnPreviousPasswords.Name = "btnPreviousPasswords";
            this.btnPreviousPasswords.Size = new System.Drawing.Size(266, 79);
            this.btnPreviousPasswords.TabIndex = 4;
            this.btnPreviousPasswords.Text = "Previous Passwords";
            this.btnPreviousPasswords.UseVisualStyleBackColor = false;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreviousPasswords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblPasswordGen);
            this.Name = "WelcomePage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordGen;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreviousPasswords;
    }
}

