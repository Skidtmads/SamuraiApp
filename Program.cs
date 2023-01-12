using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Samurai.Data;
using Samurai.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
Horses[] horses = new Horses[]
    {
        new Horses { Id = 1, Name = "Kasumi", Armortype = "Chainmail", WarriorId = 1 },
        new Horses { Id = 2, Name = "Hikari", Armortype = "Plate", WarriorId = 2 },
        new Horses { Id = 3, Name = "Kaze", Armortype = "Leather", WarriorId = 3 },
        new Horses { Id = 4, Name = "Yukiko", Armortype = "Chainmail", WarriorId = 4 } 
    };
Warrior[] samurai = new Warrior[]
{
    new Warrior { Id = 1, Name = "Hattori", Armortype = "Plate", HorseId = 1 },
    new Warrior { Id = 2, Name = "Oda", Armortype = "Leather", HorseId = 2},
    new Warrior { Id = 3, Name = "Takeda", Armortype = "Chainmail", HorseId = 3},
    new Warrior { Id = 4, Name = "Miyamoto", Armortype = "Leather", HorseId = 4}
};
Armortype[] armortype = new Armortype[]
{
    new Armortype { Id = 1, ArmorName = "Leather", ArmorClass = "Light"},
    new Armortype { Id = 2, ArmorName = "Chainmail", ArmorClass = "Medium"},
    new Armortype { Id = 3, ArmorName = "Plate", ArmorClass = "Heavy"}
};
