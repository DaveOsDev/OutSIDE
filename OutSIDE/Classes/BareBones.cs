using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutSIDE.Classes
{
    internal static class BareBones
    {

        internal static void CreateBareBones()
        {
            switch (OperatingSystemModel.CpuTarget)
            {
                case 1: // x86
                    Scaffoldx86();
                    break;
                case 2: // x64
                    Scaffoldx64();
                    break;
                default:
                    MessageBox.Show("Unknown Target CPU", "Target CPU Not Recognised", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
            }
        }

        private static void Scaffoldx64()
        {
            CreateSolutionFolder();
        }

        private static void CreateSolutionFolder()
        {
            //TODO: Default Projects Folder should be generated during setup - allowing user to change the location.
            //TODO: Change these to Settings.Default 
            var outsidePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"outside");
            var defaultProjectsPath = Path.Combine(outsidePath, "projects");
            
            // create project folder using sane OsName
            var saneName = OperatingSystemModel.OperatingSystemName.Replace(" ", "-");
            var projectPath = Path.Combine(defaultProjectsPath, saneName);

            // Check to see if the project already exists
            if (Directory.Exists(projectPath))
            {
                DialogResult dr = MessageBox.Show(
                    "This Operating System Already Exists!" + Environment.NewLine +
                    "Yes to Open Solution, No to Overwrite", "Open Solution?", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (dr)
                {
                    case DialogResult.Yes:
                        //TODO: Raise Event in FrmMain to Open Solution.
                        return;
                    case DialogResult.Cancel:
                        return;
                }
            }

            Directory.CreateDirectory(projectPath);

        }

        private static void Scaffoldx86()
        {
            CreateSolutionFolder();
        }
    }
}
