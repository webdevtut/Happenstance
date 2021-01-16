using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly DataContext _context;
        public AccountController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AppUser>> Register(RegisterDto registerDto)
        {

            if (await UserExists(registerDto.UserName)) return BadRequest ("Username is taken");
            using var hmac = new HMACSHA512();  // Here 'using' is used to dispose the managed resources as this is derived from IDisposable class

            var user = new AppUser
            {
                UserName = registerDto.UserName.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt= hmac.Key
            };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return user;
        }

        [HttpPost("login")]
        public async Task<ActionResult<AppUser>> Login(LoginDto loginDto)
        {
            var user = await _context.Users
            .SingleOrDefaultAsync( x => x.UserName == loginDto.UserName);

            if(user == null) return Unauthorized("Invalid Username");

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(loginDto.Password));
            
            for (int i = 0; i < computeHash.Length; i++)
            {
                if(computeHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid Password");
            }

            return user;
        }

        public async Task<bool> UserExists(string UserName){

            return await _context.Users.AnyAsync(x => x.UserName == UserName.ToLower());
        }
    }
}