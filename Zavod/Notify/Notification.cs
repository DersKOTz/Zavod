using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavod.Menu
{   
    public partial class Notification : Form
    {
        public Notification()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Point pt = Screen.PrimaryScreen.WorkingArea.Location;
            pt.Offset(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            pt.Offset(-this.Width, -this.Height);
            this.Location = pt;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            error.Text = Properties.Settings.Default.notify;          
        }
    }
}
