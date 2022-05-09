using EternalKit.Application.Services.Convert.Length;
using EternalKit.Application.Services.Text.CharacterCounter;
using EternalKit.Application.Services.Text.LineCounter;
using EternalKit.Application.Services.Text.WordCounter;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


#region IoC

builder.Services.AddTransient<ILengthConvertService, LengthConvertService>();
builder.Services.AddTransient<ICharacterCounterService, CharacterCounterService>();
builder.Services.AddTransient<IWordCounterService, WordCounterService>();
builder.Services.AddTransient<ILineCounterService, LineCounterService>();

#endregion


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
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
