using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using System.Net;
using Zavod.Menu;

namespace Zavod
{
    public partial class Login : Form
    {
        private const int CornerRadius = 40;
        public Login()
        {
            InitializeComponent();
            this.TransparencyKey = Color.OldLace;
            DoubleBuffered = true;
            RoundComponent(enter);         
        }


        private void Login_Load(object sender, EventArgs e)
        {
            rememberMe.Checked = Properties.Settings.Default.Remember;
            if (rememberMe.Checked)
            {
                Password.PasswordChar = '*';
                Username.Text = Properties.Settings.Default.Username;
                Password.Text = Properties.Settings.Default.Password;
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





        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool isDragging = false;
        private Point offset;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            offset = new Point(e.X, e.Y);
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.Location;
                newLocation.X += e.X - offset.X;
                newLocation.Y += e.Y - offset.Y;
                this.Location = newLocation;
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Registrator reg = new Registrator();
            this.Hide();
            reg.Show();
        }

        private void passwordEye_MouseDown(object sender, MouseEventArgs e)
        {
            passwordEye.Image = Zavod.Properties.Resources.free_icon_eye_159604;
            Password.PasswordChar = '\0';
        }

        private void passwordEye_MouseUp(object sender, MouseEventArgs e)
        {
            passwordEye.Image = Zavod.Properties.Resources.free_icon_eye_7615155;
            Password.PasswordChar = '*';

            if (Password.Text == "Password")
            {
                Password.PasswordChar = '\0';
            }
        }

        private void Username_MouseUp(object sender, MouseEventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
            }
            Username.ForeColor = Color.Black;
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Gray;
            }
        }

        private void Password_MouseUp(object sender, MouseEventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                Password.PasswordChar = '*';               
            }
            Password.ForeColor = Color.Black;
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.Gray;
                Password.PasswordChar = '\0';
            }
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

        private void enter_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            if (Password.Text == "Password" && Username.Text == "Username")
            {
                error.Text = "Введите имя и пароль";
                Username.ForeColor = Color.Red;
                Password.ForeColor = Color.Red;
                error.ForeColor = Color.Black;

                Properties.Settings.Default.notify = "Введите имя и пароль!";
                Properties.Settings.Default.Save();
                notification.Show();

            }
            else if (Username.Text == "Username")
            {
                error.Text = "Введите имя";
                Username.ForeColor = Color.Red;
                error.ForeColor = Color.Black;

                Properties.Settings.Default.notify = "Введите имя!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (Password.Text == "Password")
            {
                error.Text = "Введите пароль";
                Password.ForeColor = Color.Red;
                error.ForeColor = Color.Black;

                Properties.Settings.Default.notify = "Введите пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }

            else
            {
                string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";

                // Проверка, существует ли такой же username в базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM registerform WHERE username = @username";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@username", Username.Text);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count == 1)
                        {
                            // Username существует, теперь нужно проверить пароль
                            string passwordQuery = "SELECT password FROM registerform WHERE username = @username";
                            using (SqlCommand passwordCommand = new SqlCommand(passwordQuery, connection))
                            {
                                passwordCommand.Parameters.AddWithValue("@username", Username.Text);
                                string storedPassword = (string)passwordCommand.ExecuteScalar();

                                if (Password.Text == storedPassword)
                                {                                  
                                    if (rememberMe.Checked)
                                    {
                                        Properties.Settings.Default.Username = Username.Text;
                                        Properties.Settings.Default.Password = Password.Text;
                                        Properties.Settings.Default.Remember = rememberMe.Checked;
                                        Properties.Settings.Default.Save();
                                    }
                                    notification.Close();
                                    Properties.Settings.Default.succes = "Успешный вход!";
                                    Properties.Settings.Default.Save();
                                    Succes succes = new Succes();
                                    succes.Show();
                                   
                                    Main main = new Main();                                   
                                    main.Show();
                                    this.Hide();
                                    

                                }
                                    else
                                {
                                    error.Text = "Неверный пароль";
                                    Password.ForeColor = Color.Red;

                                    Properties.Settings.Default.notify = "Неверный пароль!";
                                    Properties.Settings.Default.Save();
                                    notification.Show();
                                }
                            }
                        }
                        else
                        {
                            error.Text = "Неверное имя";
                            Username.ForeColor = Color.Red;

                            Properties.Settings.Default.notify = "Неверное имя!";
                            Properties.Settings.Default.Save();
                            notification.Show();
                        }
                    }

                }
            }

        }

        private void rememberMe_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Remember = rememberMe.Checked;
            Properties.Settings.Default.Save();
            if (!rememberMe.Checked)
            {
                Properties.Settings.Default.Username = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}

