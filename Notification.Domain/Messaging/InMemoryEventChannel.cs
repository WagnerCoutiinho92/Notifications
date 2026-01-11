using System;
using System.Threading.Channels;

namespace Notification.Domain.Messaging;

public static class InMemoryEventChannel
{
    public static readonly Channel<object> Channel =
        System.Threading.Channels.Channel.CreateUnbounded<object>();
}
