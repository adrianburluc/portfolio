using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            int optiune, buget, pariu;
            do
            {

                Console.Write("Buget (ron) = ");
                buget = Convert.ToInt32(Console.ReadLine());
                if(buget < 0)
                    Console.WriteLine("Eroare! Nu poti aloca un buget negativ\n");
            } while (buget < 0);
            do
            {
                do
                {
                    Console.Write("\nSuma pariata (ron) = ");
                    pariu = Convert.ToInt32(Console.ReadLine());
                    if (buget < pariu)
                        Console.WriteLine("Eroare! Nu poti paria o suma mai mare decat bugetul alocat");
                    if(pariu<0)
                        Console.WriteLine("Eroare! Nu poti paria o suma negativa");
                } while (buget < pariu || pariu<0);
            int carte, i, limita = 0, k = 1, scor = 0, p = 2, scorcpu = 0;
            Random rnd = new Random();
            int[] a = new int[15];
            Console.WriteLine("");
            Console.WriteLine("Selecteaza una dintre optiunile de mai jos:\n1 - Incepe jocul\n3 - Opreste definitiv programul");
            Console.WriteLine("");
            do
            {
                Console.Write("Optiune: ");
                optiune = Convert.ToInt32(Console.ReadLine());
                if (optiune < 1 || optiune > 3)
                    Console.WriteLine("Eroare! Nu ati selectat o optiune disponibila\n");
            } while (optiune < 1 || optiune > 3);
            if (optiune == 1)
            {
                Console.WriteLine("\nStart Game!");
                do
                {
                    Console.Write("\nCarti: ");
                    do
                    {
                        if (scorcpu < 16) // criteriu pt castigare, sanse mai mari de pierdere pt player
                        {
                            carte = rnd.Next(2, 15);
                            if (carte > 11)
                                carte = 10;
                            if (scorcpu > 10)
                            {
                                if (carte == 11)
                                    carte = 1;
                            }
                            scorcpu = scorcpu + carte;
                        }
                        carte = rnd.Next(2, 15);
                        if (carte > 11)
                            carte = 10;
                        //Asul isi schimba valoarea din 11 in 1 daca scorul este minim 10
                        if (scor > 10)
                        {
                            if (carte == 11)
                                carte = 1;
                        }
                        scor = scor + carte;
                        //30% sansa pentru 10 (dama, popa, valet si 10 din 13 carti)
                        limita++;
                        for (i = k; i <= limita; i++)
                        {
                            a[i] = carte;
                        }
                        k++;
                    } while (limita < p);
                    for (i = 1; i <= limita; i++)
                        Console.Write("{0} ", a[i]);
                    Console.WriteLine("\nScor: {0}", scor);
                    if (scor > 21)
                    {
                        optiune = 2;
                    }
                    if (scor < 21)
                    {
                        Console.WriteLine("\n1 - Hit\n2 - Stand");
                        Console.WriteLine("");
                        do
                        {
                            Console.Write("Optiune: ");
                            optiune = Convert.ToInt32(Console.ReadLine());
                            if (optiune < 1 || optiune > 2)
                                Console.WriteLine("Eroare! Nu ati selectat o optiune disponibila\n");
                            if (optiune == 1)
                                p++;
                        } while (optiune < 1 || optiune > 2);
                    }
                    if (scor == 21)
                    {
                        optiune = 2;
                        Console.WriteLine("\nBlackjack!");
                    }

                } while (optiune != 2);
                if (optiune == 2)
                {
                    Console.WriteLine("\nScorul tau: {0}", scor);
                    Console.WriteLine("Scor CPU: {0}", scorcpu);
                    if (scor <= 21)
                    {
                        if (scor == scorcpu)
                        {
                            Console.WriteLine("\nRemiza!");
                            Console.WriteLine("Buget: {0}", buget);

                        }
                        else
                        {

                            if (scor > scorcpu)
                            {
                                buget = buget + pariu;
                                Console.WriteLine("\nFelicitari! Ai castigat!");
                                Console.WriteLine("Buget: {0}", buget);
                            }
                            else
                            {
                                if (scorcpu <= 21)
                                {
                                    buget = buget - pariu;
                                    Console.WriteLine("\nAi pierdut");
                                    Console.WriteLine("Buget: {0}", buget);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (scorcpu > 21)
                        {
                            Console.WriteLine("\nRemiza!");
                            if(scor<=21)
                            {
                                buget = buget + pariu;
                                Console.WriteLine("\nFelicitari! Ai castigat!");
                                Console.WriteLine("Buget: {0}", buget);
                            }
                        }
                        else
                        {
                            buget = buget - pariu;
                            Console.WriteLine("\nAi pierdut");
                            Console.WriteLine("Buget: {0}", buget);
                        }
                    }
                }
            }
            if (buget <= 0)
            {
                optiune = 3;
                Console.Write("\nStop game!\nNu mai poti paria");
            }
            } while (optiune != 3);
            Console.ReadKey();
        }
    }
}
