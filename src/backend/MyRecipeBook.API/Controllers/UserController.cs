using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ProducesResponseType(typeof(ResponseRegisteredUserJson), StatusCodes.Status201Created)]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(RequestRegisterUserJson request)
        { 
            return Created();
        }
    }
}
