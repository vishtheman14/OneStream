using Vishal_OneStream.Contracts;
using Vishal_OneStream.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IWebApiService, WebApiService>();
builder.Services.AddScoped<IWebApiTwoService, WebApiTwoService>();
builder.Services.AddHttpClient<IWebApiService, WebApiService>(client =>
{
  client.BaseAddress = new Uri("http://www.webapi1.com");
});
builder.Services.AddHttpClient<IWebApiTwoService, WebApiTwoService>(client =>
{
  client.BaseAddress = new Uri("http://www.webapi2.com");
});

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
