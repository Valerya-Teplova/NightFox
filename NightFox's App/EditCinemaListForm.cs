using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace test
{
    public partial class EditCinemaListForm : Form
    {
        public EditCinemaListForm()
        {
            InitializeComponent();
        }

        const int MIN_CINEMA_LEN = 5, MAX_CINEMA_LEN = 128; 

        private void LoadCategoryList()
        {
            SQLData.command = new SqlCommand("SELECT category_name FROM cinemaCategory", SQLData.connection);

            SQLData.reader = SQLData.command.ExecuteReader();

            if (!SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                MessageBox.Show("В базе данных нет ни одной категории.");
                return;
            }

            selectCategory__ComboBox.Items.Clear();
            selectCategory__ComboBox.Items.Add("<не указано>");

            while (SQLData.reader.Read())
            {
                selectCategory__ComboBox.Items.Add(SQLData.reader[0].ToString());
            }

            SQLData.reader.Close();
            selectCategory__ComboBox.SelectedIndex = 0;
        }

        private void EditListCinemaForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            InitializeCinemaList();
        }

        private void AddCinemaListForm_FormClosed(object sender, FormClosedEventArgs e) { }

        public int InitializeCinemaList()
        {
            int cur_row_id = 0, rows_count;

            SQLData.command = new SqlCommand(
                "SELECT cl.cinema_id, cl.cinema_name, cc.category_name, cl.cinema_description FROM cinemaList cl " +
                "JOIN cinemaCategory cc ON cc.category_id = cl.cinema_category",
                SQLData.connection);

            SQLData.reader = SQLData.command.ExecuteReader();

            rows_count = SQLData.reader.RecordsAffected;
            cinemaTable__DataGridView.Rows.Clear();

            if (!SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                return 0;
            }

            while (SQLData.reader.Read())
            {
                ++cur_row_id;

                int rowNumber = cinemaTable__DataGridView.Rows.Add();
                cinemaTable__DataGridView.Rows[rowNumber].Cells["cinema_id"].Value = cur_row_id;
                cinemaTable__DataGridView.Rows[rowNumber].Cells["cinema_name"].Value = SQLData.reader[1].ToString();
                cinemaTable__DataGridView.Rows[rowNumber].Cells["cinema_category"].Value = SQLData.reader[2].ToString();
                cinemaTable__DataGridView.Rows[rowNumber].Cells["cinema_description"].Value = SQLData.reader[3].ToString();
            }
            SQLData.reader.Close();

            cinemaTable__DataGridView.ClearSelection();
            return rows_count;
        }

        private void deleteCinemaButton_Click(object sender, EventArgs e)
        {
            if (cinemaTable__DataGridView.GetCellCount(DataGridViewElementStates.Selected) != 0)
            {
                SQLData.command = new SqlCommand(
                    "DELETE FROM cinemaList WHERE cinema_name = N'" + Utils.selected_cinema_name + "'",
                    SQLData.connection);

                SQLData.command.ExecuteNonQuery();
                MessageBox.Show("Фильм '" + Utils.selected_cinema_name + "' удалён из списка фильмов");
                InitializeCinemaList();
            }
            else
            {
                MessageBox.Show("Выберите фильм из списка.");
            }
        }

        private void cinemaTable__DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.selected_id = cinemaTable__DataGridView.SelectedCells[0].RowIndex;
            Utils.selected_cinema_name = cinemaTable__DataGridView.Rows[Utils.selected_id].Cells[2].Value.ToString();
        }

        private void AddNewCinema__Button_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(InputCinemaName__TextBox.Text))
            {
                MessageBox.Show("Вы ввели пустую строку.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (InputCinemaName__TextBox.Text.Length < MIN_CINEMA_LEN ||
                InputCinemaName__TextBox.Text.Length > MAX_CINEMA_LEN)
            {
                MessageBox.Show(
                    "Длина строки не может быть меньше чем " + MIN_CINEMA_LEN + 
                    " символов. И не может быть больше чем " + MAX_CINEMA_LEN + " символов", 
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SQLData.command = new SqlCommand("SELECT 1 FROM cinemaList WHERE cinema_name = N'" + InputCinemaName__TextBox.Text + "'", SQLData.connection);
            SQLData.reader = SQLData.command.ExecuteReader();
            if(SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                MessageBox.Show("Такой фильм уже существует");              
                InputCinemaName__TextBox.Text = String.Empty;
                InputCinemaDescription__TextBox.Text = String.Empty;
                selectCategory__ComboBox.SelectedIndex = 0;
                return;
            }
            SQLData.command = new SqlCommand(
                "INSERT INTO cinemaList (cinema_name, cinema_category, cinema_description) " +
                "values ( N'" + InputCinemaName__TextBox.Text + 
                "', " + selectCategory__ComboBox.SelectedIndex +
                ", N'" + InputCinemaDescription__TextBox.Text + "')", SQLData.connection);

            SQLData.command.ExecuteNonQuery();

            MessageBox.Show("Вы успешно добавили " + InputCinemaName__TextBox.Text , "Добавлено", MessageBoxButtons.OK, MessageBoxIcon.Information );
            InputCinemaName__TextBox.Text = "";
            InputCinemaDescription__TextBox.Text = "";
            selectCategory__ComboBox.SelectedIndex = 0;
            InitializeCinemaList();
        }
    }
}
