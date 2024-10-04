using Tyuiu.DolganovAA.Sprint1.Task2.V10.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertMetreToInchs()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.ConvertMetreToInchs(x); 
            Assert.AreEqual(16.40, res);
        }
    }
}