using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Connect4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] matrice = new int[11, 12];
        //SoundPlayer sp = new SoundPlayer("C:/Users/Adrian/Documents/Facultate/An2/Semestru 2/Algoritmi programare/Games/Connect4/sound/busted.wav");
        //SoundPlayer sp = new SoundPlayer("C:/Users/mihai/Desktop/sound/busted.wav");
        private void Form1_Load(object sender, EventArgs e)
        {
            /*string vector = "";

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 7; j++)
                    matrice[i, j] = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                    vector = vector + matrice[i, j].ToString() + " ";
                vector = vector + "/n";
            }

            label1.Text = vector;*/
        }

        int coloana = 0;
        int round = 1;
        int linie=0;
        private void KeyPressed(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right)
            {
                if (coloana < 6)
                {
                    coloana++;
                    redball.Left = redball.Left + 60;
                }
                
            }
            if (e.KeyCode == Keys.Left)
            {
                if (coloana > 0)
                {
                    coloana--;
                    redball.Left = redball.Left - 60;
                }
                
            }

            if(e.KeyCode == Keys.Enter)
            {
                if (round % 2 != 0)
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (matrice[i, coloana] == 0)
                        {
                            linie = i;
                            matrice[i, coloana] = 1;
                            NewRedBall(linie);
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (matrice[i, coloana] == 0)
                        {
                            linie = i;
                            matrice[i, coloana] = 2;
                            NewYellowBall(linie);
                            break;
                        }
                    }
                }
                round++;

                /*string displaymatrice = "";
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        displaymatrice = displaymatrice + matrice[i, j].ToString() + " ";
                    }
                    displaymatrice = displaymatrice + "/n";
                }

                label1.Text = displaymatrice;*/

                if (verificaWin() == true)
                {
                    if (round % 2 == 0)
                    {
                        labelWinner.Text = "RED WINS!";
                        labelWinner.Visible = true; 
                    }
                    else
                    {
                        labelWinner.Text = "YELLOW WINS!";
                        labelWinner.Visible = true; 
                    }
                    //sp.Play();
                    
                }
            }
        }

        public bool verificaWin()
        {
            for (int i = 6; i >0 ; i--)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (matrice[i, j] != 0)
                    {
                        //orizontal
                        if (matrice[i, j] == matrice[i, j + 1])
                            if (matrice[i, j + 1] == matrice[i, j + 2])
                                if (matrice[i, j + 2] == matrice[i, j + 3])
                                    return true;

                        //vertical
                        if (matrice[i, j] == matrice[i + 1, j])
                            if (matrice[i + 1, j] == matrice[i + 2, j])
                                if (matrice[i + 2, j] == matrice[i + 3, j])
                                    return true;


                        //diagonala1
                        if (matrice[i, j] == matrice[i + 1, j + 1])
                            if (matrice[i + 1, j + 1] == matrice[i + 2, j + 2])
                                if (matrice[i + 2, j + 2] == matrice[i + 3, j + 3])
                                    return true;

                        //diagonala2
                        if (matrice[i, j] == matrice[i - 1, j + 1])
                            if (matrice[i - 1, j + 1] == matrice[i - 2, j + 2])
                                if (matrice[i - 2, j + 2] == matrice[i - 3, j + 3])
                                    return true;
                    }
                }
            }
            return false;
        }

        public void NewRedBall(int linie)
        {
            PictureBox pb = new PictureBox();
            pb.Height = 50;
            pb.Width = 50;
            pb.Image = Image.FromFile("C:/Users/Adrian/Documents/Facultate/Informatica Economica/Anul 2/Semestrul 2/Algoritmi si structuri de date/Proiecte/Games/Connect4/Connect4/Resources/red_ball.png");
            
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = table;
            pb.Top = 10 + (60 * linie);
            pb.Left = 10 + (60 * coloana);

            redball.Image = Image.FromFile("C:/Users/Adrian/Desktop/Facultate/Informatica Economica/Anul 2/Semestrul 2/Algoritmi si structuri de date/Proiecte/Games/Connect4/Connect4/Resources/yellow_ball.png");
        }

        public void NewYellowBall(int linie)
        {
            PictureBox pb = new PictureBox();
            pb.Height = 50;
            pb.Width = 50;
            pb.Image = Image.FromFile("C:/Users/Adrian/Desktop/Facultate/Informatica Economica/Anul 2/Semestrul 2/Algoritmi si structuri de date/Proiecte/Games/Connect4/Connect4/Resources/yellow_ball.png");
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = table;
            pb.Top = 10 + (60 * linie);
            pb.Left = 10 + (60 * coloana);

            redball.Image = Image.FromFile("C:/Users/Adrian/Desktop/Facultate/Informatica Economica/Anul 2/Semestrul 2/Algoritmi si structuri de date/Proiecte/Games/Connect4/Connect4/Resources/red_ball.png");
        }
    }
}
