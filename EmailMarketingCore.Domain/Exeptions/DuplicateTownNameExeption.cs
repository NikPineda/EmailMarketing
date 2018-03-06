namespace EmailMarketingCore.Domain.Exeptions
{
    using System;

    public class DuplicateTownNameExeption: Exception
    {
        public DuplicateTownNameExeption()
        {

        }

        public DuplicateTownNameExeption(string message) : base(message)
        {

        }

        public DuplicateTownNameExeption(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
