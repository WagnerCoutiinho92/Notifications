using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Domain.Messaging
{
    public interface IMessageBus
    {
        Task PublishAsync<T>(T message, CancellationToken cancellationToken = default);

    }
}