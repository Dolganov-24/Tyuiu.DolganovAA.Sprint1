using Tyuiu.DolganovAA.Sprint1.Task2.V21.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task2.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №1                                                                  *");
            Console.WriteLine("* Тема : Арифметические операции в C#                                        *");
            Console.WriteLine("* Задание №2                                                                 *");
            Console.WriteLine("* Вариант №21                                                                *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные данные ,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране                 *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");

            int x;
            Console.WriteLine("Введите значение x :");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("Введите значение y :");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                                *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("Площадь прямоугольнка x / y  =" + ds.CalculateRectangleSquare(x, y));
            Console.ReadLine();


        }
    }
}
