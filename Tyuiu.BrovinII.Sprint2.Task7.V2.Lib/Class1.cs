using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x * x + y * y <= 1) && (y <= (x / 2))) {  return true; } return false;
        }
    }
}
