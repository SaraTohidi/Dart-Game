using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    class PointsCalculator
    {
        int centerX = 193;
        int centerY = 185;
        int radius = 134;
        public bool CheckOffBoard(int pointX, int pointY)
        {
            double diffX = pointX - centerX;
            double diffY = pointY - centerY;
            double distance = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2));
            if (distance > radius)
            {
                return true;
            }
            else
                return false;
        }

        public int SectionFinder(int pointX, int pointY)
        {
            double diffX = pointX - centerX;
            double diffY = pointY - centerY;
            double arc = (Math.Abs(Math.Atan(diffY / diffX)) * 180 )/Math.PI;

            if (pointX <= centerX && pointY <= centerY)
            {
                //left up
                if(arc <= 9)
                {
                    return 11;
                }
                else if(9 < arc && arc <= 27)
                {
                    return 14;
                }
                else if (27 < arc && arc <= 45)
                {
                    return 9;
                }
                else if (45 < arc && arc <= 63)
                {
                    return 12;
                }
                else if (63 < arc && arc <= 81)
                {
                    return 5;
                }
                else
                {
                    return 20;
                }
            }
            else if (pointX <= centerX && pointY >= centerY)
            {
                //left down
                if (arc <= 9)
                {
                    return 11;
                }
                else if (9 < arc && arc <= 27)
                {
                    return 8;
                }
                else if (27 < arc && arc <= 45)
                {
                    return 16;
                }
                else if (45 < arc && arc <= 63)
                {
                    return 7;
                }
                else if (63 < arc && arc <= 81)
                {
                    return 19;
                }
                else
                {
                    return 3;
                }
            }
            else if (pointX >= centerX && pointY <= centerY)
            {
                //right up
                if (arc <= 9)
                {
                    return 6;
                }
                else if (9 < arc && arc <= 27)
                {
                    return 13;
                }
                else if (27 < arc && arc <= 45)
                {
                    return 4;
                }
                else if (45 < arc && arc <= 63)
                {
                    return 18;
                }
                else if (63 < arc && arc <= 81)
                {
                    return 1;
                }
                else
                {
                    return 20;
                }
            }
            else if (pointX >= centerX && pointY >= centerY)
            {
                //right down
                if (arc <= 9)
                {
                    return 6;
                }
                else if (9 < arc && arc <= 27)
                {
                    return 10;
                }
                else if (27 < arc && arc <= 45)
                {
                    return 15;
                }
                else if (45 < arc && arc <= 63)
                {
                    return 2;
                }
                else if (63 < arc && arc <= 81)
                {
                    return 17;
                }
                else
                {
                    return 3;
                }
            }
            return 0;
        }
        public int FindBullseye(int pointX, int pointY)
        {
            double diffX = pointX - centerX;
            double diffY = pointY - centerY;
            double distance = Math.Sqrt(Math.Abs(Math.Pow(diffX, 2) + Math.Pow(diffY, 2)));
            if(distance <= 14 && distance > 6)
            {
                return 25;
            }
            else if(distance <= 6)
            {
                return 50;
            }
            else
            {
                return 0;
            }
        }

        public bool IsDouble(int pointX, int pointY)
        {
            double diffX = pointX - centerX;
            double diffY = pointY - centerY;
            double distance = Math.Sqrt(Math.Abs(Math.Pow(diffX, 2) + Math.Pow(diffY, 2)));
            if(distance <= radius && distance >= 127)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isTriple(int pointX, int pointY)
        {
            double diffX = pointX - centerX;
            double diffY = pointY - centerY;
            double distance = Math.Sqrt(Math.Abs(Math.Pow(diffX, 2) + Math.Pow(diffY, 2)));
            if (distance <= 85 && distance >= 77)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CalculateThrow(int pointX, int pointY)
        {
            if(CheckOffBoard(pointX, pointY))
            {
                return 0;
            }

            if (FindBullseye(pointX, pointY) == 0)
            {
                if(IsDouble(pointX, pointY))
                {
                    return SectionFinder(pointX, pointY) * 2;
                }
                else if (isTriple(pointX, pointY))
                {
                    return SectionFinder(pointX, pointY) * 3;
                }
                return SectionFinder(pointX, pointY);
            }

            return FindBullseye(pointX, pointY);

        }
    }
}
