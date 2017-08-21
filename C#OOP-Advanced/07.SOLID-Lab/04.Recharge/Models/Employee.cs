using _04.Recharge.Interfaces;

namespace _04.Recharge.Models
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id) : base(id)
        {
        }

        public void Sleep()
        {
        }
    }
}