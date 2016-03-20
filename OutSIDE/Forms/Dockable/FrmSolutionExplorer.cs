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
using WeifenLuo.WinFormsUI.Docking;

namespace OutSIDE.Forms.Dockable
{
    //TODO: Raise Event telling FrmMain that the window is closing so that it can reset the check in the view menu entry or hide the window instead if that is the default operation for the IDE (Set by User)

    public partial class FrmSolutionExplorer : DockContent
    {
        public FrmSolutionExplorer()
        {
            InitializeComponent();
            messagePanel.Visible = !OperatingSystemModel.OperatingSystemProjectLoaded;
        }
    }
}
