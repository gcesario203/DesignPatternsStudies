using System.Text.RegularExpressions;
using Implementation.Interfaces;

namespace Implementation
{
    public class RegexMailValidator : IMailValidate
    {
        public bool IsEmail(object value)
        {
            if (value.GetType() != typeof(string))
                return false;

            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var match = regex.Match((string)value);

            return match.Success;
        }
    }
}