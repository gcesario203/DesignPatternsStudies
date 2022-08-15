
namespace Implementation.Validation
{
    public class ValidateComposer : ValidationComponent
    {
        public List<ValidationComponent> Children {get; private set;} = new List<ValidationComponent>{ new ValidateString(), new ValidateEmail()};

        public override bool Validate(object value)
        {
            return Children.TrueForAll(x => x.Validate(value));
        }
    }
}