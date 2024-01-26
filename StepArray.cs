using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class StepArray
    {
        private static int n;
        private bool b = false;
        public static int[][] a;

        public StepArray(int N, bool B)
        {
            n = N;
            b = B;
            a = new int[n][];
        }
        public static void FillByUser()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Введите значение длины подмассива");
                int m = int.Parse(Console.ReadLine());
                int[] b = new int[m];

                for (int j = 0; j < m; j++)
                {
                    b[j] = int.Parse(Console.ReadLine());
                }
                a[i] = b;
            }
        }

        public static void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите значение длины подмассива");
                int m = int.Parse(Console.ReadLine());
                int[] b = new int[m];

                for (int j = 0; j < m; j++)
                {
                    b[j] = rnd.Next(1000);
                }
                a[i] = b;
            }
            Console.WriteLine("Ступенчатый массив:");
            Output_step(a);
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

        static void Output_step(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Total_mid_value()
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                    count++;
                }
            }
            Console.WriteLine(sum / count);
        }

        public void Mid_value_subarrays()
        {
            double sum = 0;
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < a[i].Length; j++)
                {
                    sum += a[i][j];
                }
                Console.WriteLine(sum / a[i].Length);
                sum = 0;
            }
        }

        public void Change_even_nums()
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; i < a[i].Length; j++)
                {
                    if (a[i][j] % 2 == 0)
                    {
                        a[i][j] = i * j;
                    }
                }
            }
            Output_step(a);
        }
    }
}
