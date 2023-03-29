using AppModels;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implementations
{
    public class Orders : IOrders
    {
        public static List<Order> AllOrders = new List<Order>();

        public List<Order> GetOrders() {
            return AllOrders;
        }

        public decimal GetTotalPrice(Order order) {
            decimal price = order.Sandwich.Cost + order.Extras.Sum(a => a.Cost);
            foreach (var item in order.Extras)
                if (order.Extras.Count(a => a.Name.Equals(item.Name)) > 1)
                    throw new Exception("Only one type of extra is allowed, please review the order");

            if (order.Extras != null) {
                if (order.Extras.Any(a => a.Name == "Fries") && !order.Extras.Any(a => a.Name == "Soft Drink"))
                    price = getDiscount(price, 10);
                if (!order.Extras.Any(a => a.Name == "Fries") && order.Extras.Any(a => a.Name == "Soft Drink"))
                    price = getDiscount(price, 15);
                if (order.Extras.Any(a => a.Name == "Fries") && order.Extras.Any(a => a.Name == "Soft Drink"))
                    price = getDiscount(price, 20);
            }
            return price;
        }


        public bool SaveOrder(Order order) {
            try
            {
                order.Id = AllOrders.Count + 1;
                order.TotalPrice = GetTotalPrice(order);
                AllOrders.Add(order);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateOrder(Order order)
        {
            try
            {
                Order current = AllOrders.FirstOrDefault(a => a.Id == order.Id);
                if (current != null)
                {
                    current.Sandwich = order.Sandwich;
                    current.Extras = new List<Extra>();
                    current.Extras = order.Extras;
                    current.TotalPrice = GetTotalPrice(order);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteOrder(int orderId)
        {
            try
            {
                Order current = AllOrders.FirstOrDefault(a => a.Id == orderId);
                if (current != null)
                {
                    AllOrders.Remove(current);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private decimal getDiscount(decimal price, decimal percentage) {
             return price - price * percentage / 100; 
        }
    }
}
