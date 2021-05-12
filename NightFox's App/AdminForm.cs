using System;
using System.Windows.Forms;

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
