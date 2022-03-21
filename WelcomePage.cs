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
    public partial class WelcomePage : Form
    {
        //variables
        public int maxWordValue;

        public static string pass1;
        public static string pass2;
        public static string pass3;


        public WelcomePage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void WelcomePage_Load(object sender, EventArgs e)
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

            lblPassword1.Visible = false;
            lblPassword2.Visible = false;
            lblPassword3.Visible = false;
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            Constraints constraintsForm = new Constraints();

            constraintsForm.ShowDialog();

            using (constraintsForm)
            {
                lblPassword1.Visible = true;
                lblPassword2.Visible = true;
                lblPassword3.Visible = true;

                this.lblPassword1.Text = constraintsForm.GetPassword1.Trim();
                pass1 = constraintsForm.GetPassword1.Trim();

                this.lblPassword2.Text = constraintsForm.GetPassword2.Trim();
                pass2 = constraintsForm.GetPassword1.Trim();

                this.lblPassword3.Text = constraintsForm.GetPassword3.Trim();
                pass3 = constraintsForm.GetPassword1.Trim();

            }
        }

        public string[] passList = { pass1, pass2, pass3 };

        private void btnPreviousPasswords_Click(object sender, EventArgs e)
        {
            PreviousPasswords prevPasswordsForm = new PreviousPasswords();

            prevPasswordsForm.ShowDialog();
        }
    }
}
