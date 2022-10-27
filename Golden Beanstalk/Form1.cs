using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Security.Cryptography;

namespace Golden_Beanstalk
{
    /// Lexi M
    /// October 20-27 2022
    /// Choose your adventure
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
            // Display initial message and options
            outputLabel.Text = "Your mom asks you to run to the store and buy some milk,";
            outputLabel.Text += "\nDo you Accept?";
            option1Label.Text = "Go to the store";
            option2Label.Text = "Go back to bed";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 11;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 11;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                Random randgen = new Random();
                int chance = randgen.Next(1, 101);

                if (chance > 30)
                {
                    page = 18;
                }
                else
                {
                    page = 17;
                }
                
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 19;
            }    
            else if (page == 19)
            {
                page = 23;
            }
            else if (page == 20)
            {
                page = 21; 
            }
            else if (page == 21)
            {
                page = 99;
            }
            else if (page == 23)
            {
                page = 24;
            }
            else if (page == 24)
            {
                page = 26;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 28;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page ==28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 99)
            {
                page = 1;
            }
            //else if (page == 16)
            //{
            //    page = 17;
            //}
            //else if (page == 17)
            //{
            //    page = 99;
            //}
            //else if (page == 18)
            //{
            //    page = 15;
            //}
            //else if (page == 19)
            //{
            //    page = 23;
            //}
            //else if (page == 20) ;

            switch (page)
            {
                case 1:
                    outputLabel.Text = "Your mom asks you to run to the store and buy some milk,";
                    outputLabel.Text += "\nDo you Accept?";
                    option1Label.Text = "Go to the store";
                    option2Label.Text = "Go back to bed";

                    option2Button.Visible = true;

                    pictureBox1.Image = Properties.Resources.livingroom;

                    //imageBox.Image = Properties.Resources.deepBrush;

                    //SoundPlayer jungle = new SoundPlayer(Properties.Resources.jungle);
                    //jungle.Play();
                    break;
                case 2:
                    outputLabel.Text = "On your walk some guy asks you if you want to buy frogs in a pale,";
                    outputLabel.Text += "\nDo you take the offer?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.walk;

                    //imageBox.Image = Properties.Resources.forestLake;

                    //SoundPlayer brook = new SoundPlayer(Properties.Resources.brook);
                    //brook.Play();
                    break;
                //case 3:
                //    //outputLabel.Text = "You get the bucket and one of the frogs jumps at you!";
                //    //outputLabel.Text += "\nYou die of a disease! Would you like to play again?";
                //    //option1Label.Text = "Yes";
                //    //option2Label.Text = "No";
                //    break;
                case 4:
                    outputLabel.Text = "You get the bucket and one of the frogs jumps at you!";
                    outputLabel.Text += "\nYou die of a disease! ";

                    option2Button.Visible = false;
                    option1Label.Text = "Ok";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.frogs;

                    break;
                //case 5:
                //    outputLabel.Text = "A horse swims by, you do you ride it?";
                //    option1Label.Text = "Yes";
                //    option2Label.Text = "No";
                //    break;
                case 6:
                    outputLabel.Text = "You pay for them and make your way home.";
                    outputLabel.Text += "\nMom asks you to open your hand, do you?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.handd;
                    break;
                case 7:
                    outputLabel.Text = "You die alone.";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.died;
                    break;
                case 8:
                    outputLabel.Text = "You open your hand and mom scolds you and throws the beans out the window.";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.windoww;

                    option1Button.Visible = false;
                    option2Button.Visible = false;

                    Refresh();
                    Thread.Sleep(3000);

                    SoundPlayer growing = new SoundPlayer(Properties.Resources.growing);
                    growing.Play();

                    pictureBox1.Visible = false;
                    BackColor = Color.Black;
                    
                    Refresh();
                    Thread.Sleep(3000);

                    pictureBox1.Visible = true;
                    BackColor = Color.NavajoWhite;

                    outputLabel.Text = "You hear noises outside your window!";
                    outputLabel.Text += "\nDo you check it out?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    option1Button.Visible = true;
                    option2Button.Visible = true;

                    break;
                case 11:
                    outputLabel.Text = "You get up and check it out and there's a huge beanstalk outside of the house!";
                    outputLabel.Text += "\nDo you check it out?";
                    option1Label.Text = "Climb";
                    option2Label.Text = "Stay put";

                    pictureBox1.Image = Properties.Resources.beanstalk;

                    option2Button.Visible = true;
                    break;
                case 13:
                    outputLabel.Text = "You start to climb the beanstalk and you reach a slippery part.";
                    outputLabel.Text += "\nWhat way do you go?";
                    option1Label.Text = "Slippery path";
                    option2Label.Text = "Follow dry path";

                    pictureBox1.Image = Properties.Resources.beanstalk;
                    break;
                case 14:
                    outputLabel.Text = "You follow the slippery path and side all the way back down.";
                    outputLabel.Text += "";
                    option1Label.Text = "AHHH!";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.house;

                    option2Button.Visible = false;
                    break;
                case 16:
                    outputLabel.Text = "You make it to the Wishing Well,";
                    outputLabel.Text += "\nDo you make a wish?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    option3Label.Text = "";

                    pictureBox1.Image = Properties.Resources.wishingwell;

                    option3Button.Visible = false;
                    break;
                case 17:
                    outputLabel.Text = "You wish fails and you teliport home.";
                    outputLabel.Text += "";
                    option1Label.Text = "Shucks";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    pictureBox1.Image = Properties.Resources.house;

                    option2Button.Visible = false;
                    break;
                case 18:
                    outputLabel.Text = "You wish for more money and appears in your hand.";
                    outputLabel.Text += "\nYou then spot a bridge and continue your adventure.";
                    option1Label.Text = "Neat!";
                    option2Label.Text = "";
                    option3Label.Text = "";

                    pictureBox1.Image = Properties.Resources.money;

                    option2Button.Visible = false;
                    break;
                case 21:
                    outputLabel.Text = "You row in the boat into the middle of the lake and get trapped in a whirlpool!";
                    option1Label.Text = "Damn";
                    option2Label.Text = "";
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.whirlpool;
                    break;
                case 23:
                    outputLabel.Text = "You cross the woodden bridge and enter a flower garden!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option1Label.Visible = false;
                    option2Label.Visible = false;

                    pictureBox1.Image = Properties.Resources.flowergarden;

                    Refresh();
                    Thread.Sleep(4000);

                    SoundPlayer roaringlion = new SoundPlayer(Properties.Resources.roaringlion);
                    roaringlion.Play();

                    outputLabel.Text = "What was that?";
                    outputLabel.Text += "\nOh no! A dragon!";
                    option1Label.Visible = true;
                    option2Label.Visible = true;
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option1Label.Text = "Run";
                    option2Label.Text = "Hide";
                    option3Label.Visible = false;
                    option3Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.dragonhaku;
                    break;
                case 24:
                    outputLabel.Text = "You run into a nearby castle and you've lost the dragon.";
                    outputLabel.Text += "\nTheres a golden apple sitting on stand in the middle of the room.";
                    option1Label.Text = "Take it";
                    option2Label.Text = "Leave it.";

                    pictureBox1.Image = Properties.Resources.goldenapple;
                    break;
                case 26:
                    outputLabel.Text = "You store the golden apple in your pocket and run out of the room";
                    outputLabel.Text += "\nYou turn the corner and the dragon is there!";
                    option1Label.Text = "Give the Dragon the Golden Apple";
                    option2Label.Text = "Keep the Golden Apple";

                    pictureBox1.Image = Properties.Resources.dragonhaku;
                    break;
                case 28:
                    outputLabel.Text = "You give the dragon the Golden Apple and he becomes your friend!";

                    option1Label.Visible = false;
                    option2Label.Visible = false;
                    option1Button.Visible = false;
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.frienddragon;

                    SoundPlayer yaysound = new SoundPlayer(Properties.Resources.yaysound);
                    yaysound.Play();

                    Refresh();
                    Thread.Sleep(2000);

                    outputLabel.Text = "Congrats you befriended the Beanstalk Dragon!";
                    option1Label.Text = "Yay!";
                    option1Label.Visible = true;
                    option1Button.Visible = true;
                    option2Label.Text = "";
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.haku;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing.";
                    outputLabel.Text += "\nWould you like to play again or quit?";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Quit";
                    option2Label.Visible = true;
                    option2Button.Visible = true;

                    pictureBox1.Image = Properties.Resources.haku;
                    break;

                    

                //Refresh();
                //Thread.Sleep(2000);
                //Application.Exit();

                default:
                    break;
            }
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 99;
            }
            else if (page == 8)
            {
                page = 10;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 15;
            }
            else if (page == 14)
            {
                page = 11;
            }
            else if (page == 15)
            {
                page = 19;
            }
            else if (page ==16)
            {
                page = 15;
            }
            else if (page == 19)
            {
                page = 15;
            }
            else if (page ==20)
            {
                page = 15;
            }
            else if (page == 23)
            {
                page = 25;
            }
            else if (page == 24)
            {
                page = 27;
            }
            else if (page == 26)
            {
                page = 29;
            }
            else if (page ==29)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 15;
            }
            
            


            //else if (page == 16)
            //{
            //    page = 17;
            //}
            //else if (page == 17)
            //{
            //    page = 99;
            //}
            //else if (page == 18)
            //{
            //    page = 15;
            //}
            //else if (page == 19)
            //{
            //    page = 23;
            //}
            //else if (page == 20) ;

            switch (page)
            {
                case 1:
                    outputLabel.Text = "Your mom asks you to run to the store and buy some milk,";
                    outputLabel.Text += "\nDo you Accept?";
                    option1Label.Text = "Go to the store";
                    option2Label.Text = "Go back to bed";
                                                          
                    break;
                case 2:
                    outputLabel.Text = "On your walk some guy asks you if you want to buy frogs in a pale,";
                    outputLabel.Text += "\nDo you take the offer?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    //imageBox.Image = Properties.Resources.forestLake;

                    //SoundPlayer brook = new SoundPlayer(Properties.Resources.brook);
                    //brook.Play();
                    break;
                case 3:
                    outputLabel.Text = "Mom gets angry and you get grounded!";
                    outputLabel.Text += "\n You lose!";
                                             
                    option2Button.Visible = false;
                    option1Label.Text = "Ok";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.door;
                    break;
                case 4:
                    outputLabel.Text = "You get the bucket and one of the frogs jumps at you!";
                    outputLabel.Text += "\nYou die of a disease! ";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.died;

                    break;
                case 5:
                    outputLabel.Text = "You run off to the store and when you enter you see magic beans,";
                    outputLabel.Text += "\nDo you grab them?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.beans;
                    break;
                case 6:
                    outputLabel.Text = "You pay for them and make your way home.";
                    outputLabel.Text += "\nMom asks you to open your hand, do you?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    pictureBox1.Image = Properties.Resources.beans;
                    break;
                case 7:
                    outputLabel.Text = "You grab the milk and make your way home, your mom is pleased";
                    
                    option2Button.Visible = false;
                    option1Label.Text = "I'm happy";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.milk;
                    break;
                case 8:
                    outputLabel.Text = "";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";
                    break;
                case 9:
                    outputLabel.Text = "You run out of this house, swallowing the beans.";
                    outputLabel.Text += "\nThey grow inside of you, and become a beanstalk!";

                    option2Button.Visible = false;
                    option1Label.Text = "Ouch!";
                    option2Label.Text = "";

                    pictureBox1.Image = Properties.Resources.died;
                    break;
                case 10:
                    outputLabel.Text = "You go back to sleep.";
                    outputLabel.Text += "\nWhen you awake, someone has claimed your beanstalk!";

                    pictureBox1.Image = Properties.Resources.beanstalk;

                    option2Button.Visible = false;
                    option1Label.Text = "I failed";
                    option2Label.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You ignore the big beanstalk thinking it was all a dream and head back inside to sleep";

                    option2Button.Visible = false;
                    option1Label.Text = "I'm so tired";
                    option2Label.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You continue your climb up and make it to the clouds!";
                    outputLabel.Text += "\nThere are 3 differnt paths.";
                    option1Label.Text = "A green path that leads to a wishing well";
                    option2Label.Text = "A blue path that leads to a bridge";
                    option3Label.Visible = true;
                    option3Button.Visible = true;
                    option3Label.Text = "A yellow path that leads to a lake with a rowboat";

                    pictureBox1.Image = Properties.Resources.paths;

                    break;
                    
                case 19:
                    outputLabel.Text = "You make it to the big wooden bridge!";
                    outputLabel.Text += "\nDo you cross the bridge?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "Go back";

                    pictureBox1.Image = Properties.Resources.bridge;

                    option3Label.Visible = false;
                    option3Button.Visible = false;


                    break;
                case 25:
                    outputLabel.Text = "You hide in a near by bush but the dragon finds you and kills you!";
                    option1Label.Text = "Ok";
                    option2Label.Text = "";
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.died;
                    break;
                case 27:
                    outputLabel.Text = "You leave the apple be and run back out the door.";
                    outputLabel.Text += "\nThe dragon turns the corner and eats you";
                    option1Label.Text = "Ouch";
                    option2Label.Text = "";
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.died;
                    break;
                case 29:
                    outputLabel.Text = "You don't give the dragon the apple he gets angry and eats you!";
                    option1Label.Text = "Rude";
                    option2Label.Text = "";
                    option2Button.Visible = false;

                    pictureBox1.Image = Properties.Resources.died;
                    break;
                case 99:
                    outputLabel.Text = "Thanks for playing.";
                    outputLabel.Text += "\nWould you like to play again or quit?";
                    option1Label.Text = "Play Again";
                    option2Label.Text = "Quit";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();

                    pictureBox1.Image = Properties.Resources.dragonhaku;

                    break;

            }
        }

        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 15)
            {
                page = 20;
            }
            
            
            switch (page)
            {
                case 20:
                    outputLabel.Text = "You make it to the cloud lake.";
                    outputLabel.Text += "\nDo you row the boat?";
                    option1Label.Text = "Row the boat";
                    option2Label.Text = "Go back";
                    option3Button.Visible = false;
                    option3Label.Visible = false;

                    pictureBox1.Image = Properties.Resources.cloud;
                    break;
            }
        }
    }
}
