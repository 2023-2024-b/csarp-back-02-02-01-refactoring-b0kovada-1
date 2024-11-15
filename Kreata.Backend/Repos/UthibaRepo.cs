using Kreata.Backend.Context;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class UthibaRepo : IUthibaRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public UthibaRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Uthiba>> GetAll()
        {
            return await _dbContext.Uthibak.ToListAsync();
        }

        public async Task<Uthiba?> GetBy(Guid id)
        {
            return await _dbContext.Uthibak.FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<ControllerResponse> UpdateUthibaAsync(Uthiba uthiba)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(uthiba).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(UthibaRepo)} osztály, {nameof(UpdateUthibaAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{uthiba} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
