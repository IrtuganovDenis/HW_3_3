using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public sealed class DoubleArray : BaseClass, IDoubleArray
    {
        public static int[,] a;

        public DoubleArray(int N, int M, bool B = false):base(B)
        {
            a = new int[N, M];
            Fill();
        }

        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        protected override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(1000);
                }
            }
        }

        public override void Print()
        {
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void Mid_value()
        {
            Console.WriteLine("Среднее значение элементов двумерного массива:");
            double sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine(sum / (a.GetLength(0) * a.GetLength(1)));
        }
        public void Output_matrix()
        {
            bool h = false;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (h)
                {
                    for (int j = a.GetLength(1) - 1; j >= 0; j--)
                    {
                        Console.Write(a[i, j] + " ");
                    }
                }
                else if (!h)
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
