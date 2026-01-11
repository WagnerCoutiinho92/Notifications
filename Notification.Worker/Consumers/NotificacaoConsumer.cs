using Notification.Domain.Events;

namespace Notification.Worker.Consumers;

public class NotificacaoConsumer
{
    public async Task HandleAsync(NotificacaoEvento evento, CancellationToken cancellationToken)
    {
        Console.WriteLine("[WORKER] Processando notificação");
        Console.WriteLine($"Tipo: {evento.Tipo}");
        Console.WriteLine($"Matrícula: {evento.Matricula}");
        Console.WriteLine($"Mensagem: {evento.Mensagem}");

        await Task.Delay(1000, cancellationToken);
    }
}

