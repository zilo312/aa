using System;
using System.ServiceModel;
using WCFClientApp.OrderService;

namespace WCFClientApp
{
    class Program
    {
        static void Main()
        {
            Order order = new Order();
            order.customerId = "PICCO";
            order.orderDate = DateTime.Today;
            order.shipAddress = "Georg Pipps";
            order.shipCity = "Salzburg";
            order.shipCountry = "Austria";
            OrderLine line1 = new OrderLine();
            line1.productId = 16;
            line1.unitPrice = 17.45F;
            line1.quantity = 2;
            OrderLine line2 = new OrderLine();
            line2.productId = 67;
            line2.unitPrice = 14;
            line2.quantity = 1;
            OrderLine[] orderLines = { line1, line2 };
            order.orderLines = orderLines;
            
            OrderControlClient occ = new OrderControlClient();
            occ.NewOrder(order);
            
            
        }
    }
}
