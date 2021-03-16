using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    class Program
    {
        public static void gambling(string nick1, string nick2)
        {
            string nr1;
            int rnr1, rnr2, scorp1 = 0, scorp2 = 0;
            Random rnd = new Random();
            Console.WriteLine("\nWelcome to Gambling!");
            do
            {
                Console.WriteLine("\nFoloseste comanda /dice pentru a paria.");
                do
                {
                    Console.Write("Comanda: ");
                    nr1 = Convert.ToString(Console.ReadLine());
                    if (nr1 != "/dice")
                        Console.WriteLine("\nEroare! Foloseste comanda /dice pentru a paria.");
                } while (nr1 != "/dice");
                Console.WriteLine("");
                rnr1 = rnd.Next(1, 101);
                Console.WriteLine("{0} a primit {1} (1-100)", nick1, rnr1);
                rnr2 = rnd.Next(1, 101);
                Console.WriteLine("{0} a primit {1} (1-100)", nick2, rnr2);
                if (rnr1 > rnr2)
                {
                    scorp1++;
                    Console.WriteLine("\n{0} castiga!", nick1);
                    Console.WriteLine("Scor: {0}-{1}", scorp1, scorp2);
                }
                if (rnr1 < rnr2)
                {
                    scorp2++;
                    Console.WriteLine("\n{0} castiga!", nick2);
                    Console.WriteLine("Scor: {0}-{1}", scorp1, scorp2);
                }
                if (rnr1 == rnr2)
                {
                    Console.WriteLine("Remiza!");
                }
            } while (scorp1 < 3 && scorp2 < 3);
            if (scorp1 == 3)
                Console.WriteLine("\n>> {0} a castigat de 3 ori", nick1);
            if (scorp2 == 3)
                Console.WriteLine("\n>> {0} a castigat de 3 ori", nick2);
        }

        public static void guessthenumber(string nick1, string nick2)
        {
            int nr1, nr2, rnr, s1, s2,v=1;
            Console.WriteLine("\nWelcome to Guess the number!");
            Console.WriteLine("\nAlegeti un numar din intervalul 1-20");
            Random rnd = new Random();
            rnr = rnd.Next(1, 20);
            do
            {
                s1 = 0;
                s2 = 0;
                if(v%2!=0)
                {
                    Console.Write("Numarul lui {0}: ", nick1);
                    nr1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Numarul lui {0}: ", nick2);
                    nr2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Numarul lui {0}: ", nick2);
                    nr2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Numarul lui {0}: ", nick1);
                    nr1 = Convert.ToInt32(Console.ReadLine());
                }
                s1 = rnr - nr1;
                if (s1 < 0)
                    s1 = s1 * (-1);
                if (s2 < 0)
                    s2 = s2 * (-1);
                s2 = rnr - nr2;
                if (s1 < s2)
                {
                    if (nr1 == rnr)
                    {
                        Console.WriteLine("\n{0} a ghicit numarul!\nNumar: {1}\n", nick1, rnr);
                    }
                    else
                        Console.WriteLine("\n{0} e mai aproape de numar\nNumar: {1}\n", nick1, rnr);
                }
                if (s1 > s2)
                {

                    if (nr2 == rnr)
                    {
                        Console.WriteLine("\n{0} a ghicit numarul!\nNumar: {1}\n", nick2, rnr);
                    }
                    else
                        Console.WriteLine("\n{0} e mai aproape de numar\nNumar: {1}\n", nick2, rnr);
                }
                if (s1 == s2)
                {
                    Console.WriteLine("\nAmandoi sunteti la o distanta egala");
                }
                v++;
            } while (rnr != nr1 && rnr != nr2);
        }
       
        static void Main(string[] args)
        {
            string nick1, nick2,comanda;
            Console.Write("Nickname Player 1: ");
            nick1 = Convert.ToString(Console.ReadLine());
            Console.Write("Nickname Player 2: ");
            nick2 = Convert.ToString(Console.ReadLine());
            do
            {
            Console.WriteLine("\nAlege un joc:\n1. Gambling - /dice\n2. Guess the number - /guess");
            do
            {
                Console.Write("\nComanda: ");
                comanda = Convert.ToString(Console.ReadLine());
                if (comanda != "/dice" && comanda != "/guess")
                    Console.WriteLine("Eroare! Foloseste una dintre comenzile /dice sau /guess pentru a juca.");
            } while (comanda != "/dice" && comanda != "/guess");
            if (comanda == "/dice")
                gambling(nick1, nick2);
            if (comanda == "/guess")
                guessthenumber(nick1, nick2);
            do
            {
                Console.Write("\nInca un joc? (da/nu): ");
                comanda = Convert.ToString(Console.ReadLine());
                if (comanda != "da" && comanda != "nu")
                    Console.WriteLine("Eroare! Alege doar 'da' sau 'nu'");
            } while (comanda != "da" && comanda != "nu");
            } while (comanda != "nu");
            Console.ReadKey();
        }
    }
}
