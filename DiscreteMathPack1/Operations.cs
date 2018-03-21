using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace DiscreteMathPack1
{
    public static class Operations
    {
        public static int RoundFloorRec(double result, int number = Int16.MaxValue, int maxRec = 1000)
        {
            if (result >= number || maxRec <= 0)
            {
                return number;
            }

            return RoundRoofRec(result, --number, --maxRec);
        }

        public static int RoundFloor(double result)
        {
            int number = Int16.MaxValue * 100;
            int maxRec = 1000;
            while (number - 1 >= result)
            {
                number = RoundFloorRec(result, number, maxRec);
            }
            return number - 1;
        }

        public static double RoundFloorD(double number)
        {
            return number - Fraction(number);
        }

        public static int RoundRoofRec(double result, int number = Int16.MinValue, int maxRec = 1000)
        {

            if (result <= number || maxRec <= 0)
            {
                return number;
            }

            return RoundRoofRec(result, ++number, --maxRec);
        }

        public static int RoundRoof(double result)
        {
            int number = Int16.MinValue * 100;
            int maxRec = 1000;
            while (number <= result)
            {
                number = RoundRoofRec(result, number, maxRec);
            }
            return number;
        }

        public static double Fraction(double number)
        {
            return Modulo.Division(number, 1);
        }

    }
}
