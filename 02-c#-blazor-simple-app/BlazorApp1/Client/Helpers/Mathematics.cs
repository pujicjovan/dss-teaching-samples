namespace DSS.Helpers
{
    public class Mathematics
    {
        public static double Power(double theBase, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            double res = 1;
            bool exponentIsNegative = false;
            if (exp < 0)
            {
                exponentIsNegative = true;
                exp = -exp;
            }
            for (int i = 1; i <= exp; i++)
                res *= theBase;
            if (!exponentIsNegative)
                return res;
            else
                return 1 / res;
        }


        public static long Factorial(int num)
        {
            long result = 1;
            for (int i = 2; i <= num; i++)
                result *= i;
            return result;
        }

    }

}




