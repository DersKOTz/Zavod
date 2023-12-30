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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zavod.Menu
{
    public partial class Zvonki : Form
    {
        public Zvonki()
        {
            InitializeComponent();
        }

        private void Zvonki_Load(object sender, EventArgs e)
        {
            RoundComponent(save);
            if (Properties.Settings.Default.admin == true)
            {
                save.Visible = true;
                RichTextBox[] richTextBoxes = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5 };

                foreach (RichTextBox richTextBox in richTextBoxes)
                {
                    richTextBox.ReadOnly = false;
                }
            }
            else
            {
                save.Visible = false;
                RichTextBox[] richTextBoxes = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5 };

                foreach (RichTextBox richTextBox in richTextBoxes)
                {
                    richTextBox.ReadOnly = true;
                }
            }




          
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM zvonki"; // Ваш запрос SQL с фильтром по выбранной группе
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Day", 1);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            richTextBox1.Text = reader["ПонедельникЛ"].ToString();
                            richTextBox2.Text = reader["ПонедельникП"].ToString();
                            richTextBox3.Text = reader["БудниЛ"].ToString();
                            richTextBox4.Text = reader["БудниП"].ToString();
                            richTextBox5.Text = reader["Суббота"].ToString();
                        }
                    }
                }
                connection.Close();
            }
        }

        private void RoundComponent(Control component)
        {
            int cornerRadius = 25; // Радиус закругления компонента 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(component.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(component.Width - cornerRadius, component.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, component.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();
            component.Region = new Region(path);
            component.BackColor = Color.FromArgb(0x79, 0xb6, 0xc9);
        }

        private void save_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string checkGroupQuery = "SELECT COUNT(*) FROM zvonki WHERE День = @day";
            SqlCommand checkGroupCmd = new SqlCommand(checkGroupQuery, connection);
            checkGroupCmd.Parameters.AddWithValue("@day", 1);
            int groupCount = (int)checkGroupCmd.ExecuteScalar();

            if (groupCount > 0)
            {
                string updateQuery = "UPDATE zvonki SET ПонедельникЛ = @mondayL, ПонедельникП = @mondayR," +
                    "БудниЛ = @budniL, БудниП = @budniR, Суббота = @saturday, День = @day";

                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@day", 1);
                updateCmd.Parameters.AddWithValue("@mondayL", richTextBox1.Text);
                updateCmd.Parameters.AddWithValue("@mondayR", richTextBox2.Text);
                updateCmd.Parameters.AddWithValue("@budniL", richTextBox3.Text);
                updateCmd.Parameters.AddWithValue("@budniR", richTextBox4.Text);
                updateCmd.Parameters.AddWithValue("@saturday", richTextBox5.Text);

                updateCmd.ExecuteNonQuery();
                Properties.Settings.Default.succes = "Данные обновлены!";
                Properties.Settings.Default.Save();
                Succes succes = new Succes();
                succes.Show();
            }
            else
            {
                string insertQuery = "INSERT INTO zvonki (День, ПонедельникЛ, ПонедельникП, БудниЛ, БудниП, Суббота) " +
                                    "VALUES (@day, @mondayL,  @mondayR, @budniL, @budniR, @saturday)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@day", 1);
                insertCmd.Parameters.AddWithValue("@mondayL", richTextBox1.Text);
                insertCmd.Parameters.AddWithValue("@mondayR", richTextBox2.Text);
                insertCmd.Parameters.AddWithValue("@budniL", richTextBox3.Text);
                insertCmd.Parameters.AddWithValue("@budniR", richTextBox4.Text);
                insertCmd.Parameters.AddWithValue("@saturday", richTextBox5.Text);

                insertCmd.ExecuteNonQuery();
                Properties.Settings.Default.succes = "Данные сохранены!";
                Properties.Settings.Default.Save();
                Succes succes = new Succes();
                succes.Show();
            }
            connection.Close();

        }

    }
}
