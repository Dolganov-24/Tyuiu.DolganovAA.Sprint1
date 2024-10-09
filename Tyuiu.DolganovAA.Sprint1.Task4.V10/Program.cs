using Tyuiu.DolganovAA.Sprint1.Task4.V10.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task4.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №1                                                                  *");
            Console.WriteLine("* Тема : Class Math                                                          *");
            Console.WriteLine("* Задание №4                                                                 *");
            Console.WriteLine("* Вариант №10                                                                *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные данные ,  *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. Ответ округлите   *");
            Console.WriteLine("* до 3 знаков после запятой .                                               *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");

            double a;
            Console.WriteLine("Введите число которое будет заместо а : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("при а = " + a + " , Ответ будет : " + ds.Calculate(a));
            Console.ReadKey();
        }
    }
}
