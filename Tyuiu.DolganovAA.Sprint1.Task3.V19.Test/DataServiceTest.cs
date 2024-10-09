using System.Net.WebSockets;
using Tyuiu.DolganovAA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionTrue()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.ElephCanMove(1, 1, 3, 3));
            Assert.IsTrue(ds.ElephCanMove(4, 4, 8, 8));
            Assert.IsTrue(ds.ElephCanMove(5, 3, 7, 5));
        }


        [TestMethod]
        public void ValidExpressionFalse()
        {
            DataService ds = new DataService();
            Assert.IsFalse(ds.ElephCanMove(1, 1, 2, 3));
            Assert.IsFalse(ds.ElephCanMove(4, 4, 5, 6));
            Assert.IsFalse(ds.ElephCanMove(3, 5, 6, 7)); 
        }

    }
}