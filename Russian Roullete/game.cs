using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        russianclass russianclass = new russianclass();
        Random spinrandom = new Random();
        private void loadbtn_Click(object sender, EventArgs e)
        {
            gifimageplayer.Image = Russian_Roullete.Properties.Resources.load;

            russianclass.bulleteload = 1;
            spinbut.Enabled = true;
            loadbut.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new game()).Show();
            this.Hide();
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            russianclass.loadchamber = spinrandom.Next(1, 6);
            System.IO.Stream str = Russian_Roullete.Properties.Resources.spinnn;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            
            snd.Play();
            shootbut.Enabled = true;
            shootawaybut.Enabled = true;
            spinbut.Enabled = false;
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            gifimageplayer.Image = Russian_Roullete.Properties.Resources.shoot;
            System.IO.Stream str = Russian_Roullete.Properties.Resources.gun;
            
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int win = 0;
            win = russianclass.Shooter();

            if (win==1)
            {

                MessageBox.Show("You Loose");

                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
                shootawaybut.Enabled = false;



            }
            else if (win==2)
            {
                

                MessageBox.Show("Bullete Missed");

            }
        }

        private void buttonshootaway_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Russian_Roullete.Properties.Resources.gun;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            if (russianclass.shoot > 0 && russianclass.loadchamber == 1 && russianclass.bulletemiss == 2)

            {
                MessageBox.Show("You Win(score=100)");
                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
                shootawaybut.Enabled = false;


            }
            if (russianclass.shoot > 0 && russianclass.loadchamber == 1 && russianclass.bulletemiss == 1)
            {
                MessageBox.Show("You Win(score=50)");
                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
                shootawaybut.Enabled = false;
            }
            if (russianclass.shoot > 0 && russianclass.loadchamber != 1)
            {

                MessageBox.Show("Saved(Bullete not Fired");

                russianclass.shoot = russianclass.shoot - 1;
                russianclass.bulletemiss = russianclass.bulletemiss - 1;
                russianclass.loadchamber = russianclass.chamberspin(russianclass.loadchamber);
                russianclass.bulleteload++;

            }
            if (russianclass.shoot == 0)
            {

                MessageBox.Show("U Losse(Bullete Fired)");
                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
                shootawaybut.Enabled = false;


            }
            if (russianclass.bulletemiss == 0)
            {

                MessageBox.Show("no more chance left u loose");
                loadbut.Enabled = false;
                shootbut.Enabled = false;
                spinbut.Enabled = false;
                shootawaybut.Enabled = false;


            }
        }
    }
}
