using Billing.Messages;
using NServiceBus.Logging;

namespace Shipping;

internal class OrderBilledEventHandler : IHandleMessages<OrderBilled>
{
    static ILog log = LogManager.GetLogger<OrderBilledEventHandler>();

    public Task Handle(OrderBilled message, IMessageHandlerContext context)
    {
        log.Info($"Received OrderBilled, OrderId = {message.OrderId} - Should we ship now?");

        return Task.CompletedTask;
    }
}
