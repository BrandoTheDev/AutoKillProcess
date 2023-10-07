using System;
using System.Diagnostics;
using System.Windows.Forms;

/*
 * 
 * ROADMAP/TODO:
 * BREAK CODE DOWN INTO CLASSES
 * MAKE THE UI PRETTY (DARK MODE?!.. YES!)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
            this.Text = "AK-Process v1.1.1";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            processIdHeader = new ColumnHeader();
            processNameHeader = new ColumnHeader();

            lvAvailableProcesses.View = View.Details;

            processIdHeader.Text = "PID";
            processNameHeader.Text = "Name";

            processNameHeader.Width = 200;

            lvAvailableProcesses.Columns.Add(processNameHeader);
            lvAvailableProcesses.Columns.Add(processIdHeader);

            RefreshProcessList();
        }

        private void RefreshProcessList()
        {
            // Empty out our listview
            lvAvailableProcesses.Items.Clear();

            // Cycle through our snapshot of running processes
            foreach (Process process in Process.GetProcesses())
            {
                // Make sure we have permission to kill the process catch if we dont
                try
                {
                    if (!process.HasExited)
                    {
                        // Make sure the process isnt already in the kill box
                        if (lbAutoKillProcesses.Items.Contains(process.ProcessName)) continue;
                         
                        ListViewItem item = lvAvailableProcesses.Items.Add(process.ProcessName);
                        item.SubItems.Add(process.Id.ToString());
                    }
                } catch (System.ComponentModel.Win32Exception win32e)
                {
                    Console.WriteLine(win32e.Message);
                    Console.WriteLine("We dont have perms to kill this process. Moving on..");
                }
            }
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            if(lvAvailableProcesses.SelectedItems.Count <= 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please select an item first!";
                return;
            }

            if(lblMessage.Visible)
            {
                lblMessage.Visible = false;
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
                RefreshProcessList();
            }
        }

        private void btnRefreshProcesses_Click(object sender, EventArgs e)
        {
            RefreshProcessList();
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if(lbAutoKillProcesses.SelectedItems.Count <= 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Please select a process to remove!";
                return;
            }

            if(lblMessage.Visible)
            {
                lblMessage.Visible = false;
            }

            var item = lbAutoKillProcesses.SelectedItem;
            lbAutoKillProcesses.Items.Remove(item);
            RefreshProcessList();
        }

        private void btnClearAllProcesses_Click(object sender, EventArgs e)
        {
            if(lbAutoKillProcesses.Items.Count <= 0)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "List is already empty!";
                return;
            }

            if(lblMessage.Visible)
            {
                lblMessage.Visible = false;
            }

            lbAutoKillProcesses.Items.Clear();
            RefreshProcessList();
        }

        private void KillProcess()
        {
            Process[] processes = Process.GetProcesses();

            // Go through our active processes
            foreach(Process process in processes)
            {
                // See if the process name matches the one in the kill box
                if(lbAutoKillProcesses.Items.Contains(process.ProcessName))
                {
                    // see if we can kill it
                    if(!process.HasExited)
                    {
                        process.Kill();
                    }
                }
            }
        }

        private void timerProcessKiller_Tick(object sender, EventArgs e)
        {
            KillProcess();
        }
    }
}
