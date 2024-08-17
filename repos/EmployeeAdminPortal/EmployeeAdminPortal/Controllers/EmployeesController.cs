using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            return Ok(dbContext.Employees.ToList());
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            if (addEmployeeDto == null)
            {
                return BadRequest("Employee data is required.");
            }

            var employeeEntity = new Employee()
            {
                ID = addEmployeeDto.ID,
                Quantity = addEmployeeDto.Quantity,
                Price = addEmployeeDto.Price,
                Directions = addEmployeeDto.Directions
            };

            dbContext.Employees.Add(employeeEntity);

            try
            {
                dbContext.SaveChanges();
                return Ok(employeeEntity);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An error occurred while saving data: {ex.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"An unexpected error occurred: {ex.Message}");
            }
        }

        /*
        [HttpPost]
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            if (addEmployeeDto == null)
            {
                return BadRequest("Employee data is required.");
            }

            var employeeEntity = new Employee()
            {
                ID = addEmployeeDto.ID,
                Quantity = addEmployeeDto.Quantity,
                Price = addEmployeeDto.Price,
                Directions = addEmployeeDto.Directions
            };

            dbContext.Employees.Add(employeeEntity);

            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Log the error (uncomment ex variable name and write a log.)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error saving data to the database.");
            }

            return Ok(employeeEntity);
        }
        */
        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateEmployee(int id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }

            employee.Quantity = updateEmployeeDto.Quantity;
            employee.Price = updateEmployeeDto.Price;
            employee.Directions = updateEmployeeDto.Directions;

            try
            {
                dbContext.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Log the error (uncomment ex variable name and write a log.)
                return StatusCode(StatusCodes.Status500InternalServerError, "Error saving data to the database.");
            }

            return Ok(employee);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }

            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();

            return Ok();
        }
    }
}

/*
using EmployeeAdminPortal.Data;
using EmployeeAdminPortal.Models;
using EmployeeAdminPortal.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllEmployees(int id)
        {
            return Ok(dbContext.Employees.ToList());
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpPost]
       
        public IActionResult AddEmployee(AddEmployeeDto addEmployeeDto)
        {
            var employeeEntity = new Employee()
            {
                ID = addEmployeeDto.ID,
                Quantity = addEmployeeDto.Quantity,
                Price = addEmployeeDto.Price,
                Directions = addEmployeeDto.Directions
            };
            dbContext.Employees.Add(employeeEntity);
            //dbContext.SaveChanges();
            return Ok(employeeEntity);
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdateEmployee(int id, UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null)
            { return NotFound(); }
            employee.Quantity = updateEmployeeDto.Quantity;
            employee.Price = updateEmployeeDto.Price;
            employee.Directions = updateEmployeeDto.Directions;

            dbContext.SaveChanges();
            return Ok(employee);
        }
        [HttpDelete]
        [Route("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = dbContext.Employees.Find(id);
            if (employee is null) { return NotFound(); };
            dbContext.Employees.Remove(employee);
            dbContext.SaveChanges();
            return Ok();
        }
    }
}
*/