using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            int mm;
            int nn;
            switch (n)
            {
                case 1:
                    if (m == 1)
                    {
                        mm= 12;
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
                    res= $"{nn} января";
                    break;
                case 2:
                    res= $"{nn} февраля";
                    break;
                case 3:
                    res= $"{nn} марта";
                    break;
                case 4:
                    res= $"{nn} апреля";
                    break;
                case 5:
                    res= $"{nn} мая";
                    break;
                case 6:
                    res= $"{nn} июня";
                    break;
                case 7:
                    res= $"{nn} июля";
                    break;
                case 8:
                    res= $"{nn} августа";
                    break;
                case 9:
                    res= $"{nn} сентября";
                    break;
                case 10:
                    res= $"{nn} октября";
                    break;
                case 11:
                    res= $"{nn} ноября";
                    break;
                case 12:
                    res= $"{nn} декабря";
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
