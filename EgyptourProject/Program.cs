using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using EgyptourProject.DAL.Repository;
var builder = WebApplication.CreateBuilder(args);


//inject DBContext
builder.Services.AddDbContext<EgyptourProject.DAL.EgyptourContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EgyptourDB")));

//inject Repostires
builder.Services.AddScoped<IRepository<EgyptourProject.DAL.Models.Product>, ProductRepository>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "EgyptTour API", Version = "v1" });
});


var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapGet("/", context =>
    {
        context.Response.Redirect("/swagger");
        return Task.CompletedTask;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
