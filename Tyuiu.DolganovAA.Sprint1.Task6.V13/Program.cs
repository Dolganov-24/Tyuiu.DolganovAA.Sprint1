using Tyuiu.DolganovAA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task6.V13
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
            Console.WriteLine("* Задание №6                                                                 *");
            Console.WriteLine("* Вариант №13                                                                 *");
            Console.WriteLine("* Выполнил : Долганов Александр Анатольевич | СМАРТб-24-1                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                                  *");
            Console.WriteLine("* Написать программу: Пользователь вводит текст. Проверить, что буквы строки *");
            Console.WriteLine("* упорядоченые по алфавиту .                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                          *");
            Console.WriteLine("******************************************************************************");


            Console.WriteLine("Введите текст:");

            string value = Console.ReadLine();

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ  :                                                               *");
            Console.WriteLine("******************************************************************************");

                if (ds.CheckWordsAlphabet(value))
                {
                    Console.WriteLine("Буквы строки упорядочены по алфавиту.");
                }
                else
                {
                    Console.WriteLine("Буквы строки не упорядочены по алфавиту.");
                }
            }
        }
    }

