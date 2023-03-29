using AppModels;
using DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessIntelligence.Interfaces
{
    public interface IBusinessOrders
    {
        Task<List<Order>> GetOrders();
        Task<decimal> GetTotalPrice(Order order);
        Task<bool> SaveOrder(Order order);
        Task<bool> UpdateOrder(Order order);
        Task<bool> DeleteOrder(int orderId);
    }
}
