namespace FogBugzApi
{
	partial class NotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.casesCountLabel = new System.Windows.Forms.Label();
            this.viewButton = new FogBugzNotificator.Buttons.FlatButton();
            this.ignoreButton = new FogBugzNotificator.Buttons.FlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "You got new case(s) assigned to you!";
            // 
            // casesCountLabel
            // 
            this.casesCountLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.casesCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.casesCountLabel.Image = ((System.Drawing.Image)(resources.GetObject("casesCountLabel.Image")));
            this.casesCountLabel.Location = new System.Drawing.Point(14, 13);
            this.casesCountLabel.Name = "casesCountLabel";
            this.casesCountLabel.Size = new System.Drawing.Size(50, 50);
            this.casesCountLabel.TabIndex = 3;
            this.casesCountLabel.Text = "100";
            this.casesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.viewButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.Location = new System.Drawing.Point(267, 101);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 35);
            this.viewButton.TabIndex = 4;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // ignoreButton
            // 
            this.ignoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ignoreButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ignoreButton.Location = new System.Drawing.Point(13, 100);
            this.ignoreButton.Name = "ignoreButton";
            this.ignoreButton.Size = new System.Drawing.Size(75, 35);
            this.ignoreButton.TabIndex = 5;
            this.ignoreButton.Text = "Ignore";
            this.ignoreButton.UseVisualStyleBackColor = true;
            this.ignoreButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 148);
            this.Controls.Add(this.ignoreButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.casesCountLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "NotificationsForm";
            this.Text = "FogBugz Notificator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label casesCountLabel;
        private FogBugzNotificator.Buttons.FlatButton viewButton;
        private FogBugzNotificator.Buttons.FlatButton ignoreButton;
	}
}