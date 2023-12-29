using ES_POS_BUSY.Services.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Test.Services.DBContext;
using Test.Services.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//private readonly string _policyName = "CorsPolicy";

//Register Connection Class
builder.Services.AddDbContext<TestDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Constr")));

builder.Services.AddDbContext<BusyDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Constrbusy")));

builder.Services.AddTransient<IRepository, Repository>();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});


////enable cors policy Any Demon
//builder.Services.AddCors(p => p.AddPolicy("corsPolicy", build =>
//{
//    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
//}));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
