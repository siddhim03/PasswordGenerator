
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 221);
            this.dataGridView1.TabIndex = 6;
            // 
            // PreviousPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblYourPreviousPasswords);
            this.Controls.Add(this.btnExitPrevPwrd);
            this.Controls.Add(this.lblPreviousPasswords);
            this.Name = "PreviousPasswords";
            this.Text = "Previous Passwords";
            this.Load += new System.EventHandler(this.PreviousPasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviousPasswords;
        private System.Windows.Forms.Button btnExitPrevPwrd;
        private System.Windows.Forms.Label lblYourPreviousPasswords;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}