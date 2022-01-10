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
