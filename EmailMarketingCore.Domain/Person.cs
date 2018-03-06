namespace EmailMarketingCore.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public abstract class Person : IPerson
    {
        private string _firstName;
        private string _secondName;
        private string _lastName;
        private string _address;
        private string _email;

        protected Person(string firstName, string secondName, string lastName, string address, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Address = address;
            Email = email;
        }
        [Key]
        public Guid Id { get; set; }

        public string FirstName
        {
            get => _firstName;
            set
            {
                ServisProvider.ValidateString(value, "First");
                ServisProvider.ValidateStringForLiterals(value, "First");

                _firstName = value;
            }
        }

        public string SecondName
        {
            get => _secondName;
            set
            {
                ServisProvider.ValidateString(value, "Second");
                ServisProvider.ValidateStringForLiterals(value, "Second");

                _secondName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                ServisProvider.ValidateString(value, "Last");
                ServisProvider.ValidateStringForLiterals(value, "Last");

                _lastName = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                ServisProvider.ValidateString(value, "Address");

                _address = value;
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                ServisProvider.ValidateEmail(value);
                
                _email = value;
            }
        }

    }
}
