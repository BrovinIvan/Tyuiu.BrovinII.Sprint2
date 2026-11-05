using Tyuiu.BrovinII.Sprint2.Task6.V2.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task6.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 2");
            Console.WriteLine("Вариант 2");
            Console.WriteLine("Задание 7");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x,y));
        }
    }
}
