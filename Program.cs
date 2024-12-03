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
 * --- A��klamalar ---
 * 
 * Controller: HTTP isteklerini i�leyerek modeli ve view'i y�nlendiren s�n�f.
 * Action: Controller i�indeki bir y�ntem, genellikle bir i�lem ger�ekle�tirir ve sonu� d�ner.
 * Model: Uygulaman�n veri ve i� mant���n� temsil eder.
 * View: Kullan�c�ya sunulan g�rsel i�erik.
 * Razor: Dinamik i�erik olu�turmak i�in kullan�lan bir View Engine.
 * Razor View: Razor syntax'� kullan�larak olu�turulan ve dinamik i�erik �reten `.cshtml` dosyas�.
 * wwwroot: Statik dosyalar�n (CSS, JS, resim vb.) sakland��� klas�r.
 * builder.Build(): Uygulama ayarlar�n� tamamlar ve bir WebApplication nesnesi olu�turur.
 * app.Run(): Uygulamay� �al��t�r�r ve HTTP isteklerini dinlemeye ba�lar.
 */