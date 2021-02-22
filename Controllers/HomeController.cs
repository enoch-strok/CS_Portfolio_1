using Microsoft.AspNetCore.Mvc;
using System;
namespace CS_Porfolio_1
{
    public class HomeController : Controller
    {
        [HttpGet("")]

        public ViewResult index()
        {
            return View();
        }
        
        [HttpGet("projects")]

        public ViewResult projects()
        {
            return View();
        }
        
        [HttpGet("contact")]

        public ViewResult contact()
        {
            return View();
        }

        // [HttpGet("projects")]
        // public RedirectToActionResult Projects()
        // {
        //     Console.WriteLine("Redirect working...");
        //     return RedirectToAction("Index");
        // }
        
        // [HttpGet("contact")]
        
        // public string Contact()
        // {
        //     return "This is my Contact!";
        // }
      
        [HttpGet("users/{username}")]
        
        public string UserName(string username)
        {
            return $"Hello {username}!";
        }
        
    }
}