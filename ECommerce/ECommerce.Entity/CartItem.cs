﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entity
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product  { get; set; }
        public int Quantity { get; set; }
    }
}
