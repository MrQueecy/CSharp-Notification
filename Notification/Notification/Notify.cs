using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notification
{
    public partial class Notify : Form
    {
        private Notify.enmAction action;
        private int x, y;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Error,
            Warning,
            Informaion
            // Add more (OPTIONAL)
        }

        public Notify()
        {
            InitializeComponent();
            this.Activated += new EventHandler(this.ForceTop);

            this.FormBorderStyle = FormBorderStyle.None;
            int radius = 20;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, radius, radius));
        }

        private void ForceTop(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Notify_Load(object sender, EventArgs e)
        {
            panel1.Width = 0;
            FillPanelAsync(345);
        }

        private async void FillPanelAsync(int targetWidth)
        {
            int step = 5; 
            while (panel1.Width < targetWidth)
            {
                panel1.Width += step;
                if (panel1.Width > targetWidth)
                {
                    panel1.Width = targetWidth; 
                }
                await Task.Delay(47); 
            }
        }

        private void CloseNotification_Click(object sender, EventArgs e)
        {
            action = enmAction.close;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    await Task.Delay(4000);
                    action = enmAction.close;
                    break;
                case Notify.enmAction.start:
                    this.timer1.Interval = 5;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Notify.enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 5;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            string fname;
            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Notify frm = (Notify)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    int padding = 5; // Break
                    int horizontalOffset = 1450; // Horizontal offset 
                    int verticalOffset = 5; // Vertical displacement

                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width - horizontalOffset;
                    this.y = verticalOffset + (this.Height + padding) * (i - 1);
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            switch (type)
            {
                case enmType.Success:
                    this.msg.Text = "Success";
                    this.lblMsg.Text = msg;
                    break;
                case enmType.Error:
                    this.msg.Text = "Error";
                    this.lblMsg.Text = msg;
                    break;
                case enmType.Warning:
                    this.msg.Text = "Warning";
                    this.lblMsg.Text = msg;
                    break;
                case enmType.Informaion:
                    this.msg.Text = "Information";
                    this.lblMsg.Text = msg;
                    break;
            }

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 5;
            this.timer1.Start();
        }
    }
}
