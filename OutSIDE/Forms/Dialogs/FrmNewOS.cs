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
using OutSIDE.Properties;

namespace OutSIDE.Forms.Dialogs
{
    public partial class FrmNewOs : Form
    {
        public FrmNewOs()
        {
            InitializeComponent();
            cbTargetCpus.DataSource = Enum.GetNames(typeof(OperatingSystemModel.CpuTargets));
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // The only thing that we must have is the OSName
            if (string.IsNullOrEmpty(tbOSName.Text))
            {
                MessageBox.Show("You must give your Operating System a Name", "OS Name Missing", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                OperatingSystemModel.OperatingSystemName = tbOSName.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cbTargetCpus_SelectedIndexChanged(object sender, EventArgs e)
        {
            OperatingSystemModel.CpuTarget = cbTargetCpus.SelectedIndex;
        }
    }
}
