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
        public string pass1 { get; set; }
        public string pass2 { get; set; }
        public string pass3 { get; set; }

        int row0 = 0;
        int row1 = 1;
        int row2 = 2;

        int passNum1 = 1;
        int passNum2 = 2;
        int passNum3 = 3;


        DataTable table = new DataTable("tbl");

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
            

            table.Columns.Add("Password Number", typeof(int));
            table.Columns.Add("Password", typeof(string));

            table.Rows.Add(passNum1, pass1);
            table.Rows.Add(passNum2, pass2);
            table.Rows.Add(passNum3, pass3);

            dgvPass.DataSource = table;
        }

        private void setControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void export()
        {
            table.WriteXml(@"C:\siddhi\PasswordGenerator\OldPasswordsXML.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Data Saved To XMl");
        }

        private void import()
        {
            DataTable dt = new DataTable();
            dt.ReadXml(@"C:\siddhi\PasswordGenerator\OldPasswordsXML.xml");
            dgvOldPass.DataSource = dt;
            MessageBox.Show("Data Imported");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.export();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.import();
        }
    }
        
}
