using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Medkit
{
    public class MedkitControler : ControllerBase
    {
        private readonly DataContext _dataContext;
        public MedkitControler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateMedkit(string ip_address)
        {
            try
            {
                if (_dataContext.Medkit.Where(x => x.ip_address == ip_address).Any())
                    return BadRequest();
                MedkitModel med = new MedkitModel();
                med.ip_address = ip_address;
                med.plaster = 1;
                med.plaster_mark = 1;
                med.plaster_mark_2 = 1;
                med.spirit = 1;
                med.elastric = 1;
                med.bandage = 1;
                med.bloodsucker = 1;
                med.dust_wound = 1;
                med.foil_nrc = 1;
                med.latex = 1;
                med.medpack = 1;
                med.splint = 1;
                med.cord_x = 0; med.cord_y = 0;
                med.Created_At = DateTime.Now;
                med.Updated_At = DateTime.Now;
                await _dataContext.AddAsync(med);
                await _dataContext.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteMedkit(int id, string ip_address)
        {
            MedkitModel? medkit = await _dataContext.Medkit.Where(x => x.id == id && x.ip_address == ip_address).FirstOrDefaultAsync();
            if (medkit == null)
                return NotFound();
            _dataContext.Remove(medkit);
            await _dataContext.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                List<MedkitModel> models = await _dataContext.Medkit.ToListAsync();
                List<Item> items = new List<Item>();
                foreach (MedkitModel m in models)
                {
                    items.Add(new Item { ip_address = m.ip_address, created_at = m.Created_At, id = m.id }); 
                }
                return Ok(items);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        public class Item
        {
            public int id { get; set; }
            public string ip_address {  get; set; }
            public DateTime created_at { get; set; }
        }
    }
}
