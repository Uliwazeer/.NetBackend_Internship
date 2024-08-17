using EmployeeDatabase.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesContext _dbcontext;

        public EmployeesController(EmployeesContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employees>>> GetEmployees()
        {
            if (_dbcontext.Employee == null)
            {
                return NotFound();
            }

            return await _dbcontext.Employee.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployee(int id)
        {
            if (_dbcontext.Employee == null)
            {
                return NotFound();
            }

            var employee = await _dbcontext.Employee.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        // POST: api/Employees
        [HttpPost]
        public async Task<ActionResult<Employees>> PostEmployee(Employees employees)
        {
            // Make sure the Id is not manually set
            employees.Id = 0;  // or set to its default value depending on your model
            _dbcontext.Employee.Add(employees);
            await _dbcontext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = employees.Id }, employees);
        }


        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employees employee)
        {
            if (id != employee.Id)
            {
                return BadRequest();
            }

            _dbcontext.Entry(employee).State = EntityState.Modified;

            try
            {
                await _dbcontext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            if (_dbcontext.Employee == null)
            {
                return NotFound();
            }

            var employee = await _dbcontext.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _dbcontext.Employee.Remove(employee);
            await _dbcontext.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _dbcontext.Employee.Any(e => e.Id == id);
        }
    }
}
