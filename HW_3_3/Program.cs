using HW_3_3;
using System;
using System.Security.Claims;

namespace HW_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, t;
            bool b;

            Console.WriteLine("Введите количество эелементов одномерного массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов одномерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            OneArray one = new OneArray(n, b);
            one.Del_repeat_elements();

            Console.WriteLine("Введите размер двумерного массива");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            DoubleArray two = new DoubleArray(n, m, b);
            two.Output_matrix();

            Console.WriteLine("Введите количество подмассивов ступенчатого массива");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите способ ввода элементов двумерного массива (1 - вручную, 0 - рандомно)");
            t = int.Parse(Console.ReadLine());
            b = t == 1 ? true : false;
            StepArray step = new StepArray(n, b);
            step.Change_even_nums();

            Weekdays wd = new Weekdays();

            IBaseInterface[] ar1 = new IBaseInterface[3] {one, two, step};
            foreach (var i in ar1)
            {
                i.Mid_value();
            }

            IPrinter[] ar2 = new IPrinter[4] {one, two, step, wd};
            foreach (var i in ar2)
            {
                i.Print();
            }
        }
    }

}