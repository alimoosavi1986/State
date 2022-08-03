using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    public enum OrderStatus
    {
        Waiting_to_Send,
        Sent,
        Delivered,
        Cancelled
    }
}
