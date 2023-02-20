using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;
/*
 * Every public method in controller is able to be call for HTTP endpoint
 * 
 * Example about HTTP endpoint
 *      Valid URL (https://localhost:5001/HelloWorld)
 *      
 * Combine below things to call
 *      Used protocol, (HTTPS)
 *      Network's location including TCP port (localhost:5001)  
 *      Target URL (HelloWorld)
 */
public class HelloWorldController : Controller  
{
    /*
    // GET: /HwlloWorld/
    public string Index()
    {
        return "This is my default action...";
    }
    */

    //Action method 
    //Generally returns IActionResult derived from ActionResult, not type like string
    public IActionResult Index()
    {
        return View();  //Generate HTML response.
    }
    /*
    // GET: /HelloWorld/Welcome
    public string Welcome()       //Overloading inavailable
    {
        return "This is the Welcome action method...";
    }
    */

    /*
    //https://localhost:7053/HelloWorld/Welcome/3?name=Rick
    //Thid segment is same with route parameter "id".
    //Welcome method includes id parameter same with url template in MapControllerRoute method.
    //The tailing ?(id?, 3?) means the begin of query string
    public string Welcome(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");    //Block malicious input like JavaScript
    }
    */

    //Controller sends parameters to view to generate dynamic data. Controllers inject parameters to ViewData and view template can access to dynamic data.
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}
