using ExampleWebApplication.ShopUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleWebApplication.ShopUI.Components;



// متناسب با نام این کلاس باید در فولدر شیرد در زیر ویو فولدری ایجاد کرد و یک ویو با نام دیفالت ساخت
public class CategoryListBoxViewComponent : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryListBoxViewComponent(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var currentCategory = RouteData?.Values["category"];
        ViewBag.Category = currentCategory; //a feature to pass dynamic data to UI
        var model = _categoryRepository.GetAllCategories();
        return View(model);
    }
}
