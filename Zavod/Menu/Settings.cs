using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zavod.Menu
{
    public partial class resetPassword : Form
    {
        public resetPassword()
        {
            InitializeComponent();
            RoundComponent(change);
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

        // !!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!

        private void newPasswordPic_MouseDown(object sender, MouseEventArgs e)
        {
            newPasswordPic.Image = Zavod.Properties.Resources.free_icon_eye_159604;
            newPassword.PasswordChar = '\0';
        }

        private void newPasswordPic_MouseUp(object sender, MouseEventArgs e)
        {
            newPasswordPic.Image = Zavod.Properties.Resources.free_icon_eye_7615155;
            newPassword.PasswordChar = '*';

            if (newPassword.Text == "Новый пароль")
            {
                newPassword.PasswordChar = '\0';
            }
        }

        private void newPassword2Pic_MouseDown(object sender, MouseEventArgs e)
        {
            newPassword2Pic.Image = Zavod.Properties.Resources.free_icon_eye_159604;
            newPassword2.PasswordChar = '\0';
        }

        private void newPassword2Pic_MouseUp(object sender, MouseEventArgs e)
        {
            newPassword2Pic.Image = Zavod.Properties.Resources.free_icon_eye_7615155;
            newPassword2.PasswordChar = '*';

            if (newPassword2.Text == "Новый пароль еще раз")
            {
                newPassword2.PasswordChar = '\0';
            }
        }

        // !!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!-!!

        private void currentPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentPassword.Text == "Текущий пароль")
            {
                currentPassword.Text = "";
                currentPassword.PasswordChar = '*';
            }
            currentPassword.ForeColor = Color.Black;
        }

        private void currentPassword_Leave(object sender, EventArgs e)
        {
            if (currentPassword.Text == "")
            {
                currentPassword.Text = "Текущий пароль";
                currentPassword.ForeColor = Color.Gray;
                currentPassword.PasswordChar = '\0';
            }
        }

        private void newPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (newPassword.Text == "Новый пароль")
            {
                newPassword.Text = "";
                newPassword.PasswordChar = '*';
            }
            newPassword.ForeColor = Color.Black;
        }

        private void newPassword_Leave(object sender, EventArgs e)
        {
            if (newPassword.Text == "")
            {
                newPassword.Text = "Новый пароль";
                newPassword.ForeColor = Color.Gray;
                newPassword.PasswordChar = '\0';
            }
        }

        private void newPassword2_MouseUp(object sender, MouseEventArgs e)
        {
            if (newPassword2.Text == "Новый пароль еще раз")
            {
                newPassword2.Text = "";
                newPassword2.PasswordChar = '*';
            }
            newPassword2.ForeColor = Color.Black;
        }

        private void newPassword2_Leave(object sender, EventArgs e)
        {
            if (newPassword2.Text == "")
            {
                newPassword2.Text = "Новый пароль еще раз";
                newPassword2.ForeColor = Color.Gray;
                newPassword2.PasswordChar = '\0';
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();

            if (currentPassword.Text == "Текущий пароль")
            {
                Properties.Settings.Default.notify = "Введите текущий пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (newPassword.Text == "Новый пароль")
            {
                Properties.Settings.Default.notify = "Введите новый пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (newPassword2.Text == "Новый пароль еще раз")
            {
                Properties.Settings.Default.notify = "Введите новый пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (currentPassword.Text != Properties.Settings.Default.Password)
            {
                Properties.Settings.Default.notify = "Неверный текущий пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else
            {
                if (currentPassword.Text == Properties.Settings.Default.Password)
                {
                    if (newPassword.Text == Properties.Settings.Default.Password)
                    {
                        Properties.Settings.Default.notify = "Текущий пароль совпадает с новым!";
                        Properties.Settings.Default.Save();
                        notification.Show();
                    } 
                    else if (newPassword.Text == newPassword2.Text)
                    {
                    string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                     
                        string updatePasswordQuery = "UPDATE registerform SET password = @password WHERE username = @username";
                            using (SqlCommand updatePasswordCommand = new SqlCommand(updatePasswordQuery, connection))
                            {
                                updatePasswordCommand.Parameters.AddWithValue("@password", newPassword.Text);
                                updatePasswordCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);

                                int rowsAffected = updatePasswordCommand.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Properties.Settings.Default.succes = "Пароль успешно изменен!";
                                    Properties.Settings.Default.Password = newPassword.Text;
                                    Properties.Settings.Default.Save();
                                    Succes succes = new Succes();
                                    succes.Show();

                                    currentPassword.Text = "Текущий пароль";
                                    currentPassword.ForeColor = Color.Gray;
                                    currentPassword.PasswordChar = '\0';

                                    newPassword.Text = "Новый пароль";
                                    newPassword.ForeColor = Color.Gray;
                                    newPassword.PasswordChar = '\0';

                                    newPassword2.Text = "Новый пароль еще раз";
                                    newPassword2.ForeColor = Color.Gray;
                                    newPassword2.PasswordChar = '\0';
                                }
                            }
                        }
                    }
                    else
                    {
                        Properties.Settings.Default.notify = "Новые пароли не совпадают!";
                        Properties.Settings.Default.Save();
                        notification.Show();
                    }
                }
                else
                {
                    Properties.Settings.Default.notify = "Неверный текущий пароль!";
                    Properties.Settings.Default.Save();
                    notification.Show();
                }
            }
        }




        private bool formLoaded = false;
        private void resetPassword_Load(object sender, EventArgs e)
        {

            if (!formLoaded) // Проверяем, была ли форма уже загружена
            {
                if (Properties.Settings.Default.admin == true)
                {
                    adminbutton.Checked = true;
                }
                else
                {
                    adminbutton.Checked = false;
                }
                Properties.Settings.Default.Save();
                formLoaded = true;
            }

            if (Properties.Settings.Default.famil == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

            if (Properties.Settings.Default.grop == true)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            Properties.Settings.Default.Save();


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
                        admin.Visible = true;
                        admin.Enabled = true;
                    }
                    else
                    {
                        admin.Visible = false;
                        admin.Enabled = false;
                    }
                    connection.Close();
                }               
            }          
        }

        private void admin_CheckedChanged(object sender, EventArgs e)
        {
            if (adminbutton.Checked)
            {
                Properties.Settings.Default.admin = true;
            }
            else
            {
                Properties.Settings.Default.admin = false;
            }
            Properties.Settings.Default.Save();
            if (formLoaded == true)
            {
                Main main = new Main();
                main.restart(this, EventArgs.Empty);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.famil = true;
            }
            else
            {
                Properties.Settings.Default.famil = false;
            }
            Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Properties.Settings.Default.grop = true;
            }
            else
            {
                Properties.Settings.Default.grop = false;
            }
            Properties.Settings.Default.Save();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

        }

    }   
}
