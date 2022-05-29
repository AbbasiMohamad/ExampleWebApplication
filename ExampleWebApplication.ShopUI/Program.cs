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

// فعال کردن سرویس های مربوط به سشن
builder.Services.AddSession();

// سشن از امکان کشینگ برای ذخیره سازی و بازیابی سشن استفاده میکند
builder.Services.AddMemoryCache();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
    //این میدلور یک صفحه برای نمایش جزئیات اکسپشنها مهیا میکند
    app.UseDeveloperExceptionPage();

// ایجاد صفحه برای خطاهای مشخص بین خطاهای 400 تا 599
app.UseStatusCodePages();

// این میدلور امکان سِرو شدن فایل های استاتیک را مهیا میکند
app.UseStaticFiles();

// اضافه کردن میدلور سشن 
app.UseSession();

// این میدلور امکان مسیریابی را مهیا میکند. درخواست کاربر را پردازش میکند و به مقصد نهایی میرساند
app.UseRouting();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}/Page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/Page{PageNumber}");
    endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}");
    endpoints.MapDefaultControllerRoute(); // {controller=home}/{action=index}/{id?}
}
    
);


app.Run();
