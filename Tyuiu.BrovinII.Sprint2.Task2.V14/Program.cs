using Tyuiu.BrovinII.Sprint2.Task2.V14.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 2");
            Console.WriteLine("Вариант 14");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат: "+ds.CheckDotInShadedArea(x,y));
        }
    }
}
