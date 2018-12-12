using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    [RequireHttpsAttribute]
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }
    }
}