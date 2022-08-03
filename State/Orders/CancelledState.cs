using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    public class CancelledState : IOrderState
    {
        public OrderStatus Status
        {
            get { return OrderStatus.Cancelled; }
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public string Cancel(Order order)
        {
            return "sefarsh dar hal hazer dar state cancel mibashad";
        }

        public bool CanDeliver(Order order)
        {
            return false;

        }

        public bool CanSend(Order order)
        {
            return false;

        }

        public string Delivered(Order order)
        {
            return "sefareshhaye cancel shode Ra, nemitavan tahvil dad";

        }

        public string Sent(Order order)
        {
            return "sefareshhaye cancel shode Ra, nemitavan ersal kard";
        }
    }
}
