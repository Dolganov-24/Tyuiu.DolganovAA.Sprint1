using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.DolganovAA.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return true;
            }

            string lowerValue = value.ToLower();

            for (int i = 0; i < lowerValue.Length - 1; i++)
            {
                if (lowerValue[i] > lowerValue[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    

    }

}               
    

