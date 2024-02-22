using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3 
{ 

    internal class Weekdays : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Понедельник, Вторник, Среда, " +
                            "Четверг, Пятница, Суббота, Воскресенье");
        }
    }
} 
