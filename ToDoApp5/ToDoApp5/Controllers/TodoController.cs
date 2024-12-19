using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoApp5.Contexts;
using ToDoApp5.Models;

namespace ToDoApp5.Controllers
{
    public class TodoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (Bp215efContext context = new())
            {
                return View(await context.Todos.ToListAsync());               
            }                          
        }
        [HttpGet]
        public async Task<IActionResult>Create()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create(Todo data)
        {
            using (Bp215efContext context = new())
            {
                await context.Todos.AddAsync(data);
                await context.SaveChangesAsync();
                
            }
            return RedirectToAction(nameof(Index));
            
        }
       



    }
}
