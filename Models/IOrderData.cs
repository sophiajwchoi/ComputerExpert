using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public interface IOrderData
    {
        void CreateOrder(Order order);

        //public IEnumerable<Order> GetAllOrders { get; }
        IEnumerable<Order> GetAllOrders(string userId);
    }
}
