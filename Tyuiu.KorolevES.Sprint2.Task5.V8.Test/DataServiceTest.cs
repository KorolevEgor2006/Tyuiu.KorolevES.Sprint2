using Tyuiu.KorolevES.Sprint2.Task5.V8.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPreviousDaySearchTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual("31.12",ds.FindDateOfPreviousDay(1,1));
            Assert.AreEqual("������������ ����", ds.FindDateOfPreviousDay(0, 14));
            Assert.AreEqual("28.02", ds.FindDateOfPreviousDay(1, 3));
            Assert.AreEqual("31.03", ds.FindDateOfPreviousDay(1, 4));
            Assert.AreEqual("31.07", ds.FindDateOfPreviousDay(1, 8));
            Assert.AreEqual("������������ ����", ds.FindDateOfPreviousDay(5, 43));
            Assert.AreEqual("17.06", ds.FindDateOfPreviousDay(18, 6));
        }
    }
}