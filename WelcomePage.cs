﻿using System;
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
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            Constraints constraintsForm = new Constraints();

            constraintsForm.ShowDialog();
        }

        private void btnPreviousPasswords_Click(object sender, EventArgs e)
        {
            PreviousPasswords prevPasswordsForm = new PreviousPasswords();

            prevPasswordsForm.ShowDialog();
        }
    }
}
