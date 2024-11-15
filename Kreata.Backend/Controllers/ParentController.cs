using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;
using Kreta.Shared.Converters;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : ControllerBase
    {
        private IParentRepo _parentRepo;

        public ParentController(IParentRepo parentRepo)
        {
            _parentRepo = parentRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Parent? entity = new();
            if (_parentRepo is not null)
            {
                entity = await _parentRepo.GetBy(id);
                if (entity != null)
                    return Ok(entity.ToDto());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Parent>? users = new();

            if (_parentRepo != null)
            {
                users = await _parentRepo.GetAll();
                return Ok(users.GetParentsDtos());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateParentAsync(ParentDto entity)
        {
            ControllerResponse response = new();
            if (_parentRepo is not null)
            {
                response = await _parentRepo.UpdateParentAsync(entity.ToModel());
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
