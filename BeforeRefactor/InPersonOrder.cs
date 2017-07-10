using System;

namespace SOLID.InterfaceSegregation.BeforeRefactor
{
    public class InPersonOrder : IOrder
    {
        public bool AcceptOnlineOrder()
        {
            throw new NotImplementedException();
        }

        public bool PayInPerson()
        {
            return true;
        }

        public bool PayOnline()
        {
            throw new NotImplementedException();
        }

        public bool TakeTelephoneOrder()
        {
            throw new NotImplementedException();
        }

        public bool WalkInCustomerOrder()
        {
            return true;
        }
    }
}
