using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test
{
    public partial class EditUserDataForm : Form
    {
        public EditUserDataForm()
        {
            InitializeComponent();
        }

        private void inputUsername__TextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputUsername__TextBox.Text))
            {
                UserId__TextBox.Text = String.Empty;
                UserName__TextBox.Text = String.Empty;
                Password__TextBox.Text = String.Empty;
                Email__TextBox.Text = String.Empty;
                UserPhoto__PictureBox.Image = Properties.Resources.defaultUserPhoto;
                IsAdmin__ListBox.SelectedIndex = 0;
                cinemaTable__DataGridView.Rows.Clear();
                return;
            }
            // Личная информация
            SQLData.command = new SqlCommand("SELECT TOP 1 account_id, nickname, password, email, COALESCE(photo_ext, '-'), isAdmin FROM accounts WHERE nickname LIKE '" + inputUsername__TextBox.Text + "%'", SQLData.connection);
            SQLData.reader = SQLData.command.ExecuteReader();

            if(SQLData.reader.HasRows)
            {
                SQLData.reader.Read();
                UserId__TextBox.Text = SQLData.reader[0].ToString();
                UserName__TextBox.Text = SQLData.reader[1].ToString();
                Password__TextBox.Text = SQLData.reader[2].ToString();
                Email__TextBox.Text = SQLData.reader[3].ToString();

                if (SQLData.reader[4].ToString() != "-")
                {
                    UserPhoto__PictureBox.ImageLocation = Environment.CurrentDirectory + @"\UserPhotos\" + UserId__TextBox.Text + "." + SQLData.reader[4].ToString();
                }
                else
                {
                    UserPhoto__PictureBox.Image = Properties.Resources.defaultUserPhoto;
                }
                IsAdmin__ListBox.SelectedIndex = Convert.ToInt32(SQLData.reader[5]);
                SQLData.reader.Close();

                // Информация о просмотренных фильмах
                int cur_row_id = 0;

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
                    "WHERE accs.account_id = " + UserId__TextBox.Text,
                    SQLData.connection);

                SQLData.reader = SQLData.command.ExecuteReader();
                cinemaTable__DataGridView.Rows.Clear();

                if (!SQLData.reader.HasRows)
                {
                    SQLData.reader.Close();
                    return;
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
            }
        }

        private void ConfirmEdit__Button_Click(object sender, EventArgs e)
        {
            SQLData.command = new SqlCommand(
                "UPDATE accounts SET " +
                "nickname = N'" + UserName__TextBox.Text + "', " +
                "password = N'" + Password__TextBox.Text + "', " +
                "email = N'" + Email__TextBox.Text + "', " +
                "isAdmin = " + IsAdmin__ListBox.SelectedIndex +
                " WHERE account_id = " + UserId__TextBox.Text, SQLData.connection);

            SQLData.command.ExecuteNonQuery();
            MessageBox.Show("Данные пользователя изменены.");
        }

        private void deleteAccount__Button_Click(object sender, EventArgs e)
        {
            if (UserData.Name == UserName__TextBox.Text)
            {
                MessageBox.Show("Нельзя удалить свой аккаунт.");
                return;
            }
            if (MessageBox.Show(
                "Вы действительно хотите удалить аккаунт пользователя '" + UserName__TextBox.Text + "'?" + Environment.NewLine +
                "Список всех просмотренных фильмов, сериалов, и т.п. будут удалены из базы данных." + Environment.NewLine +
                "Подтвердите ваше действие, нажав на кнопку 'Да' в этом окне.", 
                "Подтвеждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLData.command = new SqlCommand(
                    "DELETE FROM accounts WHERE account_id = " + UserId__TextBox.Text +
                    "; DELETE FROM userCinemaList WHERE user_id = " + UserId__TextBox.Text,
                SQLData.connection);

                SQLData.command.ExecuteNonQuery();

                MessageBox.Show("Аккаунт пользователя удалён.");
            }
            this.Close();
        }
    }
}
