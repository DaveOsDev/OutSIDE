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
using OutSIDE.Classes;
using OutSIDE.Forms.Dialogs;
using OutSIDE.Forms.Dockable;
using OutSIDE.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace OutSIDE
{
    public partial class FrmMain : Form
    {
        private FrmCodeView _codeView;
        private FrmSolutionExplorer _solutionExplorer;

        public FrmMain()
        {
            InitializeComponent();
            ResizeMenuPadding();
#if DEBUG
            AccountModel.Name = "Dave";
            AccountModel.EmailAddress = "DaveOSDev@outlook.com"; // Use this email if you wish to contact me by that method.
            UpdateTitle();
#endif
        }

        #region Main Menu Items

        private void ResizeMenuPadding()
        {
            var mfpWidth = menuFlowPanel.Width;
            var menuMainWidth = menuMain.Width;
            var menuPaddingWidth = menuPadding.Width;
            var menuRightWidth = menuRight.Width;

            var menuExpansion = mfpWidth - (menuMainWidth + menuPaddingWidth + menuRightWidth);
            menuPadding.Width += menuExpansion;

        }

        #region File Menu

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewOs newOs = new FrmNewOs();
            DialogResult dr = newOs.ShowDialog();
            if (dr == DialogResult.Cancel) return;

            UpdateTitle();
            BareBones.CreateBareBones();
        }

        #endregion

        #region View Menu
        private void codeViewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewCodeViewDocument();
        }

        private void NewCodeViewDocument()
        {
            _codeView = new FrmCodeView();
            _codeView.Show(dockPanel, DockState.Document);
        }

        private void solutionExplorerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewSolutionExplorerWindow();
        }

        private void NewSolutionExplorerWindow()
        {
            if (solutionExplorerToolStripMenuItem.Checked)
            {
                solutionExplorerToolStripMenuItem.Checked = false;
                _solutionExplorer.Dispose();
            }
            else
            {
                _solutionExplorer = new FrmSolutionExplorer();
                _solutionExplorer.Show(dockPanel, DockState.DockRight);
                solutionExplorerToolStripMenuItem.Checked = true;
            }
        }
        #endregion

        #region Help Menu

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog();
        }

        #endregion

        #endregion

        #region Account Menu
        private void toolStripMenuItemDetails_Click(object sender, EventArgs e)
        {
            FrmAccountDetails accountDetails = new FrmAccountDetails();
            DialogResult dr = accountDetails.ShowDialog();
            if (dr == DialogResult.OK)
            {
                UpdateTitle();
            }
        }



        #endregion

        #region Events
        #region FrmMain Events
        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            ResizeMenuPadding();
        }
        #endregion
        #endregion

        #region Form Methods

        #region Main Form
        private void UpdateTitle()
        {
            Text = @"OutSide [" + OperatingSystemModel.OperatingSystemName + "] Developer " + AccountModel.Name;
        }




        #endregion

        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FirstRun();
        }

        private void FirstRun()
        {
            var outsidePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "OutSIDE");
            var defaultProjectsPath = Path.Combine(outsidePath, "Projects");

            if (!Directory.Exists(outsidePath)) Directory.CreateDirectory(outsidePath);
            if (!Directory.Exists(defaultProjectsPath)) Directory.CreateDirectory(defaultProjectsPath);
        }
    }
}
