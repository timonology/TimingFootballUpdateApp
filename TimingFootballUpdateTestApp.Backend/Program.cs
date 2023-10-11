using TimingFootballUpdateTestApp.Backend.Extensions;
using TimingFootballUpdateTestApp.Backend.Hubs;
using TimingFootballUpdateTestApp.Backend.Implementations;
using TimingFootballUpdateTestApp.Backend.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSignalR();
builder.Services.AddSingleton<IFootballUpdateService, FootballUpdateService>();
builder.Services.ConfigureCorsPolicy();

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

//app.UseAuthorization();

//app.UseRouting();
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapHub<FootballUpdatesHub>("/footballupdate");
//    endpoints.MapControllers();
//});

app.MapControllers();

app.MapHub<FootballUpdatesHub>("/footballupdate");
app.UseCors("CorsPolicy");

app.Run();
