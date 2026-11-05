using Tyuiu.BrovinII.Sprint2.Task4.V11.Lib;

namespace Tyuiu.BrovinII.Sprint2.Task4.V11.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 2.5;
            Assert.AreEqual(401.312, ds.Calculate(x,y));

        }
        [TestMethod]
        public void TestMethod2() {
            DataService ds = new DataService();
            double x = 40;
            double y = 164;
            Assert.AreEqual(6.14328078920649E+170, ds.Calculate(x, y));
        }
    }
}
