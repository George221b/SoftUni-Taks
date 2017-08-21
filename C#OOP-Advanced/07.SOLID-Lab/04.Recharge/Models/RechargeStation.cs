using _04.Recharge.Interfaces;

namespace _04.Recharge.Models
{
    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}