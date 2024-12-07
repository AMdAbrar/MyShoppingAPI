using Microsoft.EntityFrameworkCore;
using MyShoppingRepository.Data;
using MyShoppingRepository.Repositries;
using MyShoppingService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Configuration -appsetting.json
var sqlconnectionstring = builder.Configuration.GetConnectionString("sqlcon");
builder.Services.AddDbContext<MyShoppingDbContext>(options => options.UseSqlServer(sqlconnectionstring));

builder.Services.AddScoped<IProductRepository, ProductRepositories>();// interfacename and class name

builder.Services.AddScoped<IProductService, ProductService>();//interfacename and classname

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
//JWT token or oauth Authorization porposs
//
//insominia or swagger or postman
