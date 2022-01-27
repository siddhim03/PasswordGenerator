
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnSubmitCon = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.panelSymbols = new System.Windows.Forms.Panel();
            this.panelMaxChar = new System.Windows.Forms.Panel();
            this.panelWords = new System.Windows.Forms.Panel();
            this.lblMaxCharEg = new System.Windows.Forms.Label();
            this.lblWordsEg = new System.Windows.Forms.Label();
            this.colAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuestionsCon = new System.Windows.Forms.DataGridView();
            this.btnQandA = new System.Windows.Forms.Button();
            this.panelNumbers.SuspendLayout();
            this.panelSymbols.SuspendLayout();
            this.panelMaxChar.SuspendLayout();
            this.panelWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsCon)).BeginInit();
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
            this.rdoSymbolsYes.Location = new System.Drawing.Point(11, 8);
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
            this.rdoSymbolsNo.Location = new System.Drawing.Point(98, 8);
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
            this.rdoNumbersNo.Location = new System.Drawing.Point(98, 5);
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
            this.rdoNumbersYes.Location = new System.Drawing.Point(11, 5);
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
            this.rdoMaxCharLengthNo.Location = new System.Drawing.Point(98, 4);
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
            this.rdoMaxCharLengthYes.Location = new System.Drawing.Point(11, 4);
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
            this.txtMaxCharLength.Location = new System.Drawing.Point(458, 170);
            this.txtMaxCharLength.Name = "txtMaxCharLength";
            this.txtMaxCharLength.Size = new System.Drawing.Size(198, 29);
            this.txtMaxCharLength.TabIndex = 12;
            // 
            // rdoWordsNo
            // 
            this.rdoWordsNo.AutoSize = true;
            this.rdoWordsNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWordsNo.Location = new System.Drawing.Point(98, 5);
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
            this.rdoWordsYes.Location = new System.Drawing.Point(11, 5);
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
            this.lblWordsHowMany.Location = new System.Drawing.Point(454, 221);
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
            this.txtWordsHowMany.Location = new System.Drawing.Point(567, 218);
            this.txtWordsHowMany.Name = "txtWordsHowMany";
            this.txtWordsHowMany.Size = new System.Drawing.Size(166, 29);
            this.txtWordsHowMany.TabIndex = 17;
            // 
            // btnSubmitCon
            // 
            this.btnSubmitCon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmitCon.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCon.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCon.Location = new System.Drawing.Point(340, 393);
            this.btnSubmitCon.Name = "btnSubmitCon";
            this.btnSubmitCon.Size = new System.Drawing.Size(112, 45);
            this.btnSubmitCon.TabIndex = 18;
            this.btnSubmitCon.Text = "Submit";
            this.btnSubmitCon.UseVisualStyleBackColor = false;
            this.btnSubmitCon.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.rdoNumbersYes);
            this.panelNumbers.Controls.Add(this.rdoNumbersNo);
            this.panelNumbers.Location = new System.Drawing.Point(256, 112);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(167, 42);
            this.panelNumbers.TabIndex = 22;
            // 
            // panelSymbols
            // 
            this.panelSymbols.Controls.Add(this.rdoSymbolsYes);
            this.panelSymbols.Controls.Add(this.rdoSymbolsNo);
            this.panelSymbols.Location = new System.Drawing.Point(256, 59);
            this.panelSymbols.Name = "panelSymbols";
            this.panelSymbols.Size = new System.Drawing.Size(167, 47);
            this.panelSymbols.TabIndex = 23;
            // 
            // panelMaxChar
            // 
            this.panelMaxChar.Controls.Add(this.rdoMaxCharLengthYes);
            this.panelMaxChar.Controls.Add(this.rdoMaxCharLengthNo);
            this.panelMaxChar.Location = new System.Drawing.Point(256, 160);
            this.panelMaxChar.Name = "panelMaxChar";
            this.panelMaxChar.Size = new System.Drawing.Size(167, 39);
            this.panelMaxChar.TabIndex = 23;
            // 
            // panelWords
            // 
            this.panelWords.Controls.Add(this.rdoWordsNo);
            this.panelWords.Controls.Add(this.rdoWordsYes);
            this.panelWords.Location = new System.Drawing.Point(256, 205);
            this.panelWords.Name = "panelWords";
            this.panelWords.Size = new System.Drawing.Size(167, 39);
            this.panelWords.TabIndex = 24;
            // 
            // lblMaxCharEg
            // 
            this.lblMaxCharEg.AutoSize = true;
            this.lblMaxCharEg.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharEg.Location = new System.Drawing.Point(456, 154);
            this.lblMaxCharEg.Name = "lblMaxCharEg";
            this.lblMaxCharEg.Size = new System.Drawing.Size(118, 13);
            this.lblMaxCharEg.TabIndex = 25;
            this.lblMaxCharEg.Text = "Enter max length here";
            // 
            // lblWordsEg
            // 
            this.lblWordsEg.AutoSize = true;
            this.lblWordsEg.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsEg.Location = new System.Drawing.Point(564, 205);
            this.lblWordsEg.Name = "lblWordsEg";
            this.lblWordsEg.Size = new System.Drawing.Size(153, 13);
            this.lblWordsEg.TabIndex = 26;
            this.lblWordsEg.Text = "Enter amount here (max is 5)";
            // 
            // colAnswer
            // 
            this.colAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAnswer.HeaderText = "Answer";
            this.colAnswer.Name = "colAnswer";
            // 
            // colQuestion
            // 
            this.colQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQuestion.HeaderText = "Question";
            this.colQuestion.Name = "colQuestion";
            // 
            // dgvQuestionsCon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestionsCon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestionsCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestionsCon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuestion,
            this.colAnswer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestionsCon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQuestionsCon.Location = new System.Drawing.Point(17, 312);
            this.dgvQuestionsCon.Name = "dgvQuestionsCon";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestionsCon.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuestionsCon.Size = new System.Drawing.Size(760, 75);
            this.dgvQuestionsCon.TabIndex = 19;
            // 
            // btnQandA
            // 
            this.btnQandA.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnQandA.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQandA.ForeColor = System.Drawing.Color.White;
            this.btnQandA.Location = new System.Drawing.Point(17, 269);
            this.btnQandA.Name = "btnQandA";
            this.btnQandA.Size = new System.Drawing.Size(760, 37);
            this.btnQandA.TabIndex = 27;
            this.btnQandA.Text = "Click to go to Questions and Answers Form";
            this.btnQandA.UseVisualStyleBackColor = false;
            this.btnQandA.Click += new System.EventHandler(this.btnQandA_Click);
            // 
            // Constraints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQandA);
            this.Controls.Add(this.lblWordsEg);
            this.Controls.Add(this.lblMaxCharEg);
            this.Controls.Add(this.panelWords);
            this.Controls.Add(this.panelMaxChar);
            this.Controls.Add(this.panelSymbols);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.dgvQuestionsCon);
            this.Controls.Add(this.btnSubmitCon);
            this.Controls.Add(this.txtWordsHowMany);
            this.Controls.Add(this.lblWordsHowMany);
            this.Controls.Add(this.lblWords);
            this.Controls.Add(this.txtMaxCharLength);
            this.Controls.Add(this.lblMaxCharLength);
            this.Controls.Add(this.lblNumbersEg);
            this.Controls.Add(this.lblSymbolsEg);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.lblPasswordConstraints);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Constraints";
            this.Text = "Constraints";
            this.Load += new System.EventHandler(this.Constraints_Load);
            this.panelNumbers.ResumeLayout(false);
            this.panelNumbers.PerformLayout();
            this.panelSymbols.ResumeLayout(false);
            this.panelSymbols.PerformLayout();
            this.panelMaxChar.ResumeLayout(false);
            this.panelMaxChar.PerformLayout();
            this.panelWords.ResumeLayout(false);
            this.panelWords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestionsCon)).EndInit();
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
        private System.Windows.Forms.Button btnSubmitCon;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Panel panelSymbols;
        private System.Windows.Forms.Panel panelMaxChar;
        private System.Windows.Forms.Panel panelWords;
        private System.Windows.Forms.Label lblMaxCharEg;
        private System.Windows.Forms.Label lblWordsEg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestion;
        private System.Windows.Forms.DataGridView dgvQuestionsCon;
        private System.Windows.Forms.Button btnQandA;
    }
}