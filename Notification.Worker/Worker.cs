using Notification.Domain.Events;
using Notification.Domain.Messaging;
using Notification.Worker.Consumers;

namespace Notification.Worker;

public class Worker : BackgroundService
{
    private readonly NotificacaoConsumer _consumer = new();

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        Console.WriteLine("[WORKER] Aguardando eventos...");

        await foreach (var message in InMemoryEventChannel.Channel.Reader.ReadAllAsync(stoppingToken))
        {
            if (message is NotificacaoEvento evento)
            {
                await _consumer.HandleAsync(evento, stoppingToken);
            }
        }
    }
}
