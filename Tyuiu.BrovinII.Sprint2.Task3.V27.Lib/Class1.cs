using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BrovinII.Sprint2.Task3.V27.Lib
{
    public class DataService : ISprint2Task3V27
    {
        public double Calculate(double x)
        {
            if (x > 0)
            {
                return Math.Round(Math.Pow((x*((x+1)/(Math.Sin(x*x)+x-0.5))),x),3);
            }
            else if (x == 0)
            {
                return Math.Round((x * x - Math.Cos(x * x) + 4) / (x * x - Math.Sin(x * x) + 12),3);
            }
            else if ((-31 < x)&&(x<0))
            {
                return Math.Round((1 + (1 / (x * x))) * (1 + (1 / (x * x))),3);
            }
            else if (x < -31)
            {
                return Math.Round(x+Math.Pow(Math.Sin(x), 5)+x*x*x-(2/x),3);
            }
            else
            {
                return x;
            }
        }
    }
}
