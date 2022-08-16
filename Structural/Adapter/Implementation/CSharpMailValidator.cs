using Implementation.Interfaces;
using System.Net.Mail;

namespace Implementation
{
    public class CSharpMailValidator : IMailValidate
    {
        public bool IsEmail(object value)
        {
            if(value.GetType() != typeof(string))
                return false;

            try
            {
                var email = new MailAddress((string)value);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}