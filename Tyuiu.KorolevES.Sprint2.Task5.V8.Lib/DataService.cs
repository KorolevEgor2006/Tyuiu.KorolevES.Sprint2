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
            switch (mm)
            {
                case 1:
                    return $"{nn} января";
                case 2:
                    return $"{nn} февраля";
                case 3:
                    return $"{nn} марта";
                case 4:
                    return $"{nn} апреля";
                case 5:
                    return $"{nn} мая";
                case 6:
                    return $"{nn} июня";
                case 7:
                    return $"{nn} июля";
                case 8:
                    return $"{nn} августа";
                case 9:
                    return $"{nn} сентября";
                case 10:
                    return $"{nn} октября";
                case 11:
                    return $"{nn} ноября";
                case 12:
                    return $"{nn} декабря";


            }
        }
    }
}
