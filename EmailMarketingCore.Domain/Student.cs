namespace EmailMarketingCore.Domain
{
    public class Student : Person
    {
        public Student(string firstName, string secondName, string lastName, string address, string email, Parent parent, School school, SchoolClass schoolClass) 
            : base(firstName, secondName, lastName, address, email)
        {
            Parent = parent;
            School = school;
            SchoolClass = schoolClass;
        }

        public Parent Parent { get; private set; }
        public School School { get; private set; }
        public SchoolClass SchoolClass { get; private set; }
    }
}
