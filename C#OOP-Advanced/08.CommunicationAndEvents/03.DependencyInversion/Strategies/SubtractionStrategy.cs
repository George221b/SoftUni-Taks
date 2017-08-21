using _03.DependencyInversion.Interfaces;

namespace _03.DependencyInversion.Strategies
{
    public class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
