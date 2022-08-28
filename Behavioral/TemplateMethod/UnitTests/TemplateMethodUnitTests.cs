using Implementation.DataParsers;

namespace UnitTests;

public class TemplateMethodUnitTests
{
    [Fact]
    public async void ShouldReturnAListOfCustomersByTextFile()
    {
        var customerTxtParser = new CustomerTxtParser(@".\customers.txt");

        await customerTxtParser.FixCustomerData();

        Assert.NotEqual(customerTxtParser.Customers.Count(), 0);
    }

    [Fact]
    public async void ShouldReturnAListOfCustomersByJsonFile()
    {
        var customerJsonParser = new CustomerJsonParser(@".\customers.json");

        await customerJsonParser.FixCustomerData();

        Assert.NotEqual(customerJsonParser.Customers.Count(), 0);
    }

    [Fact]
    public async void ShouldCustomerListFromJsonAndTextFileHaveTheSameData()
    {
        var customerJsonParser = new CustomerJsonParser(@".\customers.json");

        await customerJsonParser.FixCustomerData();

        var customerTxtParser = new CustomerTxtParser(@".\customers.txt");

        await customerTxtParser.FixCustomerData();

        var listsHaveTheSameCustomers = customerJsonParser.Customers.All(customer => customerTxtParser.Customers.Any(x => customer.Cpf == x.Cpf)) && customerJsonParser.Customers.Count() == customerTxtParser.Customers.Count();

        Assert.True(listsHaveTheSameCustomers);
    }

    [Fact]
    public async void ParsersShouldHaveDifferentHooks()
    {
        var customerJsonParser = new CustomerJsonParser(@".\customers.json");

        await customerJsonParser.FixCustomerData();

        var customerTxtParser = new CustomerTxtParser(@".\customers.txt");

        await customerTxtParser.FixCustomerData();

        var customerShouldHaveDifferentNameBecauseHook = customerJsonParser.Customers.All(customer => customerTxtParser.Customers.Any(x => customer.Name == x.Name));

        Assert.False(customerShouldHaveDifferentNameBecauseHook);
    }
}