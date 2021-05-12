using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace test
{
    public partial class UserRoomForm : Form
    {
        public UserRoomForm()
        {
            InitializeComponent();
        }

        private void UserRoomForm_Load(object sender, EventArgs e)
        {
            int rows_count = InitializeCinemaList();
            if (rows_count == 0 && !UserData.JustRegistered)
            {
                MessageBox.Show("В вашем списка не осталось фильмов. Добавьте хотя бы один через кнопку 'Добавить'");
            }
            userName__Label.Text = UserData.Name + (UserData.IsAdmin ? " (Администратор)" : "");

            string photo_path = Environment.CurrentDirectory + @"\UserPhotos\" + UserData.Id + "." + UserData.PhotoExt;

            if (File.Exists(photo_path)) 
               userPhoto__RoundPictureBox.ImageLocation = photo_path;
            if (UserData.IsAdmin)
                OpenAdminPanel__Button.Visible = true;
        }

        private void userPhoto__RoundPictureBox_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string photo_path = Environment.CurrentDirectory + @"\UserPhotos\" + UserData.Id + Path.GetExtension(ofd.FileName);
                SQLData.command = new SqlCommand("SELECT COALESCE(photo_ext, NULL) FROM accounts WHERE account_id = " + UserData.Id, SQLData.connection);
                SQLData.reader = SQLData.command.ExecuteReader();
                if (SQLData.reader.Read())
                {
                    if (SQLData.reader[0].ToString() != null)
                       File.Delete(Environment.CurrentDirectory + @"\UserPhotos\" + UserData.Id + "." + SQLData.reader[0].ToString());                    
                }
                SQLData.reader.Close();

                File.Copy(ofd.FileName, photo_path, true);
                userPhoto__RoundPictureBox.ImageLocation = photo_path;
                UserData.PhotoExt = Path.GetExtension(ofd.FileName).Remove(0, 1);
                SQLData.command = new SqlCommand("UPDATE accounts SET photo_ext = N'" + UserData.PhotoExt + "' WHERE account_id = " + UserData.Id, SQLData.connection);
                SQLData.command.ExecuteNonQuery();
            }
        }

        private void addCinema__Button_Click(object sender, EventArgs e)
        {
            new AddCinemaForm(this).Show();
        }

        private void UserRoomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void editCinema__Button_Click(object sender, EventArgs e)
        {
            if (cinemaTable__DataGridView.GetCellCount(DataGridViewElementStates.Selected) != 0)
                new EditCinemaForm(this).Show();
            else
                MessageBox.Show("Выберите фильм из списка.");
        }

        private void cinemaTable__DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Utils.selected_id = cinemaTable__DataGridView.SelectedCells[0].RowIndex;

            Utils.selected_category_name = cinemaTable__DataGridView.Rows[Utils.selected_id].Cells[1].Value.ToString();
            Utils.selected_cinema_name = cinemaTable__DataGridView.Rows[Utils.selected_id].Cells[2].Value.ToString(); 
            Utils.selected_status_name = cinemaTable__DataGridView.Rows[Utils.selected_id].Cells[3].Value.ToString();
            Utils.selected_description = cinemaTable__DataGridView.Rows[Utils.selected_id].Cells[4].Value.ToString();
        }

        private void deleteCinemaButton_Click(object sender, EventArgs e)
        {
            if (Utils.selected_id == -1)
            {
                MessageBox.Show("Выберите фильм из списка.");
                return;
            }
            SQLData.command = new SqlCommand(
                "DELETE FROM" +
                " userCinemaList " +
                " WHERE cinema_id = (SELECT cinema_id FROM cinemaList WHERE cinema_name = N'" + Utils.selected_cinema_name + "') " +
                " AND user_id = " + UserData.Id, SQLData.connection);

            SQLData.command.ExecuteNonQuery();

            Utils.selected_id = -1;
            MessageBox.Show(Utils.selected_cinema_name + " удалён из списка.");
            if(InitializeCinemaList() == 0)
            {
                MessageBox.Show("В вашем списка не осталось фильмов. Добавьте хотя бы один через кнопку 'Добавить'");
            }
        }

        private void OpenAdminPanel__Button_Click(object sender, EventArgs e)
        {
            new AdminForm(this).Show();
        }

        public int InitializeCinemaList()
        {
            int cur_row_id = 0, rows_count;

            SQLData.command = new SqlCommand(
                "SELECT " +
                "c.cinema_name, " +
                "cc.category_name, " +
                "COALESCE(ucl.status, 0), " +
                "ucl.user_description " +
                "FROM " +
                "accounts accs " +
                "JOIN usercinemalist ucl ON ucl.user_id = accs.account_id " +
                "JOIN cinemaList c ON c.cinema_id = ucl.cinema_id " +
                "JOIN cinemaCategory cc ON cc.category_id = c.cinema_category " +
                "WHERE accs.account_id = " + UserData.Id,
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
                cinemaTable__DataGridView.Rows[rowNumber].Cells["ID"].Value = cur_row_id;
                cinemaTable__DataGridView.Rows[rowNumber].Cells["cinema"].Value = SQLData.reader[0].ToString();
                cinemaTable__DataGridView.Rows[rowNumber].Cells["category"].Value = SQLData.reader[1].ToString();
                cinemaTable__DataGridView.Rows[rowNumber].Cells["status"].Value = Utils.status_arr[Convert.ToInt32(SQLData.reader[2])];
                cinemaTable__DataGridView.Rows[rowNumber].Cells["description"].Value = SQLData.reader[3].ToString();
            }
            SQLData.reader.Close();

            cinemaTable__DataGridView.ClearSelection();
            return rows_count;
        }
        private void cinemaTable__DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
