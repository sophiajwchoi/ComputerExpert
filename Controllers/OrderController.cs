using Microsoft.AspNetCore.Mvc;
using ComputerExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using ComputerExpert.ViewModels;

namespace ComputerExpert.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderData _orderData;
        private readonly ShoppingCart _shoppingCart;
        private readonly IComputerData _computerData;
        private readonly IComponentData _componentData;
        private readonly IProductData _productData;
        private readonly IOrderDetail _orderDetail;

        public OrderController(IOrderData orderData, IComputerData computerData, IComponentData componentData, IOrderDetail orderDetail, IProductData productData, ShoppingCart shoppingCart)
        {
            _orderData = orderData;
            _computerData = computerData;
            _componentData = componentData;
            _shoppingCart = shoppingCart;
            _productData = productData;
            _orderDetail = orderDetail;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Cart is empty.");
            }

            if (ModelState.IsValid)
            {
                _orderData.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your order!";
            return View();
        }

        public IActionResult Orders(string userId)
        {
            var orderViewModel = new OrderViewModel
            {
                Orders = _orderData.GetAllOrders(userId)
            };
            var processorOps = _componentData.GetProcessorOps;
            var memoryOps = _componentData.GetMemoryOps;
            var graphicsOps = _componentData.GetGraphicsOps;
            var soundCartOps = _componentData.GetSoundCardOps;
            var storageOps = _componentData.GetStorageOps;
            var computers = _computerData.GetAllComputers;
            var products = _productData.GetAllProducts;
            var orderDetails = _orderDetail.GetOrderDetail;
            orderViewModel.ProcessorOps = processorOps;
            orderViewModel.MemoryOps = memoryOps;
            orderViewModel.GraphicsOps = graphicsOps;
            orderViewModel.SoundCardOps = soundCartOps;
            orderViewModel.StorageOps = storageOps;
            orderViewModel.Computers = computers;
            orderViewModel.Products = products;
            orderViewModel.OrderDetails = orderDetails;
            return View(orderViewModel);
        }
    }
}
