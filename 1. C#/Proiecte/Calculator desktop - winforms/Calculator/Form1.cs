using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public string semn = "+";
        public double ecuatie=0;
        public bool operatie=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void verificaSemn()
        {
            switch(semn)
            {
                case "+":
                {
                    ecuatie = ecuatie + Convert.ToDouble(textBoxAfisare.Text);
                    break;
                }
                case "-":
                {
                    ecuatie = ecuatie - Convert.ToDouble(textBoxAfisare.Text);
                    break;
                }
                case "*":
                {
                    ecuatie = ecuatie * Convert.ToDouble(textBoxAfisare.Text);
                    break;
                }
                case "/":
                {
                    ecuatie = ecuatie / Convert.ToDouble(textBoxAfisare.Text);
                    break;
                }
            }
        }

        public void verificaStare()
        {
            if (operatie==true) //daca s-a folosit operatie atunci textbox-ul se sterge inainte de a introduce alt numar
            {
                textBoxAfisare.Clear();
                operatie = false;
            }
            if (textBoxAfisare.Text == "0")
                textBoxAfisare.Clear();

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "0";
        }

        private void buttonunu_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "1";
        }

        private void buttonDoi_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "2";
        }

        private void buttonTrei_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "3";
        }

        private void buttonPatru_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "4";
        }

        private void buttonCinci_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "5";
        }

        private void buttonSase_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "6";
        }

        private void buttonSapte_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "7";
        }

        private void buttonOpt_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "8";
        }

        private void buttonNoua_Click(object sender, EventArgs e)
        {
            verificaStare();
            textBoxAfisare.Text = textBoxAfisare.Text + "9";
        }

        private void buttonPunct_Click(object sender, EventArgs e)
        {
            verificaStare();
            if (textBoxAfisare.Text.Contains('.') == false) //conditie pt a nu scrie mai mult de un punct
            {
                if (textBoxAfisare.Text == "")
                    textBoxAfisare.Text = "0.";
                else
                    textBoxAfisare.Text = textBoxAfisare.Text + ".";
            }
        }

        private void buttonAdunare_Click(object sender, EventArgs e)
        {
            if(textBoxAfisare.Text!="") //conditie pentru a nu se opri programul atunci cand folosesc semnul fara sa existe numar in textbox
            {
                verificaSemn();
                labelOperatii.Text = labelOperatii.Text + textBoxAfisare.Text + "+";
                textBoxAfisare.Text = ecuatie.ToString();
                operatie = true;
                semn = "+";
            }
        }

        public string prelucrareLabel="";

        public void buttonEgal_Click(object sender, EventArgs e)
        {
            if(textBoxAfisare.Text=="") //conditie pt atunci cand nu exista numar in textbox si se apasa butonul egal
            {
                textBoxAfisare.Text = ecuatie.ToString();
                for (int i = 0; i < labelOperatii.Text.Length-1; i++) //inlocuieste ultimul semn din label cu egal
                    prelucrareLabel = prelucrareLabel + labelOperatii.Text[i];
                labelOperatii.Text = prelucrareLabel + "=";
                prelucrareLabel = ""; //resetat ptr a evita repetarea (ex label text: 10+10+10 > 10+1010+10+10=30)
            }
            else
            {
                verificaSemn();
                labelOperatii.Text = labelOperatii.Text + textBoxAfisare.Text + "=";
                textBoxAfisare.Text = ecuatie.ToString();
            }
            ecuatie = 0;
            operatie = true;
            semn = "+";//pentru a evita un bug ex: 20-1=19-1=-18
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ecuatie = 0;
            labelOperatii.Text = "";
            textBoxAfisare.Text="0";
            semn = "+";
        }

        private void buttonScadere_Click(object sender, EventArgs e)
        {
            if (textBoxAfisare.Text != "")
            {
                verificaSemn();
                labelOperatii.Text = labelOperatii.Text + textBoxAfisare.Text + "-";
                textBoxAfisare.Text = ecuatie.ToString();
                operatie = true;
                semn = "-";
            }
        }

        public string prelucrareNumar="";
        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBoxAfisare.Text.Length-1; i++)
                prelucrareNumar = prelucrareNumar + textBoxAfisare.Text[i];
            textBoxAfisare.Text = prelucrareNumar;
            prelucrareNumar = ""; //pentru a evita repetarea (ex: 2.3 > 2.2)
            if (textBoxAfisare.Text == "")
                textBoxAfisare.Text = "0";
        }

        private void buttonInmultire_Click(object sender, EventArgs e)
        {
            if (textBoxAfisare.Text != "")
            {
                verificaSemn();
                labelOperatii.Text = labelOperatii.Text + textBoxAfisare.Text + "*";
                textBoxAfisare.Text = ecuatie.ToString();
                operatie = true;
                semn = "*";
            }
        }

        private void buttonImpartire_Click(object sender, EventArgs e)
        {
            if (textBoxAfisare.Text != "")
            {
                verificaSemn();
                labelOperatii.Text = labelOperatii.Text + textBoxAfisare.Text + "/";
                textBoxAfisare.Text = ecuatie.ToString();
                operatie = true;
                semn = "/";
            }
        }

        public double numar;
        private void buttonPower_Click(object sender, EventArgs e)
        {
            if(textBoxAfisare.Text!="")
            {
                numar = Convert.ToDouble(textBoxAfisare.Text);
                numar = Math.Pow(numar, 2);
                textBoxAfisare.Text = numar.ToString();
            }
        }
    }
}
