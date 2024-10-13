using Tyuiu.KorolevES.Sprint2.Task1.V24.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLogicOperations()
        {
            int a = 325, b = 325, c = 242, d = 324;
            DataService ds = new DataService();
            bool[] wait = { true, false, true, false, true, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}