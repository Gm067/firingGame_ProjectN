using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firingGame_Project
{
    public partial class Form1 : Form
    {
        ButtonControlles button = new ButtonControlles();
        int z = 0;
        int coutShoot = 0;
        int count_shoot = 0;
        int frst = 0;
        int secnd = 0;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
            //first of all reset the butons
            load_btn.Enabled = false;
            spin_btn.Enabled = false;
            shoot_fire_btn.Enabled = false;
            shoot_away_btn.Enabled = false;
            frst = rd.Next(1,6);
            secnd = rd.Next(1,4);
        }
        // code for string the game 
        private void start_btn_Click(object sender, EventArgs e)
        {
            //this task is used to pass the condition 
            z++;
            if (button.btnTask() == z)
            {
                start_btn.Enabled = false;
                load_btn.Enabled = true;
                //this code is used to pass the value 
                show_pic.Image = firingGame_Project.Properties.Resources.pf1;
            }
            else {
                MessageBox.Show("please proceed ");
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            //here i am poceed for the load buton to load the game 
            z++;
            if (button.btnloadTask() == z)
            {
                spin_btn.Enabled = true;
                load_btn.Enabled = false;
                //this code is used to pass the value 
                show_pic.Image = firingGame_Project.Properties.Resources.pf2;
            }
            else
            {
                MessageBox.Show("please proceed ");
            }
        }

        private void spin_btn_Click(object sender, EventArgs e)
        {
            //after load the bullet spin the gun to proceeed
            z++;
            if (button.btnSpinTask() == z)
            {
                spin_btn.Enabled = false;
                shoot_fire_btn.Enabled=true;
                shoot_away_btn.Enabled = true;
                //this code is used to pass the value 
                show_pic.Image = firingGame_Project.Properties.Resources.pf1;
            }
            else
            {
                MessageBox.Show("please proceed ");
            }

        }
        // first shoot btn coding
        private void shoot_fire_btn_Click(object sender, EventArgs e)
        {
            z++;
            coutShoot++;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(firingGame_Project.Properties.Resources.guntrigger);
            sound.Play();

            if (z >= 4)
            {
                if (coutShoot == frst)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("You are dead Now! Do you Want to Play Again ", "Confirmation Message", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    // Do something  
                    MessageBox.Show("You are save ");
                }
            }
            else {
                MessageBox.Show("No more Bullets are available");
            }
                
        }
// shoot awat btn coding 
        private void shoot_away_btn_Click(object sender, EventArgs e)
        {
            count_shoot++;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(firingGame_Project.Properties.Resources.guntrigger);
            sound.Play();

            if (count_shoot <= 2)
            {
                if (count_shoot == secnd)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("You are dead Now! Do you Want to Play Again ", "Confirmation Message", buttons);
                    if (result == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else {
                    MessageBox.Show("You are save ");
                }
            }
            else {
                MessageBox.Show("You want to play Again click on Restart ");
            }

        }
    }
    
}
