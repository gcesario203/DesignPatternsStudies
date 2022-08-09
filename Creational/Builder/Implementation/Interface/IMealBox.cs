namespace Implementation.Interface
{
    public interface IMealBox : IMealComposite
    {
        void Add(params IMealComposite[] meals);
    }
}