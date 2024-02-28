using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public sealed class StepArray : BaseClass, IStepArray
    {
        public int[][] a;

        public StepArray(int N, bool B = false) : base(B)
        {
            a = new int[N][];
            Fill();
            
        }
        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
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

        protected override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
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
        }

        public override void Print()
        {
            Console.WriteLine("Ступенчатый массив:");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override void Mid_value()
        {
            Console.WriteLine("Среднее значение элементов ступенчатого массива");
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
        public void Change_even_nums()
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] % 2 == 0)
                    {
                        a[i][j] = i * j;
                    }
                }
            }
        }
    }
}
