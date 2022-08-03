using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    /// <summary>
    /// State
    /// </summary>
    public interface IOrderState
    {
        OrderStatus Status { get; }
        bool CanSend(Order order);
        string Sent(Order order);
        bool CanCancel(Order order);
        string Cancel(Order order);
        bool CanDeliver(Order order);
        string Delivered(Order order);
    }
}
