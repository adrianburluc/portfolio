using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string p1, p2, decizie, swap;
            int alegere, k, ok;
            Console.Write("Nick Player1: ");
            p1 = Console.ReadLine();
            Console.Write("Nick Player2: ");
            p2 = Console.ReadLine();
            do
            {
            k = 0;
            ok = 0;
            string[] a = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            do
            {
            k++;
            Console.WriteLine("\n {0}│{1}│{2}\n ─┼─┼─\n {3}│{4}│{5}\n ─┼─┼─\n {6}│{7}│{8}",a[0],a[1],a[2],a[3],a[4],a[5],a[6],a[7],a[8]);
            do
            {
                if (k % 2 != 0)
                    Console.Write("\nX: {0}, alege o pozitie (1-9): ", p1);
                else
                    Console.Write("\nO: {0}, alege o pozitie (1-9): ", p2);
                alegere = Convert.ToInt32(Console.ReadLine());
                if (alegere < 1 || alegere > 9)
                    Console.WriteLine("Eroare! Pozitia aleasa nu exista");
            }
            while (alegere < 1 || alegere > 9);
            alegere--;
            if (a[alegere] == "X" || a[alegere] == "O")
            {
                Console.WriteLine("Eroare! Pozitia aleasa este deja folosita");
                k--;
            }
            else
            {
                {
                    if (k % 2 != 0)
                    {
                        a[alegere] = "X";
                    }
                    else
                        a[alegere] = "O";
                }
            }
            if (a[0] == a[1])
            {
                if (a[0] == a[2])
                {
                    if (a[1] == a[2])
                        ok = 1;
                }
            }
            if (a[3] == a[4])
            {
                if (a[3] == a[5])
                {
                    if (a[4] == a[5])
                        ok = 1;
                }
            }
            if (a[6] == a[7])
            {
                if (a[6] == a[8])
                {
                    if (a[7] == a[8])
                        ok = 1;
                }
            }
            if (a[0] == a[3])
            {
                if (a[0] == a[6])
                {
                    if (a[3] == a[6])
                        ok = 1;
                }
            }
            if (a[1] == a[4])
            {
                if (a[1] == a[7])
                {
                    if (a[4] == a[7])
                        ok = 1;
                }
            }
            if (a[2] == a[5])
            {
                if (a[2] == a[8])
                {
                    if (a[5] == a[8])
                        ok = 1;
                }
            }
            if (a[0] == a[4])
            {
                if (a[0] == a[8])
                {
                    if (a[4] == a[8])
                        ok = 1;
                }
            }
            if (a[2] == a[4])
            {
                if (a[2] == a[6])
                {
                    if (a[4] == a[6])
                        ok = 1;
                }
            }
            }
            while (ok!=1 && k<9);
            if (ok == 1) 
            {
                Console.WriteLine("\n {0}│{1}│{2}\n ─┼─┼─\n {3}│{4}│{5}\n ─┼─┼─\n {6}│{7}│{8}", a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
                if(k%2!=0)
                {
                    Console.WriteLine("\nFelicitari! {0} a castigat!",p1);
                }
                else
                    Console.WriteLine("\nFelicitari! {0} a castigat!",p2);
            }
            if(k==9)
            {
                Console.WriteLine("\n {0}│{1}│{2}\n ─┼─┼─\n {3}│{4}│{5}\n ─┼─┼─\n {6}│{7}│{8}", a[0], a[1], a[2], a[3], a[4], a[5], a[6], a[7], a[8]);
                Console.WriteLine("\nRemiza!");
            }
            do
            {

                Console.Write("Reluati jocul? (da/nu): ");
                decizie = Console.ReadLine();
                if (decizie != "da" && decizie != "nu")
                    Console.WriteLine("\nEroare! Introduceti o optiune disponibila");
            }
            while (decizie != "da" && decizie != "nu");
            swap = p1;
            p1 = p2;
            p2 = swap;
            }
            while (decizie != "nu");
            Console.ReadKey();
        }
    }
}
