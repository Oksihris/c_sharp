using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;

namespace Binomial_2L_C
{
    internal class Binomial1
    {
        static void Main(string[] args)
        {
            var binom1 = new Binomial(5, 2);
            var binom2 = new Binomial(1, 3);
            int number = 4;
            double number1=2.5;
            var result1 = binom1 + binom2;
            var result2 = binom2 - binom1;
            var result3 = binom1 + number;
            var result4 = binom1 - number;
            var result5 = binom1 * number;

            Console.WriteLine("Перший двочлен: " + binom1);
            Console.WriteLine("Другий двочлен: " + binom2);
            Console.WriteLine("Додавання двочленiв: " + result1);
            Console.WriteLine("Вiднiмання двочленiв: " + result2);
            Console.WriteLine("Дiйсне число: " + number);
            Console.WriteLine("Додавання двочленa та дiйсного числа: " + result3);
            Console.WriteLine("Вiднiмання двочлена та дiйсного числа: " + result4);
            Console.WriteLine("Множення двочлена та дiйсного числа: " + result5);
            Console.WriteLine("Значення двочлену для заданого значення змiнної (x=2,5): " + binom1[number1]);
            Console.ReadKey();
        }
    }
}
