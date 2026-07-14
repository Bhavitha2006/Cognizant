using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiLab3.Models;

namespace WebApiLab3.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private List<Employee> employees;

    public EmployeeController()
    {
        employees = GetStandardEmployeeList();
    }

    private List<Employee> GetStandardEmployeeList()
    {
        return new List<Employee>()
        {
            new Employee
            {
                Id = 1,
                Name = "John",
                Salary = 50000,
                Permanent = true,
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>()
                {
                    new Skill{ Id=1, Name="C#" },
                    new Skill{ Id=2, Name="SQL" }
                },
                DateOfBirth = new DateTime(1998,5,10)
            },

            new Employee
            {
                Id = 2,
                Name = "David",
                Salary = 60000,
                Permanent = false,
                Department = new Department
                {
                    Id = 2,
                    Name = "HR"
                },
                Skills = new List<Skill>()
                {
                    new Skill{ Id=3, Name="Excel" }
                },
                DateOfBirth = new DateTime(1997,8,15)
            }
        };
    }

    [AllowAnonymous]
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<List<Employee>> GetStandard()
    {
        return Ok(employees);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Employee employee)
    {
        employees.Add(employee);
        return Ok(employee);
    }

    [HttpPut]
    public IActionResult Put([FromBody] Employee employee)
    {
        return Ok(employee);
    }
}