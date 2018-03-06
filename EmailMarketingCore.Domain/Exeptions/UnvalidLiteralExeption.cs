namespace EmailMarketingCore.Domain.Exeptions
{
    using System;

    public class UnvalidLiteralExeption : Exception
    {
        public UnvalidLiteralExeption()
        {

        }

        public UnvalidLiteralExeption(string message) : base(message)
        {

        }

        public UnvalidLiteralExeption(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
