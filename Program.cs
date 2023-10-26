using Microsoft.EntityFrameworkCore;
using WebApiProvaFaseA.Repository;
using WebApiProvaFaseA.Service;
using WebAPIVenditaLibri.DataSource;

var builder = WebApplication.CreateBuilder(args);
//LOG
builder.Logging.ClearProviders();
builder.Logging.AddEventLog();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//SQL server
builder.Services.AddDbContext<ProvaContext>(options =>
{
    //modo 1
    string? cnProdotti = builder.Configuration.GetConnectionString("cnNW");
    //modo 2
    //string cnNorthwind2 = builder.Configuration.GetValue<string>("ConnectionStrings:cnNW");



    options.UseSqlServer(cnProdotti);



});

//context
builder.Services.AddScoped<ProvaContext, ProvaContext>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IProdottoRepository, ProdottoRepository>();
builder.Services.AddScoped<IProdottoService, ProdottoService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
