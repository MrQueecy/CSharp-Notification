namespace Notification
{
    partial class Main
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
            this.ActiveNotification = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActiveNotification
            // 
            this.ActiveNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ActiveNotification.Cursor = System.Windows.Forms.Cursors.Default;
            this.ActiveNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActiveNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.ActiveNotification.ForeColor = System.Drawing.Color.Cyan;
            this.ActiveNotification.Location = new System.Drawing.Point(105, 110);
            this.ActiveNotification.Name = "ActiveNotification";
            this.ActiveNotification.Size = new System.Drawing.Size(240, 53);
            this.ActiveNotification.TabIndex = 0;
            this.ActiveNotification.Text = "Active notification";
            this.ActiveNotification.UseVisualStyleBackColor = true;
            this.ActiveNotification.Click += new System.EventHandler(this.ActiveNotification_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.ActiveNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActiveNotification;
    }
}