using System.Buffers.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using MVC01.Models;

namespace MVC01.Controllers
{
    //[Route("Products")]
    public class ProductsController : Controller
    {
        //baseURL/Products/Index/10

        //public IActionResult Index(int id)
        //{
        //    ContentResult result = new ContentResult();
        //    result.ContentType = "text/html";
        //    result.Content = "<h1> Hello Every One <h1>";
        //    result.StatusCode = StatusCodes.Status200OK;

        //    return result;
        //}

        //------------------------------------------------------------------

        //baseURL/Products/Index
        //public IActionResult index()
        //{
        //    return Content("<h1>mvc course started...<h1>", "text/plain");
        //}

        //------------------------------ Model Binding with simple data -------------------------------------------------
        //baseURL/Products/getJsonData?id=1&name=json
        //[HttpGet]
        //public IActionResult getJsonData(int id , string name)
        //{
        //    if(name != "json")
        //    {
        //        return NotFound();
        //    }

        //    var products = new List<Products>()
        //    {
        //        new Products(){Id =1, Name = "Mobile", Price = 12000},
        //        new Products(){Id=2,Name = "Iron", Price = 3500}
        //    };

        //    return Json(products);
        //}
        //------------------------ Route Attribute ---------------------------------
        //baseURL/Products/views/1
        //[HttpGet("views/{Code:int}")]
        //public IActionResult GetView(int code)
        //{
        //    return View(); 
        //}

        //---------------------- ModelBinding-> Route vs Query ---------------------------------
        //baseURL/Products/GetRequest/10?id=5   ===> id(10)"Routing segement superior over query segment"
        //[HttpGet]
        //public IActionResult GetRequest(int id)
        //{
        //    Console.WriteLine(id);
        //    return BadRequest();
        //}

        //---------------------------- ModelBinding with complex Data -------------------------------------

        //baseURL/Products/ComplexData?o.id=1&o.name=lenovaLaptop
        //[HttpGet]
        //public IActionResult ComplexData(Order o)
        //{
        //    return Json(o);
        //}

        //------------------------- ModelBinding with Collection ---------------------------------
        //baseURL/Products/GetCollection/?oList[0].id=1&oList[0].name=iron&oList[1].id=2&oList[1].name=fridge
        //[HttpGet]
        //public IActionResult GetCollection(List<Order> oList)
        //{
        //    return Json(oList);

        //}

        // --------------------------FileByte-------------------------------------

        //[HttpGet]
        //public IActionResult GetFile()
        //{
        //    byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/css/site.css");
        //    return File(fileBytes, "application/css", "Myfile");
        //}


        // --------------------------redirect-------------------------------------
        //Base4Url/Products/Test
        //[HttpGet]
        //public IActionResult Test()
        //{
        //    return Redirect("https://docs.google.com/presentation/d/1L5uja6Tj_a38uHlXC-RmNYX1bYfsSqYT/edit?slide=id.p1#slide=id.p1");
        //}

        // --------------------------redirectToAction------------------------------
        //baseURL/Products/Test/1
        //[HttpGet]
        //public IActionResult Test(int id)
        //{
        //    return RedirectToAction(nameof(Index));
        //}





    }
}
