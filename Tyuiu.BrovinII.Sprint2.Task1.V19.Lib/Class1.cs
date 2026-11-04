using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task1.V19.Lib
{
    public class DataService : ISprint2Task1V19
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[]{
                (a > b) | (c == d),
                (a == b) & (c < d),
                (a != b) || (c > d),
                (a < b) && (c != d),
                !(a <= b),
                (b >= a) ^ (c == d)
            };

            return res;
        }
    }
}
