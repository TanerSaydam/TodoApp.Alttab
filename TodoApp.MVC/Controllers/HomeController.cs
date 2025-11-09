using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApp.MVC.Context;
using TodoApp.MVC.Dtos;
using TodoApp.MVC.Models;

namespace TodoApp.MVC.Controllers;

public class HomeController(ApplicationDbContext dbContext) : Controller
{
    public async Task<IActionResult> Index()
    {
        var res = await dbContext.Todos.ToListAsync();
        return View(res);
    }

    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(CreateTodoDto request)
    {
        Todo todo = request.Adapt<Todo>();

        dbContext.Todos.Add(todo);
        await dbContext.SaveChangesAsync();

        return Redirect("Index");
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        var todo = await dbContext.Todos.FirstOrDefaultAsync(p => p.Id == id);
        if (todo is null)
        {
            throw new ArgumentNullException(nameof(todo));
        }

        dbContext.Remove(todo);
        await dbContext.SaveChangesAsync();

        return Redirect("Index");
    }
}
