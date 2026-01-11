using Notification.Api.Infrastructure.Messaging;
using Notification.Domain.Messaging;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 Mensageria
builder.Services.AddSingleton<IMessageBus, InMemoryMessageBus>();

var app = builder.Build();

// 🔹 Pipeline
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
