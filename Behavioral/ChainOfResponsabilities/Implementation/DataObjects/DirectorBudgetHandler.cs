using Implementation.Abstractions;
using Implementation.Interfaces;

namespace Implementation.DataObjects
{
    public class DirectorBudgetHandler : BaseBudgetHandler
    {
        public override (CustomerBudget Budget, IBudgetHandler BudgetHandler) Handle(CustomerBudget budget) => ApproveBudget(budget);

        public override (CustomerBudget Budget, IBudgetHandler BudgetHandler) ApproveBudget(CustomerBudget budget) => base.ApproveBudget(budget);
    }
}