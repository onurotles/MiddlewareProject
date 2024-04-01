using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiddlewareProject.WebApi.Models;

namespace MiddlewareProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            int a = 0;
            int b = 10 / a;
            return "OK";
        }

        [HttpGet]
        [Route("Student")]
        public Student GetStudent()
        {
            return new Student()
            {
                Id = 1,
                FullName = "Name Surname Test"
            };
        }

        [HttpPost]
        [Route("Student")]
        public string CreateStudent([FromBody] Student student)
        {
            return "Student Created!";
        }
    }
}
