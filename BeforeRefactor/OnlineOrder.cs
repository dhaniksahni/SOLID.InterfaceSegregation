using System;

namespace SOLID.InterfaceSegregation.BeforeRefactor
{
    public class OnlineOrder : IOrder
    {
        public bool AcceptOnlineOrder()
        {
            return true;
        }

        public bool PayInPerson()
        {
            throw new NotImplementedException();
        }

        public bool PayOnline()
        {
            return true;
        }

        public bool TakeTelephoneOrder()
        {
            throw new NotImplementedException();
        }

        public bool WalkInCustomerOrder()
        {
            throw new NotImplementedException();
        }
    }
}
