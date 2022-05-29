using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Components;



// متناسب با نام این کلاس باید در فولدر شیرد در زیر ویو فولدری ایجاد کرد و یک ویو با نام دیفالت ساخت
public class CategoryListBoxViewComponent : ViewComponent
{
    private readonly IProductRepository _productRepository;

    public CategoryListBoxViewComponent(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IViewComponentResult Invoke()
    {
        var currentCategory = RouteData?.Values["category"];
        ViewBag.Category = currentCategory; //a feature to pass dynamic data to UI
        var model = _productRepository.GetAllCategories();
        return View(model);
    }
}
