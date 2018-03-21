using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteMathPack1
{
    public static class Modulo
    {
        public static int Division(int divide, int divideBy)
        {
            CheckIfMethodIsTryingToDivideByZero(divideBy);
            if (divide == 0)
            {
                return 0;
            }

            CheckIfAnyNumberIsNegative(ref divide, ref divideBy);

            while (true)
            {
                if (divide - divideBy < 0)
                {
                    break;
                }
                else
                {
                    divide -= divideBy;
                }
            }
            return divide;
        }

        public static double Division(double divide, int divideBy)
        {
            CheckIfMethodIsTryingToDivideByZero(divideBy);
            if (divide == 0)
            {
                return 0;
            }

            CheckIfAnyNumberIsNegative(ref divide, ref divideBy);

            while (true)
            {
                if (divide - divideBy < 0)
                {
                    break;
                }
                else
                {
                    divide -= divideBy;
                }
            }
            return divide;
        }

        private static void CheckIfAnyNumberIsNegative(ref int divide, ref int divideBy)
        {
            if (divide < 0)
            {
                divide = -divide;
            }

            if (divideBy < 0)
            {
                divideBy = -divideBy;
            }
        }

        private static void CheckIfAnyNumberIsNegative(ref double divide, ref int divideBy)
        {
            if (divide < 0)
            {
                divide = -divide;
            }

            if (divideBy < 0)
            {
                divideBy = -divideBy;
            }
        }

        private static void CheckIfMethodIsTryingToDivideByZero(int divideBy)
        {
            if (divideBy == 0)
            {
                throw new DivideByZeroException();
            }
        }

    }
}
