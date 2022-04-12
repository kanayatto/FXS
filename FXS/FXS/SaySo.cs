using System;
using System.IO;
using System.Windows.Forms;

namespace FXS
{
    public partial class SaySo : Form
    {
        public SaySo()
        {
            InitializeComponent();
        }

        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        private static byte[] byte1 = new byte[]
        {
           47,71,97,109,101,47,65,110,105,109,97,116,105,111,110,47,71,97,109,101,47,77,97,105,110,80,108,97,121,101,114,47,69,109,111,116,101,115,47,80,97,114,116,121,95,74,97,122,122,95,84,119,105,110,107,108,101,95,84,111,101,115,47,69,109,111,116,101,95,80,97,114,116,121,74,97,122,122,84,119,105,110,107,108,101,84,111,101,115,95,67,77,77,95,77,46,69,109,111,116,101,95,80,97,114,116,121,74,97,122,122,84,119,105,110,107,108,101,84,111,101,115,95,67,77,77,95,77
        };

        private static byte[] byte2 = new byte[]
        {
            47,71,97,109,101,47,65,110,105,109,97,116,105,111,110,47,71,97,109,101,47,77,97,105,110,80,108,97,121,101,114,47,69,109,111,116,101,115,47,84,119,105,115,116,68,97,121,116,111,110,97,47,69,109,111,116,101,95,84,119,105,115,116,68,97,121,116,111,110,97,95,67,77,77,95,77,46,69,109,111,116,101,95,84,119,105,115,116,68,97,121,116,111,110,97,95,67,77,77,95,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] byte3 = new byte[]
        {
            47,71,97,109,101,47,65,110,105,109,97,116,105,111,110,47,71,97,109,101,47,77,97,105,110,80,108,97,121,101,114,47,69,109,111,116,101,115,47,80,97,114,116,121,95,74,97,122,122,95,84,119,105,110,107,108,101,95,84,111,101,115,47,69,109,111,116,101,95,80,97,114,116,121,74,97,122,122,84,119,105,110,107,108,101,84,111,101,115,95,67,77,70,95,77,46,69,109,111,116,101,95,80,97,114,116,121,74,97,122,122,84,119,105,110,107,108,101,84,111,101,115,95,67,77,70,95,77
        };

        private static byte[] byte4 = new byte[]
        {
            47,71,97,109,101,47,65,110,105,109,97,116,105,111,110,47,71,97,109,101,47,77,97,105,110,80,108,97,121,101,114,47,69,109,111,116,101,115,47,84,119,105,115,116,68,97,121,116,111,110,97,47,69,109,111,116,101,95,84,119,105,115,116,68,97,121,116,111,110,97,95,67,77,70,95,77,46,69,109,111,116,101,95,84,119,105,115,116,68,97,121,116,111,110,97,95,67,77,70,95,77,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };



        string filePath = Options.GetPaksFolder + "/pakchunk10-WindowsClient.pak";




        private void SaySo_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            richTextBox1.Clear();

            ReplaceBytes(filePath, 186804819, byte1);
            ReplaceBytes(filePath, 186804819, byte2);
            richTextBox1.AppendText("\nAdded Animation 1/2");
            ReplaceBytes(filePath, 186804578, byte3);
            ReplaceBytes(filePath, 186804578, byte4);
            richTextBox1.AppendText("\nAdded Animation 2/2");
            richTextBox1.AppendText("\nDone Converting!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            ReplaceBytes(filePath, 186804819, byte2);
            ReplaceBytes(filePath, 186804819, byte1);
            richTextBox1.AppendText("\nRevoved Animation 1/2");
            ReplaceBytes(filePath, 186804578, byte4);
            ReplaceBytes(filePath, 186804578, byte3);
            richTextBox1.AppendText("\nRemoved Animation 2/2");
            richTextBox1.AppendText("\nDone Reverting!");
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
