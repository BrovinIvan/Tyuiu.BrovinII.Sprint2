using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 10) && (x <= 13) && (y >= 2) && (y <= 3))
            {
                return true;
            }
            else if ((x >= 10) && (x <= 12) && (y >= 4) && (y <= 5))
            {
                return true;
            }
            else if ((x >= 3) && (x <= 5) && (y >= 3) && (y <= 7))
            {
                return true;
            }
            else if ((x == 2) && (y >= 4) && (x <= 5))
            {
                return true;
            }
            else if ((x >= 6) && (x <= 8) && (y >= 5) && (y <= 10))
            {
                return true;
            }
            else if ((x==9)&&(y==5))
            {
                return true;
            }
            else if ((y == 11) && (x >= 3) && (x <= 12))
            {
                return true;
            }
            else if ((y==12)&&(x>=7)&&(x<=10))
            {
                return true;
            }
            else if ((x==13)&&(y>=9)&&(y<=13))
            {
                return true;
            }
            else { return false; }
        }
    }
}
