using Implementation.Classes;

namespace UnitTests
{
    public class PrototypeTests
    {
        [Fact]
        public void ShoudHaveDifferentNames()
        {
            var personOne = new Person{ FirstName = "Mauricio", LastName = "De Souza"};

            var personTwo = personOne.Clone();

            personTwo.FirstName = "Elaine";

            Assert.NotEqual(personOne.FirstName, personTwo.FirstName);
        }

        [Fact]
        public void ShoudHaveDifferentAddresses()
        {
            var personOne = new Person{ FirstName = "Mauricio", LastName = "De Souza"};

            personOne.Addresses = new List<Address>{ new Address{ Number = 54, State = "SP", Street = "Rua maranhão", City="Santa Albertina"},
                                                     new Address{ Number = 22, State = "AM", Street = "Aveinida dos Caiapos", City="Rio das ostas"}};

            var personTwo = personOne.Clone();

            personTwo.Addresses.Add(new Address{ Number = 2, State = "RJ", Street = "Rua do Bacurau", City = "Rocinha"});

            personTwo.FirstName = "Elaine";

            Assert.NotEqual(personOne.Addresses, personTwo.Addresses);
        }
    }
}