using Tyuiu.KorolevES.Sprint2.Task2.V13.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 9, y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wiat = true;
            Assert.AreEqual(wiat, res);
        }
    }
}