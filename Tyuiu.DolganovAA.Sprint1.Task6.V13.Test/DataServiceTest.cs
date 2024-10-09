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

            Console.WriteLine("���� 1 (�������������): " + (ds.CheckWordsAlphabet("abc") ? "Passed" : "Failed"));
            Console.WriteLine("���� 2 (�� �������������): " + (ds.CheckWordsAlphabet("bac") ? "Failed" : "Passed"));
            Console.WriteLine("���� 3 (������ ������): " + (ds.CheckWordsAlphabet("") ? "Passed" : "Failed"));
            Console.WriteLine("���� 4 (���� ������): " + (ds.CheckWordsAlphabet("a") ? "Passed" : "Failed"));
            Console.WriteLine("���� 5 (���������������� � ��������): " + (ds.CheckWordsAlphabet("ABC") ? "Passed" : "Failed"));
        }

    }
}