namespace FogBugzNotificator.Popups
{
    partial class ConnectionErrorPopup
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
            this.errorMessage = new System.Windows.Forms.Label();
            this.warningPictureBox = new System.Windows.Forms.PictureBox();
            this.okButton = new FogBugzNotificator.Buttons.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.Location = new System.Drawing.Point(118, 55);
            this.errorMessage.MaximumSize = new System.Drawing.Size(310, 0);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(107, 18);
            this.errorMessage.TabIndex = 5;
            this.errorMessage.Text = "Can\'t connect to";
            // 
            // warningPictureBox
            // 
            this.warningPictureBox.Image = global::FogBugzNotificator.Properties.Resources.error_pic;
            this.warningPictureBox.Location = new System.Drawing.Point(12, 12);
            this.warningPictureBox.Name = "warningPictureBox";
            this.warningPictureBox.Size = new System.Drawing.Size(100, 100);
            this.warningPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.warningPictureBox.TabIndex = 4;
            this.warningPictureBox.TabStop = false;
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.okButton.Location = new System.Drawing.Point(341, 120);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(60, 35);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectionErrorPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 167);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.warningPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionErrorPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Error";
            ((System.ComponentModel.ISupportInitialize)(this.warningPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox warningPictureBox;
        private System.Windows.Forms.Label errorMessage;
        private Buttons.FlatButton okButton;
    }
}