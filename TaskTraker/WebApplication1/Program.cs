using Microsoft.OpenApi.Models;
using System.Reflection;
using TaskTracker.WebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSingleton<ITaskService, TaskService>();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "TaskTracker.Api",
        Version = "v1",
        Description = $"Build number: {Assembly.GetEntryAssembly()!.GetName().Version!.ToString()[..^2]}"
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskTracker API");
    });
    app.MapOpenApi();
}
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyHeader()
          .AllowAnyMethod()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
