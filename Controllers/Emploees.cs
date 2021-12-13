using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employees : ControllerBase
    {
        private readonly Employee_context;

        public EmployeesController(EmployeeContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            return await _context.Employee.ToListAsync();
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<Employees>> GetEmployee(int id)
        {
            var employee = await _context..FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

        
    }
}
