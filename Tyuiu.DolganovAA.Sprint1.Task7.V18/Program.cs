using Tyuiu.DolganovAA.Sprint1.Task7.V18.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №1                                                                  *");
            Console.WriteLine("* Тема : Добавление к решению итоговых проектов по спринту                   *");
            Console.WriteLine("* Задание №7                                                                 *");
            Console.WriteLine("* Вариант №18                                                                *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу , которая математическое выражение по исходным данным   *");
            Console.WriteLine("* хначениям данных , вводимых пользователем . Ответ округлите                *");
            Console.WriteLine("* до 3 знаков после запятой .                                                *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");

            double x;
            Console.WriteLine("Введите число которое будет заместо x : ");
            x = Convert.ToDouble(Console.ReadLine());

            double y;
            Console.WriteLine("Введите число которое будет заместо y : ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("при x = " + x + " , и y = " + y + " Ответ будет : " + ds.Calculate(x,y));
            Console.ReadKey();
        }
    }
}
