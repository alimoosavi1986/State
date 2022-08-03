using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Orders
{

    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        private IOrderState OrderState { get; set; }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime CreateDate { get; set; }


        public Order(IOrderState orderState)
        {
            this.OrderState = orderState;
        }
        public void ChangeState(IOrderState orderState)
        {
            this.OrderState = orderState;
        }
        public string Send()
        {
            return this.OrderState.Sent(this);
        }
        public string Delivered()
        {
            return this.OrderState.Delivered(this);
        }
        public string Cancel()
        {
            return this.OrderState.Cancel(this);
        }
    }
}
