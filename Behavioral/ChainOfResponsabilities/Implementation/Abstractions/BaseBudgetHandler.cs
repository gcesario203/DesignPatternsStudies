using Implementation.DataObjects;
using Implementation.Interfaces;

namespace Implementation.Abstractions
{
    public abstract class BaseBudgetHandler : IBudgetHandler
    {
        protected IBudgetHandler NextHandler;

        public virtual IBudgetHandler SetNextBudgetHandler(IBudgetHandler handler)
        {
            NextHandler = handler;

            return handler;
        }
        public virtual (CustomerBudget Budget, IBudgetHandler BudgetHandler) Handle(CustomerBudget budget)
        {
            if (NextHandler == null)
                return (budget, this);

            return NextHandler.Handle(budget);
        }

        public virtual (CustomerBudget Budget, IBudgetHandler BudgetHandler) ApproveBudget(CustomerBudget budget)
        {
            budget.Approved = true;

            return (budget, this);
        }
    }
}