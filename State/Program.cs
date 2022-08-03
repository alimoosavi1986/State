using State.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(new Waiting_to_SendState());
            //Console.WriteLine(order.Cancel());

            Console.WriteLine(order.Send());
            Console.WriteLine(order.Delivered());

            Console.WriteLine(order.Cancel());

            Console.Read();
        }
    }
}
