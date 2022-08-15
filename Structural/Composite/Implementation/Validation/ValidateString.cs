namespace Implementation.Validation
{
    public class ValidateString : ValidationComponent
    {
        public override bool Validate(object value)
        {
            return value.GetType() == typeof(string);
        }
    }
}