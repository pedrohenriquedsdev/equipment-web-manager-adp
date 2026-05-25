<<<<<<< HEAD
﻿// ASP.NET CORE

// BUILDER DE UM SERVER WEB
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// MVC 
builder.Services.AddControllersWithViews();

// Criação da instância do servidor web
WebApplication app = builder.Build();

//MIDDLEWARES - Funções que executam em cada chamada que o nosso servidor vai receber
app.UseRouting();
app.MapDefaultControllerRoute();

// Inicia o loop da aplicação
app.Run();
=======
﻿//ASP.NET Core -> Entra para evitar detalhes de baixo nível extremo (web app)
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

>>>>>>> v0
