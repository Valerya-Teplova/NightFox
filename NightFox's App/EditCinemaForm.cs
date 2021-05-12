using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class EditCinemaForm : Form
    {
        readonly UserRoomForm urf;
        public EditCinemaForm(UserRoomForm urf)
        {
            this.urf = urf;
            InitializeComponent();
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
                if(SQLData.reader[0].ToString() == Utils.selected_category_name)
                {
                    selectCategory__ComboBox.SelectedIndex = selectCategory__ComboBox.Items.Count-1;
                }
            }

            SQLData.reader.Close();
        }
        private void LoadCinemaList(int category_id=0)
        {   
            if(category_id==0)
                SQLData.command = new SqlCommand("SELECT cinema_name FROM cinemaList WHERE cinema_category=(SELECT category_id FROM cinemaCategory WHERE category_name=N'"+Utils.selected_category_name + "')", SQLData.connection);
            else
                SQLData.command = new SqlCommand("SELECT cinema_name FROM cinemaList WHERE cinema_category=" + selectCategory__ComboBox.SelectedIndex, SQLData.connection);
            
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
                if (SQLData.reader[0].ToString() == Utils.selected_cinema_name)
                {
                    selectCinema__ComboBox.SelectedIndex = selectCinema__ComboBox.Items.Count-1;
                }
            }

            //SQLData.reader.Close();
        }


        private void EditCinemaForm_Load(object sender, EventArgs e)
        {
            LoadCategoryList();
            LoadCinemaList();

            for(int i = 0; i < selectCinemaStatus__ComboBox.Items.Count; ++i)
            {
                if (selectCinemaStatus__ComboBox.Items[i].ToString() == Utils.selected_status_name)
                {
                    selectCinemaStatus__ComboBox.SelectedIndex = i;
                    break;
                }
            }

            inputCinemaDescription__TextBox.Text = Utils.selected_description;
        }
       
        private void EditCinemaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void editCinema__Button_Click(object sender, EventArgs e)
        {
            SQLData.command = new SqlCommand(
                "UPDATE userCinemaList SET " +
                "cinema_id = (SELECT cinema_id FROM cinemaList WHERE cinema_name = N'" + selectCinema__ComboBox.Text + "'), " +
                "user_description = N'" + inputCinemaDescription__TextBox.Text + "', " +
                "status=" + (selectCinemaStatus__ComboBox.SelectedIndex+1) +
                " WHERE user_id = " + UserData.Id +
                " AND cinema_id = (SELECT cinema_id FROM cinemaList WHERE cinema_name = N'" + Utils.selected_cinema_name + "')"
                , SQLData.connection);

            SQLData.command.ExecuteNonQuery();

            urf.InitializeCinemaList();
            this.Hide();
        }

        private void selectCategory__ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCinemaList(selectCategory__ComboBox.SelectedIndex);
        }
    }
}
