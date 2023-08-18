using JwtAuth.Services;
using Microsoft.AspNetCore.Mvc;
using JwtAuth.Models;

namespace JwtAuth.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUser _user;
        public IToken _tokenGenerator;

        public UserController(IUser user, IToken tokenGenerator)
        {
            _user = user;
            _tokenGenerator = tokenGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            List<User> users;
            try
            {
                users = await _user.GetAllUsers();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(users);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<User>> GetUserByUsername(string username)
        {
            User user;
            string token;
            try
            {
                user = await _user.GetUserByUsername(username);
                token = _tokenGenerator.GenerateToken(user.UserName, user.Role);
                Console.WriteLine(token);
                return Ok(new { Token = token, User = user }); 

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            //return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User user)
        {
            List<User> users;
            try
            {
                users = await _user.AddUser(user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(users);
        }

        [HttpPut]
        public async Task<ActionResult<User>> Upateuser(string username, User user)
        {
            User? updateduser;
            try
            {
                updateduser = await _user.UpdateUser(username, user);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(updateduser);
        }

        [HttpDelete]
        public async Task<ActionResult<List<User>>> Deleteuser(string username)
        {

            List<User> users;
            try
            {
                users = await _user.DeleteUser(username);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            return Ok(users);
        }
    }
}
