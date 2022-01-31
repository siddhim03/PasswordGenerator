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

        public string[] lstQuestions = 
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
            if (maxWordValue == 0)
            {
                //making questions appear
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;

                //making answer textboxes appear
                txtAnswer1.Visible = true;
                txtAnswer2.Visible = true;

                int initialValue = randomize.Next(lstQuestions.Length);
                
                lblQuestion1.Text = lstQuestions[initialValue];
                lblQuestion2.Text = lstQuestions[initialValue];
            }
        }

        private void btnSubmitQA_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
