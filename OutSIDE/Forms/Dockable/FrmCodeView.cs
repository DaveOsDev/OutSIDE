using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OutSIDE.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace OutSIDE.Forms.Dockable
{
    public partial class FrmCodeView : DockContent
    {
        public FrmCodeView()
        {
            InitializeComponent();
            splitContainer1.Panel2Collapsed = Settings.Default.CollapseCodeMap;
        }
    }
}
