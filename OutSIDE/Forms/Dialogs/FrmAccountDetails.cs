using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutSIDE.Classes;

namespace OutSIDE.Forms.Dialogs
{
    public partial class FrmAccountDetails : Form
    {
        public FrmAccountDetails()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbName.Text == string.Empty || tbEmail.Text == string.Empty)
            {
                MessageBox.Show("Name and Email must be added for inclusion in License Headers", "Incomplete Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccountModel.Name = tbName.Text;
                AccountModel.EmailAddress = tbEmail.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
