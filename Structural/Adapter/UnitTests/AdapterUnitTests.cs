using Implementation;

namespace UnitTests
{
    public class AdapterUnitTests
    {
        [Fact]
        public void ShouldValidateEmailWithRegexAdapter()
        {
            var mail = "teste@outlook.com";

            var regexMailValidate = new MailValidatorFactory().Build(typeof(RegexMailValidator));

            Assert.Equal(regexMailValidate.IsEmail(mail), true);
        }
        [Fact]
        public void ShouldValidateEmailWithCSharpAdapter()
        {
            var mail = "teste.com";

            var cSharpValidator = new MailValidatorFactory().Build(typeof(CSharpMailValidator));

            Assert.Equal(cSharpValidator.IsEmail(mail), false);
        }
    }
}