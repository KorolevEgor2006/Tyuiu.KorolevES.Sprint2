using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task0.V24.Lib
{
    public class DataService : ISprint2Task0V24
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] a = { (x == y) == false, x != y, y < x, x > y, x <= y, y >= x };
            return a;
        }
    }
}
