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

        public string answer1;
        public string answer2;
        public string answer3;
        public string answer4;
        public string answer5;



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

            this.DisplayQuestions();
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
            {   "What’s the first thing you grab for in the morning?",
                "Cats or dogs or neither?",
                "Beaches or snow?",
                "Favorite music artist?",
                "Who's your celebrity crush?",
                "Your favorite hobby?",
                "What's one thing you could do all day?",
                "Your favorite animal?",
                "Your favorite day of the week?",
                "What's your mood when you wake up?"
            };

        public string[] lstQuestions3 =
            {   "One thing you love about Summer",
                "One thing you love about Winter",
                "One thing you love about Fall",
                "One thing you love about Spring",
                "What's a place you would visit again?",
                "Your role model?",
                "Your favorite meal of the day?",
                "What's a language you would want to learn?",
                "What's a skill you think everyone should know?",
                "What's your favorite part of the house?"
            };

        public string[] lstQuestions4 =
            {   "If you could be any animal what would it be?",
                "What is your favorite summer activity?",
                "Who is your favorite super hero?",
                "Are you a morning or a night person?",
                "What are you most afraid of?",
                "What stresses you out the most?",
                "Money or Love?",
                "Favorite word?",
                "One thing you are obsessed with?",
                "Where were you born?"
            };

        public string[] lstQuestions5 =
            {   "What's your favorite drink?",
                "What is your least favorite beverage?",
                "If you could swim in any liquid what would it be?",
                "What is your least favorite type of music?",
                "What is your favorite genre of music?",
                "Morning, noon, or night?",
                "What is one item you could never live without?",
                "Chocolate or Cheese?",
                "Your favorite season?",
                "Coffee or Tea?"
            };

        private void DisplayQuestions()
        {
            if (maxWordValue == 1)
            {
                //making questions appear
                lblQuestion1.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;

                int initialValue1 = randomize.Next(lstQuestions1.Length);

                lblQuestion1.Text = lstQuestions1[initialValue1];

                //storing answers in variables
                answer1 = txtAnswer1.Text;
            }

            else if (maxWordValue == 2)
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

                //storing answers in variables
                answer1 = txtAnswer1.Text;
                answer2 = txtAnswer2.Text;

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

                //storing answers in variables
                answer1 = txtAnswer1.Text;
                answer2 = txtAnswer2.Text;
                answer3 = txtAnswer3.Text;
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

                //storing answers in variables
                answer1 = txtAnswer1.Text;
                answer2 = txtAnswer2.Text;
                answer3 = txtAnswer3.Text;
                answer4 = txtAnswer4.Text;
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

                //storing answers in variables
                answer1 = txtAnswer1.Text;
                answer2 = txtAnswer2.Text;
                answer3 = txtAnswer3.Text;
                answer4 = txtAnswer4.Text;
                answer5 = txtAnswer5.Text;
            }
        }

        public string GetAnswer1 
        { 
            get
            {
                return txtAnswer1.Text;
            }
        }
        public string GetAnswer2
        {
            get{ 
                return txtAnswer2.Text; 
            }
        }
        public string GetAnswer3
        {
            get
            {
                return txtAnswer3.Text;
            }
        }
        public string GetAnswer4
        {
            get
            {
                return txtAnswer4.Text;
            }
        }
        public string GetAnswer5
        {
            get
            {
                return txtAnswer5.Text;
            }
        }

        public string GetQuestion1
        {
            get
            {
                return lblQuestion1.Text;
            }
        }
        public string GetQuestion2
        {
            get
            {
                return lblQuestion2.Text;
            }
        }
        public string GetQuestion3
        {
            get
            {
                return lblQuestion3.Text;
            }
        }
        public string GetQuestion4
        {
            get
            {
                return lblQuestion4.Text;
            }
        }
        public string GetQuestion5
        {
            get
            {
                return lblQuestion5.Text;
            }
        }

        private void btnSubmitQA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
