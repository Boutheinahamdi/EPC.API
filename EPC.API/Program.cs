using EPC.API.Repository;
using EPC.Model.DTOs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IGenericRepository<BuildingInformationDTO>,GenericRepository<BuildingInformationDTO>>();
builder.Services.AddScoped<IGenericRepository<BuildingElementDTO>, GenericRepository<BuildingElementDTO>>();
builder.Services.AddScoped<IGenericRepository<StoreysDTO>, GenericRepository<StoreysDTO>>();

builder.Services.AddScoped<IImageRepository,ImageRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
