using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnrollmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
    [HttpGet]
    public string Greetings ()
        {
            return "Hello";
        }

    }
}



/*CRUD                                                        HTTP VERBS
 * CREATE - a new record                                    - POST
 * READ   - retrieve a single/list of record(s)             - GET
 * UPDATE - modify an existing record                       - PUT / PATCH
 * DELETE - remove an existing record                       - DELETE
*/