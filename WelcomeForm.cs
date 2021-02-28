using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void welcomeTimer__Timer_Tick(object sender, EventArgs e)
        {
            welcomeTimer__Timer.Enabled = false;
            new LoginForm().Show();
            this.Hide();
 
        }
    }
}
