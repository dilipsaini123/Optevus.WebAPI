using Microsoft.EntityFrameworkCore;
using EmployeeRepository.DataEmployee;
using EmployeeRepository.Interface;
using EmployeeRepository;
using EmployeeServices.Interface;
using EmployeeServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(Options =>
{
    Options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"), b => b.MigrationsAssembly("Optevus.WebAPI"));
});


builder.Services.AddScoped<IEmployeeRepository, EmployeesRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
  //  app.UseSwagger();
  //  app.UseSwaggerUI();
//}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
