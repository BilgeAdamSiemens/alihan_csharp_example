﻿using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Entity;

namespace ECommerce.Data
{
    public interface IOrderRepository : IRepository<Order, int>
    {
    }
}
