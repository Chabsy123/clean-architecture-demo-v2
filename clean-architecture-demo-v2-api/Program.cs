using clean_architecture_demo_v2.App;
using clean_architecture_demo_v2.Framing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add layers dependencies
builder.Services.AddAppServices();
builder.Services.AddFramingServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
