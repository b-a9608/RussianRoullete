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
    public partial class RussianRoullete : Form
    {
        Game clsgame = new Game();
        Random rand = new Random();
        public RussianRoullete()
        {
            InitializeComponent();
        }

        private void Btn_load_Click(object sender, EventArgs e)
        {
            video_play.Image = Russian_Roullete.Properties.Resources.Load;
            System.IO.Stream str = Russian_Roullete.Properties.Resources.loded;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            clsgame.bulleteload = 1;
            Btn_spin.Enabled = true;
            Btn_load.Enabled = false;

        }

        private void Btn_spin_Click(object sender, EventArgs e)
        {
            clsgame.loder = rand.Next(1, 6);
            System.IO.Stream str = Russian_Roullete.Properties.Resources.spined;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);

            snd.Play();
            Btn_shoot.Enabled = true;
            Btn_Shootaway.Enabled = true;
            Btn_spin.Enabled = false;
        }

        private void Btn_shoot_Click(object sender, EventArgs e)
        {
            video_play.Image = Russian_Roullete.Properties.Resources.shoot;
            System.IO.Stream str = Russian_Roullete.Properties.Resources.shoted;

            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            int win = 0;
            win = clsgame.Shooter();

            if (win == 1)
            {

                MessageBox.Show("loose");

                Btn_load.Enabled = false;
                Btn_shoot.Enabled = false;
                Btn_spin.Enabled = false;
                Btn_Shootaway.Enabled = false;



            }
            else if (win == 2)
            {


                MessageBox.Show("Missed");

            }
        }

        private void Btn_Shootaway_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Russian_Roullete.Properties.Resources.shoted;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            int k= 0;
            k = clsgame.Awayshoot();
            if (k==10)

            {
                MessageBox.Show("You Win");
                MessageBox.Show("Score=10");
                Btn_load.Enabled = false;
                Btn_shoot.Enabled = false;
                Btn_spin.Enabled = false;
                Btn_Shootaway.Enabled = false;


            }
            if (k==5)
            {
                MessageBox.Show("You Win");
                MessageBox.Show("Score=5");
                Btn_load.Enabled = false;
                Btn_shoot.Enabled = false;
                Btn_spin.Enabled = false;
                Btn_Shootaway.Enabled = false;
            }
            if (k==3)
            {

                MessageBox.Show("Saved");
                MessageBox.Show("bullet Not fired");
              

            }
            if (k== 0)
            {

                MessageBox.Show("losse");
                MessageBox.Show("bulletefired");
                Btn_load.Enabled = false;
                Btn_shoot.Enabled = false;
                Btn_spin.Enabled = false;
                Btn_Shootaway.Enabled = false;


            }
            if (k == 1)
            {

                MessageBox.Show("You losse");
                MessageBox.Show("u only get two shotaway that u used");
                Btn_load.Enabled = false;
                Btn_shoot.Enabled = false;
                Btn_spin.Enabled = false;
                Btn_Shootaway.Enabled = false;


            }
        }

        private void Btn_playagain_Click(object sender, EventArgs e)
        {
            (new RussianRoullete()).Show();
            this.Hide();
        }
    }
}
