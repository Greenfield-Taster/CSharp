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
            for (int i = 0; i < 5; i+=2)//вывод только четных чисел в столбик
            {
                Console.WriteLine("Value of i: {0}", i);
            }

            for (int i = 0; i < 10; i += 2)//вывод только четных чисел в рядок
            {
                Console.Write("{0} , ", i);
            }

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i*80);
            }
            // do-while
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a<5);

            //breal - для прикращения действий внутри цикла и переходу к следующему выражению после тела цикла
            int num = 0;
            while (num<20)
            {
                if (num == 5)
                    break;
                Console.WriteLine(num);
                num++;
            }
            //логический оператор
            
            //int age = 42;
            //int grade = 75;
            //if (age >16 && age<80 && grade>50)
            //{
            //    Console.WriteLine("Hey there");
            //

            //or
            int age = 42;
            int grade = 75;
            string msg;
            msg = (age > 16 && age < 80 && grade > 50) ? "Good job" : "I may better";
            Console.WriteLine(msg);

            //calculator
            do
            {
                Console.Write("num1 = ");
                string str = Console.ReadLine();
                if (str == "exit")
                    break;

                int num1 = Convert.ToInt32(str);

                Console.Write("num2 = ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;
                Console.WriteLine("sum = {0}", sum);

                //Console.WriteLine("Would you want sing out?(yes/no)");
                //string answer = Console.ReadLine();
                //if (answer == "yes")
                //    break;
                

            } while (true);
            
            //задача: заменять кратные 3 на *
            int numb = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numb; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine("*");
                else
                    Console.WriteLine(i);
            }
        }
    }
}