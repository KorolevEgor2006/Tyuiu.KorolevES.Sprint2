using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int mm;
            int nn;
            int k = n;
            n = m;
            m = k;
            switch (n)
            {
                case 1:
                    if (m == 1)
                    {
                        mm = 12;
                    }
                    else
                    {
                        mm = m - 1;
                    }
                    switch (mm)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            nn = 30;
                            break;
                        case 2:
                            nn = 28;
                            break;
                        default:
                            nn = 31;
                            break;

                    }
                    break;
                default:
                    mm = m;
                    nn = n - 1;
                    break;
            }
            string res ="Неккоректный день";
            switch (mm)
            {
                case 1:
                    res= $"{nn}.01";
                    break;
                case 2:
                    res= $"{nn}.02";
                    break;
                case 3:
                    res= $"{nn}.03";
                    break;
                case 4:
                    res= $"{nn}.04";
                    break;
                case 5:
                    res= $"{nn}.05";
                    break;
                case 6:
                    res= $"{nn}.06";
                    break;
                case 7:
                    res= $"{nn}.07";
                    break;
                case 8:
                    res= $"{nn}.08";
                    break;
                case 9:
                    res= $"{nn}.09";
                    break;
                case 10:
                    res= $"{nn}.10";
                    break;
                case 11:
                    res= $"{nn}.11";
                    break;
                case 12:
                    res= $"{nn}.12";
                    break;


            }
            if (nn > 31)
            {
                res = "Неккоректный день";
            }
            return res;

        }
    }
}
