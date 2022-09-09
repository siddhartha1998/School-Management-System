using Application.Users.CreateUser;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace SchoolManagementSystem.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return Ok();
        }

        [HttpGet("login")]
        [AllowAnonymous]
        public IActionResult Login(AuthenticationRequest request)
        {
            var tokenString = GenerateJSONWebToken(request);
            return Ok(new { token = tokenString });
        }

        [HttpPost("/api/users")]
        public IActionResult CreateUser(CreateApplicationUserCommand command)
        {
            return Ok(command);
        }

        private string GenerateJSONWebToken(AuthenticationRequest request)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: _configuration["Jwt:Issuer"],
                                             audience: _configuration["Jwt:Issuer"],
                                             claims: null,
                                             expires: DateTime.Now.AddMinutes(5),
                                             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }

    public class AuthenticationRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
