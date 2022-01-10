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
            this.constraintsMethod();
            this.Dispose();
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

        private void txtMaxCharLength_TextChanged(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\siddhi\\PasswordGenerator\\txt files\\maxCharacterNumber.txt");
            txt.Write(txtMaxCharLength.Text);
            txt.Close();
        }
    }
}
