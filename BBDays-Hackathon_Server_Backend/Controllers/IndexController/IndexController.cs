using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers.IndexController
{
    [Route("[controller]")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly DataContext _context;
        public IndexController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("index")]
        public async Task<IActionResult> Post(MedkitModel model)
        {
            try
            {
            if(model.id == null || model.ip_address == null)
                return BadRequest();
            MedkitModel? model2 = await _context.Medkit.Where(x => x.id == model.id).FirstOrDefaultAsync();
            if(model2 == null)
                return NotFound();
            else
            {
                model2.plaster = model.plaster;
                model2.spirit = model.spirit;
                model2.mask = model.mask;
                model2.elastric = model.elastric;
                model2.bandage = model.bandage;
                model2.bloodsucker = model.bloodsucker;
                model2.dust_wound = model.dust_wound;
                model2.foil_nrc = model.foil_nrc;
                model2.latex = model.latex;
                model2.medpack = model.medpack;
                model2.plaster_mark = model.plaster_mark;
                model2.plaster_mark_2 = model.plaster_mark_2;
                model2.splint = model.splint;
                if(model2.uwaga.Length > 0)
                {
                    model2.uwaga = model.uwaga;
                }
                model2.Updated_At = DateTime.Now;
                await _context.SaveChangesAsync();
                return Ok();
            }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            // Mapping
        }
        [HttpPost("banan")]
        public async Task<IActionResult> PostBanan()
        {
            if (null == null)
                return BadRequest();
        }

    }
}
