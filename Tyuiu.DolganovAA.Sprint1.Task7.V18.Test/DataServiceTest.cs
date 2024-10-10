using Tyuiu.DolganovAA.Sprint1.Task7.V18.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            Assert.AreEqual(Math.Round(ds.Calculate(1, 1), 3), 1.913);
            Assert.AreEqual(Math.Round(ds.Calculate(0, 0), 3), 0.500);
            Assert.AreEqual(Math.Round(ds.Calculate(2, 2), 3), 2.418);

        } 
    }
}