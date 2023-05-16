using DockerizeSample.HostedServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var addHostedServicesEnv = Environment.GetEnvironmentVariable("flag");

if (addHostedServicesEnv == null)
    throw new ArgumentNullException("ENV IS NULL");

if (Convert.ToBoolean(addHostedServicesEnv))
    builder.Services.AddHostedService<CustomHostedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
