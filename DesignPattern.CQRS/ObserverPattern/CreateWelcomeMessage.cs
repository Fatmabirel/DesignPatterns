using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverContext context = new ObserverContext();
        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için teşekkür ederiz. Dergilerimize web sitemizden ulaşabilirsiniz!"
            });
            context.SaveChanges();
        }
    }
}
