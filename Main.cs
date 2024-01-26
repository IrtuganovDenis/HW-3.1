using System;

namespace ConsoleApp14
{ 
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            One_Array();
            Double_Array();
            Step_Array();
        }



        static void One_Array()
        {
            Console.WriteLine("Введите количество эелементов одномерного массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов одномерного массива (1 - вручную, 0 - рандомно)");
            int t = int.Parse(Console.ReadLine());
            bool b = t == 1 ? true : false;
            OneArray one = new OneArray(n, b);
            one.Fill();
            Console.WriteLine("Среднее значение в массиве:");
            one.Mid_value();
            Console.WriteLine("Массив с элементами меньшими 100 по модулю:");
            one.Less_hundred();
            Console.WriteLine("Массив без повторяющихся элементов:");
            one.Del_repeat_elements();
        }

        static void Double_Array()
        {
            Console.WriteLine("Введите размер двумерного массива");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            int t = int.Parse(Console.ReadLine());
            bool b = t == 1 ? true : false;
            DoubleArray two = new DoubleArray(n, m, b);
            two.Fill();
            Console.WriteLine("Среднее значение в массиве:");
            two.Mid_value();
            Console.WriteLine("Матрица:");
            two.Output_matrix();
        }

        static void Step_Array()
        {
            Console.WriteLine("Введите количество подмассивов ступенчатого массива");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            int t = int.Parse(Console.ReadLine());
            bool b = t == 1 ? true : false;
            StepArray step = new StepArray(n, b);
            step.Fill();
            Console.WriteLine("Среднее значение в массиве:");
            step.Total_mid_value();
            Console.WriteLine("Среднее значение в каждом подмассиве:");
            step.Mid_value_subarrays();
        }
    }
}
