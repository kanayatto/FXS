using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace FXS_rpc_changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
        bool initalized = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("if you dont preview, contact cat vibe#7634 on discord, \n or got to");
        }

        private void ini_Click(object sender, EventArgs e)
        {
            initalized = true;
            client = new DiscordRpcClient($"{textBox3.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (initalized == false)
            {
                MessageBox.Show("You need to initialize app first! you fucking bitch.... uwu");
            }
            else
            {
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox1.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox5.Text}",
                        LargeImageText = $"{textBox6.Text}",
                        SmallImageKey = $"{textBox4.Text}",
                        SmallImageText = $"{textBox7.Text}",
                        
                    }
                });
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
