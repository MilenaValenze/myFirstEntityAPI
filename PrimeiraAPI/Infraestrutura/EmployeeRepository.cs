using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infraestrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ConnectionContext _context = new();
        public void Add(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção: ", ex);
                throw;
            }
        }

        public List<Employee> Get()
        {
            return _context.Employees.ToList();
        }
    }
}
