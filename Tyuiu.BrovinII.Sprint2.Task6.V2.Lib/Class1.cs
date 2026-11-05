using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1 or 2 or 12: return "зима";
                case 3 or 4 or 5: return "весна";
                case 6 or 7 or 8: return "лето";
                case 9 or 10 or 11: return "осень";
            }
            return "Err";
        }
    }
}
