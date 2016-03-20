using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutSIDE.Forms.Dialogs;
using OutSIDE.Forms.Dockable;
using WeifenLuo.WinFormsUI.Docking;

namespace OutSIDE
{
    public partial class FrmMain : Form
    {
        private FrmCodeView codeView;
        private FrmSolutionExplorer solutionExplorer;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region Menu Items

        #region View Menu
        private void codeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codeView = new FrmCodeView();
            codeView.Show(dockPanel, DockState.Document);
        }

        private void solutionExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (solutionExplorerToolStripMenuItem.Checked)
            {
                solutionExplorerToolStripMenuItem.Checked = false;
                solutionExplorer.Dispose();
            }
            else
            {
                solutionExplorer = new FrmSolutionExplorer();
                solutionExplorer.Show(dockPanel, DockState.DockRight);
                solutionExplorerToolStripMenuItem.Checked = true;
            }
        }
        #endregion

        #region Help Menu
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        #endregion

        #endregion

        
    }
}
