using GestaoInventarioV3.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona servi�os ao container, incluindo suporte para controladores e visualiza��es.
builder.Services.AddControllersWithViews();

// Aqui voc� deve adicionar a configura��o do DbContext para utilizar a string de conex�o definida no appsettings.json.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Serve ficheiros est�ticos, como imagens, CSS e JavaScript.
app.UseStaticFiles();

// Habilita o roteamento para decidir qual controlador e a��o s�o chamados com base no URL recebido.
app.UseRouting();

// Define o padr�o das rotas para os controladores. Este � o padr�o MVC comum que assume que se n�o forem fornecidos controlador ou a��o,
// o controlador 'Home' e a a��o 'Index' ser�o utilizados.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Inicia a aplica��o.
app.Run();
