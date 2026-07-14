using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI1.Controllers;

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

    // GET : api/values
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(values);
    }

    // GET : api/values/1
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        if (id < 0 || id >= values.Count)
            return BadRequest("Invalid Id");

        return Ok(values[id]);
    }

    // POST : api/values?value=Mango
    [HttpPost]
    public IActionResult Post(string value)
    {
        values.Add(value);
        return Ok("Value Added Successfully");
    }

    // PUT : api/values/1?value=Grapes
    [HttpPut("{id}")]
    public IActionResult Put(int id, string value)
    {
        if (id < 0 || id >= values.Count)
            return BadRequest("Invalid Id");

        values[id] = value;
        return Ok("Value Updated Successfully");
    }

    // DELETE : api/values/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (id < 0 || id >= values.Count)
            return BadRequest("Invalid Id");

        values.RemoveAt(id);
        return Ok("Value Deleted Successfully");
    }
}