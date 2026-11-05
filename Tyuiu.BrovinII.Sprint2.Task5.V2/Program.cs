using Tyuiu.BrovinII.Sprint2.Task5.V2.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 2");
            Console.WriteLine("Вариант 2");
            Console.WriteLine("Задание 5");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите номер месяца");
            int x = int.Parse(Console.ReadLine());
            if (x<1 || x>12) {
                Console.WriteLine("Невер знач");
            }
            Console.WriteLine("Результат: " + ds.FindMonthSeason(x));
        }
    }
}
