namespace FogBugzNotificator
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.casesListView = new System.Windows.Forms.ListView();
			this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.casesAssignedToYouLabel = new System.Windows.Forms.Label();
			this.refreshCasesListButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// casesListView
			// 
			this.casesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Title,
            this.Status,
            this.Priority});
			this.casesListView.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.casesListView.FullRowSelect = true;
			this.casesListView.Location = new System.Drawing.Point(12, 65);
			this.casesListView.Name = "casesListView";
			this.casesListView.Size = new System.Drawing.Size(1079, 547);
			this.casesListView.TabIndex = 0;
			this.casesListView.UseCompatibleStateImageBehavior = false;
			this.casesListView.View = System.Windows.Forms.View.Details;
			this.casesListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.casesListView_MouseClick);
			this.casesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.casesListView_MouseDoubleClick);
			// 
			// Id
			// 
			this.Id.Text = "Id";
			// 
			// Title
			// 
			this.Title.Text = "Title";
			this.Title.Width = 794;
			// 
			// Status
			// 
			this.Status.Text = "Status";
			this.Status.Width = 92;
			// 
			// Priority
			// 
			this.Priority.Text = "Priority";
			this.Priority.Width = 127;
			// 
			// casesAssignedToYouLabel
			// 
			this.casesAssignedToYouLabel.AutoSize = true;
			this.casesAssignedToYouLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.casesAssignedToYouLabel.Location = new System.Drawing.Point(3, 26);
			this.casesAssignedToYouLabel.Name = "casesAssignedToYouLabel";
			this.casesAssignedToYouLabel.Size = new System.Drawing.Size(160, 19);
			this.casesAssignedToYouLabel.TabIndex = 1;
			this.casesAssignedToYouLabel.Text = "Cases assigned to you:";
			// 
			// refreshCasesListButton
			// 
			this.refreshCasesListButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.refreshCasesListButton.Location = new System.Drawing.Point(1015, 30);
			this.refreshCasesListButton.Name = "refreshCasesListButton";
			this.refreshCasesListButton.Size = new System.Drawing.Size(75, 29);
			this.refreshCasesListButton.TabIndex = 2;
			this.refreshCasesListButton.Text = "Refresh";
			this.refreshCasesListButton.UseVisualStyleBackColor = true;
			this.refreshCasesListButton.Click += new System.EventHandler(this.refreshCasesListButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// trayIcon
			// 
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "notifyIcon1";
			this.trayIcon.Visible = true;
			this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1103, 620);
			this.Controls.Add(this.refreshCasesListButton);
			this.Controls.Add(this.casesAssignedToYouLabel);
			this.Controls.Add(this.casesListView);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "FogBugz Notificator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView casesListView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.Label casesAssignedToYouLabel;
        private System.Windows.Forms.Button refreshCasesListButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon trayIcon;
    }
}