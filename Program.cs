var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    //First URL segment(controller) determines controller class to execute. "localhost:5001/HelloWorld" maps to HelloWorldController.
    //Second URL segment(action) determines method of the selected controller to call. If second segment is not exist, default method is called. In this case, Index method is called.
    //Third URL segment(id) is route data. The tailing ? means id parameter is optional
    pattern: "{controller=Home}/{action=Index}/{id?}"); //Routing format
app.Run();
