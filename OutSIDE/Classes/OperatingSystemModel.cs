using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSIDE.Classes
{
    /// <summary>
    /// Holds information regarding the current Operating System Porject
    /// </summary>
    /// <remarks>
    /// Can Only have one Operating System loaded at a time so - can make this class static
    /// </remarks>
    internal static class OperatingSystemModel
    {
        internal enum  CpuTargets 
        {
            X86,
          //  X64,              // UnComment as each CPU Target is being implemented
          //  Mips,
          //  Itanium,
          //  Motorola68000,
        }


        internal static bool OperatingSystemProjectLoaded { get; set; }
        internal static string OperatingSystemName { get; set; }
        internal static int CpuTarget { get; set; }

    }


}
