using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Media;

namespace TIC_TAC_TOE
{
    public partial class _3x3 : Form
    {
        
        public bool checkbox = false;
        static bool []buttons = { false,false, false,false, false,false, false,false,false};
        static bool[] player1 = { false, false, false, false, false, false, false, false, false };
        static bool[] computer = { false, false, false, false, false, false, false, false, false };
        static int moves = 0;
        static bool win_loss_value=false;
        Random rd = new Random();
        static bool Check_player2 = false;
        static int counter1 = 0;
        static int counter2 = 0;
        public bool mov2 = false;
           

        public void reset_values()
        {
            for (int i = 0; i < 9; i++)
            {
                buttons[i] = false;
               player1[i] = false;
               computer[i] = false;
               
            }
            moves = 0;
            win_loss_value = false;
            Check_player2 = false;
            checkbox = false;
        }
        public _3x3()
        {
            InitializeComponent();
            checkbox = false;
        }
        
        public bool change_background_button(int number)
        {
            
               
            if (number == 1)
            {

                if (!computer[0])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button1.BackgroundImage = img;
                    button1.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }

            else if (number == 2)
            {
                if (!computer[1])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button2.BackgroundImage = img;
                    button2.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }

            else if (number == 3)
            {
                if (!computer[2])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button3.BackgroundImage = img;
                    button3.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 4)
            {
                if (!computer[3])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button4.BackgroundImage = img;
                    button4.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 5)
            {
                if (!computer[4])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button5.BackgroundImage = img;
                    button5.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 6)
            {
                if (!computer[5])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button6.BackgroundImage = img;
                    button6.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 7)
            {
                if (!computer[6])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button7.BackgroundImage = img;
                    button7.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 8)
            {

                if (!computer[7])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button8.BackgroundImage = img;
                    button8.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 9)
            {
                if (!computer[8])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button9.BackgroundImage = img;
                    button9.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
                return false;

        }


        public void artifial_Intelligent_move2()
        {
            if (player1[0] && player1[3])
            {
                if (!computer[6])
                {
                    change_background_button(7);
                    //  checks = true;
                    mov2 = true;
                    return;
                }
                //else
                //{
                //    if (!computer[6])
                //    {
                       
                //    }
                //}
                //return false;
            }
            if (player1[3] && player1[5])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                }
            }
            if (player1[6] && player1[8])
            {
                if (!computer[7])
                {
                    change_background_button(8);
                    mov2 = true;
                }
            }
            if (player1[0] && player1[6])
            {
                if (!computer[3])
                {
                    change_background_button(4);
                    mov2 = true;
                    return;
                }
            }
            if (player1[1] && player1[7])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                }
            }
            if (player1[2] && player1[8])
            {
                if (!computer[5])
                {
                    change_background_button(6);
                    mov2 = true;
                    return;
                }
            }
            if (player1[0] && player1[8])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                }
            }
            if (player1[4] && player1[6])
            {
                if (!computer[2])
                {
                    change_background_button(3);
                    mov2 = true;
                    return;
                }
            }
            if (player1[2] && player1[6])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                }
            }
            if (player1[0] && player1[2])
            {
                if (!computer[1])
                {
                    change_background_button(2);
                    mov2 = true;
                    return;
                }
                //else
                //{
                //    if (!computer[1])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }

            if (player1[0] && player1[1])
            {
                if (!computer[2])
                {
                    change_background_button(3);
                    mov2 = true;
                    return;
                }

                //else
                //{
                //    if (!computer[2])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[0] && player1[4])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                }
                //else
                //{
                //    if (!computer[8])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[1] && player1[2])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[0])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[1] && player1[4])
            {
                if (!computer[7])
                {
                    change_background_button(8);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[7])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[2] && player1[5])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[8])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
           if (player1[2] && player1[4])
            {
                if (!computer[6])
                {
                    change_background_button(7);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[6])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[3] && player1[4])
            {
                if (!computer[5])
                {
                    change_background_button(6);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[5])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
           if (player1[3] && player1[6])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[0])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[4] && player1[5])
            {
                if (!computer[3])
                {

                    change_background_button(4);
                    mov2 = true;
                    return;
                    //return true;
                }
                //else
                //{
                //    if (!computer[3])
                //    {
                //        return false;
                //    }
                //}
                //return false;

            }
           if (player1[4] && player1[7])
            {
                if (!computer[1])
                {
                    change_background_button(2);
                    mov2 = true;
                    return;
                    //return true;
                }
                //else
                //{
                //    if (!computer[1])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[4] && player1[8])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[0])
                //    {
                //        return false;
                //    }
                //}
                //return false;

            }
            if (player1[5] && player1[8])
            {
                if (!computer[2])
                {
                    change_background_button(3);
                    mov2 = true;
                    return;
                    //return true;
                }
                //else
                //{
                //    if (!computer[2])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[6] && player1[7])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                    //  return true;
                }
                //else
                //{
                //    if (!computer[8])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            if (player1[7] && player1[8])
            {
                if (!computer[6])
                {

                    change_background_button(7);
                    mov2 = true;
                    return;
                    // return true;
                }
                //else
                //{
                //    if (!computer[6])
                //    {
                //        return false;
                //    }
                //}
                //return false;
            }
            //else
            //{
            //    return false;
            //}
            //return false;
            
        }

        public void artifial_Intelligent_move1()
        {

          int checker = 0;
          bool checker_bool = true;

           do
           {

               if (!buttons[4])
               {

                  checker_bool =change_background_button(5);
                   
               }
               else
               {
                   //MessageBox.Show("I am in brute force area");
                   artifial_Intelligent_move2();
                   if (!mov2)
                   {
                       do
                       {
                           checker = rd.Next(1, 8);

                       } while (buttons[checker] || (player1[checker]));

                       checker_bool = change_background_button(checker + 1);
                   }
                   mov2 = false;
               }
           } while (!checker_bool);
           if (win_loss())
           {
               win_loss_value = true;
           }
             
         }
        public bool win_loss_box()
        {
            if (moves % 2 == 1)
            {
                using (var soundPlayer = new SoundPlayer(@"winning.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
                var result = MessageBox.Show(Form1.Form1Instance.label1_output()+ " Won!" , "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                    checkbox = true;
                counter2++;
                label5.Text = counter2.ToString();


                return true;
            }
            else if (moves % 2 == 0)
            {
                counter1++;
                label3.Text = counter1.ToString();
                if (Check_player2)
                {
                    using (var soundPlayer = new SoundPlayer(@"winning.wav"))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                    var result = MessageBox.Show(Form1.Form1Instance.label2_output() + " Won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.OK)
                        checkbox = true;
                }
                else
                {
                    using (var soundPlayer = new SoundPlayer(@"fail.wav"))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                    var result = MessageBox.Show("Computer Won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    if (result == DialogResult.OK)
                        checkbox = true;
                }
                return true;
            }
            return false;

        }

        public bool win_loss()
        {
            if ( ( player1[0] && player1[4] && player1[8] ) || ( computer[0] && computer[4] && computer[8]) )
            {

                return win_loss_box();
            }
               
            else if ( ( player1[0] && player1[1] && player1[2]) || (computer[0] && computer[1] && computer[2]) )
            {
                return win_loss_box();
            }

            else if ( (player1[0] && player1[3] && player1[6] ) || (computer[0] && computer[3] && computer[6]) )
            {
                return win_loss_box();
            }

            else if ( (player1[1] && player1[4] && player1[7]) || (computer[1] && computer[4] && computer[7]) )
            {
                return win_loss_box();
            }

            else if ( (player1[2] && player1[5] && player1[8]) || (computer[2] && computer[5] && computer[8]) )
            {
                return win_loss_box();
            }

            else if ( (player1[2] && player1[4] && player1[6]) || (computer[2] && computer[4] && computer[6]) )
            {
                return win_loss_box();
            }

            else if ( (player1[3] && player1[4] && player1[5]) || (computer[3] && computer[4] && computer[5]) )
            {
                return win_loss_box();
            }

            else if ((player1[6] && player1[7] && player1[8]) || (computer[6] && computer[7] && computer[8]))
            {
                return win_loss_box();
            }
            else if (moves == 9)
            {
                using (var soundPlayer = new SoundPlayer(@"fail.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
                var result = MessageBox.Show("Match Draw !", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                    checkbox = true;
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private void _3x3_Load(object sender, EventArgs e)
        {
           // check the player
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label4.Text = Form1.Form1Instance.label1_output();
            label2.Text = Form1.Form1Instance.label2_output();
            label5.Text = counter2.ToString();
            label3.Text = counter1.ToString();

            if (!Check_player2)
            {
                if (Form1.players[1])
                {
                    Check_player2 = true;
                   
                    
                }
                
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button1.BackgroundImage = img;
                buttons[0] = true;
                player1[0] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button1.Enabled = false;
            }
            else 
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button1.BackgroundImage = img;
                buttons[0] = true;
                computer[0] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button2.BackgroundImage = img;
                buttons[1] = true;
                player1[1] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button2.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button2.BackgroundImage = img;
                buttons[1] = true;
                computer[1] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button2.Enabled = false;
            }

    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button3.BackgroundImage = img;
                buttons[2] = true;
                player1[2] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button3.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button3.BackgroundImage = img;
                buttons[2] = true;
                computer[2] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button4.BackgroundImage = img;
                buttons[3] = true;
                player1[3] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button4.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button4.BackgroundImage = img;
                buttons[3] = true;
                computer[3] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button4.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button5.BackgroundImage = img;
                buttons[4] = true;
                player1[4] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button5.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button5.BackgroundImage = img;
                buttons[4] = true;
                computer[4] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button5.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button6.BackgroundImage = img;
                buttons[5] = true;
                player1[5] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button6.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button6.BackgroundImage = img;
                buttons[5] = true;
                computer[5] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button6.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button7.BackgroundImage = img;
                buttons[6] = true;
                player1[6] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button7.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button7.BackgroundImage = img;
                buttons[6] = true;
                computer[6] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button7.Enabled = false;
            }
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button8.BackgroundImage = img;
                buttons[7] = true;
                player1[7] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button8.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button8.BackgroundImage = img;
                buttons[7] = true;
                computer[7] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button8.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 9)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button9.BackgroundImage = img;
                buttons[8] = true;
                player1[8] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button9.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button9.BackgroundImage = img;
                buttons[8] = true;
                computer[8] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button9.Enabled = false;
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                if (moves >= 9 || win_loss_value)
                {
                    reset_values();
                    this.Hide();
                    this.Close();

                    Form1.Form1Instance.set_3x3(true);
                    
                }
                else if (!Check_player2)
                {

                    if (moves % 2 == 1)
                    {
                        //label1.Text = "";
                        artifial_Intelligent_move1();
                        //MessageBox.Show("Intelligent");

                    }
                }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            reset_values();
            Hide();
            Close();
            Form1.Form1Instance.max();
            
        }

        //private void label2_Click(object sender, EventArgs e)
        //{
        //     MessageBox.Show(Check_player2.ToString());
        //}

        private void button11_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            var result = MessageBox.Show("Are you sure you want to exit !", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

    }
}
