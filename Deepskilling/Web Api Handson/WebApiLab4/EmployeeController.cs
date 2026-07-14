using Microsoft.AspNetCore.Mvc;
using WebApiLab4.Models;

namespace WebApiLab4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private static List<Employee> employees = new()
    {
        new Employee
        {
            Id=1,
            Name="John",
            Salary=50000,
            Permanent=true
        },

        new Employee
        {
            Id=2,
            Name="David",
            Salary=60000,
            Permanent=false
        },

        new Employee
        {
            Id=3,
            Name="Mary",
            Salary=70000,
            Permanent=true
        }
    };

    // GET
    [HttpGet]
    public ActionResult<List<Employee>> Get()
    {
        return Ok(employees);
    }

    // PUT
    [HttpPut("{id}")]
    public ActionResult<Employee> Put(int id, [FromBody] Employee employee)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid employee id");
        }

        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
        {
            return BadRequest("Invalid employee id");
        }

        emp.Name = employee.Name;
        emp.Salary = employee.Salary;
        emp.Permanent = employee.Permanent;

        return Ok(emp);
    }

    // POST
    [HttpPost]
    public ActionResult<Employee> Post([FromBody] Employee employee)
    {
        employees.Add(employee);

        return Ok(employee);
    }

    // DELETE
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var emp = employees.FirstOrDefault(e => e.Id == id);

        if (emp == null)
        {
            return BadRequest("Invalid employee id");
        }

        employees.Remove(emp);

        return Ok("Employee Deleted Successfully");
    }
}