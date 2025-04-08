using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverContext context = new ObserverContext();
        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.Discounts.Add(new Discount
            {
                Code = "DERGIMART",
                Amount = 35,
                CodeStatus = true
            });
            context.SaveChanges();
        }
    }
}
