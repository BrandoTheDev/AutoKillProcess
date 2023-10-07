using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKillProcess
{
    // Used to handle exceptions better
    // Possibly build on to handle getting last exceptions/current/custom
    internal class ExceptionManager
    {
        private static string lastException = "";
        public static bool showLastException { get; set; } = false;

        // Sets the showLastException to true to display a message
        public static string DisplayError(string message)
        {
            showLastException = true;
            lastException = message;
            return lastException;
        }
    }
}
