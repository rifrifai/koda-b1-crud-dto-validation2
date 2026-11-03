using API.Data;
using API.Repository;
using API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddOpenApi();
builder.Services.AddProblemDetails();
builder.Services.AddSingleton<MemoryProductCatalog>();
builder.Services.AddSingleton<IProductRepository, MemoryProductRepository>();
builder.Services.AddSingleton<IProductService, ProductServices>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
