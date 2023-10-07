namespace AutoKillProcess
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAvailableProcesses = new System.Windows.Forms.Label();
            this.lblAutoKillProcesses = new System.Windows.Forms.Label();
            this.lbAutoKillProcesses = new System.Windows.Forms.ListBox();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnRefreshProcesses = new System.Windows.Forms.Button();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnClearAllProcesses = new System.Windows.Forms.Button();
            this.lvAvailableProcesses = new System.Windows.Forms.ListView();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timerProcessKiller = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.timerExceptionMessage = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAvailableProcesses
            // 
            this.lblAvailableProcesses.AutoSize = true;
            this.lblAvailableProcesses.Location = new System.Drawing.Point(12, 9);
            this.lblAvailableProcesses.Name = "lblAvailableProcesses";
            this.lblAvailableProcesses.Size = new System.Drawing.Size(102, 13);
            this.lblAvailableProcesses.TabIndex = 0;
            this.lblAvailableProcesses.Text = "Available Processes";
            // 
            // lblAutoKillProcesses
            // 
            this.lblAutoKillProcesses.AutoSize = true;
            this.lblAutoKillProcesses.Location = new System.Drawing.Point(694, 9);
            this.lblAutoKillProcesses.Name = "lblAutoKillProcesses";
            this.lblAutoKillProcesses.Size = new System.Drawing.Size(94, 13);
            this.lblAutoKillProcesses.TabIndex = 2;
            this.lblAutoKillProcesses.Text = "AutoKill Processes";
            // 
            // lbAutoKillProcesses
            // 
            this.lbAutoKillProcesses.FormattingEnabled = true;
            this.lbAutoKillProcesses.Location = new System.Drawing.Point(523, 25);
            this.lbAutoKillProcesses.Name = "lbAutoKillProcesses";
            this.lbAutoKillProcesses.Size = new System.Drawing.Size(265, 394);
            this.lbAutoKillProcesses.TabIndex = 3;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Location = new System.Drawing.Point(292, 140);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(111, 70);
            this.btnAddProcess.TabIndex = 4;
            this.btnAddProcess.Text = "Add ->";
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnRefreshProcesses
            // 
            this.btnRefreshProcesses.Location = new System.Drawing.Point(292, 216);
            this.btnRefreshProcesses.Name = "btnRefreshProcesses";
            this.btnRefreshProcesses.Size = new System.Drawing.Size(111, 79);
            this.btnRefreshProcesses.TabIndex = 5;
            this.btnRefreshProcesses.Text = "Refresh";
            this.btnRefreshProcesses.UseVisualStyleBackColor = true;
            this.btnRefreshProcesses.Click += new System.EventHandler(this.btnRefreshProcesses_Click);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Location = new System.Drawing.Point(409, 140);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(107, 70);
            this.btnRemoveProcess.TabIndex = 6;
            this.btnRemoveProcess.Text = "<- Remove";
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // btnClearAllProcesses
            // 
            this.btnClearAllProcesses.Location = new System.Drawing.Point(409, 216);
            this.btnClearAllProcesses.Name = "btnClearAllProcesses";
            this.btnClearAllProcesses.Size = new System.Drawing.Size(107, 79);
            this.btnClearAllProcesses.TabIndex = 7;
            this.btnClearAllProcesses.Text = "CLEAR ALL";
            this.btnClearAllProcesses.UseVisualStyleBackColor = true;
            this.btnClearAllProcesses.Click += new System.EventHandler(this.btnClearAllProcesses_Click);
            // 
            // lvAvailableProcesses
            // 
            this.lvAvailableProcesses.HideSelection = false;
            this.lvAvailableProcesses.Location = new System.Drawing.Point(12, 25);
            this.lvAvailableProcesses.Name = "lvAvailableProcesses";
            this.lvAvailableProcesses.Size = new System.Drawing.Size(274, 394);
            this.lvAvailableProcesses.TabIndex = 8;
            this.lvAvailableProcesses.UseCompatibleStateImageBehavior = false;
            this.lvAvailableProcesses.View = System.Windows.Forms.View.Details;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(297, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(106, 13);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message for the user";
            // 
            // timerProcessKiller
            // 
            this.timerProcessKiller.Enabled = true;
            this.timerProcessKiller.Interval = 800;
            this.timerProcessKiller.Tick += new System.EventHandler(this.timerProcessKiller_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // timerExceptionMessage
            // 
            this.timerExceptionMessage.Enabled = true;
            this.timerExceptionMessage.Interval = 3000;
            this.timerExceptionMessage.Tick += new System.EventHandler(this.timerExceptionMessage_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lvAvailableProcesses);
            this.Controls.Add(this.btnClearAllProcesses);
            this.Controls.Add(this.btnRemoveProcess);
            this.Controls.Add(this.btnRefreshProcesses);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.lbAutoKillProcesses);
            this.Controls.Add(this.lblAutoKillProcesses);
            this.Controls.Add(this.lblAvailableProcesses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Loading..";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAvailableProcesses;
        private System.Windows.Forms.Label lblAutoKillProcesses;
        private System.Windows.Forms.ListBox lbAutoKillProcesses;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnRefreshProcesses;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnClearAllProcesses;
        private System.Windows.Forms.ListView lvAvailableProcesses;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timerProcessKiller;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer timerExceptionMessage;
    }
}

