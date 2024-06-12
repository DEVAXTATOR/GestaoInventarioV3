using GestaoInventarioV3.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao container, incluindo suporte para controladores e visualizações.
builder.Services.AddControllersWithViews();

// Aqui você deve adicionar a configuração do DbContext para utilizar a string de conexão definida no appsettings.json.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Serve ficheiros estáticos, como imagens, CSS e JavaScript.
app.UseStaticFiles();

// Habilita o roteamento para decidir qual controlador e ação são chamados com base no URL recebido.
app.UseRouting();

// Define o padrão das rotas para os controladores. Este é o padrão MVC comum que assume que se não forem fornecidos controlador ou ação,
// o controlador 'Home' e a ação 'Index' serão utilizados.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Inicia a aplicação.
app.Run();
