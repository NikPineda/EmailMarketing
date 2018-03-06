namespace EmailMarketingCore.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class School
    {
        private string _name;
        private string _address;
        private string _emial;

        public School(string name, string address, string emial, Town town)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            Email = emial;
            Town = town;
        }

        [Key]
        public Guid Id { get; set; }

        public string Name
        {
            get => _name;
            private set
            {
                ServisProvider.ValidateString(value, "School");

                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            private set
            {
                ServisProvider.ValidateString(value, "Address");

                _address = value;
            }
        }

        public string Email
        {
            get => _emial;
            private set
            {
                ServisProvider.ValidateString(value, "Email");

                var testEmail = new EmailAddressAttribute();
                

                if (testEmail.IsValid(value) == false)
                {
                    throw new ArgumentException("It is not valid email address");
                }
                _emial = value;
            }
        }

        public Town Town { get; set; }
    }
}
