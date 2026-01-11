using Notification.Domain.Messaging;

namespace Notification.Api.Infrastructure.Messaging;

// Implementação InMemory usada apenas para demonstração arquitetural.
// Não realiza comunicação entre processos distintos.

public class InMemoryMessageBus : IMessageBus
{
    public async Task PublishAsync<T>(T message, CancellationToken cancellationToken = default)
    {
        await InMemoryEventChannel.Channel.Writer.WriteAsync(message!, cancellationToken);

        Console.WriteLine($"[API] Evento publicado: {typeof(T).Name}");
    }
}
