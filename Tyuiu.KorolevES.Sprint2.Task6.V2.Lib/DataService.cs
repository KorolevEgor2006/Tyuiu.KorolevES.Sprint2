using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1:
                case 2:
                case 12:return "зима";
                case 3:
                case 4:
                case 5: return "весна";
                case 6:
                case 7:
                case 8: return "лето";
                case 9:
                case 10:
                case 11: return "осень";
                default:throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}.");

            }
        }
    }
}
