using Tyuiu.KorolevES.Sprint2.Task4.V12.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task4.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest0()
        {
            DataService ds = new DataService();
            double x = 1.0, y = 0.25;
            double res = ds.Calculate(x, y);
            double wait = 39.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateTest1()
        {
            DataService ds = new DataService();
            double x = 9.0, y = 4.0;
            double res = ds.Calculate(x, y);
            double wait = 9.076;
            Assert.AreEqual(wait, res);
        }
    }
}