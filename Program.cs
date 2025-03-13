using Microsoft.EntityFrameworkCore;
using SimpleSIEM.Data;
using SimpleSIEM.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<SiemDbContext>(options =>
    options.UseSqlite("Data Source=siem.db"));


builder.Services.AddScoped<LogService>();


builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
