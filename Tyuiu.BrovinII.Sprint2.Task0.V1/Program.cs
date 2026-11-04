using Tyuiu.BrovinII.Sprint2.Task0.V1.Lib;

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
            int x = 233;
            int y = 122;
            Console.WriteLine("x = 233, y = 122. Результат:");
            for (int i = 0; i < 6; i++) {
                Console.WriteLine(ds.GetCompareOperations(x, y)[i]);
            }
        }
    }
}
