﻿using eShop.Domain.Enitities.Orders;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Orders.Orders
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
