using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Logger logger = new Logger();
                Calculator calc = new Calculator(logger);
                Console.WriteLine("Введите первое число (число должно быть целым)");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число (число должно быть целым)");
                int y = Convert.ToInt32(Console.ReadLine());
                logger.Event("Результат: " + calc.Add(x, y));
            }
            catch (FormatException e)
            {
                Logger logger = new Logger();
                logger.Error("Введено неверное значение");
            }
        }
    }

    
}
