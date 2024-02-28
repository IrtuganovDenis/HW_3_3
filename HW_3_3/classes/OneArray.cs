using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public sealed class OneArray : BaseClass, IOneArray
    {
        public int[] a;

        public OneArray(int N, bool B = false):base(B)
        {
            a = new int[N];
            Fill();
        }

        protected override void FillByUser()
        {
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        protected override void RandFill()
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1000);
            }
        }

        public override void Print()
        {
            Console.WriteLine("Одномерный массив:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public override void Mid_value()
        {
            Console.WriteLine("Среднее значение элементов одномерного массива:");
            double sum = 0;
            foreach (int i in a)
            {
                sum += i;
            }
            Console.WriteLine(sum / a.Length);
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
            Print();

        }
    }
}
