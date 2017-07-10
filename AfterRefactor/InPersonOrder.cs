using System;

namespace SOLID.InterfaceSegregation.AfterRefactor
{
    public class InPersonOrder : IPayMoney, IOrder
    {
        public bool PayMoney()
        {
            return true;
        }

        public bool PlaceOrder()
        {
            return true;
        }
    }
}
