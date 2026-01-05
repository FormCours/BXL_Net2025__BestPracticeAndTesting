namespace Projet_UAA6_Recap.BusinessExceptions
{
    public class MathException : Exception
    {
        public MathException(string message) : base($"Math Exception : {message}") { }
    }

    public class MathDivisionByZeroException : MathException
    {
        public MathDivisionByZeroException() : base("Division par zéro") { }
    }
}