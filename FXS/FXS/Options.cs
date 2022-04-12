using FXS.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Windows.Forms;

namespace FXS
{
    public partial class Options : UserControl
    {
        public Options()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.paksPath = dialog.FileName;
                Settings.Default.Save();
                label1.Text = Settings.Default.paksPath;
            }
        }

        public static string GetPaksFolder
        {
            get { return Settings.Default.paksPath; }
        }



        public static string GetStrechedFolder
        {
            get { return Settings.Default.strechedFolder; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
