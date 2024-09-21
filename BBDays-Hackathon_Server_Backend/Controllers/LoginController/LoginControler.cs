using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers.LoginController
{
    public class LoginControler : ControllerBase
    {
        protected readonly DataContext _context;
        public LoginControler(DataContext context)
        {
            _context = context;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(string login, string password)
        {
            try
            {
                if(login == null || password == null)
                    return BadRequest(string.Empty);
                RegisterModel? re = await _context.Users.Where(x => x.login == login && x.password == password).FirstOrDefaultAsync();
                if (re == null)
                    return NotFound();
                return Ok(re);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
