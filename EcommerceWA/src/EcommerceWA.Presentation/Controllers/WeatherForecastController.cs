using EcommerceWA.Application.DTO;
using EcommerceWA.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWA.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUserService userService;
        public WeatherForecastController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated([FromBody] UserDto model)
        {
            var user = userService.Get(model.UserName, model.Password);
            return $"authenticated - {user.UserName} - {user.Role}";
        }

        [HttpGet]
        [Route("basic")]
        [Authorize(Roles = "basic")]
        public string Basic() => "Acesso básico";

        [HttpGet]
        [Route("manager")]
        [Authorize(Roles = "manager")]
        public string Admin() => "Acesso administrador";

        [HttpGet]
        [Route("both")]
        [Authorize(Roles = "admin, basic")]
        public string Both() => "Acesso para ambos";

    }
}
