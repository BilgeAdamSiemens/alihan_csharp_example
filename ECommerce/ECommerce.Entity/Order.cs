using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public Cart Cart { get; set; }
        public Customer Customer { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime Date { get; set; }
        
    }

    public enum OrderStatus
    {
        Shipped,
        Processing,
        Delivered,
        Cancelled
    }
}
