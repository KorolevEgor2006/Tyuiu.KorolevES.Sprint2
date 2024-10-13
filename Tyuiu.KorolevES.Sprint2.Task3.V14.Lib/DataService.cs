using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task3.V14.Lib
{
    public class DataService : ISprint2Task3V14
    {
        public double Calculate(double x)
        {
            double y =0.0d;
            if (x > 1.0d)
            {
                y=Math.Round(x-Math.Pow((x+1)/(x-1),3),3);
            }
            else if (x == 0.0d)
            {
                y= Math.Round((3 * x * x - Math.Cos(Math.Pow(x, 3)) + 10) / (4 * x * x - Math.Sin(Math.Pow(x, 4)) + 12), 3);
            }
            else if ((x < 2.0d) && (x > -18.0d))
            {
                y= Math.Round(Math.Pow(1+1/(x*x),x), 3);
            }
            else if (x < -18.0d)
            {
                y= Math.Round(x+10*x-1/x, 3);
            }
            return y;
        }
    }
}
