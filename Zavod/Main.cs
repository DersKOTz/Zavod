using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zavod.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zavod
{
    public partial class Main : Form
    {
        private const int CornerRadius = 40;
        public Main()
        {
            InitializeComponent();
            this.TransparencyKey = Color.OldLace;
            DoubleBuffered = true;
            RoundComponent(Menu);
            
        }

        private void menuClose()
        {
            foreach (Control control in content.Controls)
            {
                if (control is Form form)
                {
                    form.Close();
                    break; // Закрываем только первую форму и выходим из цикла
                    
                }

            }
            

            // 1060; 618

        }

        public void restart(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            home_Click(sender, e);
            Username.Text = Properties.Settings.Default.Username;           

            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM registerform WHERE admin = 1";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    int count = (int)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        adm.Visible = true;
                        admPic.Visible = true;
                        Properties.Settings.Default.admin = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        adm.Visible = false;
                        admPic.Visible = false;
                        Properties.Settings.Default.admin = false;
                        Properties.Settings.Default.Save();
                    }
                    connection.Close();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Рисуем закругленную форму 
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddLine(CornerRadius, 0, Width - CornerRadius, 0);
                path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddLine(Width, CornerRadius, Width, Height - CornerRadius);
                path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                path.AddLine(Width - CornerRadius, Height, CornerRadius, Height);
                path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                path.AddLine(0, Height - CornerRadius, 0, CornerRadius);
                using (SolidBrush brush = new SolidBrush(Color.LightBlue))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }
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

        private bool isDragging = false;
        private Point offset;
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.Image = Zavod.Properties.Resources.free_icon_clear_1632708;
            Close.BackColor = Color.FromArgb(0x79, 0xb6, 0xc9);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = Color.LightBlue;
            Close.Image = Zavod.Properties.Resources.free_icon_delete_cross_63694;
        }

        private void turn_MouseEnter(object sender, EventArgs e)
        {
            turn.BackColor = Color.FromArgb(0x79, 0xb6, 0xc9);
        }

        private void turn_MouseLeave(object sender, EventArgs e)
        {
            turn.BackColor = Color.LightBlue;
        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        public void OpenForm<T>() where T : Form, new()
        {
            menuClose();
            T newForm = new T();
            newForm.TopLevel = false;
            content.Controls.Add(newForm);
            newForm.Show();
            timer1.Enabled = false;
        }

        public void home_Click(object sender, EventArgs e)
        {
            OpenForm<Home>();
            timer1.Enabled = true;
        }

        private void teachers_Click(object sender, EventArgs e)
        {
            OpenForm<Teachers>();
        }

        private void students_Click(object sender, EventArgs e)
        {
            OpenForm<Students>();
        }

        private void schedule_Click(object sender, EventArgs e)
        {
            OpenForm<Schedule>();
        }

        private void settings_Click(object sender, EventArgs e)
        {
            OpenForm<resetPassword>();
        }

        private void help_Click(object sender, EventArgs e)
        {
            OpenForm<Menu.Help>();
        }

        private void Username_Click(object sender, EventArgs e)
        {
            OpenForm<User>();
        }

        
        private void exit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Username = null;
            Properties.Settings.Default.Password = null;
            Properties.Settings.Default.Remember = false;
            Properties.Settings.Default.Save();
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void zvonki_Click(object sender, EventArgs e)
        {
            OpenForm<Zvonki>();
        }

        private void adm_Click(object sender, EventArgs e)
        {
            OpenForm<Administration>();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.start == true)
            {
                OpenForm<User>();
                Properties.Settings.Default.start = false;
                Properties.Settings.Default.Save();
                timer1.Enabled = false;
            }           
        }
    }
}
