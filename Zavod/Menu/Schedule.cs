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

namespace Zavod.Menu
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            RoundComponent(save);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.RegisterForm". При необходимости она может быть перемещена или удалена.
            this.registerFormTableAdapter.Fill(this.dataSet1.RegisterForm);

            if (Properties.Settings.Default.admin == true)
            {
                save.Visible = true;
                RichTextBox[] richTextBoxes = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6, 
                richTextBox7, richTextBox8, richTextBox9, richTextBox10, richTextBox11, richTextBox12};

                foreach (RichTextBox richTextBox in richTextBoxes)
                {
                    richTextBox.ReadOnly = false;
                }
            }
            else
            {
                save.Visible = false;
                RichTextBox[] richTextBoxes = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6,
                richTextBox7, richTextBox8, richTextBox9, richTextBox10, richTextBox11, richTextBox12};

                foreach (RichTextBox richTextBox in richTextBoxes)
                {
                    richTextBox.ReadOnly = true;
                }
            }


            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM schedule"; // Ваш запрос SQL

                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {                           
                            comboBox1.Items.Add(reader["Группа"].ToString());

                            comboBox1.Text = Properties.Settings.Default.group;
                            richTextBox1.Text = Properties.Settings.Default.mondayUp;
                            richTextBox2.Text = Properties.Settings.Default.tuesdayUp;
                            richTextBox3.Text = Properties.Settings.Default.wednesdayUp;
                            richTextBox4.Text = Properties.Settings.Default.thursdayUp;
                            richTextBox5.Text = Properties.Settings.Default.fridayUp;
                            richTextBox6.Text = Properties.Settings.Default.saturdayUp;

                            richTextBox7.Text = Properties.Settings.Default.mondayDw;
                            richTextBox8.Text = Properties.Settings.Default.tuesdayDw;
                            richTextBox9.Text = Properties.Settings.Default.wednesdayDw;
                            richTextBox10.Text = Properties.Settings.Default.thursdayDw;
                            richTextBox11.Text = Properties.Settings.Default.fridayDw;
                            richTextBox12.Text = Properties.Settings.Default.saturdayDw;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
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
        
            string checkGroupQuery = "SELECT COUNT(*) FROM schedule WHERE Группа = @group";
            SqlCommand checkGroupCmd = new SqlCommand(checkGroupQuery, connection);
            checkGroupCmd.Parameters.AddWithValue("@group", comboBox1.Text);
            int groupCount = (int)checkGroupCmd.ExecuteScalar();

            if (groupCount > 0)
            {
               
                string updateQuery = "UPDATE schedule SET ПонедельникВерх = @mondayUp, ВторникВерх = @tuesdayUp, СредаВерх = @wednesdayUp, " +
                                     "ЧетвергВерх = @thursdayUp, ПятницаВерх = @fridayUp, СубботаВерх = @saturdayUp, " +
                                     "ПонедельникНиз = @mondayDw, ВторникНиз = @tuesdayDw, СредаНиз = @wednesdayDw, " +
                                     "ЧетвергНиз = @thursdayDw, ПятницаНиз = @fridayDw, СубботаНиз = @saturdayDw " +
                                     "WHERE Группа = @group";

                SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@group", comboBox1.Text);
                updateCmd.Parameters.AddWithValue("@mondayUp", richTextBox1.Text);
                updateCmd.Parameters.AddWithValue("@tuesdayUp", richTextBox2.Text);
                updateCmd.Parameters.AddWithValue("@wednesdayUp", richTextBox3.Text);
                updateCmd.Parameters.AddWithValue("@thursdayUp", richTextBox4.Text);
                updateCmd.Parameters.AddWithValue("@fridayUp", richTextBox5.Text);
                updateCmd.Parameters.AddWithValue("@saturdayUp", richTextBox6.Text);

                updateCmd.Parameters.AddWithValue("@mondayDw", richTextBox7.Text);
                updateCmd.Parameters.AddWithValue("@tuesdayDw", richTextBox8.Text);
                updateCmd.Parameters.AddWithValue("@wednesdayDw", richTextBox9.Text);
                updateCmd.Parameters.AddWithValue("@thursdayDw", richTextBox10.Text);
                updateCmd.Parameters.AddWithValue("@fridayDw", richTextBox11.Text);
                updateCmd.Parameters.AddWithValue("@saturdayDw", richTextBox12.Text);

                updateCmd.ExecuteNonQuery();
                Properties.Settings.Default.succes = "Данные обновлены!";
                Properties.Settings.Default.Save();
                Succes succes = new Succes();
                succes.Show();
            }
            else
            {
                string insertQuery = "INSERT INTO schedule (Группа, ПонедельникВерх, ВторникВерх, СредаВерх, ЧетвергВерх, ПятницаВерх, СубботаВерх, " +
                                     "ПонедельникНиз, ВторникНиз, СредаНиз, ЧетвергНиз, ПятницаНиз, СубботаНиз) " +
                                     "VALUES (@group, @mondayUp, @tuesdayUp, @wednesdayUp, @thursdayUp, @fridayUp, @saturdayUp," +
                                     "@mondayDw, @tuesdayDw, @wednesdayDw, @thursdayDw, @fridayDw, @saturdayDw)";

                SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@group", comboBox1.Text);
                insertCmd.Parameters.AddWithValue("@mondayUp", richTextBox1.Text);
                insertCmd.Parameters.AddWithValue("@tuesdayUp", richTextBox2.Text);
                insertCmd.Parameters.AddWithValue("@wednesdayUp", richTextBox3.Text);
                insertCmd.Parameters.AddWithValue("@thursdayUp", richTextBox4.Text);
                insertCmd.Parameters.AddWithValue("@fridayUp", richTextBox5.Text);
                insertCmd.Parameters.AddWithValue("@saturdayUp", richTextBox6.Text);

                insertCmd.Parameters.AddWithValue("@mondayDw", richTextBox7.Text);
                insertCmd.Parameters.AddWithValue("@tuesdayDw", richTextBox8.Text);
                insertCmd.Parameters.AddWithValue("@wednesdayDw", richTextBox9.Text);
                insertCmd.Parameters.AddWithValue("@thursdayDw", richTextBox10.Text);
                insertCmd.Parameters.AddWithValue("@fridayDw", richTextBox11.Text);
                insertCmd.Parameters.AddWithValue("@saturdayDw", richTextBox12.Text);
                
                insertCmd.ExecuteNonQuery();
                Properties.Settings.Default.succes = "Данные сохранены!";
                Properties.Settings.Default.Save();
                Succes succes = new Succes();
                succes.Show();
            }

            connection.Close();



           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = comboBox1.SelectedItem.ToString();
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM schedule WHERE Группа = @Group"; // Ваш запрос SQL с фильтром по выбранной группе
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Group", selectedGroup);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            richTextBox1.Text = reader["ПонедельникВерх"].ToString();
                            richTextBox2.Text = reader["ВторникВерх"].ToString();
                            richTextBox3.Text = reader["СредаВерх"].ToString();
                            richTextBox4.Text = reader["ЧетвергВерх"].ToString();
                            richTextBox5.Text = reader["ПятницаВерх"].ToString();
                            richTextBox6.Text = reader["СубботаВерх"].ToString();
                            richTextBox7.Text = reader["ПонедельникНиз"].ToString();
                            richTextBox8.Text = reader["ВторникНиз"].ToString();
                            richTextBox9.Text = reader["СредаНиз"].ToString();
                            richTextBox10.Text = reader["ЧетвергНиз"].ToString();
                            richTextBox11.Text = reader["ПятницаНиз"].ToString();
                            richTextBox12.Text = reader["СубботаНиз"].ToString();

                            Properties.Settings.Default.group = comboBox1.Text;
                            Properties.Settings.Default.mondayUp = richTextBox1.Text;
                            Properties.Settings.Default.tuesdayUp = richTextBox2.Text;
                            Properties.Settings.Default.wednesdayUp = richTextBox3.Text;
                            Properties.Settings.Default.thursdayUp = richTextBox4.Text;
                            Properties.Settings.Default.fridayUp = richTextBox5.Text;
                            Properties.Settings.Default.saturdayUp = richTextBox6.Text;

                            Properties.Settings.Default.mondayDw = richTextBox7.Text;
                            Properties.Settings.Default.tuesdayDw = richTextBox8.Text;
                            Properties.Settings.Default.wednesdayDw = richTextBox9.Text;
                            Properties.Settings.Default.thursdayDw = richTextBox10.Text;
                            Properties.Settings.Default.fridayDw = richTextBox11.Text;
                            Properties.Settings.Default.saturdayDw = richTextBox12.Text;
                            Properties.Settings.Default.Save();
                        }
                    }
                }
                connection.Close();
            }
            this.SelectNextControl(null, true, true, true, true);
        }
    }
}




