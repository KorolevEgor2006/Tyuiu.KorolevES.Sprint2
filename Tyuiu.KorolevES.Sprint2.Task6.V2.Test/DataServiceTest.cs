using Tyuiu.KorolevES.Sprint2.Task6.V2.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthSeason()
        {
            DataService ds = new DataService();
            Assert.AreEqual("зима",ds.FindMonthSeason(1));
            Assert.AreEqual("зима", ds.FindMonthSeason(2));
            Assert.AreEqual("весна", ds.FindMonthSeason(3));
            Assert.AreEqual("весна", ds.FindMonthSeason(4));
            Assert.AreEqual("весна", ds.FindMonthSeason(5));
            Assert.AreEqual("лето", ds.FindMonthSeason(6));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("лето", ds.FindMonthSeason(8));
            Assert.AreEqual("осень", ds.FindMonthSeason(9));
            Assert.AreEqual("осень", ds.FindMonthSeason(10));
            Assert.AreEqual("осень", ds.FindMonthSeason(11));
            Assert.AreEqual("зима", ds.FindMonthSeason(12));
        }
    }
}