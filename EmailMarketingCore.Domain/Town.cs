using System.ComponentModel.DataAnnotations;
using EmailMarketingCore.Domain.Exeptions;

namespace EmailMarketingCore.Domain
{
    using System;
    using System.Collections.Generic;

    public class Town
    {
        private string _name;
        private static IList<string> _listOfTownNames = new List<string>();
        private const string TownStirng = "Town";

        public Town(string name)
        {
            this.Name = name;
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public string Name
        {
            get => this._name;
            private set
            {
                ServisProvider.ValidateString(value, TownStirng);
                ServisProvider.ValidateStringForLiterals(value, TownStirng);

                if (_listOfTownNames.Contains(value.ToLower()))
                {
                    throw new DuplicateTownNameExeption("Can not add existing town name!");
                }

                _listOfTownNames.Add(value.ToLower());
                this._name = value;
            }
        }        
    }
}
