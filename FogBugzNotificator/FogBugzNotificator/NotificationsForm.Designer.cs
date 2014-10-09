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
			this.viewButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.casesCountLabel = new System.Windows.Forms.Label();
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
			// viewButton
			// 
			this.viewButton.BackColor = System.Drawing.Color.Green;
			this.viewButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.viewButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.viewButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.viewButton.Location = new System.Drawing.Point(264, 99);
			this.viewButton.Name = "viewButton";
			this.viewButton.Size = new System.Drawing.Size(78, 37);
			this.viewButton.TabIndex = 1;
			this.viewButton.Text = "View";
			this.viewButton.UseVisualStyleBackColor = false;
			this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.closeButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.Location = new System.Drawing.Point(12, 99);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(78, 37);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "Ignore";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
			// NotificationsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 148);
			this.Controls.Add(this.casesCountLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.viewButton);
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
		private System.Windows.Forms.Button viewButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Label casesCountLabel;
	}
}