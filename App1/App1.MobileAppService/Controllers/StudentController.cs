using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App1.MobileAppService.Controllers
{
  [Produces("application/json")]
  [Route("api/Student")]
  public class StudentController : Controller
  {

    // GET: api/Student
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return ListStudents.ToArray();
    }

    // GET: api/Student/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Student
    [HttpPost]
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Student/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }

    public StudentController()
    {
      ListStudents.Add("Amit");
      ListStudents.Add("Vinay");
      ListStudents.Add("Mohan");
      ListStudents.Add("Sundar");
      ListStudents.Add("Raj");
      ListStudents.Add("Satya");
      ListStudents.Add("Krishna");
    }

    List<string> ListStudents = new List<string>();

  }
}
