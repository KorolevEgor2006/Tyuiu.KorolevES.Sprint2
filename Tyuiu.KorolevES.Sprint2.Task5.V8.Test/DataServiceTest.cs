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
            Assert.AreEqual("31 �������",ds.FindDateOfPreviousDay(1,1));
            Assert.AreEqual("������������ ����", ds.FindDateOfPreviousDay(0, 14));
            Assert.AreEqual("28 �������", ds.FindDateOfPreviousDay(3, 1));
            Assert.AreEqual("31 �����", ds.FindDateOfPreviousDay(4, 1));
            Assert.AreEqual("31 ����", ds.FindDateOfPreviousDay(8, 1));
            Assert.AreEqual("������������ ����", ds.FindDateOfPreviousDay(5, 43));
            Assert.AreEqual("17 ����", ds.FindDateOfPreviousDay(6, 18));
        }
    }
}