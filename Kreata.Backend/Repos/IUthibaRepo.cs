using Kreata.Backend.Context;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public interface IUthibaRepo
    {
        Task<List<Uthiba>> GetAll();
        Task<Uthiba?> GetBy(Guid id);
        Task<ControllerResponse> UpdateUthibaAsync(Uthiba uthiba);
    }
}

