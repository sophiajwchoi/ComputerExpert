using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public interface IProductData
    {
        IEnumerable<Product> GetAllProducts { get; }
        Product GetProductById(int id);
        Product CreateProduct(int computerId, double totalPrice, int processorId, int graphicsId, int memoryId, int storageId, int soundCardId);
    }
}
