namespace EmployeeDatabase.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Directions { get; set; }

        public Employees(string directions)
        {
            Directions = directions;
        }
    }

}
