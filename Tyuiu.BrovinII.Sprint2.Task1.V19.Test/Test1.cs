using Tyuiu.BrovinII.Sprint2.Task1.V19.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task1.V19.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 696;
            int b = 354;
            int c = 423;
            int d = 957;
            bool[] wait = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(wait,ds.GetLogicOperations(a,b,c,d));
        }
    }
}
