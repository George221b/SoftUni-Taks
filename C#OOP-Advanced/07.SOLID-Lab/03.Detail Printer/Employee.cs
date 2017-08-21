namespace _03.Detail_Printer
{
    public class Employee : IPerson
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            return $"Employee Name: {this.Name}";
        }
    }
}