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
    public partial class AdminForm : Form
    {
        readonly UserRoomForm urf;
        public AdminForm(UserRoomForm urf)
        {
            this.urf = urf;
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            userName__Label.Text = urf.userName__Label.Text;
            userPhoto__RoundPictureBox.ImageLocation = urf.userPhoto__RoundPictureBox.ImageLocation;
        }

        private void editUserData__Button_Click(object sender, EventArgs e)
        {
            new EditUserDataForm().Show();
        }

        private void editListCinema__Button_Click(object sender, EventArgs e)
        {
            new EditCinemaListForm().Show();
        }
    }
}
