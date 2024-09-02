namespace Notification
{
    partial class Notify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notify));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.CloseNotification = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblMsg.Location = new System.Drawing.Point(63, 25);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(56, 14);
            this.lblMsg.TabIndex = 53;
            this.lblMsg.Text = "Message";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.msg.ForeColor = System.Drawing.Color.Cyan;
            this.msg.Location = new System.Drawing.Point(63, 8);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(91, 14);
            this.msg.TabIndex = 54;
            this.msg.Text = "Notification";
            // 
            // CloseNotification
            // 
            this.CloseNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseNotification.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloseNotification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.CloseNotification.ForeColor = System.Drawing.Color.Cyan;
            this.CloseNotification.Location = new System.Drawing.Point(295, 18);
            this.CloseNotification.Name = "CloseNotification";
            this.CloseNotification.Size = new System.Drawing.Size(31, 25);
            this.CloseNotification.TabIndex = 55;
            this.CloseNotification.Text = "X";
            this.CloseNotification.UseVisualStyleBackColor = true;
            this.CloseNotification.Click += new System.EventHandler(this.CloseNotification_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Location = new System.Drawing.Point(-10, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 25);
            this.panel1.TabIndex = 56;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(338, 62);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseNotification);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Notify";
            this.Load += new System.EventHandler(this.Notify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button CloseNotification;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Timer timer1;
    }
}