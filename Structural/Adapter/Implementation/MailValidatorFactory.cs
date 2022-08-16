using Implementation.Interfaces;

namespace Implementation
{
    public class MailValidatorFactory : IMailValidatorFactory
    {
        public IMailValidate Build(Type type)
        {
            if(type == typeof(CSharpMailValidator))
                return new CSharpMailValidator();

            if(type == typeof(RegexMailValidator))
                return new RegexMailValidator();

            return null;
        }
    }
}