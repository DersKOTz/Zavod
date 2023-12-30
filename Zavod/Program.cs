using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zavod.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zavod
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";

            // Проверка, существует ли такой же username в базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM registerform WHERE username = @username";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 1)
                    {
                        // Username существует, теперь нужно проверить пароль
                        string passwordQuery = "SELECT password FROM registerform WHERE username = @username";
                        using (SqlCommand passwordCommand = new SqlCommand(passwordQuery, connection))
                        {
                            passwordCommand.Parameters.AddWithValue("@username", Properties.Settings.Default.Username);
                            string storedPassword = (string)passwordCommand.ExecuteScalar();
                            
                            if (Properties.Settings.Default.Password == storedPassword)
                            {
                                Application.Run(new Main());

                            }
                            else
                            {
                                Application.Run(new Login());
                            }
                        }
                    }
                    else
                    {
                        Application.Run(new Login());
                    }
                }
            }

            
            


        }

    }                                                                    
}
