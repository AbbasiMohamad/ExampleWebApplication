using ExampleWebApplication.ShopUI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


/* این متد تمام آبجکت های مورد نیاز در خصوص کار
 * با کنترلرها و ویوها را مهیا میکند*/
builder.Services.AddControllersWithViews();

/*راه اندازی انتیتی فریمورک*/
string connectionString = builder.Configuration.GetConnectionString("StoreCnn");
builder.Services.AddDbContext<StoreDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    //این میدلور یک صفحه برای نمایش جزئیات اکسپشنها مهیا میکند
    app.UseDeveloperExceptionPage();

// ایجاد صفحه برای خطاهای مشخص بین خطاهای 400 تا 599
app.UseStatusCodePages();

// این میدلور امکان سِرو شدن فایل های استاتیک را مهیا میکند
app.UseStaticFiles();

// این میدلور امکان مسیریابی را مهیا میکند. درخواست کاربر را پردازش میکند و به مقصد نهایی میرساند
app.UseRouting();


app.UseEndpoints(endpoints =>
    endpoints.MapDefaultControllerRoute() // {controller=home}/{action=index}/{id?}
);


app.Run();
