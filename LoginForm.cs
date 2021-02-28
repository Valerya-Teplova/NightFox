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
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            
            InitializeComponent();
            SQLData.CheckConnection();
           
        }

        private void login__Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inputNickname__TextBox.Text))
            {
                MessageBox.Show("В поле логин ничего не введено.");
                return;
            }
            if (String.IsNullOrEmpty(inputPassword__TextBox.Text))
            {
                MessageBox.Show("В поле пароль ничего не введено.");
                return;
            }
        
            SQLData.command = new SqlCommand("SELECT account_id, nickname, password, email, photo_ext, isAdmin FROM accounts WHERE nickname = N'" + inputNickname__TextBox.Text + "'", SQLData.connection);
            SQLData.reader = SQLData.command.ExecuteReader();

            if (!SQLData.reader.HasRows)
            {
                SQLData.reader.Close();
                MessageBox.Show("Такой аккаунт не зарегистрирован.");
                return;
            }

            while (SQLData.reader.Read())
            {
                if (SQLData.reader[0].ToString() != null)
                {
                    if (SQLData.reader[2].ToString() != inputPassword__TextBox.Text)
                    {
                        MessageBox.Show("Вы ввели неверный пароль.");
                    }
                    else
                    {
                        UserData.JustRegistered = false;
                        UserData.Id = Convert.ToInt32(SQLData.reader[0]);
                        UserData.Name = SQLData.reader[1].ToString();
                        UserData.Password = SQLData.reader[2].ToString();
                        UserData.Email = SQLData.reader[3].ToString();
                        UserData.PhotoExt = SQLData.reader[4].ToString();
                        UserData.IsAdmin = Convert.ToBoolean(SQLData.reader[5]);

                        SQLData.reader.Close();
                        new UserRoomForm().Show();
                        this.Hide();
                        return;
                    }
                    break;
                }
            }
            SQLData.reader.Close();
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new registerForm().Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
