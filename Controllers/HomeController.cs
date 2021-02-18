using Microsoft.AspNetCore.Mvc;
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
        
        public string Projects()
        {
            return "These are my projects";
        }
        
        [HttpGet("contact")]
        
        public string Contact()
        {
            return "This is my Contact!";
        }
      
        [HttpGet("users/{username}")]
        
        public string UserName(string username)
        {
            return $"Hello {username}!";
        }
        
    }
}