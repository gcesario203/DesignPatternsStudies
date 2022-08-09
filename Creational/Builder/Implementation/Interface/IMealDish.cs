namespace Implementation.Interface
{
    public interface IMealDish
    {
        void BuildMeal(params IMealComposite[] components);

        void BuildBeverage(params IMealComposite[] components);

        void BuildDessert(params IMealComposite[] components);
    }
}