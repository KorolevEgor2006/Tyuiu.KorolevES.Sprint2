using Tyuiu.KorolevES.Sprint2.Task7.V6.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidChechDotTest0()
        {
            DataService ds = new DataService();
            double x = 0.5, y = 0.2;
            bool res =ds.CheckDotInShadedArea(x, y);
            bool wait = false;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidChechDotTest1()
        {
            DataService ds = new DataService();
            double x = 1.5, y = 0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}