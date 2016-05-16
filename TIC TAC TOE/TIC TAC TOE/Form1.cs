using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace TIC_TAC_TOE
{
     // just replace of mov2 with void function nd place any bool element in the loop nd giving to to void function for true
    // nd false you will get the result of them as same
    public partial class Form1 : Form
    {
        public static Form1 Form1Instance;
        public static bool[] players = { false, false };
        public  static bool[] board_size = { false, false, false };
        public int labels = 0;
      
        public void show_Pictures()
        {
            pictureBox1.Show();
            pictureBox2.Show();
        }
        public void mini()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;
        }
        public void change_background()
        {
            Image img = new Bitmap("back_ground.png"); // for debug folder

            this.BackgroundImage = img;
        }
        public  void max()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            Visible = true;
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Show();
            label2.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            change_background();
            
        }
        public string label1_output()
        {
            return label2.Text;
        }
        public string label2_output()
        {
            return label1.Text;
        }
        public void label1_input( string input)
        {
            label2.Text = input;
        }
        public void label2_input(string input)
        {
            label1.Text = input;
        }
        public void set_3x3(bool value)
        {
            board_size[0] = true;
        }
        public void set_4x4(bool value)
        {
            board_size[1] = true;
        }
        public void set_5x5(bool value)
        {
            board_size[2] = true;
        }

        public Form1()
        {       
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            players[1] = true;
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Show();
            label2.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            pictureBox1.Show();
            pictureBox2.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Show();
            label2.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            players[0] = true;
            players[1] = false; ;
            change_background();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1Instance = this;
            label1.Hide();
            label2.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            pictureBox1.Show();
            pictureBox2.Show();
            
            button1.Hide();
            button2.Hide();
            button3.Hide();
            label1.Text = "Player 2";
            label1.Show();
            label2.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            players[1] = true;
            change_background();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            
            players[1] = false;
            pictureBox1.Hide();
            pictureBox2.Hide();
            label1.Hide();
            label2.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button1.Show();
            button2.Show();
            button3.Show();
            Image img = new Bitmap("background.png"); // for debug folder

            this.BackgroundImage = img;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            
            board_size[0] = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (board_size[0])
            {
                
                _3x3 open_3x3 = new _3x3();
                open_3x3.Show();
              //  players[1] = false
                board_size[0] = false;
                mini();
               

            }
            else if (board_size[1])
            {
                
                _4x4 open_4x4 = new _4x4();
                open_4x4.Show();
                board_size[1] = false;
                mini();
                
            }
            else if (board_size[2])
            {
                _5x5 open_5x5 = new _5x5();
                open_5x5.Show();
                board_size[2] = false;
                mini();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
          var result = MessageBox.Show("Are you sure you want to exit !", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result==DialogResult.Yes)
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            board_size[1] = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            board_size[2] = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            input_labels lbn = new input_labels();
            lbn.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (players[1])
            {

                input_label2 lbn = new input_label2();
                lbn.ShowDialog();
            }
        }
    }
}
