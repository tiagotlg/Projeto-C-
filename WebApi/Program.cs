using WebApi.Interfaces;
using WebApi.Mappings;
using WebApi.Rest;
using WebApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IJogoService, JogoService>();
builder.Services.AddSingleton<IDescontoService, DescontoService>();
builder.Services.AddSingleton<ICheapSharkApi, CheapSharkApiRest>();

builder.Services.AddAutoMapper(typeof(JogoMapping));
builder.Services.AddAutoMapper(typeof(DescontoMapping));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
