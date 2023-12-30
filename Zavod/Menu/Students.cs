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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zavod.Menu
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.People". При необходимости она может быть перемещена или удалена.
            // this.peopleTableAdapter.Fill(this.dataSet1.People);            
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM People WHERE проверка = 1 AND студент = 1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string группа = reader["Группа"].ToString();
                            if (!string.IsNullOrEmpty(группа))
                            {
                                if (!comboBox1.Items.Contains(группа))
                                {
                                    comboBox1.Items.Add(группа);
                                }
                            }
                        }
                    }

                }
            }

                int[] columnsToHide = { 0, 5, 7, 8, 9 };
                foreach (int columnIndex in columnsToHide)
                {
                    dataGridView1.Columns[columnIndex].Visible = false;
                }


            if (Properties.Settings.Default.grop == true)
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
            }

            if (Properties.Settings.Default.famil == true)
            {
                textBoxSearch.Visible = true;
                search.Visible = true;
                dataGridView1.Location = new Point(21, 100);
            }
            else
            {
                textBoxSearch.Visible = false;
                search.Visible = false;
                dataGridView1.Location = new Point(21, 68);
            }


        }
            
                    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectedGroup = comboBox1.SelectedItem.ToString();
                string query = "SELECT * FROM People WHERE группа = @SelectedGroup";
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

        private void search_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=LAPTOPVALAVIN-K\\SQLEXPRESS;Initial Catalog=Zavod;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectedGroup = textBoxSearch.Text;
                string query = "SELECT * FROM People WHERE Фамилия LIKE @SelectedGroup + '%' AND студент = 1 AND проверка = 1";
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
