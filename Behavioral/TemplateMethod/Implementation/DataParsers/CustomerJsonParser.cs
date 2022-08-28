using System.Text;
using System.Text.Json;
using Implementation.Abstractions;
using Implementation.DataObjects;

namespace Implementation.DataParsers
{
    public class CustomerJsonParser : CustomerParser
    {
        public CustomerJsonParser(string filePath) : base(filePath) { }

        protected override void Hook() =>
            Customers = Customers.Select(x => { x.Name = x.Name + " From Json"; return x; });

        protected override async Task<IEnumerable<Customer>> ParseData() => JsonSerializer.Deserialize<List<Customer>>(await File.ReadAllTextAsync(_filePath, Encoding.UTF8)) ?? new List<Customer>();
    }
}