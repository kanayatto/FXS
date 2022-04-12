using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace FXS
{





    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
#pragma warning disable CS0414 // The field 'Form1.initalized' is assigned but its value is never used
        bool initalized = true;
#pragma warning restore CS0414 // The field 'Form1.initalized' is assigned but its value is never used





        public static class ThreadHelperClass
        {
            delegate void SetTextCallback(Form f, Control ctrl, string text);

            public static void SetText(Form form, Control ctrl, string text)
            {
                if (ctrl.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    form.Invoke(d, new object[] { form, ctrl, text });
                }
                else
                {
                    ctrl.Text = text;
                }
            }

            internal static void SetText(SaySo saySo, RichTextBox richTextBox1, string v)
            {
                throw new NotImplementedException();
            }
        }
        //load app
        private void Form1_Load(object sender, EventArgs e)
        {
            new Form1().Hide();
            guna2TextBox1.Hide();
            guna2Button5.Hide();

            guna2Button6.Hide();
            skins1.Hide();
            options1.Hide();


            //c# discord RPC

            initalized = true;
            client = new DiscordRpcClient($"754443931206418576");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();

            client.SetPresence(new DiscordRPC.RichPresence()
            {
                Details = $"app thing",
                State = $"wtf ",
                Timestamps = Timestamps.Now,
                Assets = new Assets()
                {
                    LargeImageKey = $"logo_texture",
                    LargeImageText = "Made by Kat_#0001 uwu",
                    SmallImageKey = $""
                }
            });




        }




        private void logged_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {

            guna2Button5.Show();
            guna2TextBox1.Show();
        }

        private void logbruv1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
            skins1.Hide();
            options1.Hide();

        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {





            if (guna2TextBox1.Text == "Owner.dsc/")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("Owner");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'Owner'");





            }
            else if (guna2TextBox1.Text == "2834 1232 9392")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();

                guna2Button6.Show();
                logpic.AppendText("Kairi is sad");


                MessageBox.Show("Successfully logged in as 'Paid'");



            }

            else if (guna2TextBox1.Text == "3291 4502 2842")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("Xoid Plays");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'Paid'");



            }

            else if (guna2TextBox1.Text == "Xqc")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("Sagely");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'Paid'");



            }


            else if (guna2TextBox1.Text == "3853 8248 2034")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("Daddy Kest");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'Paid'");



            }

            else if (guna2TextBox1.Text == "9530 2748 6879")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("builder");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'Paid'");



            }

            else if (guna2TextBox1.Text == "Test.Dsc.PTB")
            {
                guna2TextBox1.Hide();

                guna2Button5.Hide();
                login.Hide();
                logpic.AppendText("PTB");
                guna2Button6.Show();



                MessageBox.Show("Successfully logged in as 'PTB'");
            }

            else
            {

                MessageBox.Show("The code you entered is incorrect, please try again" +
                    "\nIf you want an account, contact Kat_#0001 on discord. " +
                    "\nPlease note that you need to pay for an account.");

                guna2TextBox1.Focus();


            }



        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            skins1.Show();
            options1.Hide();
            dashboard1.Hide();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressbar1.Value += 1;

            if (progressbar1.Value == 100)

            {

                timer1.Enabled = false;
                guna2CustomGradientPanel1.Hide();

            }
        }

        private void progressbar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void skins1_Load(object sender, EventArgs e)
        {
            skins1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            options1.Show();
            skins1.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new soon().Show();
            MessageBox.Show("if you want to use the emotes then make sure you have no emotes on your locker.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void logpic_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void guna2CustomGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void logpic_BackgroundImageChanged(object sender, EventArgs e)
        {

        }




        //login pictures


    }
}
