﻿using PasswordGenerator.Models;
using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Constraints : Form
    {
        //variables
        private string inputSymbols;
        private string inputNumbers;
        private string inputMaxChar;
        private string inputWords;
        //private int maxCharValue;
        public int maxWordValue = 0;

        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public string answer5;


        //methods
        public Constraints()
        {
            InitializeComponent();
        }

        private void Constraints_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
            btnSubmitCon.Visible = false;
            btnQandA.Enabled = false;
            txtWordsHowMany.Enabled = false;

            rdoHowLong3.Enabled = false;
            rdoHowLong5.Enabled = false;
            rdoHowLong7.Enabled = false;
            rdoHowLong9.Enabled = false;


            //making questions disappear
            lblQuestion1Con.Visible = false;
            lblQuestion2Con.Visible = false;
            lblQuestion3Con.Visible = false;
            lblQuestion4Con.Visible = false;
            lblQuestion5Con.Visible = false;

            //making answer textboxes disappear
            txtAnswer1Con.Visible = false;
            txtAnswer2Con.Visible = false;
            txtAnswer3Con.Visible = false;
            txtAnswer4Con.Visible = false;
            txtAnswer5Con.Visible = false;

            this.rdoSymbolsYes.Checked = false;
            this.rdoSymbolsNo.Checked = false;

            //this.DisplayHowLong(false);

        }
        private void setControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnQandA_Click(object sender, EventArgs e)
        {
            WordQuestionsAnswers questionForm = new WordQuestionsAnswers();

            using (questionForm)
            {
                this.storeWords();

                questionForm.maxWordValue = this.maxWordValue;

                if (questionForm.ShowDialog() == DialogResult.OK)
                {

                    if(maxWordValue == 1)
                    {
                        lblQuestion1Con.Visible = true;

                        txtAnswer1Con.Visible = true;
                    }
                    else if (maxWordValue == 2)
                    {
                        lblQuestion1Con.Visible = true;
                        lblQuestion2Con.Visible = true;

                        txtAnswer1Con.Visible = true;
                        txtAnswer2Con.Visible = true;
                    }
                    else if (maxWordValue == 3)
                    {
                        lblQuestion1Con.Visible = true;
                        lblQuestion2Con.Visible = true;
                        lblQuestion3Con.Visible = true;

                        txtAnswer1Con.Visible = true;
                        txtAnswer2Con.Visible = true;
                        txtAnswer3Con.Visible = true;
                    }
                    else if (maxWordValue == 4)
                    {
                        lblQuestion1Con.Visible = true;
                        lblQuestion2Con.Visible = true;
                        lblQuestion3Con.Visible = true;
                        lblQuestion4Con.Visible = true;

                        txtAnswer1Con.Visible = true;
                        txtAnswer2Con.Visible = true;
                        txtAnswer3Con.Visible = true;
                        txtAnswer4Con.Visible = true;
                    }
                    else
                    {
                        lblQuestion1Con.Visible = true;
                        lblQuestion2Con.Visible = true;
                        lblQuestion3Con.Visible = true;
                        lblQuestion4Con.Visible = true;
                        lblQuestion5Con.Visible = true;

                        txtAnswer1Con.Visible = true;
                        txtAnswer2Con.Visible = true;
                        txtAnswer3Con.Visible = true;
                        txtAnswer4Con.Visible = true;
                        txtAnswer5Con.Visible = true;
                    }

                    this.txtAnswer1Con.Text = questionForm.GetAnswer1.Trim();
                    this.txtAnswer2Con.Text = questionForm.GetAnswer2.Trim();
                    this.txtAnswer3Con.Text = questionForm.GetAnswer3.Trim();
                    this.txtAnswer4Con.Text = questionForm.GetAnswer4.Trim();
                    this.txtAnswer5Con.Text = questionForm.GetAnswer5.Trim();

                    this.lblQuestion1Con.Text = questionForm.GetQuestion1.Trim();
                    this.lblQuestion2Con.Text = questionForm.GetQuestion2.Trim();
                    this.lblQuestion3Con.Text = questionForm.GetQuestion3.Trim();
                    this.lblQuestion4Con.Text = questionForm.GetQuestion4.Trim();
                    this.lblQuestion5Con.Text = questionForm.GetQuestion5.Trim();

                }
            }

            btnSubmitCon.Visible = true;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.initializeMyGroupBox();

            this.storeSymbolsNubmers();

            this.storeMaxChar();

            if (!this.checkInformation())
                return;

            //this.makePassword();

            this.Dispose();

        }

        private void initializeMyGroupBox()
        {
            //Add radio buttons to Panel
            this.panelSymbols.Controls.Add(rdoSymbolsYes);
            this.panelSymbols.Controls.Add(rdoSymbolsNo);

            this.panelNumbers.Controls.Add(rdoNumbersYes);
            this.panelNumbers.Controls.Add(rdoNumbersNo);

            this.panelMaxChar.Controls.Add(rdoHowLong3);
            this.panelMaxChar.Controls.Add(rdoHowLong5);
            this.panelMaxChar.Controls.Add(rdoHowLong7);
            this.panelMaxChar.Controls.Add(rdoHowLong9);

            this.panelWords.Controls.Add(rdoWordsYes);
            this.panelWords.Controls.Add(rdoWordsNo);
        }

        private void storeSymbolsNubmers()
        {
            if (rdoSymbolsYes.Checked == true)
            {
               inputSymbols = rdoSymbolsYes.Text;
            }

            if (rdoNumbersYes.Checked == true)
            {
               inputNumbers = rdoNumbersYes.Text;
            }
        }

        private void storeMaxChar()
        {
            if (rdoSymbolsYes.Checked == true || rdoNumbersYes.Checked == true)
            {
                rdoHowLong3.Enabled = true;
                rdoHowLong5.Enabled = true;
                rdoHowLong7.Enabled = true;
                rdoHowLong9.Enabled = true;

                if (rdoHowLong3.Checked == true)
                {
                    inputMaxChar = rdoHowLong3.Text;
                }
                else if (rdoHowLong5.Checked == true)
                {
                    inputMaxChar = rdoHowLong5.Text;
                }
                else if (rdoHowLong7.Checked == true)
                {
                    inputMaxChar = rdoHowLong7.Text;
                }
                else
                {
                    inputMaxChar = rdoHowLong9.Text;
                }
            }
            
        }
        private void SymbolsCheckedYes(object sender, EventArgs e)
        {
            this.storeMaxChar();
        }

        private void SymbolsCheckedNo(object sender, EventArgs e)
        {
            this.storeMaxChar();
        }

        private void NumbersCheckedYes(object sender, EventArgs e)
        {
            this.storeMaxChar();
        }

        private void NumbersCheckedNo(object sender, EventArgs e)
        {
            this.storeMaxChar();
        }

        private void rdoWordsYes_CheckedChanged(object sender, EventArgs e)
        {
            txtWordsHowMany.Enabled = true;
        }

        public bool storeWords()
        {
            if (rdoWordsYes.Checked == true)
            {
                inputWords = rdoWordsYes.Text;
                string smsg = "Please enter a number value for amount of words!";


                if (String.Equals(inputWords, ""))
                {
                    // The text box isn't a valid number - tell the user!
                    MessageBox.Show(smsg, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtWordsHowMany.Focus();
                    return false;
                }

                else if (String.Equals(inputWords, "Yes"))
                {
                    bool result = Int32.TryParse(this.txtWordsHowMany.Text.Trim(), out maxWordValue);

                    if (!result)
                    {
                        // The text box isn't a valid number - tell the user!
                        MessageBox.Show(smsg, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtWordsHowMany.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private void txtWordsHowMany_TextChanged(object sender, EventArgs e)
        {
            if (!storeWords())
            {
                btnQandA.Enabled = false;
            }
            else
            {
                btnQandA.Enabled = true;
            }
        }

        private void rdoWordsNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSymbolsNo.Checked == true && rdoNumbersYes.Checked == true) 
            {
                btnSubmitCon.Visible = true;
            }
            if (rdoSymbolsYes.Checked == true && rdoNumbersNo.Checked == true) 
            {
                btnSubmitCon.Visible = true;
            }
            if(rdoSymbolsNo.Checked == true && rdoNumbersYes.Checked == true)
            {
                btnSubmitCon.Visible = true;
            }
            if(rdoSymbolsNo.Checked == true && rdoNumbersNo.Checked == true)
            {
                btnSubmitCon.Visible = true;
            }
            
        }

        private bool checkInformation()
        {
            DialogResult dialogResult = MessageBox.Show("Is all the information correct?", "Password Generator", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else if (dialogResult == DialogResult.No)
            {
                return false;
            }

            return false;
        }

        public string[] symbolsList = { "!", "@", "#", "$", "%", "^", "&", "*", "=", "-", "_", "/",
            "+", ":", ";", "(", ")", "{", "}", "[", "]", "|", "~" , "."};

        private void makePassword()
        {
            Random rnd = new Random();
            int nums1 = rnd.Next(0, 10);
            int nums2 = rnd.Next(0, 10);
            int nums3 = rnd.Next(0, 10);
            int nums4 = rnd.Next(0, 10);
            int nums5 = rnd.Next(0, 10);


            //if (rdoNumbersYes.Checked == true && rdoNumbersYes.Checked == true
                //&& this.storeMaxChar() && this.storeWords())
            {

            }
        }

    }

}
