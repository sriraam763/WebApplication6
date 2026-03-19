using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Data;
using WebApplication6.Models;

namespace WebApplication6.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Tasklist : ControllerBase
{
    public ApplicationDbContext _Context;

    public Tasklist(ApplicationDbContext context)
    {
        _Context = context;
    }
    [HttpGet]
    public List<TaskList> show()
    {
        var list=_Context.TaskLists.ToList();
        Console.Write("this is stored");

        return list;
    }

    [HttpPost]
    public IActionResult getid([FromBody] TaskList nnew)
    {
        _Context.TaskLists.Add(nnew);
        _Context.SaveChanges();
        Console.WriteLine("hello");
        return Ok(new { message="succefully added" });
}
}