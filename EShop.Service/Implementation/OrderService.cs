﻿using ERestaurant.Domain.Domain;
using ERestaurant.Domain.Domain;
using ERestaurant.Repository.Interface;
using EShop.Service.Interface;
using Restaurant.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShop.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EShop.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetDetailsForOrder(BaseEntity model)
        {
            return _orderRepository.GetDetailsForOrder(model);
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await DbContext.Orders
                .Include(o => o.DeliveryPerson)
                .Include(o => o.Status)
                .ToListAsync();
        }
    }
}