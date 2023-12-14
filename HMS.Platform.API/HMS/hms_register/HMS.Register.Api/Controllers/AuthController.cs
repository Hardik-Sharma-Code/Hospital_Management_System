using HMS.Register.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HMS.Register.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public Task<IActionResult> SignUp(SignupDto signup)
        {
            return null;
        }

        
        [HttpGet]
        public Task<IActionResult> Register()
        {
            return null;
        }
    }
}
