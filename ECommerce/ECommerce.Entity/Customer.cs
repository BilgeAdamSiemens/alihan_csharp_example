using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public String ImageUrl { get; set; }

        public List<Order> Orders { get; set; }
        public DateTime? LastOrder { get; set; }

        public String FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
