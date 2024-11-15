using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;
using Kreta.Shared.Converters;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UthibaController : ControllerBase
    {
        private IUthibaRepo _uthibaRepo;

        public UthibaController(IUthibaRepo uthibaRepo)
        {
            _uthibaRepo = uthibaRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Uthiba? entity = new();
            if (_uthibaRepo is not null)
            {
                entity = await _uthibaRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity.ToDto());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Uthiba>? users = new();

            if (_uthibaRepo != null)
            {
                users = await _uthibaRepo.GetAll();
                return Ok(users.GetUthibasDtos());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateUthibaAsync(UthibaDto entity)
        {
            ControllerResponse response = new();
            if (_uthibaRepo is not null)
            {
                response = await _uthibaRepo.UpdateUthibaAsync(entity.ToModel());
                if (response.HasError)
                {
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }
    }
}
