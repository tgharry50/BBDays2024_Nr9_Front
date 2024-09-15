using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers.RegisterController
{
    public class RegisterControler : ControllerBase
    {

        protected readonly DataContext _context;
        public RegisterControler(DataContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> CreateUser(RegisterModel model)
        {
            try
            {
                if (model == null)
                    return BadRequest(model);
                RegisterModel registerModel = new RegisterModel();
                registerModel.first_name = model.first_name;
                registerModel.last_name = model.last_name;
                registerModel.password = model.password;
                registerModel.login = model.login;
                registerModel.privelage = 0;
                await _context.AddAsync(registerModel);
                await _context.SaveChangesAsync();
                return Ok();
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
        [HttpPost("register_admin")]
        public async Task<IActionResult> CreateAdmin(RegisterModel model)
        {
            try
            {
                if (model == null)
                    return BadRequest(model);
                RegisterModel registerModel = new RegisterModel();
                registerModel.first_name = model.first_name;
                registerModel.last_name = model.last_name;
                registerModel.password = model.password;
                registerModel.login = model.login;
                registerModel.privelage = 1;
                await _context.AddAsync(registerModel);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
