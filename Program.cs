using System.Data;
using Microsoft.Data.SqlClient;
using StoreApi.Contracts;
using StoreApi.Repository;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddTransient<IDbConnection>((sql) => new SqlConnection(builder.Configuration.GetConnectionString("Default")));
    builder.Services.AddScoped<IStoreRepository, StoreRepository>();

    builder.Services.AddControllers();

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