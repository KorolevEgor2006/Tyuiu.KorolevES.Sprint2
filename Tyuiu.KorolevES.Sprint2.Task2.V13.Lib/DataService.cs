﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KorolevES.Sprint2.Task2.V13.Lib
{
    public class DataService : ISprint2Task2V13
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (((x==4)&&(y>=2)&&(y<=8))||((y==11)&&(x>=2)&&(x<=9))|| ((y == 10) && (x >= 6) && (x <= 12))|| ((y == 12) && (x >= 7) && (x <= 9))|| ((y == 6) && (x >= 3) && (x <= 7))|| ((x == 13) && (y >= 6) && (y <= 8))||((x>=9)&&(x<=12)&&(y>=3)&&(y<=4))|| ((x >= 8) && (x <= 12) && (y >= 6) && (y <= 10)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
