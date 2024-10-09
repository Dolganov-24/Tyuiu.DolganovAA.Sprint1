using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAA.Sprint1.Task5.V6.Lib
{
    public class DataService : ISprint1Task5V6
    { 
        public int Calculate(int k)
        {
            return (k % 7 == 0) ? 7 : (k % 7);

        }
    }
}
