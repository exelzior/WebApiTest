

using BusinessIntelligence.Implementations;
using BusinessIntelligence.Interfaces;
using DataAccess.Implementations;
using DataAccess.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Business Dependencies
builder.Services.AddScoped<IBusinessSandwichs, BusinessSandwichs>();
builder.Services.AddScoped<IBusinessOrders, BusinessOrders>();
builder.Services.AddScoped<IBusinessExtras, BusinessExtras>();
builder.Services.AddScoped<IBusinessMenu, BusinessMenu>();
#endregion

#region Data Dependencies
builder.Services.AddScoped<ISandwichs, Sandwichs>();
builder.Services.AddScoped<IOrders, Orders>();
builder.Services.AddScoped<IExtras, Extras>();
#endregion


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
