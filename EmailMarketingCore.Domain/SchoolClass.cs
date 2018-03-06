namespace EmailMarketingCore.Domain
{
    using System;

    public class SchoolClass
    {
        private string _name;

        public SchoolClass(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name
        {
            get => _name;
            private set
            {
                ServisProvider.ValidateString(value, "School class");

                _name = value;
            }
        }
    }
}
