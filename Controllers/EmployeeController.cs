using Employee.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employees> emp = new List<Employees>()
        {
            new Employees(101,"muskan",22,300000)
        };

        [HttpGet]
        public IEnumerable<Employees> get()
        {
            return emp;
        }
        [HttpGet("{id}")]
        public Employees get(int id)
        {
            return emp.FirstOrDefault(s=>s.id==id);
        }
        [HttpPost]
        public void post([FromBody] Employees value)
        {
            emp.Add(value);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employees e)
        {
            int i = emp.FindIndex(e => e.id == id);
            if (id >= 0)
            {
                emp[i] = e;
            }
        }
        [HttpDelete]
        public void delete(int id)
        {
            emp.RemoveAll(emp => emp.id == id);
        }

    }
}
