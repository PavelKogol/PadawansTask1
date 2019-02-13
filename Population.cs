using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            int year;
            for (year = 1; ; year++)
            {
                initialPopulation = Convert.ToInt32((1 + percent / 100) * initialPopulation + visitors);
                if (initialPopulation >= currentPopulation)
                    break;
            }
            //throw new NotImplementedException();
            return year;
        }
    }
}