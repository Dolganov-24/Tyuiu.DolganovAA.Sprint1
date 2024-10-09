using Tyuiu.DolganovAA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task3.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Долганов А.А. | СМАРТб-24-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт №1                                                                  *");
            Console.WriteLine("* Тема : Операторы составного присваивания                                   *");
            Console.WriteLine("* Задание №3                                                                 *");
            Console.WriteLine("* Вариант №19                                                                *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу , которая печатает true или false в зависимости от того,*");
            Console.WriteLine("* может ли шахматная фигура <Слон> с одного заданного поля шахматной доски   *");
            Console.WriteLine("* перейти за один ход на другое. Пользователь задаёт координаты двух ячеек   *");
            Console.WriteLine("* шахматной доски (х1 и у1, х2 и у2, каждое в диапазоне от 1 до 8) .         *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");
           
            Console.WriteLine("Введите координаты первой клетки (x1)");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты первой клетки (y1)");
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй клетки (x2)");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй клетки (y2)");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("Исход  :" + ds.ElephCanMove( x1,  y1,  x2,  y2));
            Console.ReadKey();

        }
    }
}
