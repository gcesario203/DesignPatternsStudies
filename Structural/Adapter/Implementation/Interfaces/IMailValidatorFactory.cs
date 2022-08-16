namespace Implementation.Interfaces
{
    public interface IMailValidatorFactory
    {
        IMailValidate Build(Type type);
    }
}