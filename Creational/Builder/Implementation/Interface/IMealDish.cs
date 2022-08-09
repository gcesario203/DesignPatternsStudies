namespace Implementation.Interface
{
    public interface IMealDish<TDish>
    {
         TDish BuildMeal(this TDish context, params IMealComposite[] components);

         TDish BuildBeverage(this TDish context, params IMealComposite[] components);

         TDish BuildDessert(this TDish context, params IMealComposite[] components);
    }
}