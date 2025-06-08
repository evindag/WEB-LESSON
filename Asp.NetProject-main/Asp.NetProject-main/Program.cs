var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
//MVC (Model-View-Controller)

//MVC tasarım deseninde MODEL KATMANI, geliştirilen uygulamada kullanılacak olan verilerin
//özelliklerinin tanımlandığı katmandır. Veri özelliklerini (Properties) tanımlarken her bir veri için
//ayrı ayrı sınıf (class) tanımlaması yapılmalıdır.

// MVC tasarım deseninde CONTROLLER KATMANI; içinde barındırdığı action metotları ile birlikte tarayıcıdan gelen sayfa isteklerini (URL) yöneten, view ve model katmanları arasındaki bağlantıyı
//sağlayan ve projenin iş sürecini kontrol eden katmandır.