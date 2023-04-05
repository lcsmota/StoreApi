using System.Data;
using System.Globalization;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Data.SqlClient;
using StoreApi.Contracts;
using StoreApi.Models;
using StoreApi.Repository;
using StoreApi.Validators;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddTransient<IDbConnection>((sql) => new SqlConnection(builder.Configuration.GetConnectionString("Default")));
    builder.Services.AddScoped<IStoreRepository, StoreRepository>();

    builder.Services.AddControllers().AddFluentValidation(conf => conf.ValidatorOptions.LanguageManager.Culture = new CultureInfo("en-US"));
    builder.Services.AddTransient<IValidator<Store>, StoreValidator>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}