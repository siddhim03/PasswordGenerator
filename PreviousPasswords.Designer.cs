
namespace PasswordGenerator
{
    partial class PreviousPasswords
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
            this.lblPreviousPasswords = new System.Windows.Forms.Label();
            this.btnExitPrevPwrd = new System.Windows.Forms.Button();
            this.lblYourPreviousPasswords = new System.Windows.Forms.Label();
            this.lblPPassword3 = new System.Windows.Forms.Label();
            this.lblPPassword2 = new System.Windows.Forms.Label();
            this.lblPPassword1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreviousPasswords
            // 
            this.lblPreviousPasswords.AutoSize = true;
            this.lblPreviousPasswords.Font = new System.Drawing.Font("Vivaldi", 30F);
            this.lblPreviousPasswords.Location = new System.Drawing.Point(248, 20);
            this.lblPreviousPasswords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreviousPasswords.Name = "lblPreviousPasswords";
            this.lblPreviousPasswords.Size = new System.Drawing.Size(283, 47);
            this.lblPreviousPasswords.TabIndex = 1;
            this.lblPreviousPasswords.Text = "Previous Passwords";
            // 
            // btnExitPrevPwrd
            // 
            this.btnExitPrevPwrd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExitPrevPwrd.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExitPrevPwrd.ForeColor = System.Drawing.Color.White;
            this.btnExitPrevPwrd.Location = new System.Drawing.Point(617, 356);
            this.btnExitPrevPwrd.Name = "btnExitPrevPwrd";
            this.btnExitPrevPwrd.Size = new System.Drawing.Size(145, 65);
            this.btnExitPrevPwrd.TabIndex = 4;
            this.btnExitPrevPwrd.Text = "Exit";
            this.btnExitPrevPwrd.UseVisualStyleBackColor = false;
            this.btnExitPrevPwrd.Click += new System.EventHandler(this.btnExitPrevPwrd_Click);
            // 
            // lblYourPreviousPasswords
            // 
            this.lblYourPreviousPasswords.AutoSize = true;
            this.lblYourPreviousPasswords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPreviousPasswords.Location = new System.Drawing.Point(29, 93);
            this.lblYourPreviousPasswords.Name = "lblYourPreviousPasswords";
            this.lblYourPreviousPasswords.Size = new System.Drawing.Size(235, 25);
            this.lblYourPreviousPasswords.TabIndex = 5;
            this.lblYourPreviousPasswords.Text = "Your Previous Passwords:-";
            // 
            // lblPPassword3
            // 
            this.lblPPassword3.AutoSize = true;
            this.lblPPassword3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPPassword3.Location = new System.Drawing.Point(27, 226);
            this.lblPPassword3.Name = "lblPPassword3";
            this.lblPPassword3.Size = new System.Drawing.Size(108, 25);
            this.lblPPassword3.TabIndex = 10;
            this.lblPPassword3.Text = "Password 3";
            // 
            // lblPPassword2
            // 
            this.lblPPassword2.AutoSize = true;
            this.lblPPassword2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPPassword2.Location = new System.Drawing.Point(29, 185);
            this.lblPPassword2.Name = "lblPPassword2";
            this.lblPPassword2.Size = new System.Drawing.Size(108, 25);
            this.lblPPassword2.TabIndex = 9;
            this.lblPPassword2.Text = "Password 2";
            // 
            // lblPPassword1
            // 
            this.lblPPassword1.AutoSize = true;
            this.lblPPassword1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F);
            this.lblPPassword1.Location = new System.Drawing.Point(29, 141);
            this.lblPPassword1.Name = "lblPPassword1";
            this.lblPPassword1.Size = new System.Drawing.Size(105, 25);
            this.lblPPassword1.TabIndex = 8;
            this.lblPPassword1.Text = "Password 1";
            // 
            // PreviousPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPPassword3);
            this.Controls.Add(this.lblPPassword2);
            this.Controls.Add(this.lblPPassword1);
            this.Controls.Add(this.lblYourPreviousPasswords);
            this.Controls.Add(this.btnExitPrevPwrd);
            this.Controls.Add(this.lblPreviousPasswords);
            this.Name = "PreviousPasswords";
            this.Text = "Previous Passwords";
            this.Load += new System.EventHandler(this.PreviousPasswords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviousPasswords;
        private System.Windows.Forms.Button btnExitPrevPwrd;
        private System.Windows.Forms.Label lblYourPreviousPasswords;
        private System.Windows.Forms.Label lblPPassword3;
        private System.Windows.Forms.Label lblPPassword2;
        private System.Windows.Forms.Label lblPPassword1;
    }
}