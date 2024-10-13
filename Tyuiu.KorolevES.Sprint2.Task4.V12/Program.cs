using Tyuiu.KorolevES.Sprint2.Task4.V12.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task4.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
            Console.WriteLine("* использованием тенарного оператора, где пользователь вводит значение    *");
            Console.WriteLine("* переменных X,Y с клавиатуры. Округлить полученное значение до 3 знаков  *");
            Console.WriteLine("* после запятой;                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Если условие x^0.5 > y*2 истинно:                                       *");
            Console.WriteLine("* z=(7+2/y^2)^x                                                           *");
            Console.WriteLine("* Если условие x^0.5 > y*2 ложно:                                         *");
            Console.WriteLine("* z=(3*x^2-cos(y)^2+10)/(y^2-sinx^2+12)                                   *");
            Console.WriteLine("* Введите число X:                                                        *");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите число Y:                                                        *");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (((Math.Sqrt(x) > y * 2) && (y != 0.0)) || ((Math.Sqrt(x) <= y * 2) && ((y * y - Math.Sin(x * x) + 12) != 0.0)))
            {
                DataService ds = new DataService();
                Console.WriteLine($"z = {ds.Calculate(x, y)}");
            }
            else
            {
                Console.WriteLine("На ноль делить нельзя");
            }
        }
    }
}
