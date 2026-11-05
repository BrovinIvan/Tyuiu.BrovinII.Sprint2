using Tyuiu.BrovinII.Sprint2.Task6.V2.Lib;
namespace Tyuiu.BrovinII.Sprint2.Task6.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0.5, 0.5));

        }
    }
}
