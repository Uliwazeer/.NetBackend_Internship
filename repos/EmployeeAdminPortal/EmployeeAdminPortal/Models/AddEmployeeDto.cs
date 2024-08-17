namespace EmployeeAdminPortal.Models
{
    public class AddEmployeeDto
    {

        public int? ID { get; set; }
        public int Quantity { get; set; }
        public int? Price { get; set; }
        public required string Directions { get; set; }
    }
}
