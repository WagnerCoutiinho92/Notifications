using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Domain.Events;

public record NotificacaoEvento(
    string Tipo,
    string Matricula,
    DateTime DataOcorrencia,
    string Mensagem
);
