using CommerceCraft.Api.Interface.Repository;
using CommerceCraft.Api.Interface.Service;
using CommerceCraft.Api.Mappings;
using CommerceCraft.Api.Repository;
using CommerceCraft.Api.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(cnfig => cnfig.AddProfile<AutoMapperProfiles>());

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProductRepository,SQLProductRepository>();

builder.Services.AddScoped<IProductService,ProductService>();
builder.Services.AddScoped<IProductImageRepository,SQLProductImageRepository>();
builder.Services.AddScoped<IProductImageService,ProductImageService>();
builder.Services.AddScoped<IOrderRepository, SQLOrderRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddScoped<IAnalyticsRepository, SQLAnalyticsRepository>();
builder.Services.AddScoped<IAnalyticsService, AnalyticsService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
