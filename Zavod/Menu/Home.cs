using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavod.Menu
{
    public partial class Home : Form
    {
        public Home()
        {          
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            RoundComponent(start);
        }

        private void RoundComponent(Control component)
        {
            int cornerRadius = 40; // Радиус закругления компонента 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(component.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(component.Width - cornerRadius, component.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, component.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            component.Region = new Region(path);
            component.BackColor = Color.FromArgb(0x79, 0xb6, 0xc9);
        }

        private void start_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.start = true;
            Properties.Settings.Default.Save();

            
        }
    }
}
