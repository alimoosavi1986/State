using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    public class DeliveredState : IOrderState
    {
        public OrderStatus Status
        {
            get { return OrderStatus.Delivered; }
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public string Cancel(Order order)
        {
            return "Sefaresh tahvil shode ra nemitavan CANCEL kard";
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
            return "sefaresh ghablan tahvil dade shode ast";
        }

        public string Sent(Order order)
        {
            return "sefaresh tahvil dade shode ast";
        }
    }
}
