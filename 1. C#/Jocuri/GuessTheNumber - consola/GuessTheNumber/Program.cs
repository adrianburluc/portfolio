using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,j=0,ok=0,nivel=0,limita=0,nrmirel=0;
            Random rnd=new Random();
            Console.WriteLine("Ghiceste numarul ales de Mirel.");
            Console.WriteLine("Alege una dintre optiunile de mai jos:");
            Console.WriteLine("1 - nivel usor");
            Console.WriteLine("2 - nivel mediu");
            do
            {
                Console.Write("\nNivel: ");
                nivel = Convert.ToInt32(Console.ReadLine());
                if(nivel < 1 || nivel > 2)
                    Console.WriteLine("Eroare: alegeti o optiune valabila!");
            } while (nivel < 1 || nivel > 2);
            if (nivel == 1)
            {
                Console.WriteLine("\nNumarul se afla in intervalul 1-10, ai 5 sanse!");
                nrmirel = rnd.Next(1, 10);
                limita = 5;
            }
            if (nivel == 2)
            {
                Console.WriteLine("\nNumarul se afla in intervalul 1-25, ai 5 sanse!");
                nrmirel = rnd.Next(1, 25);
                limita = 5;
            }
            do
            {
                Console.Write("numar=");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > nrmirel)
                    Console.WriteLine("Numarul introdus este prea mare.");
                if (n < nrmirel)
                    Console.WriteLine("Numarul introdus este prea mic.");
                if (n == nrmirel)
                {
                    Console.WriteLine("Felicitari! Ai ghicit numarul: {0}", nrmirel);
                    ok = 1;
                }
                j++;
            } while (ok==0 && j<limita);
            if(j==limita && ok==0)
            {
                Console.Write("Din pacate nu ai ghicit numarul, Mirel a ales {0}.", nrmirel);
            }
            Console.ReadKey();
        }
    }
}
