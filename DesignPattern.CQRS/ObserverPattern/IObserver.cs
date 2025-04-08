using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.ObserverPattern
{
    public interface IObserver
    {
        void CreateNewUser(AppUser appUser);
    }
}
