using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class AddCinemaForm : Form
    {
        readonly UserRoomForm urf;
        public AddCinemaForm(UserRoomForm urf)
        {
            this.urf = urf;
            InitializeComponent();
        }

        private void addCinema__Button_Click(object sender, EventArgs e)
        {
            SQLData.command = new SqlCommand(
                "SELECT 1 FROM userCinemaList WHERE cinema_id=(SELECT cinema_id FROM cinemaList WHERE cinema_name = N'" 
                + selectCinema__ComboBox.Items[selectCinema__ComboBox.SelectedIndex] + "')" + 
                " AND user_id = " + UserData.Id, 
                SQLData.connection);

            SQLData.reader = SQLData.command.ExecuteReader();  // выполнить запрос на считывание

            if (SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                MessageBox.Show("Добавлять один и тот же фильм запрещено.");
                return;
            }
            SQLData.reader.Close();

            SQLData.command = new SqlCommand(
               "INSERT INTO userCinemaList (user_id, cinema_id, status, user_description) VALUES (" +
               UserData.Id + "," +
               "(SELECT cinema_id FROM cinemaList WHERE cinema_name = N'" + selectCinema__ComboBox.Items[selectCinema__ComboBox.SelectedIndex] + "'), " +
               (selectCinemaStatus__ComboBox.SelectedIndex+1) + "," +
               "N'" + inputCinemaDescription__TextBox.Text + "')",
               SQLData.connection);

            SQLData.command.ExecuteNonQuery(); // выполнить команду 
            urf.InitializeCinemaList();
            this.Hide();
        }
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

        private void LoadCinemaList(int category_id=0)
        {
            
            if (category_id == 0)
                SQLData.command = new SqlCommand("SELECT cinema_name FROM cinemaList", SQLData.connection);
            else
                SQLData.command = new SqlCommand("SELECT cinema_name FROM cinemaList WHERE cinema_category=" + category_id, SQLData.connection);

            SQLData.reader = SQLData.command.ExecuteReader();

            if (!SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                MessageBox.Show("В базе данных нет ни одного фильма.");
                return;
            }

            selectCinema__ComboBox.Items.Clear();

            while (SQLData.reader.Read())
            {
                selectCinema__ComboBox.Items.Add(SQLData.reader[0].ToString());
            }

            SQLData.reader.Close();
            selectCinema__ComboBox.SelectedIndex = 0;
        }



        private void AddCinemaForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadCinemaList(0);
        }

        private void selectCategory__ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCinemaList(selectCategory__ComboBox.SelectedIndex);
        }
    }
}
