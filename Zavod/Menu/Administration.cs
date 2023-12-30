using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zavod.Menu
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.RegisterForm". При необходимости она может быть перемещена или удалена.
            this.registerFormTableAdapter.Fill(this.dataSet1.RegisterForm);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.People". При необходимости она может быть перемещена или удалена.
            this.peopleTableAdapter.Fill(this.dataSet1.People);

            


        }

        private void save_Click(object sender, EventArgs e)
        {
            Notification notification = new Notification();
            if (currentPassword.Text == "Текущий пароль")
            {
                Properties.Settings.Default.notify = "Введите текущий пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (currentPassword.Text != Properties.Settings.Default.Password)
            {
                Properties.Settings.Default.notify = "Неверный текущий пароль!";
                Properties.Settings.Default.Save();
                notification.Show();
            }
            else if (currentPassword.Text == Properties.Settings.Default.Password)
            {
                this.peopleTableAdapter.Update(this.dataSet1.People);
                Properties.Settings.Default.succes = "Данные сохранены!";
                Properties.Settings.Default.Save();
                Succes succes = new Succes();
                succes.Show();
            }
        }

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

        private void search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectedGroup = textBoxSearch.Text;
                string query = "SELECT * FROM People WHERE Фамилия LIKE @SelectedGroup + '%'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedGroup", selectedGroup);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
