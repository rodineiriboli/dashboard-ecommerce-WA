using EcommerceWA.Application.DTO;
using EcommerceWA.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EcommerceWA.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IUserService userService;
        public AuthController(IAuthService authService, IUserService userService)
        {
            this.authService = authService;
            this.userService = userService;
        }

        [HttpPost]
        [Route("authenticate")]
        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] UserDto model)
        {
            var user = userService.Get(model.UserName, model.Password);

            if (user == null) return NotFound(new
            {
                erro = "Usuário não existe"
            });

            var token = authService.GenerateToken(user);

            return new
            {
                user = user,
                token = token
            };
        }
    }
}
