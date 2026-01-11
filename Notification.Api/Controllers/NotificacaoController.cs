using Microsoft.AspNetCore.Mvc;
using Notification.Domain.Events;
using Notification.Domain.Messaging;

namespace Notification.Api.Controllers;

[ApiController]
[Route("api/notificacoes")]
public class NotificacaoController : ControllerBase
{
    private readonly IMessageBus _messageBus;

    public NotificacaoController(IMessageBus messageBus)
    {
        _messageBus = messageBus;
    }

    [HttpPost]
    public async Task<IActionResult> Publicar()
    {
        var evento = new NotificacaoEvento(
            Tipo: "AdvertenciaCriada",
            Matricula: "12345",
            DataOcorrencia: DateTime.UtcNow,
            Mensagem: "Advertência criada para o colaborador."
        );

        await _messageBus.PublishAsync(evento);

        return Ok(new { status = "Evento publicado" });
    }
}
