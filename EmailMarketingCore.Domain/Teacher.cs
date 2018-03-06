namespace EmailMarketingCore.Domain
{
    public class Teacher : Person
    {
    
        public Teacher(string firstName, string secondName, string lastName, string address, string email, SchoolClass schoolClass) 
            : base(firstName, secondName, lastName, address, email)
        {
            SchoolClass = schoolClass;
        }
        
        public SchoolClass SchoolClass { get; private set; }
    }
}
