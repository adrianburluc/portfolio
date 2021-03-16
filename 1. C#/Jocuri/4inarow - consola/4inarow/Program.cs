using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4inarow
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] a = new string[10, 10];
            int[] b = { 1, 2, 3, 4, 5, 6, 7 };
            string n;
            int i, j,pozitie,ok=0,k=0,k2=1,ok2=0;
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                    a[i, j] = "-";
            }
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                    Console.Write(" {0} ", a[i, j]);
                Console.WriteLine("");
            }
            for(i=0;i<b.Length;i++)
            {
                Console.Write(" {0} ", b[i]);
            }
            do
            {
                if (k % 2 == 0)
                    n = "X";
                else
                    n = "O";
            Console.Write("\n\n[{0}] coloana (1-7): ",n);
            pozitie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
                
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                {
                    if(j==pozitie)
                    {
                        if (a[6, j] == "-")
                        {
                            a[6, j] = n;
                            ok = 1;
                            k++;
                        }
                        else
                        {
                            if (a[5, j] == "-")
                            {
                                a[5, j] = n;
                                ok = 1;
                                k++;
                            }
                            else
                            {
                                if (a[4, j] == "-")
                                {
                                    a[4, j] = n;
                                    ok = 1;
                                    k++;
                                }
                                else
                                {
                                    if (a[3, j] == "-")
                                    {
                                        a[3, j] = n;
                                        ok = 1;
                                        k++;
                                    }
                                    else
                                    {
                                        if (a[2, j] == "-")
                                        {
                                            a[2, j] = n;
                                            ok = 1;
                                            k++;
                                        }
                                        else
                                        {
                                            if (a[1, j] == "-")
                                            {
                                                a[1, j] = n;
                                                ok = 1;
                                                k++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if(ok==1)
                break;
            }
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                    Console.Write(" {0} ", a[i, j]);
                Console.WriteLine("");
            }
            for (i = 0; i < b.Length; i++)
            {
                Console.Write(" {0} ", b[i]);
            }


            //verificare conditie de castig pe orizontala
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                {
                    if (a[i, j] != "-")
                    {
                        if (a[i, j] == a[i, j - 1])
                        {
                            if (a[i, j-1] == a[i, j - 2])
                            {
                                if (a[i, j - 2] == a[i, j - 3])
                                {
                                    k2 = 4;
                                }
                            }
                        }
                        else
                            k2 = 1;
                    }
                    if (k2 == 4)
                    {
                        ok2 = 1;
                        break;
                    }
                }
                if (ok2 == 1)
                    break;
            }

            //verificare conditie de castig pe verticala

            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                {
                    if (a[i, j] != "-")
                    {
                        if (a[i, j] == a[i - 1, j])
                        {
                            if (a[i-1,j] == a[i - 2, j])
                            {
                                if (a[i-2, j] == a[i - 3, j])
                                {
                                    k2 = 4;
                                }
                            }
                        }
                        else
                            k2 = 1;
                    }
                    if (k2 == 4)
                    {
                        ok2 = 1;
                        break;
                    }
                }
                if (ok2 == 1)
                    break;
            }
            
            //verificare conditie de castig pe diagonala principala
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                {
                    if (a[i, j] != "-")
                        {
                            if (a[i, j] == a[i-1, j - 1])
                            {
                                if (a[i-1, j-1] == a[i - 2, j - 2])
                                {
                                    if (a[i - 2, j - 2] == a[i - 3, j - 3])
                                    {
                                        k2 = 4;
                                    }
                                }
                            }
                            else
                                k2 = 1;
                        }
                    if (k2 == 4)
                    {
                        ok2 = 1;
                        break;
                    }
                }
                if (ok2 == 1)
                    break;
            }

            //verificare conditie de castig pe diagonala secundara
            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 7; j++)
                {
                    if (a[i, j] != "-")
                    {
                        if (a[i, j] == a[i - 1, j + 1])
                        {
                            if (a[i-1, j+1] == a[i - 2, j + 2])
                            {
                                if (a[i - 2, j + 2] == a[i - 3, j + 3])
                                {
                                    k2 = 4;
                                }
                            }
                        }
                        else
                            k2 = 1;
                    }
                    if (k2 == 4)
                    {
                        ok2 = 1;
                        break;
                    }
                }
                if (ok2 == 1)
                    break;
            }
            if (ok2 == 1)
            {
                Console.Write("\n\n{0} a castigat!", n);
            }
            if (k == 42)
            {
                Console.Write("\n\nRemiza! Nimeni nu a castigat");
            }
            }
            while (ok2!=1 && k!=42);
            Console.ReadKey();
            

            
        }
    }
}
