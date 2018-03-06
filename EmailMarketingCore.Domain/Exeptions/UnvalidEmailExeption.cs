namespace EmailMarketingCore.Domain.Exeptions
{
    using System;

    public class UnvalidEmailExeption: Exception
    {
        public UnvalidEmailExeption()
        {

        }

        public UnvalidEmailExeption(string message) : base(message)
        {

        }

        public UnvalidEmailExeption(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
