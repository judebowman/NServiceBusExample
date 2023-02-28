using Billing.Messages;
using NServiceBus.Logging;
using Sales.Messages;

namespace Billing;

public class OrderPlacedEventHandler : IHandleMessages<OrderPlaced>
{
    static ILog log = LogManager.GetLogger<OrderPlacedEventHandler>();

    public Task Handle(OrderPlaced message, IMessageHandlerContext context)
    {
        log.Info($"Received OrderPlaced, OrderId = {message.OrderId} - Charging credit card...");

        var orderBilledEvent = new OrderBilled
        {
            OrderId = message.OrderId
        };
        
        return context.Publish(orderBilledEvent);
    }
}
