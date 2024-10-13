using Tyuiu.KorolevES.Sprint2.Task0.V24.Lib;
namespace Tyuiu.KorolevES.Sprint2.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCompareOperations()
        {
            DataService ds = new DataService();
            int x = 135;
            int y = 755;
            bool[] res = ds.GetCompareOperations(x, y);
            bool[] wait = {true,true,false,false,true,true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}