using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.Events
{
    /// <summary>
    /// Event used when the order stock items are confirmed
    /// </summary>
    public class OrderStatusChangedToStockConfirmedDomainEvent
        : INotification
    {
        public int OrderId { get; }

        public OrderStatusChangedToStockConfirmedDomainEvent(int orderId)
            => OrderId = orderId;
    }
}
