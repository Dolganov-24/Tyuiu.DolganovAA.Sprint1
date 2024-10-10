using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAA.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((((1+(Math.Sin(x+y) * Math.Sin(x+y))) / (2 + Math.Abs(x-((2 * x)/(1 + (x * x) * (y * y))))))+x), 3);
            return res;
        }
    }
}
 