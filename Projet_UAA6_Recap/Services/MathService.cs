using Projet_UAA6_Recap.BusinessExceptions;

namespace Projet_UAA6_Recap.Services
{
    public class MathService
    {
        public static double Addition(double nb1, double nb2)
        {
            double result = nb1 + nb2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public static double Soustraction(double nb1, double nb2)
        {
            double result = Math.Round((nb1 - nb2) * 1000) / 1000;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public static double Division(double nb1, double nb2)
        {
            if(nb2 == 0)
            {
                throw new MathDivisionByZeroException();
            }

            double result = Math.Round((nb1 / nb2) * 1000) / 1000;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public static double Multiplication(double nb1, double nb2)
        {
            double result = Math.Round((nb1 * nb2) * 1000) / 1000;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
