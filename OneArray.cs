using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class OneArray
    {
        private static int n;
        private bool b = false;
        public static int[] a;

        public OneArray(int N, bool B)
        {
            n = N;
            b = B;
            a = new int[n];
            Fill();
        }

        public static void FillByUser()
        {
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(1000);
            }
            Console.WriteLine("Одномерный массив:");
            Output(a);
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

        public static void Output(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public void Mid_value()
        {
            double sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum / a.Length);
        }

        public void Less_hundred()
        {
            int z = 0;
            foreach (int i in a)
            {
                if (Math.Abs(i) <= 100)
                {
                    z++;
                }
            }

            int[] b = new int[z];
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (Math.Abs(a[i]) <= 100)
                {
                    b[j] = a[i];
                    j++;
                }
            }
            Output(b);
        }
        public void Del_repeat_elements()
        {
            int z = 1;
            for (int i = 1; i < a.Length; i++)
            {
                bool u = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        u = true;
                    }
                }
                if (!u)
                {
                    z++;
                }
            }
            int[] b = new int[z];
            int k = 1;
            b[0] = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                bool l = false;
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        l = true;
                    }
                }
                if (!l)
                {
                    b[k] = a[i];
                    k++;
                }
            }
            Output(b);
        }
    }
}
