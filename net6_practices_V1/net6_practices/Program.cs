var builder = WebApplication.CreateBuilder(args);
//Bu builder nesnesi üzerinden uygulamada kullanýlacak servisler entegre edilebilmektedir.

builder.Services.AddCors();
//Servisler builder üzerinden eklenir.

var app = builder.Build();

//Middleware'ler app üzerinden eklenir.
app.MapGet("/", () => "Hello World!");

app.Run();

//*Startup
//.Net 6'da Startup.cs dosyasý kaldýrýlmýþtýr. Servis ve middleware konfigürasyonlarýnýn sorumluluðu Program.cs dosyasýna býrakýlmýþtýr.


//*Top Level Statements
//Asp.net 6'a t.l.s özelliði default olarak gelmektedir.

//*WebApplicationBuilder: .Net 5'deki HostBuilder'ýn karþýlýðýdýr.
//*WebApplication : Builder nesnesini oluþturabilmek için .Net 6'da gelmiþtir. .Net 5'deki Host sýnýfýnýn karýþýlýðýdýr. Uygulama inþa edildikten(build) sonra oluþan nesnedir.

//*Port: .Net 6 öncesinde uygulamalar default 5001 ve 5000 portlarýnda ayaða kalkarken .Net 6'da bu port deðiþiklik göstermektedir.
//Properties'in altýnda launchSettings.json'da Profiles'ýn altýnda applicationUrl' de yer almaktadýr.