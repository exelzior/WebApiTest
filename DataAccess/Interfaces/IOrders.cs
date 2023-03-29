using AppModels;
using DataAccess.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IOrders
    {
        List<Order> GetOrders();
        decimal GetTotalPrice(Order order);
        bool SaveOrder(Order order);
        bool UpdateOrder(Order order);
        bool DeleteOrder(int orderId);
    }
}
