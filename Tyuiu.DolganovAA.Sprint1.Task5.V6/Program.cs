using Tyuiu.DolganovAA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task5.V6
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
            Console.WriteLine("* Задание №5                                                                 *");
            Console.WriteLine("* Вариант №6                                                                 *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу , которая решает следующую задачу : Пусть k - целое от  *");
            Console.WriteLine("* 1 до 365. Присвоить целой переменной n значение 1,2,..,7 в зависимости от  *");
            Console.WriteLine("* того, на какой день недели приходится k-й день невисокосного года ,        *");
            Console.WriteLine("* в котором 1 января - Понедельник.                                          *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");

            DataService calculator = new DataService();
            Console.WriteLine("Введите номер дня ( от 1 до 365 ) ");

            if (int.TryParse(Console.ReadLine(), out int k))
            {
                try
                {
                    int DayOfWeek = calculator.Calculate(k);
                    Console.WriteLine($"День недели для {k}-го дня года: {DayOfWeek} (1 - Пн , 2 - Вт , ... , 7 - Вс)");

                } 
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");

            Console.WriteLine(k + "-ый день в году это : " + ds.Calculate(k));
            Console.ReadKey();
        }
    }
}
