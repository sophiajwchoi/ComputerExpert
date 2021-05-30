using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class OrderDetailData : IOrderDetail
    {
        private readonly AppDbContext _appDbContext;

        public OrderDetailData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<OrderDetail> GetOrderDetail
        {
            get
            {
                return _appDbContext.OrderDetails;
            }
        }
    }
}
