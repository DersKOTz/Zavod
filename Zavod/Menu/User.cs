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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zavod.Menu
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
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
        private string phoneNumberUpdate;
        private void User_Load(object sender, EventArgs e)
        {
            RoundComponent(savePeople);

            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Запрос данных из базы данных для заданного username
                string query = "SELECT Фамилия, Имя, Отчество, НомерТелефона, Студент, Группа, Преподаватель, Должность, ПРОВЕРКА " +
                               "FROM People WHERE username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Устанавливаем значения из базы данных в TextBox элементы
                            name1.Text = reader["Фамилия"].ToString();
                            Properties.Settings.Default.name = reader["Имя"].ToString();
                            name3.Text = reader["Отчество"].ToString();
                            string phoneNumber = reader["НомерТелефона"].ToString();
                            phoneNumberUpdate = reader["НомерТелефона"].ToString();
                            Boolean studentt = (bool)reader["Студент"];
                            
                            student.Checked = (bool)reader["Студент"];
                            teacher.Checked = (bool)reader["Преподаватель"];
                            if (studentt == true)
                            {
                                post.Text = reader["Группа"].ToString();
                            }
                            else
                            {
                                post.Text = reader["Должность"].ToString();
                            }
                            
                            
                            

                            if (phoneNumber.Length >= 4)
                            {
                                phoneNumber = new string('*', phoneNumber.Length - 4) + phoneNumber.Substring(phoneNumber.Length - 4);
                            }
                            number.Text = phoneNumber;
                            name2.Text = Properties.Settings.Default.name;
                            Properties.Settings.Default.Save();

                            TextBox[] colors = { name1, name2, name3, number, post };

                            foreach (var color in colors)
                            {
                                color.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }

        private void passwordEye_MouseDown(object sender, MouseEventArgs e)
        {
            passwordEye.Image = Zavod.Properties.Resources.free_icon_eye_159604;
            password.PasswordChar = '\0';
        }

        private void passwordEye_MouseUp(object sender, MouseEventArgs e)
        {
            passwordEye.Image = Zavod.Properties.Resources.free_icon_eye_7615155;
            password.PasswordChar = '*';
            if (password.Text == "Password*")
            {
                password.PasswordChar = '\0';
            }
        }

        private void password_MouseUp(object sender, MouseEventArgs e)
        {
            if (password.Text == "Password*")
            {
                password.Text = "";
                password.PasswordChar = '*';
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Password*";
                password.ForeColor = Color.Gray;
                password.PasswordChar = '\0';
            }

        }

        private void student_CheckedChanged(object sender, EventArgs e)
        {
            if (student.Checked == true)
            {
                teacher.Checked = false;
                post.Text = "Группа";
                post.Visible = true;
            }
            else
            {
                post.Visible = false;
            }
            post.ForeColor = Color.Gray;
        }

        private void teacher_CheckedChanged(object sender, EventArgs e)
        {
            if (teacher.Checked == true)
            {
                student.Checked = false;
                post.Text = "Должность";
                post.Visible = true;
            }
            else
            {
                post.Visible = false;
            }
            post.ForeColor = Color.Gray;
        }

        private void post_MouseUp(object sender, MouseEventArgs e)
        {
            if (post.Text == "Должность" || post.Text == "Группа")
            {
                post.Text = "";
                post.ForeColor = Color.Black;
            }
        }

        private void post_Leave(object sender, EventArgs e)
        {
            if (post.Text == "")
            {
                if (student.Checked == true)
                {
                    post.Text = "Группа";
                }
                else
                {
                    post.Text = "Должность";
                }               
                post.ForeColor = Color.Gray;
            }
        }



        private void name3_MouseUp(object sender, MouseEventArgs e)
        {
            if (name3.Text == "Отчество")
            {
                name3.Text = "";
                name3.ForeColor = Color.Black;               
            }
        }

        private void name3_Leave(object sender, EventArgs e)
        {
            if (name3.Text == "")
            {
                name3.Text = "Отчество";
                name3.ForeColor = Color.Gray;
            }
        }

        private void name2_MouseUp(object sender, MouseEventArgs e)
        {
            if (name2.Text == "Имя*")
            {
                name2.Text = "";
                name2.ForeColor = Color.Black;
            }
        }

        private void name2_Leave(object sender, EventArgs e)
        {
            if (name2.Text == "")
            {
                name2.Text = "Имя*";
                name2.ForeColor = Color.Gray;
            }
        }

        private void name1_MouseUp(object sender, MouseEventArgs e)
        {
            if (name1.Text == "Фамилия*")
            {
                name1.Text = "";
                name1.ForeColor = Color.Black;
            }
        }

        private void name1_Leave(object sender, EventArgs e)
        {
            if (name1.Text == "")
            {
                name1.Text = "Фамилия*";
                name1.ForeColor = Color.Gray;
            }
        }

        private void number_MouseUp(object sender, MouseEventArgs e)
        {
            if (number.Text == "Номер телефона")
            {
                number.Text = "+7";
                number.ForeColor = Color.Black;
                number.Select(number.Text.Length, 0);
            }
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (number.Text == "" || number.Text == "+7")
            {
                number.Text = "Номер телефона";
                number.ForeColor = Color.Gray;
            }
        }

        private void savePeople_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            if (name1.Text == "Фамилия*" && name2.Text == "Имя*")
            {
                Properties.Settings.Default.notify = "Введите фамилию и имя!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (name1.Text == "Фамилия*")
            {
                Properties.Settings.Default.notify = "Введите фамилию!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (name2.Text == "Имя*")
            {
                Properties.Settings.Default.notify = "Введите имя!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (password.Text == "Password*")
            {
                Properties.Settings.Default.notify = "Введите пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else
            {
                if (password.Text == Properties.Settings.Default.Password)
                {
                    string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Проверяем, существует ли запись с заданным username
                        string checkUserQuery = "SELECT COUNT(*) FROM People WHERE username = @username";

                        using (SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection))
                        {
                            checkUserCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);

                            int userCount = (int)checkUserCommand.ExecuteScalar();

                            if (userCount > 0)
                            {
                                // Если запись с таким username существует, выполняем операцию UPDATE
                                string updateQuery = "UPDATE People SET Фамилия = @Фамилия, Имя = @Имя, Отчество = @Отчество, НомерТелефона = @НомерТелефона, " +
                                                     "Студент = @Студент, Группа = @Группа, Преподаватель = @Преподаватель, Должность = @Должность, ПРОВЕРКА = @ПРОВЕРКА " +
                                                     "WHERE username = @username";

                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
                                    updateCommand.Parameters.AddWithValue("@Фамилия", name1.Text);
                                    updateCommand.Parameters.AddWithValue("@Имя", name2.Text);
                                    updateCommand.Parameters.AddWithValue("@Отчество", name3.Text);
                                    if (number.Text.Substring(0, 7) == "*******")
                                    {
                                        updateCommand.Parameters.AddWithValue("@НомерТелефона", phoneNumberUpdate);
                                    }
                                    else
                                    {
                                        updateCommand.Parameters.AddWithValue("@НомерТелефона", number.Text);
                                    }
                                    
                                    updateCommand.Parameters.AddWithValue("@Студент", student.Checked);
                                    updateCommand.Parameters.AddWithValue("@Преподаватель", teacher.Checked);
                                    if (student.Checked == true )
                                    {
                                        updateCommand.Parameters.AddWithValue("@Группа", post.Text);
                                        updateCommand.Parameters.AddWithValue("@Должность", DBNull.Value);
                                    }
                                    else
                                    {
                                        updateCommand.Parameters.AddWithValue("@Должность", post.Text);
                                        updateCommand.Parameters.AddWithValue("@Группа", DBNull.Value);
                                    }
                                    
                                    
                                    updateCommand.Parameters.AddWithValue("@ПРОВЕРКА", false);
                                    updateCommand.ExecuteNonQuery();

                                    notification.Close();
                                    Properties.Settings.Default.succes = "Данные обновлены!";
                                    Properties.Settings.Default.name = name2.Text;
                                    Properties.Settings.Default.Save();
                                    Succes succes = new Succes();
                                    succes.Show();

                                    password.Text = "Password*";
                                    password.PasswordChar = '\0';
                                    password.ForeColor = Color.Gray;
                                }
                            }
                            else
                            {
                                // Если запись с таким username не существует, выполняем операцию INSERT
                                string insertQuery = "INSERT INTO People (username, Фамилия, Имя, Отчество, НомерТелефона, Студент, Группа, Преподаватель, Должность, ПРОВЕРКА) " +
                                                    "VALUES (@username, @Фамилия, @Имя, @Отчество, @НомерТелефона, @Студент, @Группа, @Преподаватель, @Должность, @ПРОВЕРКА)";

                                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                                {
                                    insertCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
                                    insertCommand.Parameters.AddWithValue("@Фамилия", name1.Text);
                                    insertCommand.Parameters.AddWithValue("@Имя", name2.Text);
                                    insertCommand.Parameters.AddWithValue("@Отчество", name3.Text);
                                    insertCommand.Parameters.AddWithValue("@НомерТелефона", number.Text);
                                    insertCommand.Parameters.AddWithValue("@Студент", student.Checked);
                                    insertCommand.Parameters.AddWithValue("@Группа", post.Text);
                                    insertCommand.Parameters.AddWithValue("@Преподаватель", teacher.Checked);
                                    insertCommand.Parameters.AddWithValue("@Должность", post.Text);
                                    insertCommand.Parameters.AddWithValue("@ПРОВЕРКА", false);

                                    insertCommand.ExecuteNonQuery();

                                    notification.Close();
                                    Properties.Settings.Default.succes = "Данные сохранены!";
                                    Properties.Settings.Default.name = name2.Text;
                                    Properties.Settings.Default.Save();
                                    Succes succes = new Succes();
                                    succes.Show();

                                    password.Text = "Password*";
                                    password.PasswordChar = '\0';
                                    password.ForeColor = Color.Gray;
                                }
                            }
                        }

                        
                    }
                }

                else
                {
                    Properties.Settings.Default.notify = "Неверный пароль!";
                    Properties.Settings.Default.Save();
                    notification.Show();
                }
            }
        }
    }
}
