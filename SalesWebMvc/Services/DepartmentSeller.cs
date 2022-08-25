using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentSeller
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentSeller(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.ToList();
        }

        public void Insert(Department obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
