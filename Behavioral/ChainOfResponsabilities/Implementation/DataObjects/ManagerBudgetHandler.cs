using Implementation.Abstractions;
using Implementation.Interfaces;

namespace Implementation.DataObjects
{
    public class ManagerBudgetHandler : BaseBudgetHandler
    {
        public override (CustomerBudget Budget, IBudgetHandler BudgetHandler) Handle(CustomerBudget budget)
        {
            if (budget.Price <= 5000M)
                return ApproveBudget(budget);

            return base.Handle(budget);
        }

        public override (CustomerBudget Budget, IBudgetHandler BudgetHandler) ApproveBudget(CustomerBudget budget) => base.ApproveBudget(budget);
    }
}