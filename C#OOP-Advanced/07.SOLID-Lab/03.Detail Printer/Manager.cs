using System;

namespace _03.Detail_Printer
{
    using System.Collections.Generic;

    public class Manager : IPerson
    {
        public Manager(string name, ICollection<string> documents)
        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public string Name { get; private set; }
        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            return $"Manager Name: {this.Name}{Environment.NewLine}{string.Join(Environment.NewLine, this.Documents)}";
        }

    }
}
