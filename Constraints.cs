using PasswordGenerator.Models;
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
        private int maxCharValue;
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
                    this.txtAnswer1Con.Text = questionForm.GetAnswers;
                    this.txtAnswer2Con.Text = questionForm.answer2.Trim();
                    this.txtAnswer3Con.Text = questionForm.answer3.Trim();
                    this.txtAnswer4Con.Text = questionForm.answer4.Trim();
                    this.txtAnswer5Con.Text = questionForm.answer5.Trim();
                }
            }

            //this.retrieveAnswers();

            btnSubmitCon.Visible = true;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.initializeMyGroupBox();

            if (!this.constraintsMethod())
                return;

            if (!this.checkInformation())
                return;
            
            this.Dispose();

        }

        private void initializeMyGroupBox()
        {
            //Add radio buttons to Panel
            this.panelSymbols.Controls.Add(rdoSymbolsYes);
            this.panelSymbols.Controls.Add(rdoSymbolsNo);

            this.panelNumbers.Controls.Add(rdoNumbersYes);
            this.panelNumbers.Controls.Add(rdoNumbersNo);

            this.panelMaxChar.Controls.Add(rdoMaxCharLengthYes);
            this.panelMaxChar.Controls.Add(rdoMaxCharLengthNo);

            this.panelWords.Controls.Add(rdoWordsYes);
            this.panelWords.Controls.Add(rdoWordsNo);
        }        

        private bool constraintsMethod()
        {
            this.storeSymbolsNubmers();

            if (!this.storeMaxChar())
                return false;

            if (!this.storeWords())
                return false;

            return true;
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

        private bool storeMaxChar()
        {
            if (rdoMaxCharLengthYes.Checked == true)
            {
                inputMaxChar = rdoMaxCharLengthYes.Text;
                string smsg = "Please enter a valid numeric length!";

                if (String.Equals(inputMaxChar, " "))
                {
                    // The text box isn't a valid number - tell the user!
                    MessageBox.Show(smsg, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtMaxCharLength.Focus();
                    return false;
                }

                else if (String.Equals(inputMaxChar, "Yes"))
                {
                    if (!Int32.TryParse(this.txtMaxCharLength.Text, out maxCharValue))
                    {
                        // The text box isn't a valid number - tell the user!
                        MessageBox.Show(smsg, TitlesModel.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtMaxCharLength.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        public bool storeWords()
        {
            if (rdoWordsYes.Checked == true)
            {
                inputWords = rdoWordsYes.Text;
                string smsg = "Please enter a number value for amount of words!";

                if (String.Equals(inputWords, " "))
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

        /*
        public void retrieveAnswers()
        {
            using(WordQuestionsAnswers frm = new WordQuestionsAnswers())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    txtAnswer1Con.Text = frm.getAnswers();
            }
        }
        */
    }
}
