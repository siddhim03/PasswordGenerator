
namespace PasswordGenerator
{
    partial class WordQuestionsAnswers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWordQuestion = new System.Windows.Forms.Label();
            this.lblAnswerQuestionsQA = new System.Windows.Forms.Label();
            this.dgvQuestionsQA = new System.Windows.Forms.DataGridView();
            this.colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmitQA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsQA)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWordQuestion
            // 
            this.lblWordQuestion.AutoSize = true;
            this.lblWordQuestion.Font = new System.Drawing.Font("Vivaldi", 30F);
            this.lblWordQuestion.Location = new System.Drawing.Point(236, 9);
            this.lblWordQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWordQuestion.Name = "lblWordQuestion";
            this.lblWordQuestion.Size = new System.Drawing.Size(324, 47);
            this.lblWordQuestion.TabIndex = 1;
            this.lblWordQuestion.Text = "Questions and Answers";
            // 
            // lblAnswerQuestionsQA
            // 
            this.lblAnswerQuestionsQA.AutoSize = true;
            this.lblAnswerQuestionsQA.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerQuestionsQA.Location = new System.Drawing.Point(41, 86);
            this.lblAnswerQuestionsQA.Name = "lblAnswerQuestionsQA";
            this.lblAnswerQuestionsQA.Size = new System.Drawing.Size(310, 25);
            this.lblAnswerQuestionsQA.TabIndex = 21;
            this.lblAnswerQuestionsQA.Text = "Answer the questions in the table:-";
            // 
            // dgvQuestionsQA
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestionsQA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestionsQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionsQA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestion,
            this.colAnswer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestionsQA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestionsQA.Location = new System.Drawing.Point(12, 126);
            this.dgvQuestionsQA.Name = "dgvQuestionsQA";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestionsQA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuestionsQA.Size = new System.Drawing.Size(776, 235);
            this.dgvQuestionsQA.TabIndex = 22;
            // 
            // colQuestion
            // 
            this.colQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestion.HeaderText = "Question";
            this.colQuestion.Name = "colQuestion";
            // 
            // colAnswer
            // 
            this.colAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAnswer.HeaderText = "Answer";
            this.colAnswer.Name = "colAnswer";
            // 
            // btnSubmitQA
            // 
            this.btnSubmitQA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmitQA.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitQA.ForeColor = System.Drawing.Color.White;
            this.btnSubmitQA.Location = new System.Drawing.Point(345, 393);
            this.btnSubmitQA.Name = "btnSubmitQA";
            this.btnSubmitQA.Size = new System.Drawing.Size(112, 45);
            this.btnSubmitQA.TabIndex = 23;
            this.btnSubmitQA.Text = "Submit";
            this.btnSubmitQA.UseVisualStyleBackColor = false;
            // 
            // WordQuestionsAnswers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitQA);
            this.Controls.Add(this.dgvQuestionsQA);
            this.Controls.Add(this.lblAnswerQuestionsQA);
            this.Controls.Add(this.lblWordQuestion);
            this.Name = "WordQuestionsAnswers";
            this.Text = "WordQuestionsAnswers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsQA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWordQuestion;
        private System.Windows.Forms.Label lblAnswerQuestionsQA;
        private System.Windows.Forms.DataGridView dgvQuestionsQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswer;
        private System.Windows.Forms.Button btnSubmitQA;
    }
}