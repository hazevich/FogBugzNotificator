namespace FogBugzNotificator.Popups
{
    partial class AboutPopup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.developerLink = new System.Windows.Forms.LinkLabel();
            this.projectLink = new System.Windows.Forms.LinkLabel();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FogBugzNotificator.Properties.Resources.mainlogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Developed by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project link";
            // 
            // developerLink
            // 
            this.developerLink.AutoSize = true;
            this.developerLink.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerLink.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.developerLink.Location = new System.Drawing.Point(186, 111);
            this.developerLink.Name = "developerLink";
            this.developerLink.Size = new System.Drawing.Size(23, 18);
            this.developerLink.TabIndex = 8;
            this.developerLink.TabStop = true;
            this.developerLink.Text = "TC";
            this.developerLink.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.developerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.developerLink_LinkClicked);
            // 
            // projectLink
            // 
            this.projectLink.AutoSize = true;
            this.projectLink.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLink.LinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.projectLink.Location = new System.Drawing.Point(161, 129);
            this.projectLink.Name = "projectLink";
            this.projectLink.Size = new System.Drawing.Size(48, 18);
            this.projectLink.TabIndex = 9;
            this.projectLink.TabStop = true;
            this.projectLink.Text = "github";
            this.projectLink.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.projectLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.projectLink_LinkClicked);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(143, 93);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(66, 18);
            this.versionLabel.TabIndex = 10;
            this.versionLabel.Text = "BETA v1.1";
            // 
            // AboutPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 160);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.projectLink);
            this.Controls.Add(this.developerLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel developerLink;
        private System.Windows.Forms.LinkLabel projectLink;
        private System.Windows.Forms.Label versionLabel;
    }
}