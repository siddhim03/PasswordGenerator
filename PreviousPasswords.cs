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
    public partial class PreviousPasswords : Form
    {
        //variables
        public static string pass1;
        public static string pass2;
        public static string pass3;

        public PreviousPasswords()
        {
            InitializeComponent();
        }

        private void btnExitPrevPwrd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PreviousPasswords_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.setControls();

            this.lblPPassword1.Text = pass1;

            this.lblPPassword2.Text = pass2;

            this.lblPPassword3.Text = pass3;
        }

        private void setControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
        
}
