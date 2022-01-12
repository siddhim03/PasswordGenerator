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
        private bool symbols = false;
        private bool numbers = false;
        private bool maxCharLength = false;
        private string maxCharNum = "";

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
            this.constraintsMethod();
            this.Dispose();
        }

        private void initializeMyGroupBox()
        {
            // Create and initialize a GroupBox
            Panel panelSymbols = new Panel();
            Panel panelNumbers = new Panel();

            // Add the radio button to the GroupBox.
            panelSymbols.Controls.Add(rdoSymbolsYes);
            panelSymbols.Controls.Add(rdoSymbolsNo);

            panelNumbers.Controls.Add(rdoNumbersYes);
            panelNumbers.Controls.Add(rdoNumbersNo);

            // Add the GroupBox to the Form.
            Controls.Add(panelSymbols);
            Controls.Add(panelNumbers);
        }
        private void constraintsMethod()
        {
            if(rdoSymbolsYes.Checked)
            {
                this.symbols = true;
            }

            else if (rdoNumbersYes.Checked)
            {
                this.numbers = true;
            }

            else if (rdoMaxCharLengthYes.Checked)
            {
                this.maxCharLength = true;

            }
        }

    }
}
