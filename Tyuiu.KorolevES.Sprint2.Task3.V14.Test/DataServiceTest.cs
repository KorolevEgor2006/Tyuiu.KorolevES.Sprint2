using Tyuiu.KorolevES.Sprint2.Task3.V14.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateTest0()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double res = ds.Calculate(x);
            double wait = -25.0;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateTest1()
        {
            DataService ds = new DataService();
            double x = 0.0;
            double res = ds.Calculate(x);
            double wait = 0.75;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculateTest2()
        {
            DataService ds = new DataService();
            double x = -1.0;
            double res = ds.Calculate(x);
            double wait = 0.5;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCalculateTest3()
        {
            DataService ds = new DataService();
            double x = -20.0;
            double res = ds.Calculate(x);
            double wait = -219.95;
            Assert.AreEqual(wait, res);
        }
    }
}