using System.Text;
using Implementation.Abstractions;
using Implementation.DataObjects;

namespace Implementation.DataParsers
{
    public class CustomerTxtParser : CustomerParser
    {
        public CustomerTxtParser(string filePath) : base(filePath) { }

        protected override void Hook() =>
            Customers = Customers.Select(x => { x.Name = x.Name + " From TXT"; return x; });

        protected override async Task<IEnumerable<Customer>> ParseData() => File.ReadAllLinesAsync(_filePath, Encoding.UTF8).GetAwaiter().GetResult().Select(line =>
            {
                var lineQueue = new Queue<string>(line.Split(";"));

                return new Customer(lineQueue.Dequeue(), int.Parse(lineQueue.Dequeue()), lineQueue.Dequeue());
            });
    }
}