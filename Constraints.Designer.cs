
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
            this.lblPasswordConstraints = new System.Windows.Forms.Label();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.rdoSymbolsYesTemp = new System.Windows.Forms.RadioButton();
            this.rdoSymbolsNo = new System.Windows.Forms.RadioButton();
            this.rdoNumbersNo = new System.Windows.Forms.RadioButton();
            this.rdoNumbersYes = new System.Windows.Forms.RadioButton();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblSymbolsEg = new System.Windows.Forms.Label();
            this.lblNumbersEg = new System.Windows.Forms.Label();
            this.rdoWordsNo = new System.Windows.Forms.RadioButton();
            this.rdoWordsYes = new System.Windows.Forms.RadioButton();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblWordsHowMany = new System.Windows.Forms.Label();
            this.txtWordsHowMany = new System.Windows.Forms.TextBox();
            this.btnSubmitCon = new System.Windows.Forms.Button();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.panelSymbols = new System.Windows.Forms.Panel();
            this.rdoSymbolsYes = new System.Windows.Forms.RadioButton();
            this.panelWords = new System.Windows.Forms.Panel();
            this.lblWordsEg = new System.Windows.Forms.Label();
            this.btnQandA = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtAnswer5Con = new System.Windows.Forms.TextBox();
            this.txtAnswer4Con = new System.Windows.Forms.TextBox();
            this.txtAnswer3Con = new System.Windows.Forms.TextBox();
            this.txtAnswer2Con = new System.Windows.Forms.TextBox();
            this.txtAnswer1Con = new System.Windows.Forms.TextBox();
            this.lblQuestion5Con = new System.Windows.Forms.Label();
            this.lblQuestion4Con = new System.Windows.Forms.Label();
            this.lblQuestion3Con = new System.Windows.Forms.Label();
            this.lblQuestion2Con = new System.Windows.Forms.Label();
            this.lblQuestion1Con = new System.Windows.Forms.Label();
            this.panelMaxChar = new System.Windows.Forms.Panel();
            this.rdoHowLong7 = new System.Windows.Forms.RadioButton();
            this.rdoHowLong3 = new System.Windows.Forms.RadioButton();
            this.rdoHowLong5 = new System.Windows.Forms.RadioButton();
            this.lblMaxCharLength = new System.Windows.Forms.Label();
            this.lblMaxCharLengthExplain = new System.Windows.Forms.Label();
            this.rdoHowLong9 = new System.Windows.Forms.RadioButton();
            this.panelNumbers.SuspendLayout();
            this.panelSymbols.SuspendLayout();
            this.panelWords.SuspendLayout();
            this.panelMaxChar.SuspendLayout();
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
            // rdoSymbolsYesTemp
            // 
            this.rdoSymbolsYesTemp.AutoSize = true;
            this.rdoSymbolsYesTemp.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSymbolsYesTemp.Location = new System.Drawing.Point(11, 9);
            this.rdoSymbolsYesTemp.Name = "rdoSymbolsYesTemp";
            this.rdoSymbolsYesTemp.Size = new System.Drawing.Size(58, 29);
            this.rdoSymbolsYesTemp.TabIndex = 3;
            this.rdoSymbolsYesTemp.TabStop = true;
            this.rdoSymbolsYesTemp.Text = "Yes";
            this.rdoSymbolsYesTemp.UseVisualStyleBackColor = true;
            this.rdoSymbolsYesTemp.CheckedChanged += new System.EventHandler(this.SymbolsCheckedYes);
            // 
            // rdoSymbolsNo
            // 
            this.rdoSymbolsNo.AutoSize = true;
            this.rdoSymbolsNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSymbolsNo.Location = new System.Drawing.Point(98, 8);
            this.rdoSymbolsNo.Name = "rdoSymbolsNo";
            this.rdoSymbolsNo.Size = new System.Drawing.Size(56, 29);
            this.rdoSymbolsNo.TabIndex = 4;
            this.rdoSymbolsNo.TabStop = true;
            this.rdoSymbolsNo.Text = "No";
            this.rdoSymbolsNo.UseVisualStyleBackColor = true;
            this.rdoSymbolsNo.CheckedChanged += new System.EventHandler(this.SymbolsCheckedNo);
            // 
            // rdoNumbersNo
            // 
            this.rdoNumbersNo.AutoSize = true;
            this.rdoNumbersNo.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNumbersNo.Location = new System.Drawing.Point(98, 5);
            this.rdoNumbersNo.Name = "rdoNumbersNo";
            this.rdoNumbersNo.Size = new System.Drawing.Size(56, 29);
            this.rdoNumbersNo.TabIndex = 6;
            this.rdoNumbersNo.Text = "No";
            this.rdoNumbersNo.UseVisualStyleBackColor = true;
            this.rdoNumbersNo.CheckedChanged += new System.EventHandler(this.NumbersCheckedNo);
            // 
            // rdoNumbersYes
            // 
            this.rdoNumbersYes.AutoSize = true;
            this.rdoNumbersYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNumbersYes.Location = new System.Drawing.Point(11, 5);
            this.rdoNumbersYes.Name = "rdoNumbersYes";
            this.rdoNumbersYes.Size = new System.Drawing.Size(58, 29);
            this.rdoNumbersYes.TabIndex = 5;
            this.rdoNumbersYes.Text = "Yes";
            this.rdoNumbersYes.UseVisualStyleBackColor = true;
            this.rdoNumbersYes.CheckedChanged += new System.EventHandler(this.NumbersCheckedYes);
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
            this.rdoWordsNo.CheckedChanged += new System.EventHandler(this.rdoWordsNo_CheckedChanged);
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
            this.rdoWordsYes.CheckedChanged += new System.EventHandler(this.rdoWordsYes_CheckedChanged);
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
            this.lblWordsHowMany.Location = new System.Drawing.Point(511, 218);
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
            this.txtWordsHowMany.Location = new System.Drawing.Point(611, 215);
            this.txtWordsHowMany.Name = "txtWordsHowMany";
            this.txtWordsHowMany.Size = new System.Drawing.Size(166, 29);
            this.txtWordsHowMany.TabIndex = 17;
            this.txtWordsHowMany.TextChanged += new System.EventHandler(this.txtWordsHowMany_TextChanged);
            // 
            // btnSubmitCon
            // 
            this.btnSubmitCon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSubmitCon.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitCon.ForeColor = System.Drawing.Color.White;
            this.btnSubmitCon.Location = new System.Drawing.Point(341, 473);
            this.btnSubmitCon.Name = "btnSubmitCon";
            this.btnSubmitCon.Size = new System.Drawing.Size(112, 45);
            this.btnSubmitCon.TabIndex = 1;
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
            this.panelSymbols.Controls.Add(this.rdoSymbolsYesTemp);
            this.panelSymbols.Controls.Add(this.rdoSymbolsNo);
            this.panelSymbols.Location = new System.Drawing.Point(256, 59);
            this.panelSymbols.Name = "panelSymbols";
            this.panelSymbols.Size = new System.Drawing.Size(167, 47);
            this.panelSymbols.TabIndex = 23;
            // 
            // rdoSymbolsYes
            // 
            this.rdoSymbolsYes.AutoSize = true;
            this.rdoSymbolsYes.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSymbolsYes.Location = new System.Drawing.Point(11, 8);
            this.rdoSymbolsYes.Name = "rdoSymbolsYes";
            this.rdoSymbolsYes.Size = new System.Drawing.Size(58, 29);
            this.rdoSymbolsYes.TabIndex = 5;
            this.rdoSymbolsYes.Text = "Yes";
            this.rdoSymbolsYes.UseVisualStyleBackColor = true;
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
            // lblWordsEg
            // 
            this.lblWordsEg.AutoSize = true;
            this.lblWordsEg.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsEg.Location = new System.Drawing.Point(608, 186);
            this.lblWordsEg.Name = "lblWordsEg";
            this.lblWordsEg.Size = new System.Drawing.Size(153, 13);
            this.lblWordsEg.TabIndex = 26;
            this.lblWordsEg.Text = "Enter amount here (max is 5)";
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
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(608, 202);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(96, 13);
            this.lblWord.TabIndex = 28;
            this.lblWord.Text = "CANNOT ENTER 0";
            // 
            // txtAnswer5Con
            // 
            this.txtAnswer5Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer5Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer5Con.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAnswer5Con.Location = new System.Drawing.Point(517, 424);
            this.txtAnswer5Con.Name = "txtAnswer5Con";
            this.txtAnswer5Con.Size = new System.Drawing.Size(200, 25);
            this.txtAnswer5Con.TabIndex = 38;
            // 
            // txtAnswer4Con
            // 
            this.txtAnswer4Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer4Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer4Con.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAnswer4Con.Location = new System.Drawing.Point(517, 395);
            this.txtAnswer4Con.Name = "txtAnswer4Con";
            this.txtAnswer4Con.Size = new System.Drawing.Size(200, 25);
            this.txtAnswer4Con.TabIndex = 37;
            // 
            // txtAnswer3Con
            // 
            this.txtAnswer3Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer3Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer3Con.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAnswer3Con.Location = new System.Drawing.Point(517, 367);
            this.txtAnswer3Con.Name = "txtAnswer3Con";
            this.txtAnswer3Con.Size = new System.Drawing.Size(200, 25);
            this.txtAnswer3Con.TabIndex = 36;
            // 
            // txtAnswer2Con
            // 
            this.txtAnswer2Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer2Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer2Con.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAnswer2Con.Location = new System.Drawing.Point(517, 340);
            this.txtAnswer2Con.Name = "txtAnswer2Con";
            this.txtAnswer2Con.Size = new System.Drawing.Size(200, 25);
            this.txtAnswer2Con.TabIndex = 35;
            // 
            // txtAnswer1Con
            // 
            this.txtAnswer1Con.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAnswer1Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer1Con.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAnswer1Con.Location = new System.Drawing.Point(517, 312);
            this.txtAnswer1Con.Name = "txtAnswer1Con";
            this.txtAnswer1Con.Size = new System.Drawing.Size(200, 25);
            this.txtAnswer1Con.TabIndex = 34;
            // 
            // lblQuestion5Con
            // 
            this.lblQuestion5Con.AutoSize = true;
            this.lblQuestion5Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion5Con.Location = new System.Drawing.Point(100, 421);
            this.lblQuestion5Con.Name = "lblQuestion5Con";
            this.lblQuestion5Con.Size = new System.Drawing.Size(78, 19);
            this.lblQuestion5Con.TabIndex = 43;
            this.lblQuestion5Con.Text = "Question 5";
            // 
            // lblQuestion4Con
            // 
            this.lblQuestion4Con.AutoSize = true;
            this.lblQuestion4Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion4Con.Location = new System.Drawing.Point(100, 392);
            this.lblQuestion4Con.Name = "lblQuestion4Con";
            this.lblQuestion4Con.Size = new System.Drawing.Size(78, 19);
            this.lblQuestion4Con.TabIndex = 42;
            this.lblQuestion4Con.Text = "Question 4";
            // 
            // lblQuestion3Con
            // 
            this.lblQuestion3Con.AutoSize = true;
            this.lblQuestion3Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion3Con.Location = new System.Drawing.Point(100, 364);
            this.lblQuestion3Con.Name = "lblQuestion3Con";
            this.lblQuestion3Con.Size = new System.Drawing.Size(78, 19);
            this.lblQuestion3Con.TabIndex = 41;
            this.lblQuestion3Con.Text = "Question 3";
            // 
            // lblQuestion2Con
            // 
            this.lblQuestion2Con.AutoSize = true;
            this.lblQuestion2Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion2Con.Location = new System.Drawing.Point(98, 337);
            this.lblQuestion2Con.Name = "lblQuestion2Con";
            this.lblQuestion2Con.Size = new System.Drawing.Size(78, 19);
            this.lblQuestion2Con.TabIndex = 40;
            this.lblQuestion2Con.Text = "Question 2";
            // 
            // lblQuestion1Con
            // 
            this.lblQuestion1Con.AutoSize = true;
            this.lblQuestion1Con.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion1Con.Location = new System.Drawing.Point(98, 309);
            this.lblQuestion1Con.Name = "lblQuestion1Con";
            this.lblQuestion1Con.Size = new System.Drawing.Size(76, 19);
            this.lblQuestion1Con.TabIndex = 39;
            this.lblQuestion1Con.Text = "Question 1";
            // 
            // panelMaxChar
            // 
            this.panelMaxChar.Controls.Add(this.rdoHowLong9);
            this.panelMaxChar.Controls.Add(this.rdoHowLong7);
            this.panelMaxChar.Controls.Add(this.rdoHowLong3);
            this.panelMaxChar.Controls.Add(this.rdoHowLong5);
            this.panelMaxChar.Location = new System.Drawing.Point(256, 160);
            this.panelMaxChar.Name = "panelMaxChar";
            this.panelMaxChar.Size = new System.Drawing.Size(292, 39);
            this.panelMaxChar.TabIndex = 23;
            // 
            // rdoHowLong7
            // 
            this.rdoHowLong7.AutoSize = true;
            this.rdoHowLong7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHowLong7.Location = new System.Drawing.Point(158, 4);
            this.rdoHowLong7.Name = "rdoHowLong7";
            this.rdoHowLong7.Size = new System.Drawing.Size(40, 29);
            this.rdoHowLong7.TabIndex = 12;
            this.rdoHowLong7.TabStop = true;
            this.rdoHowLong7.Text = "7";
            this.rdoHowLong7.UseVisualStyleBackColor = true;
            // 
            // rdoHowLong3
            // 
            this.rdoHowLong3.AutoSize = true;
            this.rdoHowLong3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHowLong3.Location = new System.Drawing.Point(11, 4);
            this.rdoHowLong3.Name = "rdoHowLong3";
            this.rdoHowLong3.Size = new System.Drawing.Size(41, 29);
            this.rdoHowLong3.TabIndex = 10;
            this.rdoHowLong3.TabStop = true;
            this.rdoHowLong3.Text = "3";
            this.rdoHowLong3.UseVisualStyleBackColor = true;
            // 
            // rdoHowLong5
            // 
            this.rdoHowLong5.AutoSize = true;
            this.rdoHowLong5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHowLong5.Location = new System.Drawing.Point(85, 4);
            this.rdoHowLong5.Name = "rdoHowLong5";
            this.rdoHowLong5.Size = new System.Drawing.Size(41, 29);
            this.rdoHowLong5.TabIndex = 11;
            this.rdoHowLong5.TabStop = true;
            this.rdoHowLong5.Text = "5";
            this.rdoHowLong5.UseVisualStyleBackColor = true;
            // 
            // lblMaxCharLength
            // 
            this.lblMaxCharLength.AutoSize = true;
            this.lblMaxCharLength.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharLength.Location = new System.Drawing.Point(12, 166);
            this.lblMaxCharLength.Name = "lblMaxCharLength";
            this.lblMaxCharLength.Size = new System.Drawing.Size(106, 25);
            this.lblMaxCharLength.TabIndex = 9;
            this.lblMaxCharLength.Text = "How Long?";
            // 
            // lblMaxCharLengthExplain
            // 
            this.lblMaxCharLengthExplain.AutoSize = true;
            this.lblMaxCharLengthExplain.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCharLengthExplain.Location = new System.Drawing.Point(14, 191);
            this.lblMaxCharLengthExplain.Name = "lblMaxCharLengthExplain";
            this.lblMaxCharLengthExplain.Size = new System.Drawing.Size(162, 13);
            this.lblMaxCharLengthExplain.TabIndex = 29;
            this.lblMaxCharLengthExplain.Text = "only for numbers and symbols";
            // 
            // rdoHowLong9
            // 
            this.rdoHowLong9.AutoSize = true;
            this.rdoHowLong9.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHowLong9.Location = new System.Drawing.Point(240, 4);
            this.rdoHowLong9.Name = "rdoHowLong9";
            this.rdoHowLong9.Size = new System.Drawing.Size(41, 29);
            this.rdoHowLong9.TabIndex = 13;
            this.rdoHowLong9.TabStop = true;
            this.rdoHowLong9.Text = "9";
            this.rdoHowLong9.UseVisualStyleBackColor = true;
            // 
            // Constraints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.lblQuestion5Con);
            this.Controls.Add(this.lblQuestion4Con);
            this.Controls.Add(this.lblQuestion3Con);
            this.Controls.Add(this.lblQuestion2Con);
            this.Controls.Add(this.lblQuestion1Con);
            this.Controls.Add(this.txtAnswer5Con);
            this.Controls.Add(this.txtAnswer4Con);
            this.Controls.Add(this.txtAnswer3Con);
            this.Controls.Add(this.txtAnswer2Con);
            this.Controls.Add(this.txtAnswer1Con);
            this.Controls.Add(this.lblMaxCharLengthExplain);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.btnQandA);
            this.Controls.Add(this.lblWordsEg);
            this.Controls.Add(this.panelWords);
            this.Controls.Add(this.panelMaxChar);
            this.Controls.Add(this.panelSymbols);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.btnSubmitCon);
            this.Controls.Add(this.txtWordsHowMany);
            this.Controls.Add(this.lblWordsHowMany);
            this.Controls.Add(this.lblWords);
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
            this.panelWords.ResumeLayout(false);
            this.panelWords.PerformLayout();
            this.panelMaxChar.ResumeLayout(false);
            this.panelMaxChar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordConstraints;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.RadioButton rdoSymbolsYesTemp;
        private System.Windows.Forms.RadioButton rdoSymbolsNo;
        private System.Windows.Forms.RadioButton rdoNumbersNo;
        private System.Windows.Forms.RadioButton rdoNumbersYes;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblSymbolsEg;
        private System.Windows.Forms.Label lblNumbersEg;
        private System.Windows.Forms.RadioButton rdoWordsNo;
        private System.Windows.Forms.RadioButton rdoWordsYes;
        private System.Windows.Forms.Label lblWords;
        private System.Windows.Forms.Label lblWordsHowMany;
        private System.Windows.Forms.TextBox txtWordsHowMany;
        private System.Windows.Forms.Button btnSubmitCon;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Panel panelSymbols;
        private System.Windows.Forms.Panel panelWords;
        private System.Windows.Forms.Label lblWordsEg;
        private System.Windows.Forms.Button btnQandA;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox txtAnswer5Con;
        private System.Windows.Forms.TextBox txtAnswer4Con;
        private System.Windows.Forms.TextBox txtAnswer3Con;
        private System.Windows.Forms.TextBox txtAnswer2Con;
        private System.Windows.Forms.TextBox txtAnswer1Con;
        private System.Windows.Forms.Label lblQuestion5Con;
        private System.Windows.Forms.Label lblQuestion4Con;
        private System.Windows.Forms.Label lblQuestion3Con;
        private System.Windows.Forms.Label lblQuestion2Con;
        private System.Windows.Forms.Label lblQuestion1Con;
        private System.Windows.Forms.Panel panelMaxChar;
        private System.Windows.Forms.RadioButton rdoHowLong3;
        private System.Windows.Forms.RadioButton rdoHowLong5;
        private System.Windows.Forms.Label lblMaxCharLength;
        private System.Windows.Forms.Label lblMaxCharLengthExplain;
        private System.Windows.Forms.RadioButton rdoHowLong7;
        private System.Windows.Forms.RadioButton rdoSymbolsYes;
        private System.Windows.Forms.RadioButton rdoHowLong9;
    }
}