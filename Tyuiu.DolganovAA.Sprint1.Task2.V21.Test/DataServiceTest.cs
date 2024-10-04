using Tyuiu.DolganovAA.Sprint1.Task2.V21.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            var res = ds.CalculateRectangleSquare(x, y);
            Assert.AreEqual(20, res);
        }
    }
}