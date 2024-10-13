using Tyuiu.KorolevES.Sprint2.Task3.V14.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Королев Е. С.| АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Cпринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Королев Егор Сергеевич | АСОиУб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой;                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* При х>1 y= x-((x+1)/(x-1))^3                                            *");
            Console.WriteLine("* При х=0 y= (3*x^2-cosx^3+10)/(4*x^2-sinx^4+12)                          *");
            Console.WriteLine("* При -18<x<2 y= (1+1/x^2)^x                                              *");
            Console.WriteLine("* При x<-18 y=x+10*x-1/x                                                  *");
            Console.WriteLine("* Введите число X:                                                        *");
            
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (x != -18.0)
            {
                DataService ds = new DataService();
                Console.WriteLine($"y = {ds.Calculate(x)}");
            }
            else
            {
                Console.WriteLine("Функция y не существует");
            }
            Console.ReadKey();
        }
    }
}
