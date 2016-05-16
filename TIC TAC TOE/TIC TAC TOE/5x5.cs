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
    public partial class _5x5 : Form
    {
        public bool checkbox   = false;
        static bool[] buttons  = new bool[25];
        static bool[] player1  = new bool[25];
        static bool[] computer = new bool[25];
        static int moves = 0;
        static bool win_loss_value = false;
        Random rd = new Random();
        static bool Check_player2 = false;
        public void reset_values()
        {
            for (int i = 0; i < 25; i++)
            {
                buttons[i] = false;
                player1[i] = false;
                computer[i] = false;

            }
            moves = 0;
            win_loss_value = false;
            Check_player2 = false;
            checkbox = false;

            if (!Check_player2)
            {
                if (Form1.players[1])
                {
                    Check_player2 = true;
                }
            } 
        }
        public _5x5()
        {
            InitializeComponent();
        }
        static int counter1 = 0;
        static int counter2 = 0;
        public bool mov2 = false;

        private void _5x5_Load(object sender, EventArgs e)
        {
            reset_values();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label4.Text = Form1.Form1Instance.label1_output();
            label2.Text = Form1.Form1Instance.label2_output();
            label5.Text = counter2.ToString();
            label3.Text = counter1.ToString();

        }
        public bool win_loss_box()
        {
            if (moves % 2 == 1)
            {
                counter2++;
                label5.Text = counter2.ToString();
                using (var soundPlayer = new SoundPlayer(@"winning.wav"))
                {
                    soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                }
                var result = MessageBox.Show(Form1.Form1Instance.label1_output() + " Won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (result == DialogResult.OK)
                    checkbox = true;

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
            if ((player1[0] && player1[1] && player1[2] && player1[3]  && player1[4]) || (computer[0] && computer[1] && computer[2] && computer[3] && computer[4]))
            {
                return win_loss_box();
            }
            else if ((player1[5] && player1[6] && player1[7] && player1[8] && player1[9]) || (computer[5] && computer[6] && computer[7] && computer[8] && computer[9]))
            {
                return win_loss_box();
            }
            else if ((player1[10] && player1[11] && player1[12] && player1[13] && player1[14]) || (computer[10] && computer[11] && computer[12] && computer[13] && computer[14]))
            {
                return win_loss_box();
            }
            else if ((player1[15] && player1[16] && player1[17] && player1[18] && player1[19]) || (computer[15] && computer[16] && computer[17] && computer[18] && computer[19]))
            {
                return win_loss_box();
            }
            else if ((player1[20] && player1[21] && player1[22] && player1[23] && player1[24]) || (computer[20] && computer[21] && computer[22] && computer[23] && computer[24]))
            {
                return win_loss_box();
            }
            else if ((player1[0] && player1[5] && player1[10] && player1[15] && player1[20]) || (computer[0] && computer[5] && computer[10] && computer[15] && computer[20]))
            {
                return win_loss_box();
            }
            else if ((player1[4] && player1[9] && player1[14] && player1[19] && player1[24]) || (computer[4] && computer[9] && computer[14] && computer[19] && computer[24]))
            {
                return win_loss_box();
            }
            else if ((player1[4] && player1[8] && player1[12] && player1[16] && player1[20]) || (computer[4] && computer[8] && computer[12] && computer[16] && computer[20]))
            {
                return win_loss_box();
            }
            else if ((player1[0] && player1[6] && player1[12] && player1[18] && player1[24]) || (computer[0] && computer[6] && computer[12] && computer[18] && computer[24]))
            {
                return win_loss_box();
            }
            else if ((player1[1] && player1[6] && player1[11] && player1[16] && player1[21]) || (computer[1] && computer[6] && computer[11] && computer[16] && computer[21]))
            {
                return win_loss_box();
            }
            else if ((player1[2] && player1[7] && player1[12] && player1[17] && player1[22]) || (computer[2] && computer[7] && computer[12] && computer[17] && computer[22]))
            {
                return win_loss_box();
            }
            else if ((player1[3] && player1[8] && player1[13] && player1[18] && player1[23]) || (computer[3] && computer[8] && computer[13] && computer[18] && computer[23]))
            {
                return win_loss_box();
            }
            else if (moves == 25)
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
        public void artifial_Intelligent_move1()
        {

            int checker = 0;
            bool checker_bool = true;
            bool first_move = true;
            if (moves == 1)
            {
                first_move = false;
            }
            int randomly_1to4 = 0;
            do
            {


                //checker_bool = change_background_button(5);
                if (!first_move)
                {

                    randomly_1to4 = rd.Next(0, 4);
                    if (randomly_1to4 == 0)
                    {
                        checker = 0;
                    }
                    else if (randomly_1to4 == 1)
                    {
                        checker = 5;
                    }
                    else if (randomly_1to4 == 2)
                    {
                        checker = 20;
                    }
                    else if(randomly_1to4==3)
                    {
                        checker = 24;
                    }
                    else if (randomly_1to4 == 4)
                    {
                        checker = 12;
                    }
                    if (!buttons[checker])
                    {
                        checker_bool = change_background_button(checker + 1);
                    }
                }
                else
                {
                    artifial_Intelligent_move2();
                    //MessageBox.Show("I am in brute force area");
                    if (!mov2)
                    {
                        do
                        {
                            checker = rd.Next(0, 24);

                        } while (buttons[checker] || player1[checker]);

                        checker_bool = change_background_button(checker + 1);
                    }
                   mov2 = false;
                }
            }
            while (!checker_bool);
            timer1.Stop();
            if (win_loss())
            {
                win_loss_value = true;
            }
            timer1.Start();

        }
        public void artifial_Intelligent_move2()
        {
            if (player1[0] && player1[1] && player1[2] && player1[3])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                    //return true;
                }
              // return false;
            }
             if (player1[4] && player1[1] && player1[2] && player1[3])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;

                  //  return true;
                }
               // return false;
            }
           if (player1[0] && player1[2] && player1[2] && player1[3])
            {
                if (!computer[1])
                {
                    change_background_button(2);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[0] && player1[1] && player1[3] && player1[3])
            {
                if (!computer[2])
                {
                    change_background_button(3);
                    mov2 = true;
                    return;
                }
              //  return false;
            }
           if (player1[0] && player1[1] && player1[2] && player1[4])
            {
                if (!computer[3])
                {
                    change_background_button(4);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
            if (player1[5] && player1[6] && player1[7] && player1[8])
            {
                if (!computer[9])
                {
                    change_background_button(10);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[9] && player1[6] && player1[7] && player1[8])
            {
                if (!computer[5])
                {
                    change_background_button(6);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
           if (player1[5] && player1[9] && player1[7] && player1[8])
            {
                if (!computer[6])
                {
                    change_background_button(7);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
            if (player1[5] && player1[6] && player1[9] && player1[8])
            {
                if (!computer[7])
                {
                    change_background_button(8);
                    mov2 = true;
                    return;
                 //   return true;
                }
              //  return false;
            }
            if (player1[5] && player1[6] && player1[7] && player1[9])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                   // return true;
                }
             //   return false;
            }
            if (player1[10] && player1[11] && player1[12] && player1[13])
            {
                if (!computer[14])
                {
                    change_background_button(15);
                        mov2 = true;
                         return;
                 //   return true;
                }
              //  return false;
            }
             if (player1[14] && player1[11] && player1[12] && player1[13])
            {
                if (!computer[10])
                {
                    change_background_button(11);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
           if (player1[10] && player1[14] && player1[12] && player1[13])
            {
                if (!computer[11])
                {
                    change_background_button(12);
                    mov2 = true;
                    return;
                 //   return true;
                }
               // return false;
            }
           if (player1[10] && player1[11] && player1[14] && player1[13])
            {
                if (!computer[12])
                {
                    change_background_button(13);
                    mov2 = true;
                    return;
                 //   return true;
                }
              //  return false;
            }
            if (player1[10] && player1[11] && player1[12] && player1[14])
            {
                if (!computer[13])
                {
                    change_background_button(14);
                    mov2 = true;
                    return;
                 //   return true;
                }
              //  return false;
            }
            else if (player1[15] && player1[16] && player1[17] && player1[18])
            {
                if (!computer[19])
                {
                    change_background_button(20);
                    mov2 = true;
                    return;
                 //   return true;
                }
              //  return false;
            }
           if (player1[19] && player1[16] && player1[17] && player1[18])
            {
                if (!computer[15])
                {
                    change_background_button(16);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
           if (player1[15] && player1[19] && player1[17] && player1[18])
            {
                if (!computer[16])
                {
                    change_background_button(17);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[15] && player1[16] && player1[19] && player1[18])
            {
                if (!computer[17])
                {
                    change_background_button(18);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
            if (player1[15] && player1[16] && player1[17] && player1[19])
            {
                if (!computer[18])
                {
                    change_background_button(19);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
          if (player1[20] && player1[21] && player1[22] && player1[23])
            {
                if (!computer[24])
                {
                    change_background_button(25);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[24] && player1[21] && player1[22] && player1[23])
            {
                if (!computer[20])
                {
                    change_background_button(21);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
           if (player1[20] && player1[24] && player1[22] && player1[23])
            {
                if (!computer[21])
                {
                    change_background_button(22);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
           if (player1[20] && player1[21] && player1[24] && player1[23])
            {
                if (!computer[22])
                {
                    change_background_button(23);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[0] && player1[5] && player1[10] && player1[15])
            {
                if (!computer[20])
                {
                    change_background_button(21);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
          if (player1[20] && player1[5] && player1[10] && player1[15])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;
                   // return true;
                }
             //   return false;
            }
           if (player1[0] && player1[20] && player1[10] && player1[15])
            {
                if (!computer[5])
                {
                    change_background_button(6);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
            if (player1[0] && player1[5] && player1[20] && player1[15])
            {
                if (!computer[10])
                {
                    change_background_button(11);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
           if (player1[0] && player1[5] && player1[10] && player1[20])
            {
                if (!computer[15])
                {
                    change_background_button(16);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[4] && player1[9] && player1[14] && player1[19])
            {
                if (!computer[24])
                {
                    change_background_button(25);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[24] && player1[9] && player1[14] && player1[19])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                 //   return true;
                }
               // return false;
            }
            if (player1[4] && player1[24] && player1[14] && player1[19])
            {
                if (!computer[9])
                {
                    change_background_button(10);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[4] && player1[9] && player1[24] && player1[19])
            {
                if (!computer[14])
                {
                    change_background_button(15);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
           if (player1[4] && player1[9] && player1[14] && player1[24])
            {
                if (!computer[19])
                {
                    change_background_button(20);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[4] && player1[8] && player1[12] && player1[16])
            {
                if (!computer[20])
                {
                    change_background_button(21);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[20] && player1[8] && player1[12] && player1[16])
            {
                if (!computer[4])
                {
                    change_background_button(5);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
           if (player1[4] && player1[20] && player1[12] && player1[16])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[4] && player1[8] && player1[20] && player1[16])
            {
                if (!computer[12])
                {
                    change_background_button(13);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
          if (player1[4] && player1[8] && player1[12] && player1[20])
            {
                if (!computer[16])
                {
                    change_background_button(17);
                    mov2 = true;
                    return;
                  //  return true;
                }
             //   return false;
            }
           if (player1[0] && player1[6] && player1[12] && player1[18])
            {
                if (!computer[24])
                {
                    change_background_button(25);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
           if (player1[24] && player1[6] && player1[12] && player1[18])
            {
                if (!computer[0])
                {
                    change_background_button(1);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
           if (player1[0] && player1[24] && player1[12] && player1[18])
            {
                if (!computer[6])
                {
                    change_background_button(7);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
            if (player1[0] && player1[6] && player1[24] && player1[18])
            {
                if (!computer[12])
                {
                    change_background_button(23);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }

            if (player1[0] && player1[6] && player1[12] && player1[24])
            {
                if (!computer[18])
                {
                    change_background_button(19);
                    mov2 = true;
                    return;
                 //   return true;
                }
               // return false;
            }
           if (player1[1] && player1[6] && player1[11] && player1[16])
            {
                if (!computer[21])
                {
                    change_background_button(22);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
           if (player1[21] && player1[6] && player1[11] && player1[16])
            {
                if (!computer[1])
                {
                    change_background_button(2);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[1] && player1[21] && player1[11] && player1[16])
            {
                if (!computer[6])
                {
                    change_background_button(7);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
            if (player1[1] && player1[6] && player1[21] && player1[16])
            {
                if (!computer[11])
                {
                    change_background_button(12);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[1] && player1[6] && player1[11] && player1[21])
            {
                if (!computer[16])
                {
                    change_background_button(17);
                    mov2 = true;
                    return;
                //    return true;
                }
              //  return false;
            }
           if (player1[2] && player1[7] && player1[12] && player1[17])
            {
                if (!computer[22])
                {
                    change_background_button(23);
                    mov2 = true;
                    return;
                   // return true;
                }
             //   return false;
            }
           if (player1[22] && player1[7] && player1[12] && player1[17])
            {
                if (!computer[2])
                {
                    change_background_button(3);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
           if (player1[2] && player1[22] && player1[12] && player1[17])
            {
                if (!computer[7])
                {
                    change_background_button(8);
                    mov2 = true;
                    return;
                   // return true;
                }
               // return false;
            }
           if (player1[2] && player1[7] && player1[22] && player1[17])
            {
                if (!computer[12])
                {
                    change_background_button(13);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[2] && player1[7] && player1[12] && player1[22])
            {
                if (!computer[17])
                {
                    change_background_button(18);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            if (player1[3] && player1[8] && player1[13] && player1[18])
            {
                if (!computer[23])
                {
                    change_background_button(24);
                    mov2 = true;
                    return;
                 //   return true;
                }
              //  return false;
            }
          if (player1[23] && player1[8] && player1[13] && player1[18])
            {
                if (!computer[3])
                {
                    change_background_button(4);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
           if (player1[3] && player1[23] && player1[13] && player1[18])
            {
                if (!computer[8])
                {
                    change_background_button(9);
                    mov2 = true;
                    return;
                  //  return true;
                }
              //  return false;
            }
          if (player1[3] && player1[8] && player1[23] && player1[18])
            {
                if (!computer[13])
                {
                    change_background_button(14);
                    mov2 = true;
                    return;
                   // return true;
                }
              //  return false;
            }
            if (player1[3] && player1[8] && player1[13] && player1[23])
            {
                if (!computer[18])
                {
                    change_background_button(19);
                    mov2 = true;
                    return;
                  //  return true;
                }
               // return false;
            }
            //return false;
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
            else if (number == 10)
            {
                if (!computer[9])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button10.BackgroundImage = img;
                    button10.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 11)
            {
                if (!computer[10])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button11.BackgroundImage = img;
                    button11.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 12)
            {
                if (!computer[11])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button12.BackgroundImage = img;
                    button12.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 13)
            {
                if (!computer[12])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button13.BackgroundImage = img;
                    button13.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 14)
            {
                if (!computer[13])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button14.BackgroundImage = img;
                    button14.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 15)
            {
                if (!computer[14])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button15.BackgroundImage = img;
                    button15.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 16)
            {
                if (!computer[15])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button16.BackgroundImage = img;
                    button16.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 17)
            {
                if (!computer[16])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button17.BackgroundImage = img;
                    button17.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 18)
            {
                if (!computer[17])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button18.BackgroundImage = img;
                    button18.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 19)
            {
                if (!computer[18])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button19.BackgroundImage = img;
                    button19.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 20)
            {
                if (!computer[19])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button20.BackgroundImage = img;
                    button20.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 21)
            {
                if (!computer[20])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button21.BackgroundImage = img;
                    button21.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 22)
            {
                if (!computer[21])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button22.BackgroundImage = img;
                    button22.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 23)
            {
                if (!computer[22])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button23.BackgroundImage = img;
                    button23.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 24)
            {
                if (!computer[23])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button24.BackgroundImage = img;
                    button24.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }
            else if (number == 25)
            {
                if (!computer[24])
                {
                    Image img = new Bitmap("V.png"); // for debug folder
                    button25.BackgroundImage = img;
                    button25.Enabled = false;
                    buttons[number - 1] = true;
                    computer[number - 1] = true;
                    moves++;
                    return true;
                }

                return false;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
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

            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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
            if (moves % 2 == 0 && moves < 25)
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

        private void button10_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button10.BackgroundImage = img;
                buttons[9] = true;
                player1[9] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button10.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button10.BackgroundImage = img;
                buttons[9] = true;
                computer[9] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button10.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button11.BackgroundImage = img;
                buttons[10] = true;
                player1[10] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button11.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button11.BackgroundImage = img;
                buttons[10] = true;
                computer[10] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button12.BackgroundImage = img;
                buttons[11] = true;
                player1[11] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button12.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button12.BackgroundImage = img;
                buttons[11] = true;
                computer[11] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button12.Enabled = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button13.BackgroundImage = img;
                buttons[12] = true;
                player1[12] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button13.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button13.BackgroundImage = img;
                buttons[12] = true;
                computer[12] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button13.Enabled = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button14.BackgroundImage = img;
                buttons[13] = true;
                player1[13] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button14.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button14.BackgroundImage = img;
                buttons[13] = true;
                computer[13] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button14.Enabled = false;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button15.BackgroundImage = img;
                buttons[14] = true;
                player1[14] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button15.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button15.BackgroundImage = img;
                buttons[14] = true;
                computer[14] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button15.Enabled = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button16.BackgroundImage = img;
                buttons[15] = true;
                player1[15] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button16.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button16.BackgroundImage = img;
                buttons[15] = true;
                computer[15] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button16.Enabled = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button17.BackgroundImage = img;
                buttons[16] = true;
                player1[16] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button17.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button17.BackgroundImage = img;
                buttons[16] = true;
                computer[16] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button17.Enabled = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button18.BackgroundImage = img;
                buttons[17] = true;
                player1[17] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button18.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button18.BackgroundImage = img;
                buttons[17] = true;
                computer[17] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button17.Enabled = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button19.BackgroundImage = img;
                buttons[18] = true;
                player1[18] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button19.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button19.BackgroundImage = img;
                buttons[18] = true;
                computer[18] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button19.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button20.BackgroundImage = img;
                buttons[19] = true;
                player1[19] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button20.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button20.BackgroundImage = img;
                buttons[19] = true;
                computer[19] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button20.Enabled = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button21.BackgroundImage = img;
                buttons[20] = true;
                player1[20] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button21.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button21.BackgroundImage = img;
                buttons[20] = true;
                computer[20] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button21.Enabled = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button22.BackgroundImage = img;
                buttons[21] = true;
                player1[21] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button22.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button22.BackgroundImage = img;
                buttons[21] = true;
                computer[21] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button22.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button23.BackgroundImage = img;
                buttons[22] = true;
                player1[22] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button23.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button23.BackgroundImage = img;
                buttons[22] = true;
                computer[22] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button23.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button24.BackgroundImage = img;
                buttons[23] = true;
                player1[23] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button24.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button24.BackgroundImage = img;
                buttons[23] = true;
                computer[23] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button24.Enabled = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (moves % 2 == 0 && moves < 25)
            {
                Image img = new Bitmap("X.png"); // for debug folder

                button25.BackgroundImage = img;
                buttons[24] = true;
                player1[24] = true;
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button25.Enabled = false;
            }
            else
            {
                Image img = new Bitmap("V.png"); // for debug folder

                button25.BackgroundImage = img;
                buttons[24] = true;
                computer[24] = true; // computer array is player 2
                moves++;
                timer1.Stop();
                if (win_loss())
                {
                    win_loss_value = true;
                }
                timer1.Start();
                button25.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"click.wav"))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            var result = MessageBox.Show("Are you sure you want to exit !", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void button27_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moves >= 25 || win_loss_value)
            {
                reset_values();
                this.Hide();
                this.Close();
               
               Form1.Form1Instance.show_Pictures();
              Form1.Form1Instance.set_5x5(true);

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
        
    }
}
