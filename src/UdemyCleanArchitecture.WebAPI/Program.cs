using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using UdemyCleanArchitecture.Application.Behaviors;
using UdemyCleanArchitecture.Application.Services;
using UdemyCleanArchitecture.Domain.Repositories;
using UdemyCleanArchitecture.Persistance.Context;
using UdemyCleanArchitecture.Persistance.Repositories;
using UdemyCleanArchitecture.Persistance.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork<AppDbContext>>();
builder.Services.AddScoped<ICarRepository, CarRepository>();

builder.Services.AddAutoMapper(typeof(UdemyCleanArchitecture.Persistance.AssemblyReference).Assembly);

string? connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers().AddApplicationPart(typeof(UdemyCleanArchitecture.Presentation.AssemblyReference).Assembly);

builder.Services.AddMediatR(cfr =>
{
    cfr.RegisterServicesFromAssembly(typeof(UdemyCleanArchitecture.Application.AssemblyReference).Assembly);
});

builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
builder.Services.AddValidatorsFromAssembly(typeof(UdemyCleanArchitecture.Application.AssemblyReference).Assembly);

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
