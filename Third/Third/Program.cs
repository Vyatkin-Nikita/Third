using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    /*
      Программа принимает координаты х и у точки,
      проверяет, являются ли они действительными числами,
      определяет, принадлежит ли точка с указанными координатми кругу с радиусом 1 и центром в начале координат
    */
    class Program
    {
        static double Check()//Проверка вводимых с клавиатуры данных (данные должны быть действительными числами)
        {
            bool ok;
            double n;//искомое число
            do
            {
                ok = double.TryParse(Console.ReadLine(), out n);
                if (!ok) { Console.WriteLine("Ошибка. Неверный формат данных. Повторите ввод."); }

            } while (!ok);//если введённые данные - не число, то новая итерация цикла
            return n;
        }
        static void Main(string[] args)
        {
            double x, y;//координаты х и у искомой точка
            Console.WriteLine("Введите координату х точки");
            x = Check();//проверка координаты х
            Console.WriteLine("Введите координату y точки");
            y = Check();//проверка координаты у
            if (x * x + y * y <= 1)//если координаты удовлетворяют условию, значит точка лежит внутри круга
            {
                Console.WriteLine("Точка находится внутри круга");
            }
            else
            {
                Console.WriteLine("Точка находится вне круга");
            }

            Console.ReadLine();
        }
    }
}
