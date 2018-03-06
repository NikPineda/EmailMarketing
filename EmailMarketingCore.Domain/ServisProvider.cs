using EmailMarketingCore.Domain.Exeptions;

namespace EmailMarketingCore.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public static class ServisProvider
    {
        public static void ValidateString(string stringValue, string nameOfString)
        {
            if (string.IsNullOrEmpty(stringValue))
            {
                throw new ArgumentNullException("{0} name can not be null or empty!", nameOfString);
            }
        }

        public static void ValidateStringForLiterals(string stringInput, string typeOfSting)
        {
            if (stringInput.All(Char.IsLetter) == false)
            {
                string message = String.Format("{0} must contains only leters!", typeOfSting);
                throw new UnvalidLiteralExeption(message);
            }
        }

        public static void ValidateEmail(string emailString)
        {
            var emailAddressAttribute = new EmailAddressAttribute();

            if (emailAddressAttribute.IsValid(emailString) == false)
            {
                throw new UnvalidEmailExeption("You are entering unvalid email address");
            }
        }
    }
}
