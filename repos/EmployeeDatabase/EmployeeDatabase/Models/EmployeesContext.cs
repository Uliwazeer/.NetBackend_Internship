using Microsoft.EntityFrameworkCore;

namespace EmployeeDatabase.Models
{
    public class EmployeesContext : DbContext 
    {
        public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options)
        {

        }
        public DbSet<Employees> Employee {  get; set; }

                }
}
