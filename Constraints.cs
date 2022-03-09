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
        private string inputSymbolRdo;
        private string inputNumberRdo;
        private string inputWords;
        public int maxWordValue = 0;

        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public string answer5;

        public static string word1;
        public static string word2;
        public static string word3;
        public static string word4;
        public static string word5;

        public string password1;
        public string password2;
        public string password3;


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

            rdoSymbol3.Enabled = false;
            rdoSymbol5.Enabled = false;

            rdoNumber3.Enabled = false;
            rdoNumber5.Enabled = false;


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
                    word1 = questionForm.GetAnswer1.Trim();

                    this.txtAnswer2Con.Text = questionForm.GetAnswer2.Trim();
                    word2 = questionForm.GetAnswer2.Trim();

                    this.txtAnswer3Con.Text = questionForm.GetAnswer3.Trim();
                    word3 = questionForm.GetAnswer3.Trim();

                    this.txtAnswer4Con.Text = questionForm.GetAnswer4.Trim();
                    word4 = questionForm.GetAnswer4.Trim();

                    this.txtAnswer5Con.Text = questionForm.GetAnswer5.Trim();
                    word5 = questionForm.GetAnswer5.Trim();

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

            this.storeSymbolsRdo();

            this.storeNumbersRdo();

            if (!this.checkInformation())
                return;

            this.makePassword();

            this.Dispose();

        }

        private void initializeMyGroupBox()
        {
            //Add radio buttons to Panel
            this.panelSymbols.Controls.Add(rdoSymbolsYes);
            this.panelSymbols.Controls.Add(rdoSymbolsNo);

            this.panelSymbolsRdo.Controls.Add(rdoSymbol3);
            this.panelSymbolsRdo.Controls.Add(rdoSymbol5);

            this.panelNumbers.Controls.Add(rdoNumbersYes);
            this.panelNumbers.Controls.Add(rdoNumbersNo);

            this.panelNumbersRdo.Controls.Add(rdoNumber3);
            this.panelNumbersRdo.Controls.Add(rdoNumber5);

            this.panelWords.Controls.Add(rdoWordsYes);
            this.panelWords.Controls.Add(rdoWordsNo);
        }

        private void messageBoxError()
        {
            if (rdoNumbersYes.Checked == true)
            {
                if (!rdoNumber3.Checked && !rdoNumber5.Checked)
                {
                    MessageBox.Show("Please select length for Numbers", "Error");
                    return;

                }
            }

            if (rdoSymbolsYes.Checked == true)
            {
                if (!rdoSymbol3.Checked && !rdoSymbol5.Checked)
                {
                    MessageBox.Show("Please select length for Symbols", "Error");
                    return;

                }
            }
            
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

        private void storeSymbolsRdo()
        {
            if (rdoSymbolsNo.Checked == true)
            {
                rdoSymbol3.Enabled = false;
                rdoSymbol5.Enabled = false;
            }

            if (rdoSymbolsYes.Checked == true)
            {
                rdoSymbol3.Enabled = true;
                rdoSymbol5.Enabled = true;

                this.messageBoxError();

                if (rdoSymbol3.Checked == true)
                {
                    inputSymbolRdo = rdoSymbol3.Text;
                }
                else
                {
                    inputSymbolRdo = rdoSymbol5.Text;
                }
            }

        }

        private void storeNumbersRdo()
        {
            if (rdoNumbersNo.Checked == true)
            {
                rdoNumber3.Enabled = false;
                rdoNumber5.Enabled = false;
            }

            if (rdoNumbersYes.Checked == true)
            {
                rdoNumber3.Enabled = true;
                rdoNumber5.Enabled = true;

                this.messageBoxError();

                if (rdoNumber3.Checked == true)
                {
                    inputNumberRdo = rdoNumber3.Text;
                }
                else
                {
                    inputNumberRdo = rdoNumber5.Text;
                }
            }

        }

        private void SymbolsCheckedYes(object sender, EventArgs e)
        {
            this.storeSymbolsRdo();
        }

        private void SymbolsCheckedNo(object sender, EventArgs e)
        {
            this.storeSymbolsRdo();
        }

        private void NumbersCheckedYes(object sender, EventArgs e)
        {
            this.storeNumbersRdo();
        }

        private void NumbersCheckedNo(object sender, EventArgs e)
        {
            this.storeNumbersRdo();
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
            txtWordsHowMany.Enabled = false;

            if (rdoSymbolsYes.Checked == true && rdoNumbersYes.Checked == true)
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

        public string[] symbolsList = { "!", "@", "#", "$", "%", "&", "*", "=", "-", "_", "/",
            "+", ":", ";", "~" };

        public string[] wordList = { word1, word2, word3, word4, word5 };

        private void makePassword()
        {
            Random rnd = new Random();

            //numbers
            string nums1 = rnd.Next(0, 10).ToString();
            string nums2 = rnd.Next(0, 10).ToString();
            string nums3 = rnd.Next(0, 10).ToString();
            string nums4 = rnd.Next(0, 10).ToString();
            string nums5 = rnd.Next(0, 10).ToString();

            //symbols
            int initialValue1 = rnd.Next(symbolsList.Length);
            int initialValue2 = rnd.Next(symbolsList.Length);
            int initialValue3 = rnd.Next(symbolsList.Length);
            int initialValue4 = rnd.Next(symbolsList.Length);
            int initialValue5 = rnd.Next(symbolsList.Length);

            string symbol1 = symbolsList[initialValue1];
            string symbol2 = symbolsList[initialValue2];
            string symbol3 = symbolsList[initialValue3];
            string symbol4 = symbolsList[initialValue4];
            string symbol5 = symbolsList[initialValue5];

            if (rdoWordsNo.Checked == true)
            {
                if(rdoSymbolsNo.Checked == true)
                {
                    if(rdoNumbersNo.Checked == true)
                    {
                        password1 = "You entered 'No' for all constraints";
                        password2 = "You entered 'No' for all constraints";
                        password3 = "You entered 'No' for all constraints";
                    }
                    else
                    {
                        if (inputNumberRdo.Equals("3"))
                        {
                            password1 = nums1 + nums2 + nums3;
                            password2 = nums2 + nums3 + nums1;
                            password3 = nums3 + nums1 + nums2;
                        }
                        else
                        {
                            password1 = nums1 + nums2 + nums3 + nums4 + nums5;
                            password2 = nums5 + nums3 + nums4 + nums1 + nums2;
                            password3 = nums5 + nums4 + nums3 + nums2 + nums1;
                        }
                    }
                }
                else
                {
                    if (rdoNumbersNo.Checked == true)
                    {
                        if (rdoSymbolsNo.Checked == true)
                        {
                            password1 = "You entered 'No' for all constraints";
                            password2 = "You entered 'No' for all constraints";
                            password3 = "You entered 'No' for all constraints";
                        }
                        else
                        {
                            if (inputSymbolRdo.Equals("3"))
                            {
                                password1 = symbol1 + symbol2 + symbol3;
                                password2 = symbol2 + symbol3 + symbol1;
                                password3 = symbol3 + symbol1 + symbol2;
                            }
                            else
                            {
                                password1 = symbol1 + symbol2 + symbol3 + symbol4 + symbol5;
                                password2 = symbol5 + symbol3 + symbol4 + symbol1 + symbol2;
                                password3 = symbol5 + symbol4 + symbol3 + symbol2 + symbol1;
                            }
                        }
                    }
                }
                
            }
            else
            {
                if (maxWordValue == 1)
                {
                    if (rdoSymbolsNo.Checked == true)
                    {
                        if (rdoNumbersNo.Checked == true)
                        {
                            password1 = word1;
                            password2 = word1;
                            password3 = word1;
                        }
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + nums1 + nums2 + nums3;
                                password2 = nums2 + nums3 + word1 + nums1;
                                password3 = nums3 + nums1 + nums2 + word1;
                            }
                            else
                            {
                                password1 = word1 + nums1 + nums2 + nums3 + nums4 + nums5;
                                password2 = nums5 + nums3 + nums4 + nums1 + nums2 + word1;
                                password3 = nums5 + nums4 + nums3 + word1 + nums2 + nums1;
                            }
                        }
                    }
                    else if(rdoNumbersNo.Checked == true)
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            password1 = word1 + symbol1 + symbol2 + symbol3;
                            password2 = symbol2 + symbol3 + symbol1 + word1;
                            password3 = symbol3 + word1 + symbol1 + symbol2;
                        }
                        else
                        {
                            password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5;
                            password2 = symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                            password3 = symbol5 + symbol4 + symbol3 + word1 + symbol2 + symbol1;
                        }
                    }
                    else
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + nums1 + nums2 + nums3;
                                password2 = nums2 + nums3 +  nums1 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + nums2 + symbol1 + symbol2;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + nums1 + nums2 + nums3 + nums4 + nums5;
                                password2 = nums4 + nums5 + nums2 + nums3 + nums1 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + nums2 + symbol1 + symbol2 + nums5 + nums4;
                            }
                        }
                        //symbols = 5 
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5 + nums1 + nums2 + nums3;
                                password2 = nums1 + nums2 + nums3 + symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + symbol4 + nums2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + nums4 + nums5;
                                password2 = nums1 + nums2 + nums3 + nums4 + nums5 + symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + symbol4 + nums2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1 + nums4 + nums5;
                            }
                        }
                    }
                }
                else if(maxWordValue == 2)
                {
                    if (rdoSymbolsNo.Checked == true)
                    {
                        if (rdoNumbersNo.Checked == true)
                        {
                            password1 = word1 + word2;
                            password2 = word2 + word1;
                            password3 = word1 + word2;
                        }
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + nums1 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + word1 + nums1;
                                password3 = nums3 + word2 + nums1 + nums2 + word1;
                            }
                            else
                            {
                                password1 = word1 + nums1 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = nums5 + nums3 + word2 + nums4 + nums1 + nums2 + word1;
                                password3 = word2+ nums5 + nums4 + nums3 + word1 + nums2 + nums1;
                            }
                        }
                    }
                    else if (rdoNumbersNo.Checked == true)
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            password1 = word1 + symbol1 + symbol2 + symbol3 + word2;
                            password2 = word2+ symbol2 + symbol3 + symbol1 + word1;
                            password3 = symbol3 + word1 + symbol1 + word2 +  symbol2;
                        }
                        else
                        {
                            password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5 + word2;
                            password2 = symbol5 + symbol3 + word2 + symbol4 + symbol1 + symbol2 + word1;
                            password3 = word2 + symbol5 + symbol4 + symbol3 + word1 + symbol2 + symbol1;
                        }
                    }
                    else
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + nums1 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + nums1 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + nums2 + symbol1 + word2 + symbol2;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + nums1 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = word2 + nums4 + nums5 + nums2 + nums3 + nums1 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + nums2 + symbol1 + word2 + symbol2 + nums5 + nums4;
                            }
                        }
                        //symbols = 5 
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + word2;
                                password2 = nums1 + nums2 + word2 + nums3 + symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word2 + symbol4 + nums2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = nums1 + word2 + nums2 + nums3 + nums4 + nums5 + symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + symbol4 + nums2 + word2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1 + nums4 + nums5;
                            }
                        }
                    }
                }
                else if(maxWordValue == 3)
                {
                    if (rdoSymbolsNo.Checked == true)
                    {
                        if (rdoNumbersNo.Checked == true)
                        {
                            password1 = word1 + word2 + word3;
                            password2 = word2 + word3 + word1;
                            password3 = word3 + word1 + word2;
                        }
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + nums1 + word3 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + word1 + nums1 + word3;
                                password3 = nums3 + word2 + nums1 + word3 + nums2 + word1;
                            }
                            else
                            {
                                password1 = word1 + nums1 + nums2 + word3 + nums3 + nums4 + nums5 + word2;
                                password2 = word3 + nums5 + nums3 + word2 + nums4 + nums1 + nums2 + word1;
                                password3 = word2 + nums5 + nums4 + nums3 + word1 + nums2 + nums1 + word3;
                            }
                        }
                    }
                    else if (rdoNumbersNo.Checked == true)
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            password1 = word1 + symbol1 + word3 + symbol2 + symbol3 + word2;
                            password2 = word2 + symbol2 + symbol3 + word3 + symbol1 + word1;
                            password3 = symbol3 + word1 + symbol1 + word2 + symbol2 + word3;
                        }
                        else
                        {
                            password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + symbol4 + symbol5 + word2;
                            password2 = word3 + symbol5 + symbol3 + word2 + symbol4 + symbol1 + symbol2 + word1;
                            password3 = word2 + symbol5 + symbol4 + symbol3 + word1 + symbol2 + symbol1 + word3;
                        }
                    }
                    else
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + nums1 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + nums1 + symbol2 + word3 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + word3 + nums2 + symbol1 + word2 + symbol2;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + nums1 + nums2 + word3 + nums3 + nums4 + nums5 + word2;
                                password2 = word2 + nums4 + nums5 + nums2 + word3 + nums3 + nums1 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + nums2 + symbol1 + word2 + symbol2 + nums5 + word3 + nums4;
                            }
                        }
                        //symbols = 5 
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + symbol3 + word3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + word2;
                                password2 = nums1 + nums2 + word2 + nums3 + symbol5 + symbol3 + word3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word2 + symbol4 + nums2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1 + word3;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = nums1 + word2 + nums2 + nums3 + nums4 + nums5 + word3 + symbol5 + symbol3 + symbol4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + symbol4 + nums2 + word2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1 + word3 + nums4 + nums5;
                            }
                        }
                    }
                }
                else if(maxWordValue == 4)
                {
                    if (rdoSymbolsNo.Checked == true)
                    {
                        if (rdoNumbersNo.Checked == true)
                        {
                            password1 = word1 + word3 + word2 + word4;
                            password2 = word4 + word2 + word1 + word3;
                            password3 = word3 + word1 + word4 + word2;
                        }
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + nums1 + word3 + nums2 + word4 + nums3 + word2;
                                password2 = word2 + nums2 + word4 + nums3 + word1 + nums1 + word3;
                                password3 = word4 + nums3 + word2 + nums1 + word3 + nums2 + word1;
                            }
                            else
                            {
                                password1 = word1 + nums1 + nums2 + word3 + nums3 + nums4 + word4 + nums5 + word2;
                                password2 = word3 + nums5 + nums3 + word2 + nums4 + nums1 + word4 + nums2 + word1;
                                password3 = word2 + nums5 + word4 + nums4 + nums3 + word1 + nums2 + nums1 + word3;
                            }
                        }
                    }
                    else if (rdoNumbersNo.Checked == true)
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            password1 = word1 + symbol1 + word3 + symbol2 + word4 + symbol3 + word2;
                            password2 = word2 + symbol2 + word4 + symbol3 + word3 + symbol1 + word1;
                            password3 = word4 + symbol3 + word1 + symbol1 + word2 + symbol2 + word3;
                        }
                        else
                        {
                            password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + word4 + symbol4 + symbol5 + word2;
                            password2 = word3 + symbol5 + word4 + symbol3 + word2 + symbol4 + symbol1 + symbol2 + word1;
                            password3 = word2 + symbol5 + symbol4 + symbol3 + word1 + symbol2 + word4 + symbol1 + word3;
                        }
                    }
                    else
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + nums1 + word4 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + word4 + nums1 + symbol2 + word3 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + word3 + nums2 + symbol1 + word2 + symbol2 + word4;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + word4 + symbol3 + nums1 + nums2 + word3 + nums3 + nums4 + nums5 + word2;
                                password2 = word2 + nums4 + nums5 + nums2 + word3 + nums3 + nums1 + word4 + symbol2 + symbol3 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + word4 + nums2 + symbol1 + word2 + symbol2 + nums5 + word3 + nums4;
                            }
                        }
                        //symbols = 5 
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + symbol2 + word4 + symbol3 + word3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + word2;
                                password2 = nums1 + nums2 + word2 + nums3 + symbol5 + symbol3 + word3 + symbol4 + word4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word2 + symbol4 + nums2 + nums3 + word4 + nums1 + symbol3 + word1 + symbol2 + symbol1 + word3;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + symbol4 + word4 + symbol5 + nums1 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = nums1 + word2 + nums2 + nums3 + nums4 + nums5 + word3 + symbol5 + symbol3 + symbol4 + word4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word4 + symbol4 + nums2 + word2 + nums3 + nums1 + symbol3 + word1 + symbol2 + symbol1 + word3 + nums4 + nums5;
                            }
                        }
                    }
                }
                else
                {
                    if (rdoSymbolsNo.Checked == true)
                    {
                        if (rdoNumbersNo.Checked == true)
                        {
                            password1 = word1 + word2 + word3 + word4 + word5;
                            password2 = word5 + word1 + word2 + word3 + word4;
                            password3 = word3 + word4 + word5 + word1 + word2;
                        }
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + word5 + nums1 + word3 + nums2 + word4 + nums3 + word2;
                                password2 = word2 + nums2 + word4 + word5 + nums3 + word1 + nums1 + word3;
                                password3 = word4 + nums3 + word2 + nums1 + word3 + nums2 + word5 + word1;
                            }
                            else
                            {
                                password1 = word1 + nums1 + word5 + nums2 + word3 + nums3 + nums4 + word4 + nums5 + word2;
                                password2 = word3 + nums5 + nums3 + word2 + nums4 + word5 + nums1 + word4 + nums2 + word1;
                                password3 = word2 + nums5 + word4 + nums4 + word5 + nums3 + word1 + nums2 + nums1 + word3;
                            }
                        }
                    }
                    else if (rdoNumbersNo.Checked == true)
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            password1 = word1 + symbol1 + word3 + symbol2 + word4 + symbol3 + word2 + word5;
                            password2 = word2 + symbol2 + word4 + symbol3 + word5 + word3 + symbol1 + word1;
                            password3 = word4 + symbol3 + word5 + word1 + symbol1 + word2 + symbol2 + word3;
                        }
                        else
                        {
                            password1 = word1 + symbol1 + word5 + symbol2 + word3 + symbol3 + word4 + symbol4 + symbol5 + word2;
                            password2 = word3 + symbol5 + word4 + symbol3 + word2 + symbol4 + word5 + symbol1 + symbol2 + word1;
                            password3 = word2 + symbol5 + symbol4 + word5 + symbol3 + word1 + symbol2 + word4 + symbol1 + word3;
                        }
                    }
                    else
                    {
                        if (inputSymbolRdo.Equals("3"))
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + word5 + symbol2 + word3 + symbol3 + nums1 + word4 + nums2 + nums3 + word2;
                                password2 = word2 + nums2 + nums3 + word4 + nums1 + symbol2 + word3 + symbol3 + word5 + symbol1 + word1;
                                password3 = word5 + nums1 + symbol3 + word1 + nums3 + word3 + nums2 + symbol1 + word2 + symbol2 + word4;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + word5 + symbol2 + word4 + symbol3 + nums1 + nums2 + word3 + nums3 + nums4 + nums5 + word2;
                                password2 = word2 + nums4 + nums5 + nums2 + word3 + nums3 + nums1 + word4 + symbol2 + symbol3 + word5 + symbol1 + word1;
                                password3 = nums1 + symbol3 + word1 + nums3 + word4 + nums2 + word5 + symbol1 + word2 + symbol2 + nums5 + word3 + nums4;
                            }
                        }
                        //symbols = 5 
                        else
                        {
                            if (inputNumberRdo.Equals("3"))
                            {
                                password1 = word1 + symbol1 + word5 + symbol2 + word4 + symbol3 + word3 + symbol4 + symbol5 + nums1 + nums2 + nums3 + word2;
                                password2 = nums1 + nums2 + word2 + nums3 + word5 + symbol5 + symbol3 + word3 + symbol4 + word4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word2 + symbol4 + nums2 + nums3 + word4 + nums1 + symbol3 + word1 + symbol2 + word5 + symbol1 + word3;
                            }
                            //numbers = 5
                            else
                            {
                                password1 = word1 + symbol1 + symbol2 + word3 + symbol3 + symbol4 + word4 + symbol5 + nums1 + word5 + nums2 + nums3 + nums4 + nums5 + word2;
                                password2 = nums1 + word2 + nums2 + nums3 + word5 + nums4 + nums5 + word3 + symbol5 + symbol3 + symbol4 + word4 + symbol1 + symbol2 + word1;
                                password3 = symbol5 + word4 + symbol4 + nums2 + word2 + nums3 + word5 + nums1 + symbol3 + word1 + symbol2 + symbol1 + word3 + nums4 + nums5;
                            }
                        }
                    }
                }

            }
            
        }

        public string GetPassword1
        {
            get
            {
                return password1;
            }
        }
        public string GetPassword2
        {
            get
            {
                return password2;
            }
        }
        public string GetPassword3
        {
            get
            {
                return password3;
            }
        }

    }

}
