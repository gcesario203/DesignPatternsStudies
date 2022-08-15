using System.Net.Mail;

namespace Implementation.Validation
{
    public class ValidateEmail : ValidationComponent
    {
        public override bool Validate(object value)
        {
            string valueString = (string)value;

            try
            {
                var mailAddress = new MailAddress(valueString);

                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}