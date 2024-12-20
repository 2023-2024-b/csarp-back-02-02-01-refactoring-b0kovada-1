﻿using Kreata.Backend.Context;
using Kreta.Shared.Models.Datas.Entities;
using Kreta.Shared.Models.Responses;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Repos
{
    public class ParentRepo : IParentRepo
    {
        private readonly KretaInMemoryContext _dbContext;

        public ParentRepo(KretaInMemoryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Parent>> GetAll()
        {
            return await _dbContext.Parents.ToListAsync();
        }

        public async Task<Parent?> GetBy(Guid id)
        {
            return await _dbContext.Parents.FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task<ControllerResponse> UpdateParentAsync(Parent parent)
        {
            ControllerResponse response = new ControllerResponse();
            _dbContext.ChangeTracker.Clear();
            _dbContext.Entry(parent).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                response.AppendNewError(e.Message);
                response.AppendNewError($"{nameof(ParentRepo)} osztály, {nameof(UpdateParentAsync)} metódusban hiba keletkezett");
                response.AppendNewError($"{parent} frissítése nem sikerült!");
            }
            return response;
        }
    }
}
