using Implementation.DataObjects;

namespace Implementation.Abstractions
{
    public abstract class CustomerParser
    {
        protected string _filePath;

        public IEnumerable<Customer> Customers { get; set; }

        public CustomerParser(string filePath)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, filePath);
            string sFilePath = Path.GetFullPath(sFile);

            _filePath = sFilePath;
        }

        public async Task FixCustomerData()
        {
            Customers = await ParseData();

            Hook();
            
            Customers = FixCpf();
        }

        protected abstract void Hook();

        private IEnumerable<Customer> FixCpf() => Customers.Select(customer => { customer.Cpf = customer.Cpf.Replace(".", "").Replace("-", ""); return customer; });

        protected abstract Task<IEnumerable<Customer>> ParseData();
    }
}