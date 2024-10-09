using Tyuiu.DolganovAA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void RunTests()
        {
            DataService ds = new DataService();

            Console.WriteLine("Тест 1 (упорядоченные): " + (ds.CheckWordsAlphabet("abc") ? "Passed" : "Failed"));
            Console.WriteLine("Тест 2 (не упорядоченные): " + (ds.CheckWordsAlphabet("bac") ? "Failed" : "Passed"));
            Console.WriteLine("Тест 3 (пустая строка): " + (ds.CheckWordsAlphabet("") ? "Passed" : "Failed"));
            Console.WriteLine("Тест 4 (один символ): " + (ds.CheckWordsAlphabet("a") ? "Passed" : "Failed"));
            Console.WriteLine("Тест 5 (чувствительность к регистру): " + (ds.CheckWordsAlphabet("ABC") ? "Passed" : "Failed"));
        }

    }
}