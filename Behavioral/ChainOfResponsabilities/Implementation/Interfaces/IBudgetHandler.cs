using Implementation.DataObjects;

namespace Implementation.Interfaces
{
    public interface IBudgetHandler
    {
        IBudgetHandler SetNextBudgetHandler(IBudgetHandler handler);

       (CustomerBudget Budget, IBudgetHandler BudgetHandler) Handle(CustomerBudget budget);
       (CustomerBudget Budget, IBudgetHandler BudgetHandler) ApproveBudget(CustomerBudget budget);
    }
}