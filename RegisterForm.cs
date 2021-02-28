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
    public partial class registerForm : Form
    {

        public registerForm()
        {
            InitializeComponent();
        }

        const int 
            MIN_PASSWORD_LEN = 3,
            MAX_PASSWORD_LEN = 24;

        bool isExists = false;

        private void registerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void login__LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void register__Button_Click(object sender, EventArgs e)
        {
            SQLData.command = new SqlCommand(
                "SELECT 1 FROM accounts WHERE nickname = N'" + inputNickname__TextBox.Text + "'", SQLData.connection);

            SQLData.reader = SQLData.command.ExecuteReader();
            isExists = SQLData.reader.HasRows;


            if (isExists)
            {
                SQLData.reader.Close();
                MessageBox.Show("Аккаунт с таким именем уже зарегистрирован.");
                return;
            }
            SQLData.reader.Close();
            if (
                String.IsNullOrEmpty(inputNickname__TextBox.Text) ||
                String.IsNullOrEmpty(inputPassword__TextBox.Text) ||
                String.IsNullOrEmpty(repeatPassword__TextBox.Text) ||
                String.IsNullOrEmpty(inputEmail__TextBox.Text))
            {
                SQLData.reader.Close();
                MessageBox.Show("Все поля обязательны к заполнению.");
                return;
            }

            if (inputPassword__TextBox.Text != repeatPassword__TextBox.Text)
            {
                SQLData.reader.Close();
                MessageBox.Show("Пароли не совпадают.");
                return;
            }
            if(inputPassword__TextBox.Text.Length < MIN_PASSWORD_LEN || inputPassword__TextBox.Text.Length > MAX_PASSWORD_LEN)
            {
                SQLData.reader.Close();
                MessageBox.Show("Длина пароля должна больше " + (MIN_PASSWORD_LEN - 1).ToString() + " и меньше " + (MAX_PASSWORD_LEN + 1).ToString() + " символов");
                return;
            }

            try
            {
                UserData.JustRegistered = true;
                SQLData.command = new SqlCommand(
                "INSERT INTO accounts (nickname, password, email, isAdmin) VALUES (" +
                $"N'{inputNickname__TextBox.Text}', N'{inputPassword__TextBox.Text}', N'{inputEmail__TextBox.Text}', 0); SELECT SCOPE_IDENTITY();",
                SQLData.connection);

                int account_id = Convert.ToInt32(SQLData.command.ExecuteScalar());

                UserData.Id = account_id;
                UserData.Name = inputNickname__TextBox.Text;
                UserData.Password = inputPassword__TextBox.Text;
                UserData.Email = inputEmail__TextBox.Text;
                UserData.IsAdmin = false;
                new UserRoomForm().Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Не удалось зарегистрироваться. Обратитесь к администратору.");
                return;
            }
        }
    }
}
