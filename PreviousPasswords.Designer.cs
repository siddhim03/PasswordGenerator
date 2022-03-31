
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
            this.dgvPass = new System.Windows.Forms.DataGridView();
            this.dgvOldPass = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldPass)).BeginInit();
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
            this.btnExitPrevPwrd.Location = new System.Drawing.Point(302, 390);
            this.btnExitPrevPwrd.Name = "btnExitPrevPwrd";
            this.btnExitPrevPwrd.Size = new System.Drawing.Size(197, 47);
            this.btnExitPrevPwrd.TabIndex = 4;
            this.btnExitPrevPwrd.Text = "Exit";
            this.btnExitPrevPwrd.UseVisualStyleBackColor = false;
            this.btnExitPrevPwrd.Click += new System.EventHandler(this.btnExitPrevPwrd_Click);
            // 
            // lblYourPreviousPasswords
            // 
            this.lblYourPreviousPasswords.AutoSize = true;
            this.lblYourPreviousPasswords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourPreviousPasswords.Location = new System.Drawing.Point(29, 53);
            this.lblYourPreviousPasswords.Name = "lblYourPreviousPasswords";
            this.lblYourPreviousPasswords.Size = new System.Drawing.Size(235, 25);
            this.lblYourPreviousPasswords.TabIndex = 5;
            this.lblYourPreviousPasswords.Text = "Your Previous Passwords:-";
            // 
            // dgvPass
            // 
            this.dgvPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPass.Location = new System.Drawing.Point(65, 142);
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.Size = new System.Drawing.Size(316, 218);
            this.dgvPass.TabIndex = 11;
            // 
            // dgvOldPass
            // 
            this.dgvOldPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOldPass.Location = new System.Drawing.Point(441, 142);
            this.dgvOldPass.Name = "dgvOldPass";
            this.dgvOldPass.Size = new System.Drawing.Size(295, 218);
            this.dgvOldPass.TabIndex = 12;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnImport.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(441, 94);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(295, 42);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(65, 91);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(316, 42);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // PreviousPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.dgvOldPass);
            this.Controls.Add(this.dgvPass);
            this.Controls.Add(this.lblYourPreviousPasswords);
            this.Controls.Add(this.btnExitPrevPwrd);
            this.Controls.Add(this.lblPreviousPasswords);
            this.Name = "PreviousPasswords";
            this.Text = "Previous Passwords";
            this.Load += new System.EventHandler(this.PreviousPasswords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOldPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviousPasswords;
        private System.Windows.Forms.Button btnExitPrevPwrd;
        private System.Windows.Forms.Label lblYourPreviousPasswords;
        private System.Windows.Forms.DataGridView dgvPass;
        private System.Windows.Forms.DataGridView dgvOldPass;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
    }
}