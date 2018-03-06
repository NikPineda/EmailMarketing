namespace EmailMarketingCore.Domain
{
    using System;

    public interface IPerson
    {
        Guid Id
        {
            get;
        }

        string FirstName
        {
            get;
            set;
        }

        string SecondName
        {
            get;
            set;
        }

        string LastName
        {
            get;
            set;
        }

        string Address
        {
            get;
            set;
        }

        string Email
        {
            get;
            set;
        }
    }
}
