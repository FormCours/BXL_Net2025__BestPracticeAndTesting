using Projet_UAA6_Recap.BusinessExceptions;

namespace Projet_UAA6_Recap.Services
{
    public class MathService
    {
        public static decimal Addition(decimal nb1, decimal nb2)
        {
            decimal result = nb1 + nb2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public static decimal Soustraction(decimal nb1, decimal nb2)
        {
            decimal result = nb1 - nb2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }

        public static decimal Division(decimal nb1, decimal nb2)
        {
            if(nb2 == 0)
            {
                throw new MathDivisionByZeroException();
            }

            decimal result = nb1 / nb2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
        public static decimal Multiplication(decimal nb1, decimal nb2)
        {
            decimal result = nb1 * nb2;
            return Math.Round(result, 2, MidpointRounding.AwayFromZero);
        }
    }
}
