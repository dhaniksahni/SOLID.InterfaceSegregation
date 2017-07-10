namespace SOLID.InterfaceSegregation.BeforeRefactor
{
    public interface IOrder
    {
        bool AcceptOnlineOrder();
        bool TakeTelephoneOrder();
        bool PayOnline();
        bool WalkInCustomerOrder();
        bool PayInPerson();
    }
}
