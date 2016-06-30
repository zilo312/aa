using System;
using System.Collections.Generic;
using System.Text;

namespace Wrox.ProCSharp.EnterpriseServices
{
    class Program
    {
        static void Main()
        {
            Order order = Order.Create("PICCO", DateTime.Today, "Georg Pipps",
                           "Salzburg", "Austria");
            order.AddOrderLine(OrderLine.Create(16, 17.45F, 2));
            order.AddOrderLine(OrderLine.Create(67, 14, 1));

            using (OrderControl orderControl = new OrderControl())
            {
                orderControl.NewOrder(order);
            }

        }
    }
}
