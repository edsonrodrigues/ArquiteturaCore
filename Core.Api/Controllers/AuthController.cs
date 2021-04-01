using Core.Dao.ConfigurationToken.Business;
using Core.Dao.VO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Api.Controllers
{
    //[Route("api/[controller]")]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult signIn([FromBody] UserVO user) 
        {
            if (user == null) return BadRequest("Invalid Client Request");
            var token = _loginBusiness.ValidateCredentials(user);
            if (token == null) return Unauthorized();

            return Ok(token);
        }

    }
}
