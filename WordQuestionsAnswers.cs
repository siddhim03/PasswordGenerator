using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class WordQuestionsAnswers : Form
    {
        //variable
        public int maxWordValue;
        Random randomize = new Random();
        

        public WordQuestionsAnswers()
        {
            InitializeComponent();
        }

        private void WordQuestionsAnswers_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            //making questions disappear
            lblQuestion1.Visible = false;
            lblQuestion2.Visible = false;
            lblQuestion3.Visible = false;
            lblQuestion4.Visible = false;
            lblQuestion5.Visible = false;

            //making answer textboxes disappear
            txtAnswer1.Visible = false;
            txtAnswer2.Visible = false;
            txtAnswer3.Visible = false;
            txtAnswer4.Visible = false;
            txtAnswer5.Visible = false;
        }

        public string[] lstQuestions1 = 
            {   "What did you eat today?",
                "What's your favorite color",
                "First animal you can think of?",
                "Favorite ice cream flavor?",
                "What color is your hair?",
                "Birthday month?",
                "What's your first pet's name?",
                "Somewhere you want to visit?",
                "Your most used brand?",
                "A word to describe your personality?"
            };

        public string[] lstQuestions2 =
            {   "What did you eat today?",
                "What's your favorite color",
                "First animal you can think of?",
                "Favorite ice cream flavor?",
                "What color is your hair?",
                "Birthday month?",
                "What's your first pet's name?",
                "Somewhere you want to visit?",
                "Your most used brand?",
                "A word to describe your personality?"
            };

        public string[] lstQuestions3 =
            {   "What did you eat today?",
                "What's your favorite color",
                "First animal you can think of?",
                "Favorite ice cream flavor?",
                "What color is your hair?",
                "Birthday month?",
                "What's your first pet's name?",
                "Somewhere you want to visit?",
                "Your most used brand?",
                "A word to describe your personality?"
            };

        public string[] lstQuestions4 =
            {   "What did you eat today?",
                "What's your favorite color",
                "First animal you can think of?",
                "Favorite ice cream flavor?",
                "What color is your hair?",
                "Birthday month?",
                "What's your first pet's name?",
                "Somewhere you want to visit?",
                "Your most used brand?",
                "A word to describe your personality?"
            };

        public string[] lstQuestions5 =
            {   "What did you eat today?",
                "What's your favorite color",
                "First animal you can think of?",
                "Favorite ice cream flavor?",
                "What color is your hair?",
                "Birthday month?",
                "What's your first pet's name?",
                "Somewhere you want to visit?",
                "Your most used brand?",
                "A word to describe your personality?"
            };

        private void btnGenerateQuestions_Click(object sender, EventArgs e)
        {
            if (maxWordValue == 0 || maxWordValue == 2)
            {
                //making questions appear
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);
                int initialValue2 = randomize.Next(lstQuestions2.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];
                lblQuestion2.Text = lstQuestions2[initialValue2];
            }
            else if(maxWordValue == 1)
            {
                //making questions appear
                lblQuestion1.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];
            }
            else if (maxWordValue == 3)
            {
                //making questions appear
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;
                lblQuestion3.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;
                txtAnswer3.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);
                int initialValue2 = randomize.Next(lstQuestions2.Length);
                int initialValue3 = randomize.Next(lstQuestions3.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];
                lblQuestion2.Text = lstQuestions2[initialValue2];
                lblQuestion3.Text = lstQuestions3[initialValue3];
            }
            else if (maxWordValue == 4)
            {
                //making questions appear
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;
                lblQuestion3.Visible = true;
                lblQuestion4.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;
                txtAnswer3.Visible = true;
                txtAnswer4.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);
                int initialValue2 = randomize.Next(lstQuestions2.Length);
                int initialValue3 = randomize.Next(lstQuestions3.Length);
                int initialValue4 = randomize.Next(lstQuestions4.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];
                lblQuestion2.Text = lstQuestions2[initialValue2];
                lblQuestion3.Text = lstQuestions3[initialValue3];
                lblQuestion4.Text = lstQuestions4[initialValue4];
            }
            else
            {
                //making questions appear
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;
                lblQuestion3.Visible = true;
                lblQuestion4.Visible = true;
                lblQuestion5.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;
                txtAnswer3.Visible = true;
                txtAnswer4.Visible = true;
                txtAnswer5.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);
                int initialValue2 = randomize.Next(lstQuestions2.Length);
                int initialValue3 = randomize.Next(lstQuestions3.Length);
                int initialValue4 = randomize.Next(lstQuestions4.Length);
                int initialValue5 = randomize.Next(lstQuestions5.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];
                lblQuestion2.Text = lstQuestions2[initialValue2];
                lblQuestion3.Text = lstQuestions3[initialValue3];
                lblQuestion4.Text = lstQuestions4[initialValue4];
                lblQuestion5.Text = lstQuestions5[initialValue5];
            }
        }

        private void btnSubmitQA_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
