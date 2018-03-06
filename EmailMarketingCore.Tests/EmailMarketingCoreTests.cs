namespace EmailMarketingCore.Tests
{
    using System;
    using Xunit;
    using EmailMarketingCore.Domain;
    using EmailMarketingCore.Domain.Exeptions;

    public class EmailMarketingCoreTests
    {
        [Fact]
        [Trait("Category","DomainTests")]
        public void CheckTownClassIdGenerator()
        {
            var firsTown = new Town("Qmbol");
            var secondTown = new Town("Sliven");
            Assert.NotEqual(firsTown.Id, secondTown.Id);
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingArgumentNullExeptionForClassTownName()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var town = new Town("");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingArgumentNullExeptionForClassTownNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var town = new Town(null);
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingArgumentExeptionForNonLeteralsInName()
        {
            Assert.Throws<UnvalidLiteralExeption>(() =>
            {
                var town = new Town("Sofia1");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingArgumentExeptionForDuplicationTownName()
        {
            var town1 = new Town("Sofia");
            
            Assert.Throws<DuplicateTownNameExeption>(() =>
            {
                var town2 = new Town("Sofia");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingNullExeptionForClassPersonFirstName()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var person = new Parent("", "Sasho", "Kaloqnov", "Address", "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingNullExeptionForClassPersonSecondName()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var person = new Parent("Sasho", "", "Kaloqnov", "Address", "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingNullExeptionForClassPersonLastName()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var person = new Parent("Sasho", "Kaloqnov", "", "Address", "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingNullExeptionForClassPersonAddress()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var person = new Parent("Sasho", "Kaloqnov", "Petrov", null, "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingEmailExeptionForClassPersonEmail()
        {
            Assert.Throws<UnvalidEmailExeption>(() =>
            {
                var person = new Parent("Sasho", "Kaloqnov", "Petrov", "Blagoev 15", "NNinedaabv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingLiteralExeptionForClassPersonFirstName()
        {
            Assert.Throws<UnvalidLiteralExeption>(() =>
            {
                var person = new Parent("Sasho@", "Kaloqnov", "Petrov", "Blagoev 15", "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingLiteralExeptionForClassPersonSecondName()
        {
            Assert.Throws<UnvalidLiteralExeption>(() =>
            {
                var person = new Parent("Sasho", "Kaloqnov/", "Petrov", "Blagoev 15", "NNineda@abv.bg");
            });
        }

        [Fact]
        [Trait("Category", "DomainTests")]
        public void GettingLiteralExeptionForClassPersonLastName()
        {
            Assert.Throws<UnvalidLiteralExeption>(() =>
            {
                var person = new Parent("Sasho", "Kaloqnov", "?Petrov", "Blagoev 15", "NNineda@abv.bg");
            });
        }
    }
}
