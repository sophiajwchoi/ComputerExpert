using Microsoft.AspNetCore.Mvc;
using ComputerExpert.Models;
using ComputerExpert.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerExpert.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IComputerData _computerData;
        private readonly IProductData _productData;
        private readonly IComponentData _componentData;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IComputerData computerData, IProductData productData, IComponentData componentData, ShoppingCart shoppingCart)
        {
            _computerData = computerData;
            _productData = productData;
            _componentData = componentData;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            var processorOps = _componentData.GetProcessorOps;
            var memoryOps = _componentData.GetMemoryOps;
            var graphicsOps = _componentData.GetGraphicsOps;
            var soundCartOps = _componentData.GetSoundCardOps;
            var storageOps = _componentData.GetStorageOps;
            var computers = _computerData.GetAllComputers;
            shoppingCartViewModel.ProcessorOps = processorOps;
            shoppingCartViewModel.MemoryOps = memoryOps;
            shoppingCartViewModel.GraphicsOps = graphicsOps;
            shoppingCartViewModel.SoundCardOps = soundCartOps;
            shoppingCartViewModel.StorageOps = storageOps;
            shoppingCartViewModel.Computers = computers;
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int computerId, double totalPrice, int processorId, int graphicsId, int memoryId, int storageId, int soundCardId)
        {
            var product = _productData.CreateProduct(computerId, totalPrice, processorId, graphicsId, memoryId, storageId, soundCardId);

            if (product != null)
            {
                _shoppingCart.AddToCart(product, 1);
            }

            return RedirectToAction("Index");
        }


        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var sProduct = _productData.GetAllProducts.FirstOrDefault(c => c.Id == productId);

            if (sProduct != null)
            {
                _shoppingCart.RemoveFromCart(sProduct);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
