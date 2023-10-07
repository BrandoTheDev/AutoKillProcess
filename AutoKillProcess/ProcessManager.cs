using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKillProcess
{
    // This class will handle everything process related
    internal class ProcessManager
    {
        // Returns an array of processes that the user can kill
        public static Process[] GetProcessList()
        {
            // Clean list to save killable processes
            List<Process> processesWeCanKill = new List<Process>();

            // Cycle through our snapshot of running processes
            foreach (Process process in Process.GetProcesses())
            {
                // Make sure we have permission to kill the process catch if we dont
                try
                {
                    if (!process.HasExited)
                    {
                        processesWeCanKill.Add(process);
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    // Handle our exception with an Error class to be built
                    // ExceptionManager.DisplayError("Can not kill this process");        
                }
            }

            // Return our clean array list
            return processesWeCanKill.ToArray();  
        }

        public static void KillProcess(String processName)
        {
            // Iterate through our processes we know we can kill
            foreach (Process process in GetProcessList())
            {
                // See if the process name matches the one in the kill box
                if (process.ProcessName.Equals(processName))
                {
                  process.Kill(); 
                }
            }
        }
    }
}
