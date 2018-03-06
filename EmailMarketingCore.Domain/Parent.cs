namespace EmailMarketingCore.Domain
{
    public class Parent : Person
    {
        public Parent(string firstName, string secondName, string lastName, string address, string email)
            : base(firstName, secondName, lastName, address, email)
        {
        }
    }
}
