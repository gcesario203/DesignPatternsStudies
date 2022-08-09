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
    }
}