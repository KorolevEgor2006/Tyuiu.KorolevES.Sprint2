using Tyuiu.KorolevES.Sprint2.Task2.V13.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task2.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
            Console.WriteLine("* области.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите координату X:                                                   *");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите координату Y:                                                   *");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService ds = new DataService();
            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("Область закрашенна");
            }
            else
            {
                Console.WriteLine("Область незакрашенна");
            }
            Console.ReadKey();
        }
    }
}
