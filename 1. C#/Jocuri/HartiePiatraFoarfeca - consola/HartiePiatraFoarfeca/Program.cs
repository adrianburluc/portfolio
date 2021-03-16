using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HartiePiatraFoarfeca
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random, k=0, scor1=0, scor2=0;
            do
            {
                k++;
                int ok = 0, optiune = 0;
                string opt;
                Console.WriteLine("Alege o optiune: piatra, hartie, foarfeca\n");
                do
                {
                    Console.Write("Alegerea ta: ");
                    opt = Console.ReadLine();
                    if (opt == "piatra")
                    {
                        optiune = 1;
                        ok = 1;
                    }
                    if (opt == "hartie")
                    {
                        optiune = 2;
                        ok = 1;
                    }
                    if (opt == "foarfeca")
                    {
                        optiune = 3;
                        ok = 1;
                    }
                    if (ok == 0)
                        Console.WriteLine("\nEroare! Alege doar 'piatra', 'hartie' sau 'foarfeca'!");
                }
                while (ok == 0);



                random = rnd.Next(1, 4);
                switch (optiune)
                {
                    case 1:
                        if (random == 1)
                        {
                            Console.WriteLine("Alegere CPU: piatra");
                            Console.WriteLine("\nRemiza! Piatra vs Piatra");
                        }
                        if (random == 2)
                        {
                            Console.WriteLine("Alegere CPU: hartie");
                            Console.WriteLine("\nAi pierdut! Hartia ti-a acoperit piatra");
                            scor2++;
                        }
                        if (random == 3)
                        {
                            Console.WriteLine("Alegere CPU: foarfeca");
                            Console.WriteLine("\nAi castigat! Ai distrus foarfeca cu piatra");
                            scor1++;
                        }
                        break;
                    case 2:
                        if (random == 1)
                        {
                            Console.WriteLine("Alegere CPU: piatra");
                            Console.WriteLine("\nAi castigat! Ai acoperit piatra cu hartia");
                            scor1++;
                        }
                        if (random == 2)
                        {
                            Console.WriteLine("Alegere CPU: hartie");
                            Console.WriteLine("\nRemiza! Hartie vs Hartie");
                        }
                        if (random == 3)
                        {
                            Console.WriteLine("Alegere CPU: foarfeca");
                            Console.WriteLine("\nAi pierdut! Foarfeca ti-a taiat hartia");
                            scor2++;
                        }
                        break;
                    case 3:
                        if (random == 1)
                        {
                            Console.WriteLine("Alegere CPU: piatra");
                            Console.WriteLine("\nAi pierdut! Piatra ti-a distrus foarfeca");
                            scor2++;
                        }
                        if (random == 2)
                        {
                            Console.WriteLine("Alegere CPU: hartie");
                            Console.WriteLine("\nAi castigat! Ai taiat hartia cu foarfeca");
                            scor1++;
                        }
                        if (random == 3)
                        {
                            Console.WriteLine("Alegere CPU: foarfeca");
                            Console.WriteLine("\nRemiza! Foarfeca vs Foarfeca");
                        }
                        break;
                }
                Console.WriteLine("Scor: {0}-{1}\n",scor1,scor2);
            }
            while (scor1 < 3 && scor2 < 3);
            Console.ReadKey();
        }
    }
}
