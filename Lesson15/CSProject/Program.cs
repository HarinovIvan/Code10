using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    public List<string> users = new List<string>();

    [HttpGet]
    public ActionResult Get()
    {
        return Ok("Hello World!"); 
    }

    [HttpPost]
    public ActionResult Post([FromBody] string body)
    {
        if (body != null)
        {
            users.Append(body);
        }
        else
        {
            return NotFound("Ошибка");
        }

        return Ok($"Пользователь {body} успешно добавлен");
    }
}

[ApiController]
[Route("api/[controller]")]
public class Controller : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok("User 1"); 
    }
    [HttpPost]
    public ActionResult Post([FromBody] string body)
    {
        try
        {
            // методы для сохранения данных...
            throw new Exception("Ошибка");
        }
        catch (Exception ex)
        {
            return Problem(ex.Message);
        }
        return Ok($"Data is saved");
    }
}
