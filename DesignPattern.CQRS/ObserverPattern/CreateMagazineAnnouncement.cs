using DesignPattern.CQRS.DataAccessLayer;

namespace DesignPattern.CQRS.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        ObserverContext context = new ObserverContext();
        public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimizin Mart Sayısı 1 Martta evinize ulaştırılacaktır. Konular Jupiter ve Mars olacaktır!"
            });
            context.SaveChanges();
        }
    }
}
