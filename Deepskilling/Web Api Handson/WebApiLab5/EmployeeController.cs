using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiLab5.Models;

namespace WebApiLab5.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    static List<Employee> employees = new()
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
        }
    };

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(employees);
    }
}