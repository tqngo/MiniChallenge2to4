using MiniChallenge2to4.Services.GreaterOrLess;
using MiniChallenge2to4.Services.Sum;
using MiniChallenge2to4.Services.WhoAreYou;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IWhoAreYouService, WhoAreYouService>();
builder.Services.AddScoped<ISumService, SumService>();
builder.Services.AddScoped<IGreaterOrLessService, GreaterOrLessService>();

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
