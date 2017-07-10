using System;

namespace SOLID.InterfaceSegregation.BeforeRefactor
{
    public class TelephoneOrder : IOrder
    {
        public bool AcceptOnlineOrder()
        {
            throw new NotImplementedException();
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
            return true;
        }

        public bool WalkInCustomerOrder()
        {
            throw new NotImplementedException();
        }
    }
}
