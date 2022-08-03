using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{
    public class Waiting_to_SendState : IOrderState
    {
        public OrderStatus Status
        {
            get { return OrderStatus.Waiting_to_Send; }
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public string Cancel(Order order)
        {

            //cancel
            order.ChangeState(new CancelledState());
            return "Sefaresh CANCEL Shod";
        }

        public bool CanDeliver(Order order)
        {
            return false;
        }

        public bool CanSend(Order order)
        {
            return true;
        }

        public string Delivered(Order order)
        {
            return "ghabl az ersan nemitavan sefaresh ro tahvil dad";
        }

        public string Sent(Order order)
        {
            order.ChangeState(new SentState());
            return "Sefaresh Ersal Shod";
        }
    }
}
