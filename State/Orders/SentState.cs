using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    public class SentState : IOrderState
    {
        public OrderStatus Status
        {
            get { return OrderStatus.Sent; }
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public string Cancel(Order order)
        {
            order.ChangeState(new CancelledState());
            return "Sefaresh Cancel Shod";
        }

        public bool CanDeliver(Order order)
        {
            return true;
        }

        public bool CanSend(Order order)
        {
            return false;
        }

        public string Delivered(Order order)
        {
            order.ChangeState(new DeliveredState());
            return "Sefaresh tahvil Shod";
        }

        public string Sent(Order order)
        {
            return "sefaresh dar hal ersal mibashad";
        }
    }
}
