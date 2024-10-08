﻿
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
            this.lblPassword1 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblPassword3 = new System.Windows.Forms.Label();
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
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnPreviousPasswords.Click += new System.EventHandler(this.btnPreviousPasswords_Click);
            // 
            // lblPassword1
            // 
            this.lblPassword1.AutoSize = true;
            this.lblPassword1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPassword1.Location = new System.Drawing.Point(30, 163);
            this.lblPassword1.Name = "lblPassword1";
            this.lblPassword1.Size = new System.Drawing.Size(105, 25);
            this.lblPassword1.TabIndex = 5;
            this.lblPassword1.Text = "Password 1";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPassword2.Location = new System.Drawing.Point(30, 207);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(108, 25);
            this.lblPassword2.TabIndex = 6;
            this.lblPassword2.Text = "Password 2";
            // 
            // lblPassword3
            // 
            this.lblPassword3.AutoSize = true;
            this.lblPassword3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPassword3.Location = new System.Drawing.Point(28, 248);
            this.lblPassword3.Name = "lblPassword3";
            this.lblPassword3.Size = new System.Drawing.Size(108, 25);
            this.lblPassword3.TabIndex = 7;
            this.lblPassword3.Text = "Password 3";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPassword3);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.lblPassword1);
            this.Controls.Add(this.btnPreviousPasswords);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblPasswordGen);
            this.Name = "WelcomePage";
            this.Text = "Welcome Page";
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordGen;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreviousPasswords;
        private System.Windows.Forms.Label lblPassword1;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblPassword3;
    }
}

