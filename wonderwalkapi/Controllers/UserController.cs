using Microsoft.AspNetCore.Mvc;
using WonderWalkApi.Data;
using WonderWalkApi.Models;
using System.Threading.Tasks;

namespace WonderWalkApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UsersDataAccess _usersDataAccess;

        public UsersController(UsersDataAccess usersDataAccess)
        {
            _usersDataAccess = usersDataAccess;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDto request)
        {
            // Hash the password
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            int? userId = await _usersDataAccess.CreateUser(request.Username, request.Email, passwordHash);

            if (userId.HasValue)
            {
                return Ok(userId.Value); // Return the int value
            }
            else
            {
                // Handle the case where user creation failed (userId is null)
                return BadRequest("User registration failed."); // Or throw an exception
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto request)
        {
            var user = await _usersDataAccess.GetUserByEmail(request.Email);

            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return Unauthorized("Invalid email or password.");
            }

            return Ok("Login successful.");
        }
    }
}