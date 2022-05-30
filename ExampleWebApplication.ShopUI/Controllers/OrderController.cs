using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Controllers;
public class OrderController : Controller
{
    private readonly IOrderRepository _orderRepository;
    private readonly Basket _basket;

    public OrderController(IOrderRepository orderRepository, Basket basket)
    {
        _orderRepository = orderRepository;
        _basket = basket;
    }
    public IActionResult Checkout()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Checkout(CheckoutViewModel model)
    {
        if (!_basket.Items.Any())
        {
            ModelState.AddModelError("", "There is no item in the basket!");
        }
        if (ModelState.IsValid)
        {
            var order = new Order
            {
                Name = model.Name,
                City = model.City,
                Address = model.Address
            };
            OrderDetail orderDetail = new();
            foreach (var item in _basket.Items)
            {
                order.OrderDetails.Add(new OrderDetail
                {
                    Product = item.Product,
                    Quantity = item.Quantity,
                });
            }
            _orderRepository.Checkout(order);
            _basket.Clear();
            return RedirectToAction(nameof(CompeletedCheckout));
        }
        return View(model);
    }

    public IActionResult CompeletedCheckout()
    {
        return View();
    }
}
