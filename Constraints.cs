using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private int maxWordValue;


        //methods
        public Constraints()
        {
            InitializeComponent();
        }

        private void Constraints_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();
        }

        private void setControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.initializeMyGroupBox();

            if (!this.constraintsMethod())
                return;
            
            this.Dispose();
        }

        private void initializeMyGroupBox()
        {
            // Create and initialize a GroupBox
            Panel panelSymbols = new Panel();
            Panel panelNumbers = new Panel();
            Panel panelMaxChar = new Panel();
            Panel panelWords = new Panel();

            // Add the radio button to the GroupBox.
            panelSymbols.Controls.Add(rdoSymbolsYes);
            panelSymbols.Controls.Add(rdoSymbolsNo);

            panelNumbers.Controls.Add(rdoNumbersYes);
            panelNumbers.Controls.Add(rdoNumbersNo);

            panelMaxChar.Controls.Add(rdoMaxCharLengthYes);
            panelMaxChar.Controls.Add(rdoMaxCharLengthNo);

            panelWords.Controls.Add(rdoWordsYes);
            panelWords.Controls.Add(rdoWordsNo);

            // Add the GroupBox to the Form.
            Controls.Add(panelSymbols);
            Controls.Add(panelNumbers);
            Controls.Add(panelMaxChar);
            Controls.Add(panelWords);
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

                if (String.Equals(inputMaxChar, " "))
                {
                    // The text box isn't a valid number - tell the user!
                    MessageBox.Show("Please enter a valid number!");
                    return false;
                }

                else if (String.Equals(inputMaxChar, "Yes"))
                {
                    if (!Int32.TryParse(txtMaxCharLength.Text, out maxCharValue))
                    {
                        // The text box isn't a valid number - tell the user!
                        MessageBox.Show("Please enter a valid number!");
                        return false;
                    }
                }
            }

            return true;
        }

        private bool storeWords()
        {
            if (rdoWordsYes.Checked == true)
            {
                inputWords = rdoWordsYes.Text;

                if (String.Equals(inputWords, " "))
                {
                    // The text box isn't a valid number - tell the user!
                    MessageBox.Show("Please enter a valid number!");
                    return false;
                }

                else if (String.Equals(inputWords, "Yes"))
                {
                    if (!Int32.TryParse(txtMaxCharLength.Text, out maxWordValue))
                    {
                        // The text box isn't a valid number - tell the user!
                        MessageBox.Show("Please enter a valid number!");
                        return false;
                    }
                }
            }

            return true;
        }

    }
}
