using _03.DependencyInversion.Interfaces;

namespace _03.DependencyInversion.Strategies
{
    class AdditionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
