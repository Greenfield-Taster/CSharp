using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i+=2)//вывод только четных чисел в столбик
            {
                Console.WriteLine("Value of i: {0}", i);
            }
            for (int i = 0; i < 10; i += 2)//вывод только четных чисел в рядок
            {
                Console.Write("{0} , ", i);
            }
        }
    }
}