using System;
using System.Windows.Forms;

namespace FXS
{
    public partial class logbruv : UserControl
    {
        public logbruv()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (btnlog.Text == "2576-1983-7234-2491")
            {




                MessageBox.Show("Successfully logged in as 'Admin'");

            }

            else
            {
                MessageBox.Show("The code you entered is incorrect, please try again");
                btnlog.Focus();

            }
        }
    }
}
