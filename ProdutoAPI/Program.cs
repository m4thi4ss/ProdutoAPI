using Microsoft.EntityFrameworkCore;
using ProdutoAPI.Data.Context; 
using ProdutoAPI.Data.Interfaces;
using ProdutoAPI.Data.Repositories;
using ProdutoAPI.Service.Interfaces;
using ProdutoAPI.Service.Servicos;



var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddDbContext<BancoDeDadosContext>(opcoes =>
    opcoes.UseSqlite(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
