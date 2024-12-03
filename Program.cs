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
/* 
 * --- Açýklamalar ---
 * 
 * Controller: HTTP isteklerini iþleyerek modeli ve view'i yönlendiren sýnýf.
 * Action: Controller içindeki bir yöntem, genellikle bir iþlem gerçekleþtirir ve sonuç döner.
 * Model: Uygulamanýn veri ve iþ mantýðýný temsil eder.
 * View: Kullanýcýya sunulan görsel içerik.
 * Razor: Dinamik içerik oluþturmak için kullanýlan bir View Engine.
 * Razor View: Razor syntax'ý kullanýlarak oluþturulan ve dinamik içerik üreten `.cshtml` dosyasý.
 * wwwroot: Statik dosyalarýn (CSS, JS, resim vb.) saklandýðý klasör.
 * builder.Build(): Uygulama ayarlarýný tamamlar ve bir WebApplication nesnesi oluþturur.
 * app.Run(): Uygulamayý çalýþtýrýr ve HTTP isteklerini dinlemeye baþlar.
 */