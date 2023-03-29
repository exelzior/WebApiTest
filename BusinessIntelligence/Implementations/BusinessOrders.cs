using AppModels;
using BusinessIntelligence.Interfaces;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.Implementations
{
    public class BusinessOrders : IBusinessOrders
    {
        private readonly IOrders _orders;

        public BusinessOrders(IOrders orders)
        {
            _orders = orders;
        }

        public Task<List<Order>> GetOrders()
        {
            return Task.Run(() =>
            {
                return this._orders.GetOrders();
            });
        }

        public Task<decimal> GetTotalPrice(Order order) {
            return Task.Run(() =>
            {
                
                return this._orders.GetTotalPrice(order);
            });
        }
        public Task<bool> SaveOrder(Order order) {
            return Task.Run(() =>
            {
                return this._orders.SaveOrder(order);
            });
        }
        public Task<bool> UpdateOrder(Order order) {
            return Task.Run(() =>
            {
                return this._orders.UpdateOrder(order);
            });
        }
        public Task<bool> DeleteOrder(int orderId) {
            return Task.Run(() =>
            {
                return this._orders.DeleteOrder(orderId);
            });
        }

    }
}
