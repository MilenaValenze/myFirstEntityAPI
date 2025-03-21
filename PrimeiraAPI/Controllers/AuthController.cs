using Microsoft.AspNetCore.Mvc;
using PrimeiraAPI.Services;

namespace PrimeiraAPI.Controllers
{
    public class AuthController : Controller
    {
        [HttpPost]
        [Route("api/v1/auth")]
        public IActionResult Auth(string username, string password)
        {
            if (username == "milena" && password == "12345")
            {
                var token = TokenService.GenerateToken(new Model.Employee());
                return Ok(token);
            }
            else
            {
                return BadRequest("Usuário ou senha inválidos");
            }
        }
               
    }
}
