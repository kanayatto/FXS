using System;
using System.Windows.Forms;

namespace FXS
{
    public partial class Skins : UserControl
    {
        public Skins()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new SaySo().Show();
        }
    }
}
