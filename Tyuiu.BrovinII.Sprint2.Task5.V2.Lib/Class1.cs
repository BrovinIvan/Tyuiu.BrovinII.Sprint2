using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        string res;
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1 or 12 or 2:
                    res = "зима";
                    break;
                case 3 or 4 or 5:
                    res = "весна";
                    break;
                case 6 or 7 or 8:
                    res = "лето";
                    break;
                case 9 or 10 or 11:
                    res = "осень";
                    break;
            }
            return res;
        }
    }
}
