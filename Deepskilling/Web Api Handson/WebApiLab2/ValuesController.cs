using Microsoft.AspNetCore.Mvc;

namespace WebApiLab2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ValuesController : ControllerBase
{
    static List<string> values = new()
    {
        "Apple",
        "Banana",
        "Orange"
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(values);
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        return Ok(values[id]);
    }

    [HttpPost]
    public IActionResult Post(string value)
    {
        values.Add(value);
        return Ok("Value Added Successfully");
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, string value)
    {
        values[id] = value;
        return Ok("Value Updated Successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        values.RemoveAt(id);
        return Ok("Value Deleted Successfully");
    }
}