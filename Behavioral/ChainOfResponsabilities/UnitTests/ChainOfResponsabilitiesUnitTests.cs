using Implementation.DataObjects;

namespace UnitTests;

public class ChainOfResponsabilitiesUnitTests
{
    [Fact]
    public void ShouldCustomerBudgetBeApprovedByDirector()
    {
        var customerBudget = new CustomerBudget(100000);

        var budgetValidator = new SellerBudgetHandler();

        budgetValidator.SetNextBudgetHandler(new ManagerBudgetHandler())
                        .SetNextBudgetHandler(new DirectorBudgetHandler());

        var approvedBudget = budgetValidator.Handle(customerBudget);

        Assert.Equal(approvedBudget.BudgetHandler.GetType(), typeof(DirectorBudgetHandler));
    }

    [Fact]
    public void ShouldCustomerBudgetBeApprovedByManager()
    {
        var customerBudget = new CustomerBudget(4000);

        var budgetValidator = new SellerBudgetHandler();

        budgetValidator.SetNextBudgetHandler(new ManagerBudgetHandler())
                        .SetNextBudgetHandler(new DirectorBudgetHandler());

        var approvedBudget = budgetValidator.Handle(customerBudget);

        Assert.Equal(approvedBudget.BudgetHandler.GetType(), typeof(ManagerBudgetHandler));
    }

    [Fact]
    public void ShouldCustomerBudgetBeApprovedBySeller()
    {
        var customerBudget = new CustomerBudget(900);

        var budgetValidator = new SellerBudgetHandler();

        budgetValidator.SetNextBudgetHandler(new ManagerBudgetHandler())
                        .SetNextBudgetHandler(new DirectorBudgetHandler());

        var approvedBudget = budgetValidator.Handle(customerBudget);

        Assert.Equal(approvedBudget.BudgetHandler.GetType(), typeof(SellerBudgetHandler));
    }
}