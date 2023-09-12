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

namespace Game_start
{
    public partial class gameBackground : Form
    {
        public gameBackground()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   SoundPlayer beepPlayer = new SoundPlayer(Properties.Resources.gameBeep);
            SoundPlayer revPlayer = new SoundPlayer(Properties.Resources._461012__matrixxx__retro_wormhole_01);
            SoundPlayer startPlayer = new SoundPlayer(Properties.Resources._403007__inspectorj__ui_confirmation_alert_a2);
           
            buttonStart.Visible = false;
            gameStartText.Visible = true;
            gameStartText.Text = "Game Starting in:";
            beepPlayer.Play();
            Update();  
            Countdown.Text = "3";
            Countdown.Visible = true;
            Update();
            Thread.Sleep(1000);
            beepPlayer.Play();
            Countdown.Text = "2";
            Update();
            Thread.Sleep(1000);
            beepPlayer.Play();
            Countdown.Text = "1";
            Update();
            Thread.Sleep(1000);
            Update();   
            startPlayer.Play();
            Countdown.Text = "GO!!!!";
            gameStartText.Visible=false;
            BackColor = Color.Green;
          



            



        }

        private void gameStartText_Click(object sender, EventArgs e)
        {
            
        }

        private void Countdown_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
