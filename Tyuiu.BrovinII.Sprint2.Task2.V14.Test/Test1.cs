using Tyuiu.BrovinII.Sprint2.Task2.V14.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task2.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 6;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
