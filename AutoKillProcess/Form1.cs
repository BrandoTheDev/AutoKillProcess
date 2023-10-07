using System;
using System.Diagnostics;
using System.Windows.Forms;

/*
 * 
 * ROADMAP/TODO:
 * BREAK CODE DOWN INTO CLASSES
 * SETUP TESTING
 * HANDLE EXCEPTIONS
 * MAYBE ADD A SAVE FILE?
 * 
 */

namespace AutoKillProcess
{
    public partial class Form1 : Form
    {
        private ColumnHeader processIdHeader;
        private ColumnHeader processNameHeader;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * This function serves to setup our columns and headers,
         * making sure everything fits within the control and,
         * doesnt overflow
         */
        private void properlySetupListView()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            processIdHeader = new ColumnHeader();
            processNameHeader = new ColumnHeader();

            lvAvailableProcesses.View = View.Details;

            processIdHeader.Text = "PID";
            processNameHeader.Text = "Name";

            processNameHeader.Width = 200;

            lvAvailableProcesses.Columns.Add(processNameHeader);
            lvAvailableProcesses.Columns.Add(processIdHeader);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            this.Text = "AK-Process v2.4.5";
            
            properlySetupListView();
            populateProcessList();
        }

        private void populateProcessList()
        {
            // Empty out our listview
            lvAvailableProcesses.Items.Clear();

            // Cycle through killable processes
            foreach (Process process in ProcessManager.GetProcessList())
            {
                // Make sure the process isnt in the kill box
                if (lbAutoKillProcesses.Items.Contains(process.ProcessName)) continue;

                // Add it to the running list as "ProcessName | PID"
                ListViewItem item = lvAvailableProcesses.Items.Add(process.ProcessName); // Name
                item.SubItems.Add(process.Id.ToString());                               // PID
            }
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            if(lvAvailableProcesses.SelectedItems.Count <= 0)
            {
                lblMessage.Text = ExceptionManager.DisplayError("Please select an item first!");
                lblMessage.Visible = ExceptionManager.showLastException;
                return;
            }

            foreach(ListViewItem item in lvAvailableProcesses.SelectedItems)
            {
                // Remove it from the running list
                lvAvailableProcesses.Items.Remove(item);

                // Check if its name already exists
                if (lbAutoKillProcesses.Items.Contains(item.Text)) continue;

                // Add it to our kill list
                lbAutoKillProcesses.Items.Add(item.Text);

                // Refresh the list
                populateProcessList();
            }
        }

        private void btnRefreshProcesses_Click(object sender, EventArgs e)
        {
            populateProcessList();
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if(lbAutoKillProcesses.SelectedItems.Count <= 0)
            {
                
                lblMessage.Text = ExceptionManager.DisplayError("Please select a process to remove!");
                lblMessage.Visible = ExceptionManager.showLastException;
                return;
            }

            var item = lbAutoKillProcesses.SelectedItem;
            lbAutoKillProcesses.Items.Remove(item);
            populateProcessList();
        }

        private void btnClearAllProcesses_Click(object sender, EventArgs e)
        {
            if(lbAutoKillProcesses.Items.Count <= 0)
            {
                lblMessage.Text = ExceptionManager.DisplayError("List is already empty!");
                lblMessage.Visible = ExceptionManager.showLastException;
                return;
            }

            lbAutoKillProcesses.Items.Clear();
            populateProcessList();
        }

        private void timerProcessKiller_Tick(object sender, EventArgs e)
        {
            foreach(var item in lbAutoKillProcesses.Items)
            {
                ProcessManager.KillProcess(item.ToString());
            }
            
        }

        private void DarkTheme()
        {
            // Main form
            this.BackColor = ThemeColors.DarkBackgroundColor;
            this.ForeColor = ThemeColors.DarkForegroundColor;

            // List view (left side)
            lvAvailableProcesses.BackColor = ThemeColors.DarkBackgroundColor;
            lvAvailableProcesses.ForeColor = ThemeColors.DarkForegroundColor;

            // List box (right side)
            lbAutoKillProcesses.BackColor = ThemeColors.DarkBackgroundColor;
            lbAutoKillProcesses.ForeColor = ThemeColors.DarkForegroundColor;

            // Button Controls
            btnAddProcess.BackColor = ThemeColors.DarkBackgroundColor;
            btnAddProcess.ForeColor = ThemeColors.DarkForegroundColor;

            btnRemoveProcess.BackColor = ThemeColors.DarkBackgroundColor;
            btnRemoveProcess.ForeColor = ThemeColors.DarkForegroundColor;

            btnClearAllProcesses.BackColor = ThemeColors.DarkBackgroundColor;
            btnClearAllProcesses.ForeColor  = ThemeColors.DarkForegroundColor;
            
            btnRefreshProcesses.BackColor = ThemeColors.DarkBackgroundColor;
            btnRefreshProcesses.ForeColor = ThemeColors.DarkForegroundColor;

        }

        private void LightTheme()
        {
            // Main app
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ForeColor = System.Drawing.SystemColors.ControlText;

            // List view (left side)
            lvAvailableProcesses.BackColor = System.Drawing.SystemColors.Control;
            lvAvailableProcesses.ForeColor = ThemeColors.LightForegroundColor;

            // List box (right side)
            lbAutoKillProcesses.BackColor = System.Drawing.SystemColors.Control;
            lbAutoKillProcesses.ForeColor = ThemeColors.LightForegroundColor;

            // Button Controls
            btnAddProcess.BackColor = ThemeColors.LightBackgroundColor;
            btnAddProcess.ForeColor = ThemeColors.LightForegroundColor;

            btnRemoveProcess.BackColor = ThemeColors.LightBackgroundColor;
            btnRemoveProcess.ForeColor = ThemeColors.LightForegroundColor;

            btnClearAllProcesses.BackColor = ThemeColors.LightBackgroundColor;
            btnClearAllProcesses.ForeColor = ThemeColors.LightForegroundColor;

            btnRefreshProcesses.BackColor = ThemeColors.LightBackgroundColor;
            btnRefreshProcesses.ForeColor = ThemeColors.LightForegroundColor;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DarkTheme();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LightTheme();
        }

        private void timerExceptionMessage_Tick(object sender, EventArgs e)
        {
            // Hide our messages after 3 seconds
            ExceptionManager.showLastException = false;
            lblMessage.Visible = false;
        }
    }
}
