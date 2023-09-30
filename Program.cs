using Ticket_Reservation_System_Server.Models;
using Ticket_Reservation_System_Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.Configure<DbConfiguration>(
     builder.Configuration.GetSection("MongoDB")
    );

//resolving the CategoryService dependency here
builder.Services.AddTransient<ITravelerService, TravelerService>();

//resolving the TicketReservationService dependency here
builder.Services.AddTransient< ITicketReservationService,TicketReservationService>();

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


