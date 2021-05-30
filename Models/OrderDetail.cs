using ComputerExpert.Models;

namespace ComputerExpert.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }
    }
}