using Tyuiu.DolganovAA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.DolganovAA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new DataService();
        }
  
        [TestMethod]
        public void ValidExpression()
        {
            Assert.AreEqual(1, _calculator.Calculate(1));
            Assert.AreEqual(2, _calculator.Calculate(2));
            Assert.AreEqual(3, _calculator.Calculate(3));
            Assert.AreEqual(4, _calculator.Calculate(4));
            Assert.AreEqual(5, _calculator.Calculate(5));
            Assert.AreEqual(6, _calculator.Calculate(6));
            Assert.AreEqual(7, _calculator.Calculate(7));


        }
    }
}