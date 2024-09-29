using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using api.src.Dtos.Auth;
using api.src.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace api.src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto){
            {
                try
                {
                    if(!ModelState.IsValid) return BadRequest(ModelState);

                    var appUser = new AppUser
                    {
                        UserName = registerDto.UserName,
                        Email = registerDto.Email,
                    };

                    if(string.IsNullOrEmpty(registerDto.Password))
                    {
                        return BadRequest("Password cannot be null or empty");
                    }

                    var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                    if(createUser.Succeeded)
                    {
                        var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
                        if(roleResult.Succeeded){
                            return Ok("User created");
                        }
                        else
                        {
                            return StatusCode(500, roleResult.Errors);
                        }
                    }
                    else
                    {
                        return StatusCode(500, createUser.Errors);
                    }


                }
                catch(Exception ex)
                {
                    return StatusCode(500, ex.Message);
                }
            }
        }
    }
}