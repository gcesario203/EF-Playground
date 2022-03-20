using AutoMapper;
using Hdogs.api.Config;
using Hdogs.api.Model.Context;
using Hdogs.api.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<MySqlContext>(options =>
{

    var connection = builder.Configuration["DbConnectionString:MySqlConnectionString"];
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 28)));
});

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped(typeof(AuthDataRepository));
builder.Services.AddScoped(typeof(DocumentTypeRepository));
builder.Services.AddScoped(typeof(AdminRepository));

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

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
