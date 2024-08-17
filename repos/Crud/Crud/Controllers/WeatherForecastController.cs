using Crud.Caching;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        return Ok(EmployeeStorage.GetAllEmployees());
    }

    [HttpGet("{id}")]
    public IActionResult GetEmployeeById(int id)
    {
        var employee = EmployeeStorage.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
    }

    [HttpPost]
    public IActionResult AddEmployee([FromBody] Employee employee)
    {
        if (employee == null)
        {
            return BadRequest("Employee is null.");
        }

        EmployeeStorage.AddEmployee(employee);
        return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
    {
        if (employee == null || id != employee.Id)
        {
            return BadRequest("Employee data is incorrect.");
        }

        var existingEmployee = EmployeeStorage.GetEmployeeById(id);
        if (existingEmployee == null)
        {
            return NotFound();
        }

        EmployeeStorage.UpdateEmployee(employee);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(int id)
    {
        var employee = EmployeeStorage.GetEmployeeById(id);
        if (employee == null)
        {
            return NotFound();
        }

        EmployeeStorage.DeleteEmployee(id);
        return NoContent();
    }
}
