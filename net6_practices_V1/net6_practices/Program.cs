var builder = WebApplication.CreateBuilder(args);
//Bu builder nesnesi �zerinden uygulamada kullan�lacak servisler entegre edilebilmektedir.

builder.Services.AddCors();
//Servisler builder �zerinden eklenir.

var app = builder.Build();

//Middleware'ler app �zerinden eklenir.
app.MapGet("/", () => "Hello World!");

app.Run();

//*Startup
//.Net 6'da Startup.cs dosyas� kald�r�lm��t�r. Servis ve middleware konfig�rasyonlar�n�n sorumlulu�u Program.cs dosyas�na b�rak�lm��t�r.


//*Top Level Statements
//Asp.net 6'a t.l.s �zelli�i default olarak gelmektedir.

//*WebApplicationBuilder: .Net 5'deki HostBuilder'�n kar��l���d�r.
//*WebApplication : Builder nesnesini olu�turabilmek i�in .Net 6'da gelmi�tir. .Net 5'deki Host s�n�f�n�n kar���l���d�r. Uygulama in�a edildikten(build) sonra olu�an nesnedir.

//*Port: .Net 6 �ncesinde uygulamalar default 5001 ve 5000 portlar�nda aya�a kalkarken .Net 6'da bu port de�i�iklik g�stermektedir.
//Properties'in alt�nda launchSettings.json'da Profiles'�n alt�nda applicationUrl' de yer almaktad�r.