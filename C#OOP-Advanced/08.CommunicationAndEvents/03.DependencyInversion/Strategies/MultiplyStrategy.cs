using _03.DependencyInversion.Interfaces;

namespace _03.DependencyInversion.Strategies
{
    class MultiplyStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
