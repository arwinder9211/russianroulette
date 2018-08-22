using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russianroulette
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Player: ";

        }
        int Chamber;
        int chamber_count = 0;
        Random ran = new Random();
        int[] playerGun = new int[6] { 0, 0, 0, 0, 0, 0};
        int round = 0;
        int miss_shot = 0;
        int total_score = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 load_sound = new Class1();
            load_sound.load_sound();

            LoadBullet();
            //here is coding about how to load a bullet

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            {
                
            }

        }
        public void LoadBullet()
        {
            Chamber = ran.Next(0, 6);
            MessageBox.Show("Player chamber " + Chamber);
        }

        public void SpinBullet()
        {
            playerGun[Chamber] = 1;
            //MessageBox.Show("Player chamber: " + playerChamber);
            //here is coding about how to spin bullet
        }
        public void Restart()
        {
            Application.ExitThread();
            Application.Restart();
            // here is coding about how to restart game
        }
        void round_count()
        {
            round++;
            label3.Text = "Round " + round;
            if (round == 6)
            {
                label3.Text = "Round " + round;
            }

        }
        public void PointAway()
        {
            round_count();
            chamber_count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class1 spin_sound = new Class1();

            spin_sound.spin_sound();
            SpinBullet();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                pictureBox3.Hide();
                pictureBox4.Show();

                Class1 shot_sound = new Class1();

                shot_sound.shot_sound();

                round_count();
                chamber_count++;

                if (playerGun[chamber_count] == 1)
                {
                    MessageBox.Show("Bang - You're dead\nBetter Lucks Next Time...\n\n***Restart Game***");
                    Restart();
                }
                else
                {
                    MessageBox.Show("Bang - You survived");
                    total_score += 100; //User get 100 points each time they survived 
                    label4.Text = "Total Shots: " + total_score;
                }
                if (round == 6)
                {
                    MessageBox.Show("YOU WON!!!\n\n***End Game***\n***Restart Game***");
                    Restart();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                
                pictureBox4.Hide();
                pictureBox3.Show();
                Class1 shot_sound = new Class1();

                shot_sound.shot_sound();


                PointAway();

                if (miss_shot <= 2)
                {
                    MessageBox.Show("You survived");
                    total_score += 100;
                    label4.Text = "Total Shots: " + total_score;
                }

                if (miss_shot > 2)
                {
                    MessageBox.Show("You're dead\nYou shoot away more than 2 times and the bullet has not been fired...\n\n***Restart Game***");

                    Restart();
                }
                //If the player has survived up to round #4 
                //this mean that the bullet is in Round #5 or Round #6
                //So when the player decided to SHOOT AWAY both round #5 and #6 this mean that they have WON because they won't be shot dead by the bullet

                if (round == 6)
                {
                    MessageBox.Show("YOU WON!!!\n\n***Restart Game***");
                    chamber_count++;

                    Restart();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Restart();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

    //Buttons Click: Load Button, Spin Button, Shoot Button, Shoot Away Button, Restart Button




