using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dino
{
    public partial class Form1 : Form
    {
        int groundSpeed = -10;
        int gravity = 0;
        int scor=0;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            dinozaur.Top = dinozaur.Top + gravity;

            //daca ajunge jos
            if (dinozaur.Top > 230)
                {
                    dinozaur.Top = 230;
                    gravity = 0;
                }

            //daca ajunge sus
            if (dinozaur.Top < 20)
                gravity = 10;


            ground.Left = ground.Left + groundSpeed;
            ground2.Left = ground2.Left + groundSpeed;
            cactus.Left = cactus.Left + groundSpeed;

            if (ground2.Left < -14)
            {
                ground.Left = -14;
                ground2.Left = 886;
            }

            if (cactus.Right < 0)
            {
                scor = scor + 1;
                cactus.Width = rnd.Next(30, 60);
                cactus.Height = rnd.Next(65, 80);
                cactus.Top = (380 - cactus.Height);
                cactus.Left = rnd.Next(800, 1100);
                labelScor.Text = "SCOR TOTAL: " + scor;
            }


            if (dinozaur.Bounds.IntersectsWith(cactus.Bounds))
            {
                gameTimer.Stop();
                if (MessageBox.Show("Reluati jocul?", "Confirma", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    MessageBox.Show("Jocul se va inchide");
                    this.Close();
                }
                else
                    restartGame();
            }

            if (scor == 10)
                groundSpeed = -15;

            
        }

        private void KeyUpIsPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if(dinozaur.Top==230)
                    gravity = -10;
            }
        }

        private void KeyDownIsPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gravity = 15;
            }
        }

        public void restartGame()
        {
            ground.Left = -14;
            ground2.Left = 886;
            cactus.Left = 900;
            cactus.Height = 80;
            cactus.Width = 50;
            cactus.Top = 300;
            scor = 0;
            groundSpeed = -10;
            dinozaur.Left = 105;
            dinozaur.Top = 230;
            labelScor.Text = "SCOR TOTAL: 0";
            gameTimer.Start();
        }
    }
}
