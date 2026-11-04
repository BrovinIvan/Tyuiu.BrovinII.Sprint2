using Tyuiu.BrovinII.Sprint2.Task1.V19.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task0.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 2");
            Console.WriteLine("Вариант 1");
            Console.WriteLine("Задание 0");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            Console.WriteLine("a = 696, b = 354, c = 423, d = 957. Результат:");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(ds.GetLogicOperations(a,b,c,d)[i]);
            }
        }
    }
}
