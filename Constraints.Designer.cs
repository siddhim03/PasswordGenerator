
namespace PasswordGenerator
{
    partial class Constraints
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPasswordConstraints = new System.Windows.Forms.Label();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.rdoSymbolsYes = new System.Windows.Forms.RadioButton();
            this.rdoSymbolsNo = new System.Windows.Forms.RadioButton();
            this.rdoNumbersNo = new System.Windows.Forms.RadioButton();
            this.rdoNumbersYes = new System.Windows.Forms.RadioButton();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblSymbolsEg = new System.Windows.Forms.Label();
            this.lblNumbersEg = new System.Windows.Forms.Label();
            this.rdoMaxCharLengthNo = new System.Windows.Forms.RadioButton();
            this.rdoMaxCharLengthYes = new System.Windows.Forms.RadioButton();
            this.lblMaxCharLength = new System.Windows.Forms.Label();
            this.txtMaxCharLength = new System.Windows.Forms.TextBox();
            this.rdoWordsNo = new System.Windows.Forms.RadioButton();
            this.rdoWordsYes = new System.Windows.Forms.RadioButton();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblWordsHowMany = new System.Windows.Forms.Label();
            this.txtWordsHowMany = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAnswerQuestions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPasswordConstraints
            // 
            this.lblPasswordConstraints.AutoSize = true;
            this.lblPasswordConstraints.Font = new System.Drawing.Font("Vivaldi", 30F);
            this.lblPasswordConstraints.Location = new System.Drawing.Point(248, 9);
            this.lblPasswordConstraints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordConstraints.Name = "lblPasswordConstraints";
            this.lblPasswordConstraints.Size = new System.Drawing.Size(300, 47);
            this.lblPasswordConstraints.TabIndex = 0;
            this.lblPasswordConstraints.Text = "Password Constraints";
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbols.Location = new System.Drawing.Point(12, 67);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(92, 25);
            this.lblSymbols.TabIndex = 1;
            this.lblSymbols.Text = "Symbols?";
            // 
            // rdoSymbolsYes
            // 
            this.rdoSymbolsYes.AutoSize = true;
            this.rdoSymbolsYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSymbolsYes.Location = new System.Drawing.Point(267, 63);
            this.rdoSymbolsYes.Name = "rdoSymbolsYes";
            this.rdoSymbolsYes.Size = new System.Drawing.Size(58, 29);
            this.rdoSymbolsYes.TabIndex = 2;
            this.rdoSymbolsYes.TabStop = true;
            this.rdoSymbolsYes.Text = "Yes";
            this.rdoSymbolsYes.UseVisualStyleBackColor = true;
            // 
            // rdoSymbolsNo
            // 
            this.rdoSymbolsNo.AutoSize = true;
            this.rdoSymbolsNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSymbolsNo.Location = new System.Drawing.Point(354, 63);
            this.rdoSymbolsNo.Name = "rdoSymbolsNo";
            this.rdoSymbolsNo.Size = new System.Drawing.Size(56, 29);
            this.rdoSymbolsNo.TabIndex = 3;
            this.rdoSymbolsNo.TabStop = true;
            this.rdoSymbolsNo.Text = "No";
            this.rdoSymbolsNo.UseVisualStyleBackColor = true;
            // 
            // rdoNumbersNo
            // 
            this.rdoNumbersNo.AutoSize = true;
            this.rdoNumbersNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNumbersNo.Location = new System.Drawing.Point(354, 112);
            this.rdoNumbersNo.Name = "rdoNumbersNo";
            this.rdoNumbersNo.Size = new System.Drawing.Size(56, 29);
            this.rdoNumbersNo.TabIndex = 6;
            this.rdoNumbersNo.TabStop = true;
            this.rdoNumbersNo.Text = "No";
            this.rdoNumbersNo.UseVisualStyleBackColor = true;
            // 
            // rdoNumbersYes
            // 
            this.rdoNumbersYes.AutoSize = true;
            this.rdoNumbersYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNumbersYes.Location = new System.Drawing.Point(267, 112);
            this.rdoNumbersYes.Name = "rdoNumbersYes";
            this.rdoNumbersYes.Size = new System.Drawing.Size(58, 29);
            this.rdoNumbersYes.TabIndex = 5;
            this.rdoNumbersYes.TabStop = true;
            this.rdoNumbersYes.Text = "Yes";
            this.rdoNumbersYes.UseVisualStyleBackColor = true;
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(12, 116);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(99, 25);
            this.lblNumbers.TabIndex = 4;
            this.lblNumbers.Text = "Numbers?";
            // 
            // lblSymbolsEg
            // 
            this.lblSymbolsEg.AutoSize = true;
            this.lblSymbolsEg.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbolsEg.Location = new System.Drawing.Point(455, 68);
            this.lblSymbolsEg.Name = "lblSymbolsEg";
            this.lblSymbolsEg.Size = new System.Drawing.Size(131, 21);
            this.lblSymbolsEg.TabIndex = 7;
            this.lblSymbolsEg.Text = "(Eg: @, $, %, #, *)";
            // 
            // lblNumbersEg
            // 
            this.lblNumbersEg.AutoSize = true;
            this.lblNumbersEg.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersEg.Location = new System.Drawing.Point(455, 117);
            this.lblNumbersEg.Name = "lblNumbersEg";
            this.lblNumbersEg.Size = new System.Drawing.Size(126, 21);
            this.lblNumbersEg.TabIndex = 8;
            this.lblNumbersEg.Text = "(Eg: 1, 10, 9, 2, 5)";
            // 
            // rdoMaxCharLengthNo
            // 
            this.rdoMaxCharLengthNo.AutoSize = true;
            this.rdoMaxCharLengthNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaxCharLengthNo.Location = new System.Drawing.Point(354, 160);
            this.rdoMaxCharLengthNo.Name = "rdoMaxCharLengthNo";
            this.rdoMaxCharLengthNo.Size = new System.Drawing.Size(56, 29);
            this.rdoMaxCharLengthNo.TabIndex = 11;
            this.rdoMaxCharLengthNo.TabStop = true;
            this.rdoMaxCharLengthNo.Text = "No";
            this.rdoMaxCharLengthNo.UseVisualStyleBackColor = true;
            // 
            // rdoMaxCharLengthYes
            // 
            this.rdoMaxCharLengthYes.AutoSize = true;
            this.rdoMaxCharLengthYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaxCharLengthYes.Location = new System.Drawing.Point(267, 160);
            this.rdoMaxCharLengthYes.Name = "rdoMaxCharLengthYes";
            this.rdoMaxCharLengthYes.Size = new System.Drawing.Size(58, 29);
            this.rdoMaxCharLengthYes.TabIndex = 10;
            this.rdoMaxCharLengthYes.TabStop = true;
            this.rdoMaxCharLengthYes.Text = "Yes";
            this.rdoMaxCharLengthYes.UseVisualStyleBackColor = true;
            // 
            // lblMaxCharLength
            // 
            this.lblMaxCharLength.AutoSize = true;
            this.lblMaxCharLength.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharLength.Location = new System.Drawing.Point(12, 164);
            this.lblMaxCharLength.Name = "lblMaxCharLength";
            this.lblMaxCharLength.Size = new System.Drawing.Size(210, 25);
            this.lblMaxCharLength.TabIndex = 9;
            this.lblMaxCharLength.Text = "Max Character Length?";
            // 
            // txtMaxCharLength
            // 
            this.txtMaxCharLength.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMaxCharLength.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxCharLength.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMaxCharLength.Location = new System.Drawing.Point(458, 160);
            this.txtMaxCharLength.Name = "txtMaxCharLength";
            this.txtMaxCharLength.Size = new System.Drawing.Size(198, 29);
            this.txtMaxCharLength.TabIndex = 12;
            this.txtMaxCharLength.Text = "Enter max length here";
            // 
            // rdoWordsNo
            // 
            this.rdoWordsNo.AutoSize = true;
            this.rdoWordsNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWordsNo.Location = new System.Drawing.Point(354, 205);
            this.rdoWordsNo.Name = "rdoWordsNo";
            this.rdoWordsNo.Size = new System.Drawing.Size(56, 29);
            this.rdoWordsNo.TabIndex = 15;
            this.rdoWordsNo.TabStop = true;
            this.rdoWordsNo.Text = "No";
            this.rdoWordsNo.UseVisualStyleBackColor = true;
            // 
            // rdoWordsYes
            // 
            this.rdoWordsYes.AutoSize = true;
            this.rdoWordsYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWordsYes.Location = new System.Drawing.Point(267, 205);
            this.rdoWordsYes.Name = "rdoWordsYes";
            this.rdoWordsYes.Size = new System.Drawing.Size(58, 29);
            this.rdoWordsYes.TabIndex = 14;
            this.rdoWordsYes.TabStop = true;
            this.rdoWordsYes.Text = "Yes";
            this.rdoWordsYes.UseVisualStyleBackColor = true;
            // 
            // lblWords
            // 
            this.lblWords.AutoSize = true;
            this.lblWords.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWords.Location = new System.Drawing.Point(12, 209);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(74, 25);
            this.lblWords.TabIndex = 13;
            this.lblWords.Text = "Words?";
            // 
            // lblWordsHowMany
            // 
            this.lblWordsHowMany.AutoSize = true;
            this.lblWordsHowMany.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsHowMany.Location = new System.Drawing.Point(454, 210);
            this.lblWordsHowMany.Name = "lblWordsHowMany";
            this.lblWordsHowMany.Size = new System.Drawing.Size(94, 21);
            this.lblWordsHowMany.TabIndex = 16;
            this.lblWordsHowMany.Text = "How many?";
            // 
            // txtWordsHowMany
            // 
            this.txtWordsHowMany.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtWordsHowMany.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsHowMany.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtWordsHowMany.Location = new System.Drawing.Point(566, 207);
            this.txtWordsHowMany.Name = "txtWordsHowMany";
            this.txtWordsHowMany.Size = new System.Drawing.Size(166, 29);
            this.txtWordsHowMany.TabIndex = 17;
            this.txtWordsHowMany.Text = "Enter amount here";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(354, 393);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 45);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvQuestions
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestion,
            this.colAnswer});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvQuestions.Location = new System.Drawing.Point(17, 285);
            this.dgvQuestions.Name = "dgvQuestions";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvQuestions.Size = new System.Drawing.Size(760, 91);
            this.dgvQuestions.TabIndex = 19;
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
            // lblAnswerQuestions
            // 
            this.lblAnswerQuestions.AutoSize = true;
            this.lblAnswerQuestions.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerQuestions.Location = new System.Drawing.Point(15, 257);
            this.lblAnswerQuestions.Name = "lblAnswerQuestions";
            this.lblAnswerQuestions.Size = new System.Drawing.Size(310, 25);
            this.lblAnswerQuestions.TabIndex = 20;
            this.lblAnswerQuestions.Text = "Answer the questions in the table:-";
            // 
            // Constraints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswerQuestions);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWordsHowMany);
            this.Controls.Add(this.lblWordsHowMany);
            this.Controls.Add(this.rdoWordsNo);
            this.Controls.Add(this.rdoWordsYes);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.txtMaxCharLength);
            this.Controls.Add(this.rdoMaxCharLengthNo);
            this.Controls.Add(this.rdoMaxCharLengthYes);
            this.Controls.Add(this.lblMaxCharLength);
            this.Controls.Add(this.lblNumbersEg);
            this.Controls.Add(this.lblSymbolsEg);
            this.Controls.Add(this.rdoNumbersNo);
            this.Controls.Add(this.rdoNumbersYes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.rdoSymbolsNo);
            this.Controls.Add(this.rdoSymbolsYes);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.lblPasswordConstraints);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Constraints";
            this.Text = "Constraints";
            this.Load += new System.EventHandler(this.Constraints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordConstraints;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.RadioButton rdoSymbolsYes;
        private System.Windows.Forms.RadioButton rdoSymbolsNo;
        private System.Windows.Forms.RadioButton rdoNumbersNo;
        private System.Windows.Forms.RadioButton rdoNumbersYes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblSymbolsEg;
        private System.Windows.Forms.Label lblNumbersEg;
        private System.Windows.Forms.RadioButton rdoMaxCharLengthNo;
        private System.Windows.Forms.RadioButton rdoMaxCharLengthYes;
        private System.Windows.Forms.Label lblMaxCharLength;
        private System.Windows.Forms.TextBox txtMaxCharLength;
        private System.Windows.Forms.RadioButton rdoWordsNo;
        private System.Windows.Forms.RadioButton rdoWordsYes;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblWordsHowMany;
        private System.Windows.Forms.TextBox txtWordsHowMany;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswer;
        private System.Windows.Forms.Label lblAnswerQuestions;
    }
}