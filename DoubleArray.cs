using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class DoubleArray
    {
        private static int n;
        private static int m;
        private bool b = false;
        public static int[,] a;

        public DoubleArray(int N, int M, bool B)
        {
            n = N;
            b = B;
            m = M;
            a = new int[n, m];
        }

        public static void FillByUser()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.Next(1000);
                }
            }
            Console.WriteLine("Двумерный массив:");
            Output_double(a);
        }

        public void Fill()
        {
            if (!b)
            {
                RandFill();
            }
            else
            {
                FillByUser();
            }
        }

        static void Output_double(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Mid_value()
        {
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine(sum / (m*n));
        }

        public void Output_matrix()
        {
            bool h = false;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (h)
                {
                    for (int j = a.GetLength(1)-1; j >= 0; j--)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                else if(!h)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                Console.WriteLine();
                h = !h;
            }
        }
    }
}
