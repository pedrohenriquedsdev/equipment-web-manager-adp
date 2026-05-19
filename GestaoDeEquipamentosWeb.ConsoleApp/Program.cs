//ASP.NET Core -> Entra para evitar detalhes de baixo nível extremo (web app)
//Vai atuar como nossa TelasBase de antes

//Builder de um web server
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // -> // tipagem de app web (como iremos organizar as apresentações) Models, Controllers & Views

//Criação da instância do web server
WebApplication app = builder.Build();

//Middlewares - Funções que executam em cada chamada que o nosso server vai receber
app.UseRouting(); // considera a chamada do server e + as rotas dele
app.MapDefaultControllerRoute(); //rotas específicas

// Iniciar o loop da app 
app.Run();

