using DesignPattern.CQRS.DataAccessLayer;
using DesignPattern.CQRS.ObserverPattern;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ObserverContext>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<ObserverContext>();
builder.Services.AddSingleton<ObserverObject>(sp =>
{
    var observers = new List<IObserver>
    {
        new CreateWelcomeMessage(sp),
        new CreateMagazineAnnouncement(sp),
        new CreateDiscountCode(sp)
    };

    return new ObserverObject(observers);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
