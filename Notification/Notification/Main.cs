using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Notification
{
    public partial class Main : Form
    {

        public void NotifyMSG(string msg, Notify.enmType type)
        {
            Notify frm = new Notify();
            frm.showAlert(msg, type);
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ActiveNotification_Click(object sender, EventArgs e)
        {
            NotifyMSG("Notification example", Notify.enmType.Informaion);
        }
    }
}
