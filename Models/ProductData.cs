using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Models
{
    public class ProductData : IProductData
    {
        private readonly AppDbContext _appDbContext;

        public ProductData(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Product> GetAllProducts
        {
            get
            {
                return _appDbContext.Products;
            }
        }

        public Product CreateProduct(int computerId, double totalPrice, int processorId, int graphicsId, int memoryId, int storageId, int soundCardId)
        {
            var Product = _appDbContext.Products.SingleOrDefault(p => p.ComputerId == computerId && p.ProcessorId == processorId && p.GraphicsId == graphicsId && p.MemoryId == memoryId && p.StorageId == storageId && p.SoundCardId == soundCardId);
            if (Product == null)
            {
                Product = new Product
                {
                    FinalPrice = totalPrice,
                    ComputerId = computerId,
                    ProcessorId = processorId,
                    GraphicsId = graphicsId,
                    MemoryId = memoryId,
                    SoundCardId = soundCardId
                };
                _appDbContext.Products.Add(Product);
            }
            _appDbContext.SaveChanges();
            return Product;
        }

        public Product GetProductById(int id)
        {
            return _appDbContext.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
